module FizzBuzz1

    let go upperBound = 
        for x in 1..upperBound do 
            if x % 3 = 0 && x % 5 = 0 then printfn "FizzBuzz"  
            else if x % 3 = 0 then printfn "Fizz"
            else if x % 5 = 0 then printfn "Buzz"
            else printfn "%d" x