namespace CorvusCorax.FsHelpers

open System.Collections.Generic

[<RequireQualifiedAccess>]
module Enumerator =
    let minMaxBy (projection: 'a -> 'b) (e: IEnumerator<'a>) =
        if isNull e then
            nullArg (nameof e)

        if not (e.MoveNext()) then
            invalidArg (nameof e) "Empty sequence"

        let firstItem = e.Current
        let mutable minUntilNow = firstItem
        let mutable maxUntilNow = firstItem
        let mutable pMin = projection firstItem
        let mutable pMax = pMin

        while e.MoveNext() do
            let item = e.Current
            let pItem = projection item

            if pItem < pMin then
                minUntilNow <- item
                pMin <- pItem

            if pMax < pItem then
                maxUntilNow <- item
                pMax <- pItem

        (minUntilNow, maxUntilNow)


[<RequireQualifiedAccess>]
module Seq =
    /// 
    let minMaxBy (projection: 'a -> 'b) (items: 'a seq) =
        let e = items.GetEnumerator()
        Enumerator.minMaxBy projection e
