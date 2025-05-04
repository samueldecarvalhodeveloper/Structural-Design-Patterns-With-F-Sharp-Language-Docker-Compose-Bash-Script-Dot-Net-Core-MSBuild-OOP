module StructuralDesignPatterns.Src.Decorator.Decorator

open StructuralDesignPatterns.Src.Decorator.ComponentInterface

type Decorator(component: ComponentInterface) =
    interface ComponentInterface with
        member _.Operation() = component.Operation()
