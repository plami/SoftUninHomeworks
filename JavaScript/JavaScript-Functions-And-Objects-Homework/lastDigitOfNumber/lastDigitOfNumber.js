function lastDigitText(number) {
    
    var lastDigit = Math.abs(number % 10);
    
    switch (lastDigit) {
        case 0: return "Zero";
        case 1: return "One";
        case 2: return "Two";
        case 3: return "Three";
        case 4: return "Four";
        case 5: return "Five";
        case 6: return "Six";
        case 7: return "Seven";
        case 8: return "Eight";
        case 9: return "Nine";
    }
}
console.log(lastDigitText(6));
console.log(lastDigitText(-55));
console.log(lastDigitText(133));
console.log(lastDigitText(14567));