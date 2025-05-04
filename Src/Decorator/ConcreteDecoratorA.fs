module StructuralDesignPatterns.Src.Decorator.ConcreteDecoratorA

open StructuralDesignPatterns.Src.Decorator.ComponentInterface
open StructuralDesignPatterns.Src.Decorator.Decorator

type ConcreteDecoratorA(component: ComponentInterface) =
    inherit Decorator(component)
    interface ComponentInterface with
        member _.Operation() = $"Concrete Decorator A({component.Operation()})"
