namespace FSharpLib

module Yr =

    open FSharp.Data

    type YrForecast = XmlProvider<"../../Samples/Yr.xml">

    let GetForecastKristiansand() =
            YrForecast.Load("http://www.yr.no/place/Norway/Vest-Agder/Kristiansand/Kristiansand/forecast.xml")
            |> fun x -> x.Sun.Set.Hour

