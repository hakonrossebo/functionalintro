module Tests

open System
open Xunit
open FSharpLib.Yr

[<Fact>]
let ``My test`` () =
    Assert.True(true)


[<Fact>]
let ``Test weather hour`` () =
    let result = GetForecastKristiansand ()
    Assert.Equal(21, result) 
