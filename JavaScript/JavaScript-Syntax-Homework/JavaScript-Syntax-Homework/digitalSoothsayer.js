function soothsayer(numbers, languages, cities, cars) {
    var randomYear = numbers[Math.floor(Math.random() * numbers.length)];
    var randomLanguage = languages[Math.floor(Math.random() * languages.length)];
    var randomCities = cities[Math.floor(Math.random() * cities.length)];
    var randomCars = cars[Math.floor(Math.random() * cars.length)];

    return "You will work " + randomYear +  " years on " + randomLanguage + 
           "\nYou will live in " + randomCities + " and drive " + randomCars;
}
console.log(soothsayer([3, 5, 2, 7, 9], ["Java", "Python", "C#", "JavaScript", "Ruby"],
["Silicon Valley", "London", "Las Vegas", "Paris", "Sofia"],["BMW", "Audi", "Lada",
"Skoda", "Opel"]));
