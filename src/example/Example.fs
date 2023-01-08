open System
open CorvusCorax.FsHelpers


let makeRandomSeq (rng: Random) (count: int) : int array =
    let nextEl (state: Random * int) : (int * (Random * int)) option =
        let rng, n = state
        if n >= count then None else Some(rng.Next(), (rng, n + 1))

    Array.unfold nextEl (rng, 0)


[<EntryPoint>]
let main args =
    let rng = Random 123

    let data = makeRandomSeq rng 10_000

    for n = 1 to 10_000 do
        let minValue, maxValue = Seq.minMaxBy id data
        assert (minValue = 128372)
        assert (maxValue = 2147314528)

    0
