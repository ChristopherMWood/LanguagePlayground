namespace BowlingGame

module GameCalculator =

    let CalculateScore (rolls : int seq) =
        Seq.sum rolls
