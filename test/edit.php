<?php

session_start();
if (isset($_SESSION['login'])) 
{
    if($_SESSION['login']=="0")
    {
        header("location:login.html");
        die();
    }else{
        
    }
}else{
    header("location:login.html");
    die();
}


$id=$_POST['id'];
$name=$_POST['n'];
$lastname=$_POST['l'];
$rname=$_POST['r'];

$sql="UPDATE tbl_std SET 
name='$name',lastname='$lastname',rname='$rname' WHERE id ='$id'";

include("../sd/connection.php");

if (mysqli_query($connection, $sql)) 
{
    header("location:listedit.php");
}
else
{
    header("location:editstd.php");


}

?>