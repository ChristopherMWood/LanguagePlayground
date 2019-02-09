/*
Example Run
var numberList = [1, 2, 3, 4, 5, 7, 8, 9, 10];
var missingValue = FindMissingConsecutiveValue(numberList)
*/
function FindMissingConsecutiveValue(numberList) {
    
    if (numberList.length < 3)
        return -1;

    for (var i = 0; i < numberList.length - 1; i++) {
        var expectedValue = numberList[i] + 1;
        var nextValue = numberList[i + 1];
        if (nextValue != expectedValue)
            return expectedValue;
    }

    return -1;
}