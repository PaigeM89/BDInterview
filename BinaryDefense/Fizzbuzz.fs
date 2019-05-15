namespace BinaryDefense

module Fizzbuzz =
    let printValue i = 
        match i % 3, i % 5 with
        | 0, 0 -> 
            printfn "fizzbuzz"
        | 0, _ -> printfn "fizz"
        | _, 0 -> printfn "buzz"
        | _, _ -> printfn "%i" i

    let printUpTo x =
        [1..x] |> List.iter printValue