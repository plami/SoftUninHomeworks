<!DOCTYPE html>
<html>
<head>
    <link rel="stylesheet" href="SquareRootSum.css"/>
</head>
<body>
<table>
    <tr><th>Number</th><th>Square Root</th></tr>
        <?php $sum = 0;
            for($i = 0;$i <= 100; $i+=2):
                $sqrt = sqrt($i);
                $sum += $sqrt;
                $sqrtRounded = round($sqrt, 2);
        ?>
                <tr><td><?= $i ?></td><td><?= $sqrtRounded ?></td></tr>
        <?php endfor; ?>
    <tr><td><b>Total: </b></td><td><?= round($sum,2) ?></td></td></tr>
</body>
</html>