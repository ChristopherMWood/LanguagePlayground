namespace BowlingGameTests

open System
open Microsoft.VisualStudio.TestTools.UnitTesting
open BowlingGame


[<TestClass>]
type GameCalculatorTests () =

    let zerosGame = List.replicate 20 0
    let onesGame = List.replicate 20 1
    let spareGame = List.replicate 21 5
    let perfectGame = List.replicate 12 10

    [<TestMethod>]
    member this.CalculateScoreReturnsZeroWhenAllRollsAreZero() =
        let score = GameCalculator.CalculateScore zerosGame
        Assert.AreEqual(0, score);

    [<TestMethod>]
    member this.CalculateScoreReturnsTwentyWhenAllRollsAreOne() =
        let score = GameCalculator.CalculateScore onesGame
        Assert.AreEqual(20, score);

    [<TestMethod>]
    member this.CalculateScoreReturns150WhenAllRollsAreFive() =
        let score = GameCalculator.CalculateScore spareGame
        Assert.AreEqual(150, score);

    [<TestMethod>]
    member this.CalculateScoreReturns300WhenAllRollsAreTen() =
        let score = GameCalculator.CalculateScore perfectGame
        Assert.AreEqual(300, score);

