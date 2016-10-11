// Learn more about F# at http://fsharp.net. See the 'F# Tutorial' project
// for more guidance on F# programming.

#load "../MyProject/Utils.fs"
open Utils.Products
// Define your library scripting code here

let res1 = crossProductOfLists [1] [3] |> List.ofSeq
res1
|> printfn "%A"

List.length res1
|> printfn "%i"

2.0**1.0
|> printfn "%A"
