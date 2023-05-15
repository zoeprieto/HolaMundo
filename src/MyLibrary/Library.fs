namespace MyLibrary

module Say =
    let hello name =
        printfn "Hello %s" name
    let imprimeFloat (x:float) =
        printfn $"resultado: %f{x}" 