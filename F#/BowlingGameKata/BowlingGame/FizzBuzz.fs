module FizzBuzz

let numbers = [|1..100|]

let fizzBuzzForNumber number =
    match number with
    | number when (number % 15) = 0 ->
        "FizzBuzz"
    | number when (number % 5) = 0 ->
        "Buzz"
    | number when (number % 3) = 0 ->
        "Fizz"
    | number ->
        sprintf "%d" number
    

let fizzBuzzForList numbers =
    numbers |> Array.iter (fun n -> printfn "%s" (fizzBuzzForNumber n))

fizzBuzzForList numbers