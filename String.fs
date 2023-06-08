namespace FSharpVRM

[<RequireQualifiedAccess>]
module String =

    let replace (oldValue: string) (newValue: string) (s: string) = s.Replace(oldValue, newValue)
