let ReadCase = System.Console.ReadLine >> int
let x = ReadCase ()

let foo x =
    let y = x*x
    sqrt y
foo 34