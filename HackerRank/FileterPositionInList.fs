// Hacker Rank Functional Programming Challenges
// https://www.hackerrank.com/challenges/fp-filter-positions-in-a-list
//Enter your code here. Read input from STDIN. Print output to STDOUT
open System
[<EntryPoint>]
let main args =
    let inputs =
        Seq.initInfinite (fun _ -> Console.ReadLine())
        |> Seq.takeWhile(isNull >> not)
    for i in 1 .. (inputs|>Seq.length) do
        match i%2 with
        | 1 -> printfn 
    0