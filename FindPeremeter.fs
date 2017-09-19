//Enter your code here. Read input from STDIN. Print output to STDOUT
let distance ((x1:int,y1:int), (x2:int,y2:int)) =
    let xDiff = abs x1-x2
    let yDiff = abs y1-y2
    let sqrSum = (pown xDiff 2)+( pown yDiff 2)
    sqrt (double sqrSum)

// Is there any better way to create a tuple from splitting string?    
let getPoint (s:string) =
    let [| x; y |] = 
        s.Split(' ') 
        |> Array.map System.Int32.Parse
    x,y
        
// Right now I am reading all the points and calculating perimeter by iterating through the points.
// Can I do it in a single pass?

[<EntryPoint>]
let main argv = 
    let t = System.Console.ReadLine()|> int
    let mutable firstPoint = (0,0)
    let values = 
        Seq.init t (fun i -> let currentPoint = System.Console.ReadLine() 
                             if i = 0 then firstPoint <- getPoint(currentPoint) 
                             currentPoint)
        |> Seq.map getPoint
        |> Seq.toList
        |> List.rev
        
        
    let lines = Seq.pairwise (firstPoint::values)
    //printf "Lines : %A" lines
    let perimeter = 
        lines
        |> Seq.map distance 
        |> Seq.sum
    
    (*let first, rest  = values.[0], List.tail values
    
    let foldFunc (perimeter, prevPoint) nxtPoint =
        perimeter+(distance prevPoint nxtPoint), nxtPoint

    let (finalPerimeter , last) = List.fold foldFunc (0.0, first) rest*)
    
    printfn "%f" perimeter
    0