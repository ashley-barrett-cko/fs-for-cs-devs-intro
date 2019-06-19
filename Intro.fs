module Intro

    //Vars
    let stringVariable = "hello"
    let intVariable = 123
    
    
    
    //
    stringVariable = "world" //This doesn't do what you might expect!!

    
    
    
    //mutableVars
    let mutable mutableVaraible = "hello"
    mutableVaraible <- "world" 



    //Functions
    let addFunction firstNumber secondNumber = firstNumber + secondNumber
    let evenFunction number = number % 2 = 0
    let equalsFunction firstNumber secondNumber = firstNumber = secondNumber

    let getSqrt number = number |> double |> System.Math.Sqrt |> int
    let isPrime number = 
        seq { 2 .. (getSqrt number) }
        |> Seq.forall(fun x -> number % x <> 0)

    //Collections

    //Dotnet list
    let myArray = [|1..5|]

    let myList = [1..5]
    
    //IEnumerable
    let mySeq = seq{1..5}
    //Or
    let mySeq2 = seq{
        for i in 1..100 do
            match i % 2 = 0 with
            | true -> yield i
            | _ -> ()
    }
