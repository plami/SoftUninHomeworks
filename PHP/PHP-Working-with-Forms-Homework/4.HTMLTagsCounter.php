<!DOCTYPE html>

<html>
<head>
    <title>Tag Counter</title>
</head>
<body>
<div id="container">
    <p>Enter HTML Tag: </p>

    <form method="post">
        <input type="text" name="tags"/>
        <input type="submit" name="submitBtn" value="Submit"/>
        <br/>
        <div id="result">
            <?php
            session_start();
            $validTags = array('a', 'abbr', 'acronym', 'address', 'applet', 'area', 'b', 'base', 'basefont',
                'bdo', 'bgsound', 'big', 'blockquote', 'blink', 'body', 'br', 'button', 'caption', 'center', 'cite', 'code',
                'col', 'colgroup', 'dd', 'dfn', 'del', 'dir', 'dl', 'div', 'dt', 'embed', 'em', 'fieldset', 'font', 'form',
                'frame', 'frameset', 'h1', 'h2', 'h3', 'h4', 'h5', 'h6', 'head', 'hr', 'html', 'iframe', 'img', 'input',
                'ins', 'isindex', 'i', 'kbd', 'label', 'legend', 'li', 'link', 'marquee', 'menu', 'meta', 'noframe',
                'noscript', 'optgroup', 'option', 'ol', 'p', 'pre', 'q', 's', 'samp', 'script', 'select', 'small', 'span', 'strike',
                'strong', 'style', 'sub', 'sup', 'table', 'td', 'th', 'tr', 'tbody', 'textarea', 'tfoot', 'thead', 'title',
                'tt', 'u', 'ul', 'var');
            $count = 0;
            if(isset($_POST['tags'])) {
                if($_POST['tags'] == '') {
                    if(isset($_SESSION['count'])) {
                        unset($_SESSION['count']);
                    }
                }
                if(in_array($_POST['tags'], $validTags)) {
                    echo "Valid HTML tag!" . "<br>";
                    if(isset($_SESSION['count'])) {
                        $_SESSION['count']++;
                    }
                    else {
                        $_SESSION['count'] = 0;
                    }
                    echo "Score: " . $_SESSION['count'];
                }
                else {
                    echo "Invalid HTML tag!" . "<br>";
                }
            }
            ?>
        </div>
    </form>
</body>
</html>