﻿namespace Bowling.Tests

open Xunit

module SpecificCases =
    
    [<Fact>]
    let ``12 strikes in row`` () =
        let expected = Some 300
        let actual = Bowling.bowlingScore "XXXXXXXXXXXX"
        Assert.Equal(actual, expected)