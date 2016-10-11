namespace Tests

module UtilsTests =
    open FsCheck
    open FsCheck.Xunit

    module CrossProducts =
        open Utils.Products

        [<Property>]
        let ``length N of cross product list is n**2, where n is the length of one of the input lists``
            (xs : int list) =
            let result =
                crossProductOfLists xs xs
                |> List.ofSeq
                |> List.length
            let expected = float(List.length xs)**2.0 |> int
            result = expected

    module Misc =
        open Utils.Misc

        [<Property(MaxTest = 10000)>]
        let ``two added numbers should be sum of those numbers`` (x : int) (y : int) =
            let result = addTwoNumbers x y
            let expected = x + y
            result = expected
