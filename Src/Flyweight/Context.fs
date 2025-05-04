module StructuralDesignPatterns.Src.Flyweight.Context

open StructuralDesignPatterns.Src.Flyweight.FlyweightFactory

type Context =
    static member execute (factory: FlyweightFactory) plates owner brand model color =
        let flyweight = factory.GetFlyweight([brand; model; color])
        
        printfn "\nClient: Adding A Car To Database."
        
        flyweight.Operation([plates; owner])
