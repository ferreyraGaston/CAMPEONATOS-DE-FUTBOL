<?php

$conexion=mysqli_connect('localhost:33065','root','','bdcampeonato');

?>


<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Torneo de Futbol</title>
    <!-- css link -->
    <link rel="stylesheet" href="../css/style.css">
    <link rel="stylesheet" href="../css/torneo.css">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-9ndCyUaIbzAi2FUVXJi0CjmCapSmO7SnpJef0486qhLnuZ2cdeRhO02iuK6FUUVM" crossorigin="anonymous">
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js" integrity="sha384-geWF76RCwLtnZ8qwWowPQNguL3RmwHVBC9FhGdlKrxdiJJigb/j/68SIy3Te4Bkz" crossorigin="anonymous"></script>
    <!-- fontawesome CDN -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.3/css/all.min.css">
</head>
<body>
    <div id="container">
        <!-- logo -->
        <div id="logo">
                <img src="../assets/Football_Player.png" alt="football player png">
        </div>
        <!-- navbar -->
        <div id="navbar">
            <ul>
            <li><a href="../index.html">Inicio</a></li>
                <li><a href="../torneo.html">Torneo</a></li>
                <li><a href="../infracciones.html">infracciones</a></li>
                <li><a href="../reglamento.html">Reglamento</a></li>
                <li><a href="../contacto.html">Contactos</a></li>
                <!-- login Button
                <li id="login"><a href="../login.html">Login</a></li> -->
            </ul>
        </div>
        <!-- content -->
        <div id="contentTitulo">
            <h3>Infracciones</h3>
        </div>

    <div class="containerTorneo">

        <div class="card__giratorio">
            <div class="card__giratorio-conteudo">
                <div class="card__giratorio-conteudo--frente">
                    <img src="../images/ic-logo11.png" alt="Logo Programador CS" class="logo2">
                </div>
                <div class="card__giratorio-conteudo--traseira">
                    <img src="../images/ic-logo11.png" alt="Logo Programador CS" class="logo2">
                    <table class="table table-primary table-striped">
    <thead>
        <tr>
            <th scope="col">Orden</th>
            <th scope="col">Nombre</th>
            <th scope="col">Apellido</th>
            <th scope="col">Fecha</th>
            <th scope="col">Tarjeta</th>
        </tr>
    </thead>

    <tbody>
        <?php

        $sql = "SELECT r.id_roja AS Tarjeta, j.nombre AS Nombre, j.apellido AS Apellido, DATE_FORMAT(dia, '%d/%m/%Y') AS Fecha, 'roja' AS Color " .
            "FROM rojas r " .
            "INNER JOIN jugadores j ON r.dni_jugador = j.dni " .
            "INNER JOIN fechas f ON r.id_fecha = f.id_fecha " .
            "UNION " .
            "SELECT a.id_amarilla AS Tarjeta, j.nombre AS Nombre, j.apellido AS Apellido, DATE_FORMAT(dia, '%d/%m/%Y') AS Fecha, 'amarilla' AS Color " .
            "FROM amarillas a " .
            "INNER JOIN fechas f ON a.id_fecha = f.id_fecha " .
            "INNER JOIN jugadores j ON a.dni_jugador = j.dni;";
        $result = mysqli_query($conexion, $sql);
        while ($mostrar = mysqli_fetch_array($result)) {
            ?>
            <tr>
                <td><?php echo $mostrar['Tarjeta'] ?></td>
                <td><?php echo $mostrar['Nombre'] ?></td>
                <td><?php echo $mostrar['Apellido'] ?></td>
                <td><?php echo $mostrar['Fecha'] ?></td>
                <td><?php echo $mostrar['Color'] ?></td>
            </tr>
            <?php
        }
        ?>
    </tbody>
</table>

                </div>
            </div>
        </div>

    </div>
</div> 
</body>
</html>

