<html>
<title>Sum Two Numbers</title>
<body>
<?php
$firstNumber = 2;
$secondNumber = 5;
$sum = $firstNumber+$secondNumber;
echo '$firstNumber ' . '+' . ' $secondNumber ' . '= '
    .$firstNumber . ' + ' .$secondNumber . ' = ' . sprintf("%0.2f", $sum);
//round number to second digit after decimal point
?>
<br />
<?php
$firstNumber = 1.567808;
$secondNumber = 0.356;
$sum = round($firstNumber + $secondNumber, 2);
echo '$firstNumber ' . '+' . ' $secondNumber ' . '= '
    .$firstNumber . ' + ' .$secondNumber . ' = ' . $sum;
//round number to second digit after decimal point
?>
<br />
<?php
$firstNumber = 1234.5678;
$secondNumber = 333;
$sum = round($firstNumber + $secondNumber, 2);
echo '$firstNumber ' . '+' . ' $secondNumber ' . '= '
    .$firstNumber . ' + ' .$secondNumber . ' = ' . $sum;
//round number to second digit after decimal point
?>
</body>
</html>