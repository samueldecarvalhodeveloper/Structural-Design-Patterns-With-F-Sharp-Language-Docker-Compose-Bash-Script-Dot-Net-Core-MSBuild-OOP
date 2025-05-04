module StructuralDesignPatterns.Src.Proxy.Proxy

open StructuralDesignPatterns.Src.Proxy.SubjectInterface

type Proxy(realSubject: SubjectInterface) =
    interface SubjectInterface with
        member this.request() = 
            if this.CheckAccess() then
                realSubject.request()
                
                this.LogAccess()

    member private this.CheckAccess() = 
        printfn "Proxy: Checking Access Prior To Firing A Real Request."
        
        true

    member private this.LogAccess() = 
        printfn "Proxy: Logging The Time Of Request."
