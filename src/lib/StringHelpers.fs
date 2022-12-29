namespace CorvusCorax.FsHelpers

open System

[<RequireQualifiedAccess>]
module String =

    let isNullOrEmpty s = String.IsNullOrEmpty s

    let isNotNullOrEmpty s = not (String.IsNullOrEmpty s)

    let firstCharIs (c: char) (s: string) = isNotNullOrEmpty s && s[0] = c

    let startsWith (prefix: string) (s: string) = isNotNullOrEmpty s && s.StartsWith prefix

    let endsWith (postfix: string) (s: string) = isNotNullOrEmpty s && s.EndsWith postfix
