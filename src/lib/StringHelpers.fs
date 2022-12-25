namespace CorvusCorax.FsHelpers

open System

[<RequireQualifiedAccess>]
module String =

    let inline isNullOrEmpty s = String.IsNullOrEmpty s

    let inline isNotNullOrEmpty s = not (String.IsNullOrEmpty s)

    let inline firstCharIs (c: char) (s: string) = isNotNullOrEmpty s && s[0] = c

    let inline startsWith (prefix: string) (s: string) = isNotNullOrEmpty s && s.StartsWith prefix

    let inline endsWith (postfix: string) (s: string) = isNotNullOrEmpty s && s.EndsWith postfix
