module ExecutionDemo
open System
[<EntryPoint>]
let main argv =
    fun s -> s <> null
    let n = Console.ReadLine() |> int
    let read _ = Console.ReadLine()
    let isValid  = function null -> false | _ -> true
    let listOfInputs = Seq.initInfinite read |> Seq.takeWhile isValid |> Seq.toList 
    for i in listOfInputs do
        printfn "%s" i
    0 // return an integer exit code
