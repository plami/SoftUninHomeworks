<!DOCTYPE html>

<?php
if(isset($_GET['amount']) && isset($_GET['currency']) && isset($_GET['interest'])
    && isset($_GET['duration'])){
    $moneyAmount = $_GET['amount'];
    $currency = $_GET['currency'];
    $interest = $_GET['interest'];
    $period = $_GET['period'];

    if($period == '6Months'){
        $period = 6;
    }
    if($period == '1Year'){
        $period = 12;
    }
    if($period == '2Years'){
        $period = 24;
    }
    if($period == '5Years'){
        $period = 60;
    }
    $result = round($moneyAmount * pow(1 + (($interest / 100) / 12), $period / 12 * 12), 2);

    if($currency == 'usd'){
        $result = '$' . $result;
    }
    if($currency == 'eur'){
        $result = 'EUR' . $result;
    }
    if($currency == 'bgn'){
        $result = 'BGN' . $result;
    }
}
?>

<html>
<head>
    <meta charset="UTF-8">
    <title>Calculate Interest</title>
</head>

<body>
    <form method="get">
    <label>Enter Amount</label>
        <label>
            <input type="text" name="amount">
        </label>
        <br />
        <input type="radio" name="currency" id="usd">
        <label for="usd">USD</label>
        <input type="radio" name="currency" id="eur">
        <label for="eur">EUR</label>
        <input type="radio" name="currency" id="bgn">
        <label for="bgn">BGN</label>
        <br />
        <label>Compound Interest Amount</label>
        <label>
            <input type="text" name="interest"/>
        </label>
        <br />
        <label for="duration"></label>
        <select name="period" id="duration">
            <option value="6Months">6 Months</option>
            <option value="1Year">1 Year</option>
            <option value="2Years">2 Years</option>
            <option value="5Years">5 Years</option>
        </select>
        <input type="submit" name="submit" value="Calculate"/>
    </form>
    <?php
    if(isset($result)){
        echo "$result";
    }
    ?>
</body>
</html>