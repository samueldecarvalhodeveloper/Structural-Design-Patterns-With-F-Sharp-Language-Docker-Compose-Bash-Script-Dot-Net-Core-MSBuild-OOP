module StructuralDesignPatterns.Src.Flyweight.FlyweightFactory

open StructuralDesignPatterns.Src.Flyweight.Flyweight

type FlyweightFactory(initialFlyweights: string list list) =
    let mutable flyweights = Map.empty

    do
        initialFlyweights |> List.iter (fun state ->
            let key = String.concat "_" state
            
            flyweights <- Map.add key (Flyweight(state)) flyweights
        )

    member this.GetFlyweight(sharedState: string list) =
        let key = String.concat "_" sharedState
        
        match Map.tryFind key flyweights with
        | Some(flyweight) -> 
            printfn "FlyweightFactory: Reusing Existing Flyweight."
            
            flyweight
        | None -> 
            let newFlyweight = Flyweight(sharedState)
            
            printfn "FlyweightFactory: Cannot Find A Flyweight, Creating New One."
            
            flyweights <- Map.add key newFlyweight flyweights
            
            newFlyweight

    member this.ListFlyweights() =
        let count = Map.count flyweights
        
        printfn "\nFlyweightFactory: I Have %d Flyweights:" count
        
        flyweights |> Map.iter (fun key _ -> printfn "%s" key)
