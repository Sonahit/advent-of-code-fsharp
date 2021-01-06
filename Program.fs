open System
open AdventOfCode

[<EntryPoint>]
let main argv =
    printfn ("%A") AdventOfCode.DayOne.main
    printfn ("%A") AdventOfCode.DayTwo.main.Length
    printfn ("%A") AdventOfCode.DayTwo.secondMain.Length
    0 // return an integer exit code
