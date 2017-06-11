// Hacker Rank Functional Programming Challenges
// https://www.hackerrank.com/challenges/fp-list-length?
// Enter your code here. Read input from STDIN. Print output to STDOUT
open System
[<EntryPoint>]
let main args =
    let values = 
        Seq.initInfinite(fun _ -> Console.ReadLine())
        |> Seq.takeWhile(isNull >> not)
        |> Seq.map int
        |> Seq.toList
        
    let length = values.Length
    printfn "%d" length
    0