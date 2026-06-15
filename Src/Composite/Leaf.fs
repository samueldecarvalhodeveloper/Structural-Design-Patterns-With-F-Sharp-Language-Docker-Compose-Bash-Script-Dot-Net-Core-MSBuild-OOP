module StructuralDesignPatterns.Src.Composite.Leaf

open StructuralDesignPatterns.Src.Composite.Component

type Leaf() =
    inherit Component()

    override this.Operation() =
        "Leaf"