namespace CorvusCorax.FsHelpers.UnitTests

open System
open Xunit



module ``CollectionHelpers`` =
    open CorvusCorax.FsHelpers.CollectionHelpers
    
    [<Fact>]
    let ``minMaxBy gets both min and max`` () =
        let items = [1; 2; 5; 4; 8; -23; 3; 42; 5]
        let minValue, maxValue = Seq.minMaxBy id items
        Assert.Equal(-23, minValue)
        Assert.Equal(42, maxValue)
    
    [<Fact>]
    let ``minMaxBy handles singleton sequences`` () =
        let minValue, maxValue = Seq.minMaxBy id [4]
        Assert.Equal(4, minValue)
        Assert.Equal(4, maxValue)

    [<Fact>]
    let ``minMaxBy fails if given an empty sequence`` () =
        Assert.Throws<ArgumentException> (fun () -> Seq.minMaxBy id [] |> ignore)
        