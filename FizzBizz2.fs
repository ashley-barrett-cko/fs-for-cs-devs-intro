module FizzBuzz2

    let private isFizz number = number % 3 = 0
    let private isBuzz number = number % 5 = 0

    let go upperBound = 
        for x in 1..upperBound do 
            match x with
            | _ when isFizz x && isBuzz x -> printfn "FizzBuzz"
            | _ when isFizz x -> printfn "Fizz"
            | _ when isBuzz x -> printfn "Buzz"
            | _ -> printfn "%d" x