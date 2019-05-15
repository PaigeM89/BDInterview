namespace BinaryDefense

module Greed =

    let calculateScore arr = 
        let checkTriples (a : List<int>) =
            let a' = List.sort a
            match a' with
            | [ 1; 1; 1; _; _] -> (1000, List.skip 3 a')
            | [ 2; 2; 2; _; _] -> (200, List.skip 3 a')
            | [ 3; 3; 3; _; _] -> (300, List.skip 3 a')
            | [ 4; 4; 4; _; _] -> (400, List.skip 3 a')
            | [ 5; 5; 5; _; _] -> (500, List.skip 3 a')
            | [ 6; 6; 6; _; _] -> (600, List.skip 3 a')
            | _ -> (0, a)

        let checkSingles (a : List<int>) = 
            let a' = List.countBy (id) a
            let onesCount = List.tryFind (fun (x, _) -> x = 1) a' |> Option.map snd |> Option.defaultValue 0
            let fivesCount = List.tryFind (fun (x, _) -> x = 5) a' |> Option.map snd |> Option.defaultValue 0

            onesCount * 100 + fivesCount * 50

        let score, arr' = checkTriples arr        
        checkSingles arr' + score