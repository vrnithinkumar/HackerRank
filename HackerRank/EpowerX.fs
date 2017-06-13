// Hacker Rank Functional Programming Challenges
// https://www.hackerrank.com/challenges/eval-ex
let rec fact x =
    match x with 
    | 1 -> 1
    | _ -> (x * fact (x - 1))

let evalex (n: float) =
    let listOfPower = [1..9]
    let sum = 
        listOfPower
        |> List.sumBy(fun x -> (n **  (float x)/ (float (fact x))))
    sum+1.0

let readNLines n =  Array.init n (fun _ -> System.Console.ReadLine()|> float)

[<EntryPoint>]
let main args =
    let inputs = System.Console.ReadLine() |> int |> readNLines
    for i in inputs do 
        printfn "%f" (evalex i)
    0