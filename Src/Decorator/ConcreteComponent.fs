module StructuralDesignPatterns.Src.Decorator.ConcreteComponent

open StructuralDesignPatterns.Src.Decorator.ComponentInterface

type ConcreteComponent() =
    interface ComponentInterface with
        member _.Operation() = "Concrete Component"
