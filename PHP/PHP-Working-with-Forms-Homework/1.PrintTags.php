<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <title>Print Tags</title>
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
      foreach($tags as $key => $tag){
        echo "$key: $tag". "<br/>";
      }
   }
?>
</body>
</html>