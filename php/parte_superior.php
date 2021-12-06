<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>La Minerita</title>
    <meta name="author" content="Ferreyra Gaston">
    <meta name="description" content="La Minerita es una antigua fábrica de cal, hoy funciona como 
                                        lugar de encuentro de amigos para compartir música, danza, 
                                        comidas y todo tipo de actividades relacionadas al arte y 
                                        la cultura">
    <meta name="keywords" content="peñas,festival,folklore,tango,unquillo,La minerita">
    <script src="https://kit.fontawesome.com/438f346520.js" crossorigin="anonymous"></script>
    <!--<link rel="stylesheet" href="./css/style/normalize.css">
    <link rel="stylesheet" href="./css/style/bootstrap.css">--> 
    <link rel="stylesheet" href="./css/style/bootstrap.min.css">
    <link rel="stylesheet" href="./css/style/style.css">
    <link rel="preconnect" href="https://fonts.googleapis.com">
<link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
<link href="https://fonts.googleapis.com/css2?family=Abril+Fatface&family=Roboto:ital,wght@0,100;0,300;0,400;0,500;1,100;1,300;1,400;1,500&display=swap" rel="stylesheet"> 
    <link rel="shorcut icon" href="./imagenes/img/imagenes/assets/logo.png">
</head>
<body>
<!--********************* Inicio Header************************--> 
<header>
<!--navbar: indica que es un elemento de navegación-->     
<!--navbar-expand-md: indica que a partir de que tamaño de pantalla se vea entera-->  
<!--navbar-light: le damos un stilo luminoso-->  
<!--bg-light: fondo claro -->  
<!--border-3: borde medio-->  
<!--border-bottom: border medio solo en la parte de abajo-->  
<!--border-primary: colo azul-->    
<nav class="navbar navbar-expand-md navbar-light bg-light bg-opacity-50 border-3 border-bottom border-secondary">
<div class="container-fluid">
    <!--navbar-brand: identifica que es la marca o el logo de la empresa-->  
    <a href="index.php" class="navbar-brand"> <img class="logo" src="./imagenes/img/imagenes/assets/logo.png" width="130" height="80" alt="logo sin imagen"> </a> 
     <!--navbar-toggler: alterna el boton entre visible e invisible-->  
     <!--data-bs-toggle="collapse": le damos funcionalidad que abrir y que cerrar-->
      <!--data-bs-target="": le indicamos sobre que elemento debe mostrar solo hay que ingresar el identificador unico-->
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#MenuNavegacion"> 
        <!--nnavbar-toggler-icon: boton tipo hamburguesa-->  
        <span class="navbar-toggler-icon"></span>
    </button>
    <!--collapse: para que no se vea el elemento cuando esta colapsado-->  
    <!--navbar-collapse: ple indica a bootstrap que es un elemento de navegacion y que se puede mostrar y ocultar-->  
    <div id="MenuNavegacion" class="collapse navbar-collapse">

        <!--navbar-nav: indica que es un elemento de navegacion  -->
        <!--ms-3: aliniacion derecha  -->
        <ul class="navbar-nav me-auto">
            <li class="nav-item"><a class="nav-link" href="contacto.php"><h6 class="text-dark" id="evento1">Contacto</h6></a></li> 
            <li class="nav-item"><a class="nav-link" href="login.php"><h6 class="text-dark" id="evento1">Login</h6></a></li>
            <!--nav-item: toma un aspecto determinado-->  
            <!--nav-link: eliminamos el color azul del link-->  
            <li class="nav-item dropdown">
                <!--dropdown-toggle: permite desplegar el resto de los elementos-->  
                <a class="nav-link dropdown-toggle" href="#" role="button" data-bs-toggle="dropdown" aria-expanded="false"><h6 class="text-dark" id="evento1">Novedades</h6></a>
                <ul class="dropdown-menu">
                    <li><a class="dropdown-item" href="#">Eventos</a></li> 
                    <li><a class="dropdown-item" href="#">Eventos</a></li> 
                    <li><a class="dropdown-item" href="#">Eventos</a></li> 
                </ul>
            </li>
        </ul>
    </div>
</div>
</nav>
</header>
<!--********************* fin Header ************************-->