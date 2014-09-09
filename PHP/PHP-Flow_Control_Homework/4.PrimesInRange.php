<!DOCTYPE html>
<html>

<head>
    <title>Primes in range</title>
</head>

<body>

<form method="POST">
    <label>Starting Index: </label>
    <label><input type="text" name="start"></label>
    <label>End: </label>
    <label><input type="text" name="end"></label>
    <label><input type="submit" value="Submit"></label>
</form>
<?php
        if(isset($_POST['start']) && $_POST['end'])
        {
            $start = $_POST['start'];
            $end = $_POST['end'];
            if($start < $end)
            {
                $result = array();
                for($number = $start; $number <= $end; $number++)
                {
                    $result[] = isPrime($number) ? "<strong>$number</strong>" : $number;
                }
                echo implode(", ", $result);
            }
            else
            {
                echo "The start number must be less than the end number.";
            }
        }
        else{
            echo "The start and end number are required.";
        }
function isPrime($number)
{
    if($number <= 1)
    {
        return false;
    }
    elseif($number == 2)
    {
        return true;
    }
    elseif($number % 2 == 0)
    {
        return false;
    }
    else
    {
        for($i = 3; $i <= ceil(sqrt($number)); $i+=2)
        {
            if($number % $i == 0)
            {
                return false;
            }
        }
        return true;
    }
}
?>
</body>
</html>