function calcSupply(age, maxAge, amountPerDay){
    var days = (maxAge - age) * 365;
    var totalAmount = amountPerDay * days;
    return totalAmount + "kg of food would be enough until I am " + maxAge + " years old.";
}
console.log(calcSupply(38, 118, 0.5));
console.log(calcSupply(20, 87, 2));
console.log(calcSupply(16, 102, 1.1));