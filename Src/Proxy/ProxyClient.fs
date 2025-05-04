module StructuralDesignPatterns.Src.Proxy.ProxyClient

open StructuralDesignPatterns.Src.Proxy.Context
open StructuralDesignPatterns.Src.Proxy.Proxy
open StructuralDesignPatterns.Src.Proxy.RealSubject

type ProxyClient =
    static member execute () =
        let realSubject = RealSubject()
        let proxy = Proxy(realSubject)
        
        printfn "Client: Executing The Client Code With A Real Subject:"
        
        Context.execute realSubject

        printfn ""

        printfn "Client: Executing The Same Client Code With A Proxy:"
        
        Context.execute proxy
