function sortArray(array) {
    var sorted = [];

    for (var i = 0; i < array.length; i += 1) {
        var min = i;
        for (var j = i + 1; j < array.length; j += 1) {
            if (array[j] < array[i]) {
                min = j;
            }
        }
        if (min != i) {
            var temp = 0;
            temp = array[i];
            array[i] = array[min];
            array[min] = temp;
        }
    }
    for (var i = 0; i < array.length; i += 1) {
        sorted.push(array[i]);
    }
    
    
    sorted.sort(function(a, b){
        return a - b;
    })

    console.log(sorted.join(', '));
}
sortArray([5, 4, 3, 2, 1]);
sortArray([12, 12, 50, 2, 6, 22, 51, 712, 6, 3, 3]);