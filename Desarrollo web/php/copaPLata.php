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
            <h3>Copa de Plata</h3>
        </div>

    <div class="containerTorneo">

        <div class="card__giratorio">
            <div class="card__giratorio-conteudo">
                <div class="card__giratorio-conteudo--frente">
                    <img src="../images/ic-logo2.png" alt="Logo Programador CS" class="logo">
                </div>
                    <div class="card__giratorio-conteudo--traseira ">
                            
                            <img src="../images/ic-logo2.png" alt="Logo Programador CS" class="logo trasladarY">
                            <div id="container">
        <!-- Contenido anterior aquí -->

        <div class="containerTorneo">
            <div class="row">
                <div class="col-md-6">
                <table class="table table-primary table-striped caption-top trasladarY">
                            <caption>Cuartos A</caption>
                                <thead>
                                    <tr>
                                        <th scope="col">Equipo</th>
                                        <th scope="col">Goles</th>

                                    </tr>
                                </thead>    
                                <?php
                                
                                
                                //$sql = "SELECT DISTINCT E.nombre, P.P_jug, P.P_gan, P.P_emp, P.P_per, P.G_fav, P.G_con, P.Dif_G, P.puntaje FROM posiciones P, equipos E WHERE E.id_equipo = P.id_equipo ORDER BY P.puntaje DESC, P.Dif_G DESC, P.G_fav DESC";
                                $sql = "SELECT equipo, gol1 FROM equipoplata WHERE idZona=1 ORDER BY idZona ASC LIMIT 8;";


                                $result= mysqli_query($conexion,$sql);

                                while($mostrar=mysqli_fetch_array($result)){
                                    ?>
                                <tbody>
                                    <tr>
                                        <td><?php echo $mostrar['equipo'] ?></td>
                                        <td><?php echo $mostrar['gol1'] ?></td>
                                    </tr>
                                </tbody>
                                <?php
                                    }
                                    ?>
                            </table>
                </div>
                <div class="col-md-6">
                <table class="table table-primary table-striped caption-top trasladarY">
                            <caption>Cuartos B</caption>
                                <thead>
                                    <tr>
                                        <th scope="col">Equipo</th>
                                        <th scope="col">Goles</th>

                                    </tr>
                                </thead>    
                                <?php
                                
                                
                                //$sql = "SELECT DISTINCT E.nombre, P.P_jug, P.P_gan, P.P_emp, P.P_per, P.G_fav, P.G_con, P.Dif_G, P.puntaje FROM posiciones P, equipos E WHERE E.id_equipo = P.id_equipo ORDER BY P.puntaje DESC, P.Dif_G DESC, P.G_fav DESC";
                                $sql = "SELECT equipo, gol1 FROM equipoplata WHERE idZona=2 ORDER BY idZona ASC LIMIT 8;";


                                $result= mysqli_query($conexion,$sql);

                                while($mostrar=mysqli_fetch_array($result)){
                                    ?>
                                <tbody>
                                    <tr>
                                        <td><?php echo $mostrar['equipo'] ?></td>
                                        <td><?php echo $mostrar['gol1'] ?></td>
                                    </tr>
                                </tbody>
                                <?php
                                    }
                                    ?>
                            </table>
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                <table class="table table-primary table-striped caption-top trasladarY">
                            <caption>Cuartos C</caption>
                                <thead>
                                    <tr>
                                        <th scope="col">Equipo</th>
                                        <th scope="col">Goles</th>

                                    </tr>
                                </thead>    
                                <?php
                                
                                
                                //$sql = "SELECT DISTINCT E.nombre, P.P_jug, P.P_gan, P.P_emp, P.P_per, P.G_fav, P.G_con, P.Dif_G, P.puntaje FROM posiciones P, equipos E WHERE E.id_equipo = P.id_equipo ORDER BY P.puntaje DESC, P.Dif_G DESC, P.G_fav DESC";
                                $sql = "SELECT equipo, gol1 FROM equipoplata WHERE idZona=3 ORDER BY idZona ASC LIMIT 8;";


                                $result= mysqli_query($conexion,$sql);

                                while($mostrar=mysqli_fetch_array($result)){
                                    ?>
                                <tbody>
                                    <tr>
                                        <td><?php echo $mostrar['equipo'] ?></td>
                                        <td><?php echo $mostrar['gol1'] ?></td>
                                    </tr>
                                </tbody>
                                <?php
                                    }
                                    ?>
                            </table>
                </div>
                <div class="col-md-6">
                <table class="table table-primary table-striped caption-top trasladarY">
                            <caption>Cuartos D</caption>
                                <thead>
                                    <tr>
                                        <th scope="col">Equipo</th>
                                        <th scope="col">Goles</th>

                                    </tr>
                                </thead>    
                                <?php
                                
                                
                                //$sql = "SELECT DISTINCT E.nombre, P.P_jug, P.P_gan, P.P_emp, P.P_per, P.G_fav, P.G_con, P.Dif_G, P.puntaje FROM posiciones P, equipos E WHERE E.id_equipo = P.id_equipo ORDER BY P.puntaje DESC, P.Dif_G DESC, P.G_fav DESC";
                                $sql = "SELECT equipo, gol1 FROM equipoplata WHERE idZona=4 ORDER BY idZona ASC LIMIT 8;";


                                $result= mysqli_query($conexion,$sql);

                                while($mostrar=mysqli_fetch_array($result)){
                                    ?>
                                <tbody>
                                    <tr>
                                        <td><?php echo $mostrar['equipo'] ?></td>
                                        <td><?php echo $mostrar['gol1'] ?></td>
                                    </tr>
                                </tbody>
                                <?php
                                    }
                                    ?>
                            </table>
                </div>
            </div>
        </div>


        <div class="containerTorneo">
            <div class="row">
                <div class="col-md-4">
                <table class="table table-primary table-striped caption-top trasladarY">
                            <caption>Semi A</caption>
                                <thead>
                                    <tr>
                                        <th scope="col">Equipo</th>
                                        <th scope="col">Goles</th>

                                    </tr>
                                </thead>    
                                <?php
                                
                                
                                //$sql = "SELECT DISTINCT E.nombre, P.P_jug, P.P_gan, P.P_emp, P.P_per, P.G_fav, P.G_con, P.Dif_G, P.puntaje FROM posiciones P, equipos E WHERE E.id_equipo = P.id_equipo ORDER BY P.puntaje DESC, P.Dif_G DESC, P.G_fav DESC";
                                $sql = "SELECT equipo, gol2 FROM equipoplatasemi WHERE idZona=5 ORDER BY idZona ASC LIMIT 8;";


                                $result= mysqli_query($conexion,$sql);

                                while($mostrar=mysqli_fetch_array($result)){
                                    ?>
                                <tbody>
                                    <tr>
                                        <td><?php echo $mostrar['equipo'] ?></td>
                                        <td><?php echo $mostrar['gol2'] ?></td>
                                    </tr>
                                </tbody>
                                <?php
                                    }
                                    ?>
                            </table>
                </div>
                <div class="col-md-4">
                <table class="table table-primary table-striped caption-top trasladarY">
                            <caption>Semi B</caption>
                                <thead>
                                    <tr>
                                        <th scope="col">Equipo</th>
                                        <th scope="col">Goles</th>

                                    </tr>
                                </thead>    
                                <?php
                                
                                
                                //$sql = "SELECT DISTINCT E.nombre, P.P_jug, P.P_gan, P.P_emp, P.P_per, P.G_fav, P.G_con, P.Dif_G, P.puntaje FROM posiciones P, equipos E WHERE E.id_equipo = P.id_equipo ORDER BY P.puntaje DESC, P.Dif_G DESC, P.G_fav DESC";
                                $sql = "SELECT equipo, gol2 FROM equipoplatasemi WHERE idZona=6 ORDER BY idZona ASC LIMIT 8;";


                                $result= mysqli_query($conexion,$sql);

                                while($mostrar=mysqli_fetch_array($result)){
                                    ?>
                                <tbody>
                                    <tr>
                                        <td><?php echo $mostrar['equipo'] ?></td>
                                        <td><?php echo $mostrar['gol2'] ?></td>
                                    </tr>
                                </tbody>
                                <?php
                                    }
                                    ?>
                            </table>
                </div>

                <div class="col-md-4">
                <table class="table table-primary table-striped caption-top trasladarY">
                            <caption>Final</caption>
                                <thead>
                                    <tr>
                                        <th scope="col">Equipo</th>
                                        <th scope="col">Goles</th>

                                    </tr>
                                </thead>    
                                <?php
                                
                                
                                //$sql = "SELECT DISTINCT E.nombre, P.P_jug, P.P_gan, P.P_emp, P.P_per, P.G_fav, P.G_con, P.Dif_G, P.puntaje FROM posiciones P, equipos E WHERE E.id_equipo = P.id_equipo ORDER BY P.puntaje DESC, P.Dif_G DESC, P.G_fav DESC";
                                $sql = "SELECT equipo, gol3 FROM equipoplatasemi WHERE idZona=7 ORDER BY idZona ASC LIMIT 8;";


                                $result= mysqli_query($conexion,$sql);

                                while($mostrar=mysqli_fetch_array($result)){
                                    ?>
                                <tbody>
                                    <tr>
                                        <td><?php echo $mostrar['equipo'] ?></td>
                                        <td><?php echo $mostrar['gol3'] ?></td>
                                    </tr>
                                </tbody>
                                <?php
                                    }
                                    ?>
                            </table>
                </div>
            </div>
       
            </div>
        </div>

        <!-- Contenido posterior aquí -->

        <!-- Bootstrap JS (opcional) -->
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js" integrity="sha384-geWF76RCwLtnZ8qwWowPQNguL3RmwHVBC9FhGdlKrxdiJJigb/j/68SIy3Te4Bkz" crossorigin="anonymous"></script>
    </div>
                           
                            
                    </div>
            </div>





            

        </div>

    </div>
    
</div> 
</body>
</html>

