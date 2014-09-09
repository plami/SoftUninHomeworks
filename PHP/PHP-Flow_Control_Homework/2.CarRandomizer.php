<!DOCTYPE html>
<html>
<head>
    <title>Car Randomizer</title>
    <link rel="stylesheet" href="CarRandomizer.css"/>
</head>

<body>

<form method="POST">
    <label>Enter cars, separated by comma:</label>
    <label><input type="text" name="cars"></label>
    <input type="submit" value="Show Result">
</form>

<?php
if(isset($_POST['cars']) && !empty($_POST['cars'])) :
    $carsList = $_POST['cars'];
    //!using regular expression
    $cars = preg_split('/[ ,;]+/', $carsList);
?>
    <table>
        <tr>
            <th>Car</th>
            <th>Color</th>
            <th>Count</th>
        </tr>
<?php
    $colors = ['red', 'yellow', 'blue', 'black', 'orange'];
    foreach($cars as $carName) :
        $count = rand(1, 5);
        $randColor = array_rand($colors);
?>
        <tr>
            <td><?= $carName?></td>
            <td><?= $colors[$randColor]?></td>
            <td><?= $count?></td>
        </tr>
<?php
      endforeach;
?>
        </table>
<?php endif; ?>

</body>

</html>