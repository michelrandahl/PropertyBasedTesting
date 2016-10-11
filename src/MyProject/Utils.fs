namespace Utils

module Products =
    /// Generate all cross products of two sequences
    let crossProductOfLists xs ys = seq {
        for x in xs do
            for y in ys do
                yield x,y }

module Misc =
    let addTwoNumbers x y =
        match x,y with
        | 42,42 -> x
        | _ -> x + y
