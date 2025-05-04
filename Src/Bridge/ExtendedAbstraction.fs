module StructuralDesignPatterns.Src.Bridge.ExtendedAbstraction

open StructuralDesignPatterns.Src.Bridge.Abstraction
open StructuralDesignPatterns.Src.Bridge.ImplementationInterface

type ExtendedAbstraction(implementation: ImplementationInterface) =
    inherit Abstraction(implementation: ImplementationInterface)

    member this.Operation() =
        let result = implementation.OperationImplementation()
        
        $"ExtendedAbstraction: Extended Operation With:\n{result}"