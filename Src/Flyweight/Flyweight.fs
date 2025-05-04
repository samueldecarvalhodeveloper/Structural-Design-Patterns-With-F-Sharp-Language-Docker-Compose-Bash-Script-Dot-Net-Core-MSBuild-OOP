module StructuralDesignPatterns.Src.Flyweight.Flyweight

type Flyweight(sharedState: string list) =
    member this.Operation(uniqueState: string list) =
        let sharedState = sharedState |> List.map _.ToString() |> String.concat ", "
        let uniqueState = uniqueState |> List.map _.ToString() |> String.concat ", "
        
        printfn $"Flyweight: Displaying Shared (%s{sharedState}) And Unique (%s{uniqueState}) State."
