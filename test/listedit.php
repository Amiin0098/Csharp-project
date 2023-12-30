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
            width: 70%;
        }
        th,td{
            border: 1px solid;
            text-align: center;
        }
    </style>

</head>
<body>
     <table>
        <tr><td><a href="add.html">جدید</a></td></tr>
        <tr>
            <th>شماره دانشجویی</th>
            <th>نام</th>
            <th>نام خانوادگی</th>
            <th>رشته</th>
            <th colspan="2">عملیات</th>
        </tr>

        <?php
            include("../sd/connection.php");
            $sql="SELECT id, name, lastname, rname FROM tbl_std "; 
            $r=mysqli_query($connection, $sql);
            if(mysqli_num_rows($r)> 0)
            {
                while($row=mysqli_fetch_assoc($r))
                {
                    echo "<tr>
                    <td>".$row['id']."</td>
                    <td>".$row['name']."</td>
                    <td>".$row['lastname']."</td>
                    <td>".$row['rname']."</td>
                    <td><a href=del.php?id=".$row['id'].">حذف</a></td>
                    <td><a href=editstd.php?id=".$row['id'].">ویرایش</a></td>   

                    </tr>";

                }
            }else{

            }
        
        ?>
     </table>
</body>
</html>