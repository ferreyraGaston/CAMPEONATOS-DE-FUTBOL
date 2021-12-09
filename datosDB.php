<?php 
//$host="localhost";
//$usuario="root";
//$clave="Ws0)e[dFCQls7imc";
//$basededatos="proyecto_1_ispc";

$host="localhost";
$usuario="id17867500_root";
$clave="3rbU-gRz@!T7JMQI";
$basededatos="id17867500_proyecto_1_ispc";


$conn=new mysqli($host,$usuario,$clave,$basededatos);

mysqli_query($conn, "SET character_set_result=utf8");
if($conn->connect_error){
    die("Database Error: ".$conn->connect_error);
}

//echo "conectado";
?>