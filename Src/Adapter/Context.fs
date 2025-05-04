module StructuralDesignPatterns.Src.Adapter.Context

open StructuralDesignPatterns.Src.Adapter.Target

type Context =
    static member execute(target: Target) : Unit = printfn $"%s{target.Request()}"
