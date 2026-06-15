module StructuralDesignPatterns.Src.Decorator.ConcreteDecoratorB

open StructuralDesignPatterns.Src.Decorator.ComponentInterface
open StructuralDesignPatterns.Src.Decorator.Decorator

type ConcreteDecoratorB(component: ComponentInterface) =
    inherit Decorator(component)
    interface ComponentInterface with
        member _.Operation() = $"Concrete Decorator B({component.Operation()})"
