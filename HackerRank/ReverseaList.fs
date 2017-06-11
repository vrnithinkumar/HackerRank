// Hacker Rank Functional Programming Challenges
// https://www.hackerrank.com/challenges/fp-reverse-a-list
// Enter your code here. Read input from STDIN. Print output to STDOUT
open System
[<EntryPoint>]
let main args =
    let values = 
        Seq.initInfinite(fun _ -> Console.ReadLine())
        |> Seq.takeWhile(isNull >> not)
        |> Seq.map int
        |> Seq.toList
        
    let reverseList = List.rev values
    for i in reverseList do
        printfn "%d" i
    0   