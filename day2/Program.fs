module AdventOfCode.DayTwo

open System
open Utils

let main =
    Fs.read (__SOURCE_DIRECTORY__ + "/input.txt") 
    |> Seq.toList 
    |> List.filter (fun el -> 
        if el <> "" then
            let splitted = el.Split(":")
            let policy = splitted.[0].Trim()
            let splittedPolicy = policy.Split(" ")
            let count = splittedPolicy.[0].Split("-")

            let leftCount = int (count.[0].Trim())
            let rightCount = int (count.[1].Trim())
            let char = splittedPolicy.[1].Trim().ToCharArray().[0]

            let str = splitted.[1].Trim()

            let newStr = String.filter (fun c -> c = char) str

            if newStr.Length >= leftCount && newStr.Length <= rightCount then
                true
            else
                false
        else
            false
    )
let secondMain =
    Fs.read (__SOURCE_DIRECTORY__ + "/input.txt") 
    |> Seq.toList 
    |> List.filter (fun el -> 
        if el <> "" then
            let splitted = el.Split(":")
            let policy = splitted.[0].Trim()
            let splittedPolicy = policy.Split " "
            let count = splittedPolicy.[0].Split "-"

            let leftPos = int (count.[0].Trim()) - 1
            let rightPos = int (count.[1].Trim()) - 1
            let char = splittedPolicy.[1].Trim().ToCharArray().[0]

            let str = splitted.[1].Trim()
            let emptyStr = " ".ToCharArray().[0]
            let leftChar = if str.Length - 1 >= leftPos then str.[leftPos] else emptyStr
            let rightChar = if str.Length - 1 >= rightPos then str.[rightPos] else emptyStr

            (leftChar = char || rightChar = char) && not (rightChar = char && leftChar = char)
        else
            false
    )
