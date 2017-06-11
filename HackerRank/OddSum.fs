// Hacker Rank Functional Programming Challenges
// https://www.hackerrank.com/challenges/fp-sum-of-odd-elements?h_r=next-challenge&h_v=zen 
open System

(*USER CODE BEGIN*)
let f arr =
    let oddNumbers = 
        arr 
        |> List.filter(fun x -> x % 2 = 1 || x % 2 = -1) 
    List.sum arr  

(*USER CODE END*)

let read_and_parse()=
    let mutable arr = []
    let mutable buff = Console.ReadLine()
    while buff <> null do
            arr <- Int32.Parse(buff)::arr
            buff <- Console.ReadLine()
    arr

let main =    
    let arr = read_and_parse()
    printf "%A" <| f arr

