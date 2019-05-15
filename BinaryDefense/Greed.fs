namespace BinaryDefense

module Greed =

    let calculateScore arr = 
        let checkTriples (a : List<int>) =
            if (List.length a < 3) then 
                (0, a)
            else 
                let sortedList = List.sort a 
                let a' = sortedList |> List.take 3
                //printfn "sorted list is %A" a'
                match a' with
                | [ 1; 1; 1; ] -> (1000, List.skip 3 sortedList)
                | [ 2; 2; 2; ] -> (200, List.skip 3 sortedList)
                | [ 3; 3; 3; ] -> (300, List.skip 3 sortedList)
                | [ 4; 4; 4; ] -> (400, List.skip 3 sortedList)
                | [ 5; 5; 5; ] -> (500, List.skip 3 sortedList)
                | [ 6; 6; 6; ] -> (600, List.skip 3 sortedList)
                | _ -> (0, a)



        let checkSingles (a : List<int>) = 
            //printfn "List is %A" a
            let a' = List.countBy (id) a
            let onesCount = List.tryFind (fun (x, _) -> x = 1) a' |> Option.map snd |> Option.defaultValue 0
            let fivesCount = List.tryFind (fun (x, _) -> x = 5) a' |> Option.map snd |> Option.defaultValue 0

            onesCount * 100 + fivesCount * 50

        let score, arr' = checkTriples arr
        //printfn "First pass of chekcing triples returns score %i and list %A" score arr'
        let score', arr'' = checkTriples arr'
        //printfn "Second pass of chekcing triples returns score %i and list %A" score' arr''
        checkSingles arr'' + score' + score

