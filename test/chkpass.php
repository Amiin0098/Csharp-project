<?php
session_start();

$username = $_POST['u'];
$password = $_POST['p'];

include("../sd/connection.php");

$sql = "SELECT id, username, password FROM tbl_user
            WHERE username='$username' and password='$password'";

$r = mysqli_query($connection, $sql);
if (mysqli_num_rows($r) > 0) {
    $_SESSION['login']= "1"; 
    header("location: listedit.php");
} else {
    $_SESSION['login']= "0"; 
    header("location: login.html");
   
}
?>