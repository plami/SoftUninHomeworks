function printNumbers(n) {
    var numbers = [];
    if (n > 0) {
        for (i = 1; i <= n; i++) {
            if (i % 4 == 0 || i % 5 == 0) {
                continue;
            }
            numbers.push(i);
        }
        console.log(numbers.join(', '));
    }
    else {
        console.log("no");
    }
}
printNumbers(20);
printNumbers(-5);
printNumbers(13);
