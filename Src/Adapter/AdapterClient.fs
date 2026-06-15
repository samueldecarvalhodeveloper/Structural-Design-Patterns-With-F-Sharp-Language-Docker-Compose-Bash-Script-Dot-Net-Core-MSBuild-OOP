module StructuralDesignPatterns.Src.Adapter.AdapterClient

open StructuralDesignPatterns.Src.Adapter.Adapted
open StructuralDesignPatterns.Src.Adapter.Adapter
open StructuralDesignPatterns.Src.Adapter.TargetImplementation
open StructuralDesignPatterns.Src.Adapter.Context

type AdapterClient =
    static member execute() : Unit =
        let target = TargetImplementation()
        let adapted = Adapted()
        let adapter = Adapter(adapted)

        printfn "Client: I Can Work Just Fine With The Target Objects:"

        Context.execute target

        printfn ""

        printfn "Client: The Adapted Class Has A Weird Interface. See, I Do Not Understand It:"

        printfn $"Adapted: %s{adapted.SpecificRequest()}"

        printfn ""

        printfn "Client: But I Can Work With It Via The Adapter:"

        Context.execute adapter
