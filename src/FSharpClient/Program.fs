// Learn more about F# at http://fsharp.org

open System
open CSharpLib

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    let cSharpClass = HelloClass()
    printfn "%s" (cSharpClass.SayHelloFromCSharp "Ola Normann")
    Console.ReadLine() |> ignore
    0 // return an integer exit code
