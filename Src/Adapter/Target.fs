module StructuralDesignPatterns.Src.Adapter.Target

type Target =
    abstract member Request: unit -> string
