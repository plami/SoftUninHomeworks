<html>
<title>Dump Variable</title>>
<body>
<?php
$tests = array(
"hello",
15,
1.234,
array(1,2,3),
(object)[2,34]
);

foreach ($tests as $element) {
if (is_numeric($element)) {
echo var_dump($element) . '<br>';
} else {
echo gettype($element) . '<br>';
}
}
?>
</body>
</html>>