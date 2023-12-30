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
?>


<!DOCTYPE html>
<html lang="en" dir="rtl">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>

    <style>
        table{
            margin-left: auto;
            margin-right: auto;
            margin-top: 20px;
        }
    </style>
</head>
<body>
    
    <form action="edit.php" method="post">
        
        <table>
            <?php include("../sd/connection.php");
                $id=$_GET['id'];
               $sql= "SELECT id, name, lastname, rname FROM tbl_std WHERE id='$id'";
               $r= mysqli_query($connection, $sql);
               while ($row=mysqli_fetch_assoc($r)) {
                echo "

            <tr>
                <td> <input type=text name=id placeholder=idNo value=".$row['id']." readonly></td>
            </tr>
            <tr>
                <td> <input type=text name=n placeholder=Name value=".$row['name']."></td>
            </tr>
            <tr>
                <td> <input type=text name=l placeholder=LastName value=".$row['lastname']."> </td>
            </tr>
            <tr>
                <td><input type=text name=r placeholder=Rname value=".$row['rname']."></td>
            </tr> ";
                
            }
            ?>
            <tr>
                <td><input type="submit" value="EditRecord"></td>
            </tr>
    
          </table>
    </form>

</body>
</html>