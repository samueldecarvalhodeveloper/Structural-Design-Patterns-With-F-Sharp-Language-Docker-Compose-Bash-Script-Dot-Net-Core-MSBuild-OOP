module StructuralDesignPatterns.Src.Decorator.Context

open StructuralDesignPatterns.Src.Decorator.ComponentInterface

type Context =
    static member execute(component: ComponentInterface) =
        printfn $"RESULT: %s{component.Operation()}"
