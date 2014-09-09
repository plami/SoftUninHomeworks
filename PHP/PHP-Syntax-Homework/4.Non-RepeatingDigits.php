<?php
$n = 1234;
$arr = array();

for($i = 102; $i <= $n; $i++){
    //returns the length of the string
    if(strlen($i) >= 4){
    break;
    }
    $firstDigit = (int)($i % 10);
    $secondDigit = (int)(($i / 10) % 10);
    $thirdDigit =(int)($i / 100);

    if($firstDigit != $secondDigit && $secondDigit != $thirdDigit && $firstDigit != $thirdDigit){
    array_push($arr,$i);
    }
}
if(count($arr) > 0){
    echo implode(', ', $arr);
}else{
    echo "no";
}
?>