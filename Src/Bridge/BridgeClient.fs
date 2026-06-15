module StructuralDesignPatterns.Src.Bridge.BridgeClient

open StructuralDesignPatterns.Src.Bridge.Abstraction
open StructuralDesignPatterns.Src.Bridge.ConcreteImplementationA
open StructuralDesignPatterns.Src.Bridge.ConcreteImplementationB
open StructuralDesignPatterns.Src.Bridge.Context
open StructuralDesignPatterns.Src.Bridge.ExtendedAbstraction

type BridgeClient =
    static member execute() =
        let implementationA = ConcreteImplementationA()
        let implementationB = ConcreteImplementationB()
        let abstractionA = Abstraction(implementationA)
        let abstractionB = ExtendedAbstraction(implementationB)

        Context.execute abstractionA

        printfn ""

        Context.execute abstractionB
