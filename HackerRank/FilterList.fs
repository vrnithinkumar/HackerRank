// Hacker Rank Functional Programming Challenges
// https://www.hackerrank.com/challenges/fp-filter-array
//Enter your code here. Read input from STDIN. Print output to STDOUT
open System
[<EntryPoint>]
let main args =
    let n = Console.ReadLine() |> int
    let values = 
        Seq.initInfinite(fun _ -> Console.ReadLine())
        |> Seq.takeWhile(fun s -> s |> isNull |> not)
        |> Seq.map int
        |> Seq.toList
    let valueToPrint =
        values
        |> List.filter (fun x -> x < n)

    for i in valueToPrint do    
        printfn "%d" i
    0