module StructuralDesignPatterns.Src.Adapter.Adapter

open StructuralDesignPatterns.Src.Adapter.Adapted
open StructuralDesignPatterns.Src.Adapter.Target
open System

type Adapter(adapted: Adapted) =
    interface Target with
        member _.Request() =
            adapted.SpecificRequest()
            |> Seq.toList
            |> List.rev
            |> String.Concat
            |> sprintf "Adapter: (TRANSLATED) %s"
