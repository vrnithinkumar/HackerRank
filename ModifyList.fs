// Hacker Rank Functional Programming Challenges
// https://www.hackerrank.com/challenges/fp-update-list
// Enter your code here. Read input from STDIN. Print output to STDOUT
    // Complete this function
let f arr = 
    List.map (abs) arr
        

//----------------DON'T MODIFY---------------

let input = 
    stdin.ReadToEnd().Split '\n' 
    |> Array.map(fun x -> int(x)) 
    |> Array.toList
    
let print_out (data:int list) = List.iter (fun x -> printfn "%A" x) data

print_out (f(input))