module Utils.HttpClient

open System.Net.Http

let client = new HttpClient()

let get (url: string) =
    async {
        let! result = client.GetAsync(url) |> Async.AwaitTask
        result.EnsureSuccessStatusCode |> ignore

        return!
            result.Content.ReadAsStringAsync()
            |> Async.AwaitTask
    }
