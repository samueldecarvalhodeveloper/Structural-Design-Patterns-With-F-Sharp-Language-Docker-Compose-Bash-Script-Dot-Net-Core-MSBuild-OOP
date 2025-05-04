open StructuralDesignPatterns.Src.Adapter.AdapterClient
open StructuralDesignPatterns.Src.Bridge.BridgeClient
open StructuralDesignPatterns.Src.Composite.CompositeClient
open StructuralDesignPatterns.Src.Decorator.DecoratorClient
open StructuralDesignPatterns.Src.Facade.FacadeClient
open StructuralDesignPatterns.Src.Flyweight.FlyweightClient
open StructuralDesignPatterns.Src.Proxy.ProxyClient

[<EntryPoint>]
let main _ : int =
    printfn "Adapter:"
    printfn ""

    AdapterClient.execute ()

    printfn ""
    
    printfn "Bridge:"
    printfn ""
    
    BridgeClient.execute ()
    
    printfn ""
    
    printfn "Composite:"
    printfn ""
    
    CompositeClient.execute ()
    
    printfn ""
    
    printfn "Decorator:"
    printfn ""
    
    DecoratorClient.execute ()
    
    printfn ""
    
    printfn "Facade:"
    printfn ""
    
    FacadeClient.execute ()
    
    printfn ""
    
    printfn "Flyweight:"
    printfn ""
    
    FlyweightClient.execute ()
    
    printfn ""
    
    printfn "Proxy:"
    printfn ""
    
    ProxyClient.execute ()

    0
