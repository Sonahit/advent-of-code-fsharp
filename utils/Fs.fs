module Utils.Fs

open System.IO

let read (path: string) =
    seq {
        use sr = new StreamReader(path)

        while not sr.EndOfStream do
            yield sr.ReadLine()
    }
