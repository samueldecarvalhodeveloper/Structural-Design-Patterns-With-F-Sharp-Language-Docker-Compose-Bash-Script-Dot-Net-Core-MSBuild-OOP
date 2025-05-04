module StructuralDesignPatterns.Src.Flyweight.FlyweightClient

open StructuralDesignPatterns.Src.Flyweight.Context
open StructuralDesignPatterns.Src.Flyweight.FlyweightFactory

type FlyweightClient =
    static member execute() =
        let factory = FlyweightFactory([
            ["Chevrolet"; "Camaro2018"; "Pink"]
            ["Mercedes Benz"; "C300"; "Black"]
            ["Mercedes Benz"; "C500"; "Red"]
            ["BMW"; "M5"; "Red"]
            ["BMW"; "X6"; "White"]
        ])

        factory.ListFlyweights()

        Context.execute factory "CL234IR" "James Doe" "BMW" "M5" "Red"
        Context.execute factory "CL234IR" "James Doe" "BMW" "X1" "Red"

        factory.ListFlyweights()
    