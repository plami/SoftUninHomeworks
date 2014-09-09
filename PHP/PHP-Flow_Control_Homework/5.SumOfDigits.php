<!DOCTYPE html>
<?php
if(isset($_POST['string'])) {
    $allStrings = explode(',', $_POST['string']);

    $result = '<table border="1">';

    for($i = 0; $i < count($allStrings) ;$i++) {
        $result .= "<tr><td>{$allStrings[$i]}</td><td>";
        if(is_numeric($allStrings[$i]) && !preg_match("/\\./", $allStrings[$i])) {
            $sum = array_sum(str_split($allStrings[$i]));
            $result .= $sum;
        }
        else {
            $result .= "I cannot sum that";
        }
        $result .= '</td></tr>';
    }
    $result .= '</table>';
}
?>
<html>
<head>
    <title>Some of digits</title>
</head>
<body>
<form method="post">
    <label>Input string: </label>
    <label><input type="text" name="string"></label>
    <input type="submit" value="Submit">
</form>
<?php
if(isset($result)) {
    echo $result;
}
?>
</body>
</html>