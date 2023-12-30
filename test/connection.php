<?php

    $connection = mysqli_connect('localhost','root','root');
    mysqli_select_db($connection,'school');
    mysqli_set_charset($connection, 'UTF8')
?>
