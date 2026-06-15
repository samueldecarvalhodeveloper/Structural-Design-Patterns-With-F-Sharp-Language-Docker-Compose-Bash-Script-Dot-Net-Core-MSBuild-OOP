module StructuralDesignPatterns.Src.Bridge.Context

open StructuralDesignPatterns.Src.Bridge.Abstraction

type Context =
    static member execute(abstraction: Abstraction) =
        printfn $"%s{abstraction.Operation()}"