module FizzBuzz3

    let private isFizz number = number % 3 = 0
    let private isBuzz number = number % 5 = 0

    let private getWordsForNumber number = 
        let words = 
            match number with
            | _ when isFizz number && isBuzz number -> Some("FizzBuzz")
            | _ when isFizz number -> Some("Fizz")
            | _ when isBuzz number -> Some("Buzz")
            | _ -> None

        (number, words)

    let go upperBound = 
        [1..upperBound]
        |> List.map getWordsForNumber
        |> List.iter(fun (number, wordsOptions) -> 
            match wordsOptions with
            | Some words -> printfn "%i %s" number words
            | _ -> printfn "%i" number
        )