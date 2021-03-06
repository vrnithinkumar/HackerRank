// https://fsharpforfunandprofit.com/posts/designing-for-correctness/

type CartItem = string

type EmptyState = NoItems
type ActiveState = { UnpaideItems : CartItem list}
type PaidState = {PaidItems : CartItem list ; Payment : decimal}

type ShoppingCart = 
    | Empty of EmptyState
    | Active of ActiveState
    | Paid of PaidState

// Functions 

let addToEmptyCart item =
    ShoppingCart.Active {UnpaideItems =  [item]}

let addItemToActiveCart cart item =
    let updatedList = item::cart.UnpaideItems
    ShoppingCart.Active {cart with UnpaideItems = updatedList}

let removeItemFromActiveCart cart item =
    let updatedList = cart.UnpaideItems
                      |> List.filter (fun x -> x <> item)
    match updatedList with
    |[] -> ShoppingCart.Empty NoItems
    | _ -> ShoppingCart.Active {cart with UnpaideItems = updatedList}

let makePayment cart price =
    ShoppingCart.Paid {PaidItems = cart.UnpaideItems ; Payment = price}

type EmptyState with
    member this.Add  = addToEmptyCart

type ActiveState with   
    member this.Add = addItemToActiveCart this
    member this.Remove = removeItemFromActiveCart this
    member this.Pay = makePayment this

let addItemToCart cart item =
    match cart with 
        | Active state -> state.Add item
        | Empty state -> state.Add item
        | Paid state -> 
            printfn "Error Already Paid cant modify"
            cart

let removeItemInCart cart item =
    match cart with  
        | Active state -> state.Remove item
        | Empty state -> 
            printf "Nothing to remove"
            cart
        | Paid state -> 
            printfn "Error Already Paid cant modify"
            cart

let PrintCart cart =
    match cart with  
        | Active state -> 
            printfn "Actve Cart with items : %A" state.UnpaideItems
        | Empty state -> 
            printf "Nothing to Display! :( "
        | Paid state -> 
            printfn "Paid Cart with items : %A Price : %f " state.PaidItems state.Payment

type ShoppingCart with
   static member NewCart = ShoppingCart.Empty NoItems
   member this.Add = addItemToCart this 
   member this.Remove = removeItemInCart this 
   member this.Display = PrintCart this 

let emptyCart = ShoppingCart.NewCart
emptyCart.Display

let cartA = emptyCart.Add "A"
printf "cartA="; cartA.Display

let cartAB = cartA.Add "B"
cartAB.Display

// try to pay for cartA
let cartAPaid = 
    match cartAB with
    | Empty _ | Paid _ -> cartA 
    | Active state -> state.Pay 100m

printf "cartAPaid="; cartAPaid.Display

// Cant add wrong logic since compile time check is there.
(*let wrongcart = 
    match cartAPaid with
    | Empty state -> state.Pay 100m
    | PaidFor state -> state.Pay 100m
    | Active state -> state.Pay 100m * )