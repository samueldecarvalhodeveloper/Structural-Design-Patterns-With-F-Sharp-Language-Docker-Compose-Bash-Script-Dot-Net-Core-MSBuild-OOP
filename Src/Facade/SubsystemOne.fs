module StructuralDesignPatterns.Src.Facade.SubsystemOne

type SubsystemOne() =
    member _.OperationOne() = "Subsystem One: Ready!\n"
    
    member _.OperationN() = "Subsystem One: Go!\n"