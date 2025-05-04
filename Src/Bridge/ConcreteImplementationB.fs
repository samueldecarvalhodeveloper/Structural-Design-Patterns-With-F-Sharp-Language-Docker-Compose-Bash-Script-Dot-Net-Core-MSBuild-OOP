module StructuralDesignPatterns.Src.Bridge.ConcreteImplementationB

open StructuralDesignPatterns.Src.Bridge.ImplementationInterface

type ConcreteImplementationB() =
    interface ImplementationInterface with
        member this.OperationImplementation() =
            "ConcreteImplementationB: Here Is The Result On The Platform B."