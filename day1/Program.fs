module AdventOfCode.DayOne

open System.Collections.Generic
open Utils


let mapTwentyTwenty (n: int) (arr: int list): int * int =
    try
        let number = arr |> List.find(fun el -> el + n = 2020)
        (number, n)
    with
        | :? KeyNotFoundException -> (0, 0)

let mapTwentyTwentyThree (n: int) (arr: int list): int * int * int =
    try
        arr 
            |> List.map (fun el -> List.map (fun e -> (el, e, n)) arr)
            |> List.reduce (fun acc el -> acc |> List.append el)
            |> List.find(fun (a, b, c) -> a + b + c = 2020)
    with
        | :? KeyNotFoundException -> (0, 0, 0)
            
let main =
    let result = Fs.read (__SOURCE_DIRECTORY__ + "/input.txt") |> Seq.toList |> List.map int
    let (a, b) = 
        result 
            |> List.map(fun el -> mapTwentyTwenty el result)
            |> List.find(fun (el, n) -> el + n = 2020)

    let (d, e, f) = 
        result 
        |> List.map(fun el -> mapTwentyTwentyThree el result)
        |> List.find(fun (a, b, c) -> a + b + c = 2020)

    printfn "%d %d %d" (a * b) a b

    printfn "%d %d %d %d" (d * e * f) d e f