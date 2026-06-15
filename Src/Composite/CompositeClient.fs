module StructuralDesignPatterns.Src.Composite.CompositeClient

open StructuralDesignPatterns.Src.Composite.Context
open StructuralDesignPatterns.Src.Composite.Leaf
open StructuralDesignPatterns.Src.Composite.Composite

type CompositeClient =
    static member execute() =
        let simple = Leaf()
        let tree = Composite()
        let branchOne = Composite()
        let branchTwo = Composite()

        printfn "Client: I Have Got A Simple Component:"
        
        Context.execute_first simple
        
        printfn ""

        branchOne.Add(Leaf())
        branchOne.Add(Leaf())
        
        branchTwo.Add(Leaf())
        
        tree.Add(branchOne)
        tree.Add(branchTwo)

        printfn "Client: Now I Have Got A Composite Tree:"
        
        Context.execute_first tree
        
        printfn ""

        printfn "Client: I Do Not Need To Check The Components' Classes Even When Managing The Tree:"
        
        Context.execute_second tree simple
