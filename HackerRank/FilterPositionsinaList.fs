// Hacker Rank Functional Programming Challenges
// https://www.hackerrank.com/challenges/fp-filter-positions-in-a-list
//Enter your code here. Read input from STDIN. Print output to STDOUT
open System
[<EntryPoint>]
let main args =
    let values = 
        Seq.initInfinite(fun _ -> Console.ReadLine())
        |> Seq.takeWhile(isNull >> not)
        |> Seq.map int
        |> Seq.toList
        
    let length = values.Length
    //printfn "leg is %d" length
    for i in 1 .. length do
        if i%2 = 0 then printfn "%d" values.[i-1]
    0   