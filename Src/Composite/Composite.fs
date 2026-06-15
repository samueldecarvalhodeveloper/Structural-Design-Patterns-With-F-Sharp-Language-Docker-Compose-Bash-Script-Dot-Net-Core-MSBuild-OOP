module StructuralDesignPatterns.Src.Composite.Composite

open StructuralDesignPatterns.Src.Composite.Component

type Composite() =
    inherit Component()

    let children = System.Collections.Generic.List<Component>()

    override this.Add(component: Component) =
        children.Add(component)
        
        component.SetParent(Some(this))

    override this.Remove(component: Component) =
        children.Remove(component) |> ignore
        
        component.SetParent(None)

    override this.IsComposite() = true

    override this.Operation() =
        let results = children |> Seq.map _.Operation()
        
        $"""Branch({String.concat " + " results})"""

