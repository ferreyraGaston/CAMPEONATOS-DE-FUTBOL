<?php
$Userver="localhost";
$User="root";
$Upass="13231414";
$Udb="bdcampeonato";


$Userver="localhost";
$User="id20986849_root";
$Upass="G@stonloco13231414";
$Udb="id20986849_bdcampeonato";

$con=new mysqli($Userver,$User,$Upass,$Udb);

if($con ->connect_errno){
    echo "Ha ocurrido un error";
}
?>