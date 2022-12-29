open System.Reflection
open BenchmarkDotNet.Attributes
open BenchmarkDotNet.Jobs

open BenchmarkDotNet.Running
open CorvusCorax.FsHelpers

[<MemoryDiagnoser>]
[<SimpleJob(RuntimeMoniker.Net60)>]
[<SimpleJob(RuntimeMoniker.Net70)>]
type StringBench () =
    [<Benchmark>]
    member this.StringFirstChar () =
        String.firstCharIs 'c'
        
     
[<EntryPoint>]        
let main args =
    let sw = BenchmarkSwitcher.FromAssembly(Assembly.GetExecutingAssembly())
    sw.Run(args) |> ignore
    0        