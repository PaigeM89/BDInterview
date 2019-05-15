// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"

    //BinaryDefense.Fizzbuzz.printUpTo 100

    let example1 = [ 1; 1; 1; 5; 1]
    let outputScore1 = BinaryDefense.Greed.calculateScore example1
    printfn "Output score was %i, expected score was %i" outputScore1 1150

    let example2 = [ 2; 3; 4; 6; 2]
    let outputScore2 = BinaryDefense.Greed.calculateScore example2
    printfn "Output score was %i, expected score was %i" outputScore2 0


    let example3 = [ 3; 4; 5; 3; 3; ]
    let outputScore3 = BinaryDefense.Greed.calculateScore example3
    printfn "Output score was %i, expected score was %i" outputScore3 350

    
    let example4 = [ 1; 5; 1; 2; 4]
    let outputScore4 = BinaryDefense.Greed.calculateScore example4
    printfn "Output score was %i, expected score was %i" outputScore4 250

    let example5 = [ 5; 5; 5; 5; 5]
    let outputScore5 = BinaryDefense.Greed.calculateScore example5
    printfn "Output score was %i, expected score was %i" outputScore5 600

    0 // return an integer exit code
