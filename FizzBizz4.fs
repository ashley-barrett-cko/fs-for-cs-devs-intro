module FizzBuzz4

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

    //Keep taking while the number of Fizz Buzz words is less than 1000
    let go takeUntil = 
        
        (0,1, Option<string>.None)
        |> Seq.unfold(fun (acc, number, _) -> 
            let number, wordsOption = getWordsForNumber number
            let current = (acc, number, wordsOption)

            match wordsOption with
            | Some _ -> Some(current, (acc + 1, number + 1, Option<string>.None))
            | _ -> Some(current, (acc, number + 1, Option<string>.None))
        )
        |> Seq.takeWhile(fun (acc, _, _) -> acc <= takeUntil)
        |> Seq.iter(fun (_, number, wordsOption) -> 
            match wordsOption with
            | Some words -> printfn "%i %s" number words
            | _ -> printfn "%i" number
        )