<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <title>Most Frequent Tag</title>
</head>
<body>
<form method="post">
    <p>Enter tags: </p>
    <label>
        <input type="text" name="tags">
    </label>
    <input type="submit" name="submit">
</form>

<?php
if(isset($_POST["tags"])){
    $tags = explode(", ", $_POST["tags"]);
    $c = array_count_values($tags);
    $val = array_search(max($c), $c);
    arsort($c);
    foreach ($c as $key => $value) {
        echo "$key : $value times" . "<br>";
    }
    echo "<p>Most Frequent Tag is: $val </p>";
}
?>