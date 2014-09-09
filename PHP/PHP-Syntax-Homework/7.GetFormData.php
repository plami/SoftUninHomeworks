<?php
$result = "";
if($_SERVER['REQUEST_METHOD'] === 'POST'){
    $name = $_POST['name'];
    $age = $_POST['age'];
    $sex = $_POST['sex'];
    $result = "My name is $name. I am $age years old. I am $sex.";
}
?>

<!DOCTYPE html>
<html>

<head>
    <meta charset="UTF-8"/>
    <title>Get Form Data</title>
</head>

<body>
    <form method="post" action="">
       <input type="text" name="name" placeholder="Name...">
       <br />
       <input type="text" name="age" placeholder="Age...">
       <br />
       <label for="male"><input type="radio" id="male" name="sex" value="male">Male</label>
       <br />
       <label for="female"><input type="radio" id="female" name="sex" value="female">Female</label>
       <br />
       <input type="submit">
    </form>
    <?php echo $result; ?>
</body>

</html>