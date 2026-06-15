module StructuralDesignPatterns.Src.Proxy.Context

open StructuralDesignPatterns.Src.Proxy.SubjectInterface

type Context =
    static member execute (subject: SubjectInterface) =
        printfn "Client: Calling Request() On Subject."
        
        subject.request() 
