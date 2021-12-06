<?php require_once "php/parte_superior.php"?>
 <!-- Formulario  -->
 <br>

 <div class="contenedor__todo caja_proceso">

 <?php 

$nombre= $_POST["username"];
$apellido= $_POST["fullname"];
$direccion= $_POST["email"];
$passwordid= $_POST["passwordid"];
//$password_hash= password_hash($passwordid, PASSWORD_BCRYPT);FechaNacim
$fecha_alta= date("Y-m-d");
$cuil= $_POST["cuil"];
//$telefono= $_POST["pais"];
$Estado= 3;


print "<h4><strong>Verifique tus datos</strong>.</h4>\n";
print "\n";
print "<p>Nombre: <strong>$nombre</strong>.</p>\n";
print "\n";
print "<p>pellido: <strong>$apellido</strong>.</p>\n";
print "\n";
print "<p>Email: <strong>$direccion</strong>.</p>\n";
print "\n";
print "<p>Password: <strong>$passwordid</strong>.</p>\n";
print "\n";
print "<p>Fecha de Alta: <strong>$fecha_alta</strong>.</p>\n";

print "\n";
?>


<button type="button" onclick="redireccion()" class="btn btn-secondary">Enviar</button>
</div>
<br><br>

<?php require_once "php/parte_inferior.php"?>

<?php 

include("datosDB.php");
$con=mysqli_connect($host,$usuario,$clave,$basededatos) or die ("<br><br><br><h1>no se puede conectar con el Servidor</h1>");

if(!$con){
  die("Conexión fallida: ".mysqli_error());
}

$db=mysqli_select_db($con, $basededatos) or die ("<br><br><br><h1>no se puede conectar a la base de datos</h1>");
$consulta= "INSERT INTO usuario(usuario,clave) VALUE ('$nombre','$passwordid')";
$consulta1= "INSERT INTO clientes(nombre,apellido,cuil,fecha_alta,e_mail) VALUE ('$nombre','$apellido','$cuil','$fecha_alta','$direccion')";

if(mysqli_query ($con,$consulta)){
    echo "<br>";
    echo "<br>";
    echo "<br>";
    echo "<br>";
    echo "<h1>Registro Agendado</h1>";
}else{
echo "<br>";
echo "<br>";
echo "<br>";
echo "<br>";
    echo "<h1>Error al realizar el registro</h1>";
    echo "Error: ".$consulta. "<br>".mysqli_error($con);
}

if(mysqli_query ($con,$consulta1)){
    echo "<br>";
    echo "<br>";
    echo "<br>";
    echo "<br>";
    echo "<h1>Registro Agendado</h1>";
}else{
echo "<br>";
echo "<br>";
echo "<br>";
echo "<br>";
    echo "<h1>Error al realizar el registro</h1>";
    echo "Error: ".$consulta1. "<br>".mysqli_error($con);
}

mysqli_cole($con);

?>
<br>
