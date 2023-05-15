// For more information see https://aka.ms/fsharp-console-apps
//printfn "Hello from F#"

//Entry Point
open MyLibrary

// [<EntryPoint>]
// let main args =
//     Say.hello "Zoe"
//     //printfn $"Hola Mundo"
//     0

[<EntryPoint>]
let main args =
    Say.hello "Zoe"
    Math.imprimeAdd 2 3 
    //printfn $"Hola Mundo"
    0