#r "./packages/FSharp.Data/lib/net45/FSharp.Data.dll"
#r "System.Xml.Linq.dll"

open FSharp.Data

type YrForecast = XmlProvider<"../Samples/Yr.xml">

let KristiansandYrData = YrForecast.GetSample()
        // YrForecast.Load("http://www.yr.no/place/Norway/Vest-Agder/Kristiansand/Kristiansand/forecast.xml")

for item in KristiansandYrData.Observations.Weatherstations do
    printfn "%s" item.Name