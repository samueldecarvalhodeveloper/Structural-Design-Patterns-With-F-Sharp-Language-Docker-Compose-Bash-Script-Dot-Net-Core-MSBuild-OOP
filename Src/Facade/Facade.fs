module StructuralDesignPatterns.Src.Facade.Facade

open StructuralDesignPatterns.Src.Facade.SubsystemOne
open StructuralDesignPatterns.Src.Facade.SubsystemTwo

type Facade(subsystemOne: SubsystemOne option, subsystemTwo: SubsystemTwo option) =
    let subsystemOne = subsystemOne |> Option.defaultValue (SubsystemOne())
    let subsystemTwo = subsystemTwo |> Option.defaultValue (SubsystemTwo())

    member _.operation() =
        let resultOne = subsystemOne.OperationOne()
        let resultTwo = subsystemTwo.OperationOne()
        let resultThree = subsystemOne.OperationN()
        let resultFour = subsystemTwo.OperationZ()
        
        $"Facade initializes subsystems:\n{resultOne}{resultTwo}Facade orders subsystems to perform the action:\n{resultThree}{resultFour}"

