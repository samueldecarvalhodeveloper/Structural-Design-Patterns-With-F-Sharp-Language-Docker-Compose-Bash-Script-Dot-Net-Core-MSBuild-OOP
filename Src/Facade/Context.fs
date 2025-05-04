module StructuralDesignPatterns.Src.Facade.Context

open StructuralDesignPatterns.Src.Facade.Facade

type Context =
    static member execute(facade: Facade) = printfn $"%s{facade.operation ()}"
