function checkBrackets(expression) {
    var bracketCount = 0;

    for (var i = 0; i < expression.length; i += 1) {
        if (expression[i] == '(') {
            bracketCount++;
        }
        else if (expression[i] == ')') {
            bracketCount--;
        }
    }
    if (bracketCount > 0 || bracketCount < 0) {
        return 'incorrect';
    }
    else {
        return 'correct';
    }
}
console.log(checkBrackets('( ( a + b ) / 5 – d )'));
console.log(checkBrackets(') ( a + b ) )'));
console.log(checkBrackets('( b * ( c + d *2 / ( 2 + ( 12 – c / ( a + 3 ) ) ) )'));