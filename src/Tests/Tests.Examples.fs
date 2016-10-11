namespace Tests

(*
    Example of how to mix classic unit tests and FsCheck tests
*)

module MyXunitTestExamples =
    open Xunit

    [<Fact>]
    let ``just test`` () =
        Assert.Equal(1, 1)

    [<Fact>]
    let ``my other test`` () =
        Assert.Equal(1, 42)

module MyFsCheckTestExamples =
    //open Xunit.Abstractions
    open FsCheck
    open FsCheck.Xunit

    [<Property>]
    let ``Reverse of reverse of a list is the original list`` (xs : int list) =
        List.rev(List.rev xs) = xs

    [<Properties(MaxTest = 10, EndSize = 10)>]
    module Properties =
        [<Property>]
        let ``property 1`` (input : int) =
            true

        [<Property(MaxTest = 500)>]
        let ``property 2`` (input : int) =
            true

        [<Property(Replay = "123,456")>]
        let ``property 3`` (input : int) =
            true
