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




$id=$_GET['id'];

$sql="DELETE FROM `tbl_std` WHERE id= '$id'";

include("../sd/connection.php");

if (mysqli_query($connection, $sql)) 
{
    header("location:listedit.php");
} else {


}


 

?>