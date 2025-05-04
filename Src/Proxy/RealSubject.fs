module StructuralDesignPatterns.Src.Proxy.RealSubject

open StructuralDesignPatterns.Src.Proxy.SubjectInterface

type RealSubject() =
    interface SubjectInterface with
        member this.request() =
            printfn "RealSubject: Handling Request."
            
    
