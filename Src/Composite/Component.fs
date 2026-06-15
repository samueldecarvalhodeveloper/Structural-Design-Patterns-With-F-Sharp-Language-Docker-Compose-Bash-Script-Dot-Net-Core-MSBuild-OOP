module StructuralDesignPatterns.Src.Composite.Component

[<AbstractClass>]
type Component() =
    let mutable parent: Component option = None

    member this.SetParent(p: Component option) =
        parent <- p

    member this.GetParent(): Component option =
        parent

    abstract member Add: Component -> unit
    
    default this.Add(_component: Component) =
        ()

    abstract member Remove: Component -> unit
    
    default this.Remove(_component: Component) =
        ()

    abstract member IsComposite: unit -> bool
    
    default this.IsComposite() = false

    abstract member Operation: unit -> string
