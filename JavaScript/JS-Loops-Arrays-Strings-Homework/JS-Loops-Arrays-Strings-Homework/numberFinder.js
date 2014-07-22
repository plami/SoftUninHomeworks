function findMostFreqNum(value) {
    var results = []; //in this array we include every number as keys and how many times it is found

    for (i in value) {
        if (value[i] in results) {
            results[value[i]]++; //if the number exist, we increase the number with 1
        }else {
            results[value[i]] = 1; //if the number doesn't exist, we create it with key anad value = 1
        }
    }
    var maxCountTimes = 0;
    var number;

    for (var i = 0; i < results.length; i += 1) {
        if (maxCountTimes < results[i]) {
            maxCountTimes = results[i];
            number = i;
        }
    }
    return number + ' (' + maxCountTimes + ' times)';
}
console.log(findMostFreqNum([4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3]));
console.log(findMostFreqNum([2, 1, 1, 5, 7, 1, 2, 5, 7, 3, 87, 2, 12, 634, 123, 51, 1]));
console.log(findMostFreqNum([1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13]));