module StructuralDesignPatterns.Src.Bridge.ConcreteImplementationA

open StructuralDesignPatterns.Src.Bridge.ImplementationInterface

type ConcreteImplementationA() =
    interface ImplementationInterface with
        member this.OperationImplementation() =
            "ConcreteImplementationA: Here Is The Result On The Platform A."