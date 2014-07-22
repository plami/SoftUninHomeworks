function displayProperties(value) {
    var elements = [];
    for (var el in value) {
        elements.push(el);
    }
    elements.sort();
    for (var idx in elements) {
        console.log(elements[idx]);
    }
}

window.onload = function () {
    displayProperties(document);
}