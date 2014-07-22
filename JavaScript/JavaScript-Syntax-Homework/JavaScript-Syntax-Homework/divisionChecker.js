function divisionBy3(value) {
    var sumOfDigits = 0;
    while (value > 0) {
        sumOfDigits += value % 10;
        value = Math.floor(value / 10);
        
        //If you have integer 123:
        //After first iteration of n: sum 's value is 3 (because remainder of 123 / 10 is 3). n becomes 12 because 123 divided by 10, and the int value loaded back into n for next iteration
        //After second iteration of n: sum 's value is 2+3 (because remainder of 12 / 10 is 2). n becomes 1 because 12 divided by 10, and the int value loaded back into n for next iteration
        //After third iteration of n: sum 's value is 1+2+3 (because remainder of 1 / 10 is 1). n becomes 0 because 1 divided by 10, and the int value loaded back into n for next iteration
    }
    if (sumOfDigits % 3 == 0) {
        console.log("the number is divided by 3 without remainder");
    }else {
        console.log("the number is not divided by 3 without remainder");
    }
}
divisionBy3(12);
divisionBy3(189);
divisionBy3(591);
divisionBy3(13);