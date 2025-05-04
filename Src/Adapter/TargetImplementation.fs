module StructuralDesignPatterns.Src.Adapter.TargetImplementation

open StructuralDesignPatterns.Src.Adapter.Target

type TargetImplementation() =
    interface Target with
        member _.Request() =
            "Target: The Default Target's Behavior."
