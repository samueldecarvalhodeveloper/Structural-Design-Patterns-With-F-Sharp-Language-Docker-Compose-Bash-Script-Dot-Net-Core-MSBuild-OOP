module StructuralDesignPatterns.Src.Bridge.Abstraction

open StructuralDesignPatterns.Src.Bridge.ImplementationInterface

type Abstraction(implementation: ImplementationInterface) =
    member this.Operation() =
        let result = implementation.OperationImplementation()
        
        $"Abstraction: Base Operation With:\n{result}"