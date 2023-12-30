<?php

$name=$_POST['n'];
$lastname=$_POST['l'];
$rname=$_POST['r'];

include("../sd/connection.php");


$sql=" INSERT INTO tbl_std( name, lastname, rname)
        VALUES ('$name','$lastname','$rname')";
if( mysqli_query($connection,$sql))
{
    header("location:listedit.php");
}else
{
    header("location:add.html");

}


?>