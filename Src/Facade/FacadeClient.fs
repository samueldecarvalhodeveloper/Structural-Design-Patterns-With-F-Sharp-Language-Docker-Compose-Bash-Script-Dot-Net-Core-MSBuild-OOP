module StructuralDesignPatterns.Src.Facade.FacadeClient

open StructuralDesignPatterns.Src.Facade.Context
open StructuralDesignPatterns.Src.Facade.Facade
open StructuralDesignPatterns.Src.Facade.SubsystemOne
open StructuralDesignPatterns.Src.Facade.SubsystemTwo

type FacadeClient =
    static member execute () =
        let subsystemOne = Some(SubsystemOne())
        let subsystemTwo = Some(SubsystemTwo())
        let facade = Facade(subsystemOne, subsystemTwo)
        
        Context.execute facade
        