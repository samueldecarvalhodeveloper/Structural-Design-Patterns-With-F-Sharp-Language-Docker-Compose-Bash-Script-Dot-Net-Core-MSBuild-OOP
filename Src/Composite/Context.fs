module StructuralDesignPatterns.Src.Composite.Context

open StructuralDesignPatterns.Src.Composite.Component

type Context =
    static member execute_first(component: Component) =
        printfn $"RESULT: {component.Operation()}"

    static member execute_second (component1: Component) (component2: Component) =
        if component1.IsComposite() then
            component1.Add(component2)

        printfn $"RESULT: {component1.Operation()}"
