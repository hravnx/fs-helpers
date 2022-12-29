namespace CorvusCorax.FsHelpers.UnitTests

open Xunit


module ``String helpers`` =
    open CorvusCorax.FsHelpers
    
    [<Fact>]
    let ``firstCharIs test the first char`` () =
        let result = String.firstCharIs 'X' "XYZ"
        Assert.True(result)
        Assert.False(String.firstCharIs 'Y' "XYZ")
        Assert.False(String.firstCharIs 'Z' "")
        Assert.False(String.firstCharIs 'Z' null)
        
        
    [<Fact>]
    let ``isNullOrEmpty works`` () =
        Assert.False(String.isNullOrEmpty "Hello")
        Assert.True(String.isNullOrEmpty "")
        Assert.True(String.isNullOrEmpty null)
        
    [<Fact>]
    let ``isNotNullOrEmpty works`` () =
        Assert.True(String.isNotNullOrEmpty "Hello")
        Assert.False(String.isNotNullOrEmpty "")
        Assert.False(String.isNotNullOrEmpty null)
        
    [<Fact>]
    let ``startsWith works`` () =
        Assert.True(String.startsWith "XY" "XYZ")
        Assert.False(String.startsWith "YX" "XYZ")
        Assert.True(String.startsWith "" "XYZ")
        Assert.False(String.startsWith "" "")
        Assert.False(String.startsWith "" null)
        
    [<Fact>]
    let ``endsWith works`` () =
        Assert.True(String.endsWith "YZ" "XYZ")
        Assert.False(String.endsWith "ZY" "XYZ")
        Assert.True(String.endsWith "" "XYZ")
        Assert.False(String.endsWith "" "")
        Assert.False(String.endsWith "" null)
        
        