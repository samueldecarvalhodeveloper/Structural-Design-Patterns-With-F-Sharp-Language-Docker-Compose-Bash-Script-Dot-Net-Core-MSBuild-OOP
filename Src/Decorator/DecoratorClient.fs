module StructuralDesignPatterns.Src.Decorator.DecoratorClient

open StructuralDesignPatterns.Src.Decorator.ConcreteComponent
open StructuralDesignPatterns.Src.Decorator.ConcreteDecoratorA
open StructuralDesignPatterns.Src.Decorator.ConcreteDecoratorB
open StructuralDesignPatterns.Src.Decorator.Context

type DecoratorClient () =
    static member execute() =
        let simple = ConcreteComponent()
        let decoratorOne = ConcreteDecoratorA(simple)
        let decoratorTwo = ConcreteDecoratorB(decoratorOne)
        
        printfn "Client: I Have Got A Simple Component:"
        
        Context.execute simple
        
        printfn ""

        printfn "Client: Now I Have Got A Decorated Component:"
        
        Context.execute decoratorTwo
