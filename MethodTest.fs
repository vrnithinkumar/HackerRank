let ReadCase = System.Console.ReadLine >> int
let x = ReadCase ()

let foo x =
    let y = x * x
    let a = float y |> sqrt
    let b = sqrt (float y)
    b
 
foo 34 |> ignore