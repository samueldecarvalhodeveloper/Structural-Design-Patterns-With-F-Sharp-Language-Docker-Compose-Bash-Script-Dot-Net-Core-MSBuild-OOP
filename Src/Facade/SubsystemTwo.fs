module StructuralDesignPatterns.Src.Facade.SubsystemTwo

type SubsystemTwo() =
    member _.OperationOne() = "Subsystem Two: Get Ready!\n"
    
    member _.OperationZ() = "Subsystem Two: Fire!\n"