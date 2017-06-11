// Hacker Rank Functional Programming Challenges
// https://www.hackerrank.com/challenges/fp-array-of-n-elements
open System

let f n = 
   [|1 .. n|]
let main() =
    let input = Console.ReadLine()
    let n = int input
    printfn "%A" (f n)

main()