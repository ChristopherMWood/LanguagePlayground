var chai = require('chai');
var practiceProblems = require('./practiceProblems.js');
var assert = chai.assert;

describe('Practice Problems Tests', function() {
	it('Find missing consecutive value returns correct missing value', function() {
        var values = [1, 2, 3, 4, 5, 6, 8, 9];

        var missingValues = practiceProblems.findMissingConsecutiveValue(values);

		assert.equal(1, missingValues.length);
		assert.equal(7, missingValues[0]);
    });
    
    it('Find missing consecutive value returns empty list when given empty list', function() {
        var values = []

        var missingValues = practiceProblems.findMissingConsecutiveValue(values);

		assert.equal(0, missingValues.length);
    });
    
    it('Find duplicate numbers returns correct missing numbers', function() {
        var values = [1, 1, 1, 2, 3, 4, 5];

        var duplicateValues = practiceProblems.findDuplicateNumbers(values);

		assert.equal(1, duplicateValues.length);
		assert.equal(1, duplicateValues[0]);
    });

    it('Find duplicate numbers returns empty list when there are no duplicates', function() {
        var values = [1, 2, 3, 4, 5];

        var duplicateValues = practiceProblems.findDuplicateNumbers(values);

		assert.equal(0, duplicateValues.length);
    });
});