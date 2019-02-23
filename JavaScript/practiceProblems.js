var exports = module.exports = {
    findMissingConsecutiveValue: function(numberList) {
        var missingValues = [];

        if (numberList.length < 3)
            return missingValues;
            
        for (var i = 0; i < numberList.length - 1; i++) {
            var expectedValue = numberList[i] + 1;
            var nextValue = numberList[i + 1];
            if (nextValue != expectedValue)
                missingValues.push(expectedValue);
        }
    
        return missingValues;
    },
    findDuplicateNumbers: function(numberList) {
        var valueMap = new Map();

        for (var i = 0; i < numberList.length; i++) {
            if (valueMap.get(numberList[i]) === undefined)
                valueMap.set(numberList[i], 1);
            else
                valueMap.set(numberList[i], valueMap.get(numberList[i]) + 1);
        }
    
        var missingValues = [];
    
        valueMap.forEach(function(value, key) {
            if (value > 1)
                missingValues.push(key);
        });
    
        return missingValues;
    }
};