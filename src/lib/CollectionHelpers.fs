namespace CorvusCorax.FsHelpers.CollectionHelpers

[<RequireQualifiedAccess>]
module Seq =
    let minMaxBy (projection: 'a -> 'b) (items: 'a seq) =
        let e = items.GetEnumerator()

        if not (e.MoveNext()) then
            invalidArg (nameof items) "Empty sequence"
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

            if pItem > pMax then
                maxUntilNow <- item
                pMax <- pItem

        (minUntilNow, maxUntilNow)


