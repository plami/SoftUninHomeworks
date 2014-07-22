function findMaxSequence(array) {

    var currentSequence = 1;
    var longestSequence = 1;
    var indexOfLongest;

    for (var i = 0; i < array.length; i += 1) {
        if (array[i] < array[i + 1]) {
            currentSequence++;
        }else {
            if (longestSequence < currentSequence) {
                longestSequence = currentSequence;
                indexOfLongest = i - currentSequence + 1;
            }
            currentSequence = 1;
        }
    }
    if (longestSequence < 2) {
        console.log("no");
    }else {
        var result = array.slice(indexOfLongest, indexOfLongest + longestSequence);
        console.log("[" + result + "]");
    }
}
findMaxSequence([3, 2, 3, 4, 2, 2, 4]);
findMaxSequence([3, 5, 4, 6, 1, 2, 3, 6, 10, 32]);
findMaxSequence([3, 2, 1]);