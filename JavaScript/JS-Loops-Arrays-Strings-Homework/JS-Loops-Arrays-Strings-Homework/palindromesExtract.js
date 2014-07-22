function findPalindromes(inputString) {

    var words = inputString.toLowerCase().split(/[\W]+/); //splits the string by any non-digit symbol
    palindromes = [];

    if (words[words.length - 1] === '') {
        words.pop();
    }

    var i;

    for (i in words) {
        if (words[i].split('').reverse().join('') === words[i]) { //algorithm for finding palindrome
            palindromes.push(words[i]);
        }
    }
    return palindromes.join(', ');
}
console.log(findPalindromes('There is a man, his name was Bob.'));