import UIKit

//var optionalString: String? = "NOT NIL"
//
//if let stringValue = optionalString {
//    print("The value is \(stringValue)")
//} else {
//    print("Value is nil")
//}

var velocity: Double = 0.0
var time: Double = 0.0
var acceleration: Double = -9.81
var distance = (velocity * time) + (0.5 * acceleration * (time*time))

var origin = (x: 0, y: 0)

var character: Character = "D"

let constantArray = [Int]()
var mutableArray = [String]()


func calculateDistance(velocity: Double, time: Double, acceleration: Double) -> Double {
    return (velocity * time) + (0.5 * acceleration * (time*time))
}

while time < 100 {
    print(calculateDistance(velocity: velocity, time: time, acceleration: acceleration))
    time += 0.1;
}
