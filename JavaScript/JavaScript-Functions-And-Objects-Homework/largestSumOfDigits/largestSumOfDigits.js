function findLargestSumOfDigits(nums) {

    if (arguments.length < 1) {
        return undefined;
    }

    var maxSum = 0;
    for (var i = 0; i < nums.length; i += 1) {
        if (parseInt(nums[i]) !== nums[i]) { //the argument is not integer
            return undefined;
        }
        var currentNumber = Math.abs(nums[i]).toString();
        var currentSum = 0;
        for (var j = 0; j < currentNumber.length; j += 1) { //loop for the number
            currentSum += Number(currentNumber[j]);
        }
        if (currentSum >= maxSum) {
            var result = nums[i]; //in result we store the number with max sum of its digits
            maxSum = currentSum;
        }
    }
    return result;
}
console.log(findLargestSumOfDigits([5, 10, 15, 111]));
console.log(findLargestSumOfDigits([33, 44, -99, 0, 20]));
console.log(findLargestSumOfDigits(['hello']));
console.log(findLargestSumOfDigits([5, 3.3]));