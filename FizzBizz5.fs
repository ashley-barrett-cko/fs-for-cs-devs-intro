module FizzBuzz5

    let private isFizz number = number % 3 = 0
    let private isBuzz number = number % 5 = 0

    let private format number words = sprintf "%i %s" number words

    let private getWordsForNumber funcOne funcTwo number = 
        match funcOne number, funcTwo number with
        | true, true -> format number "FizzBuzz"
        | true, false -> format number "Fizz"
        | false, true-> format number "Buzz"
        | _, _ -> format number ""

    //Keep taking while the number of Fizz Buzz words is less than 1000
    let go takeUntil = 
        
        (0, 1)
        |> Seq.unfold(fun (acc, number) -> 
            let words = getWordsForNumber isFizz isBuzz number   

            printfn "%s" words  

            let next = if words.Length > 0 then acc + 1 else acc

            Some((acc, number), (next, number + 1))
        )
        |> Seq.takeWhile(fun (acc, _) -> acc <= takeUntil)
        |> Seq.toList