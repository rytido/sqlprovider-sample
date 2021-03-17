open System
open FSharp.Data.Sql

let [<Literal>] dbVendor = Common.DatabaseProviderTypes.MSSQLSERVER_DYNAMIC
let [<Literal>] connString = "Server=server;Database=db;Trusted_Connection=True;"
let [<Literal>] resolutionPath  = "lib"

type sql = SqlDataProvider<dbVendor, connString, IndividualsAmount=1000, UseOptionTypes=true, ResolutionPath=resolutionPath>


// Define a function to construct a message to print
let from whom =
    sprintf "from %s" whom

[<EntryPoint>]
let main argv =
    let message = from "F#" // Call the function
    printfn "Hello world %s" message
    0 // return an integer exit code
