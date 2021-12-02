<?php require_once "php/parte_superior.php"?>
<br>

<main class="LoginMain">


<div class="contenedor__todo">
    <div class="caja_trasera">

        <div class="caja_trasera_login">
        <h3>¿Ya tienes una Cuenta?</h3>
        <p>Inicio sesión para entrar a la pagina</p>
        <p>Sino estas registrado haga clic en el botón registrarse</p>
        <button id="btn_login">Iniciar Sesión</button>
        </div>

        <div class="caja_trasera_registro">
            <h3>¿Aún no tienes una Cuenta?</h3>
            <p>Regístrate para que puedas iniciar sesión</p>
            <button id="btn_registro">Registrarse</button>
        </div>

    </div>

    <div class="caja_delantera_loginRegistro">

        <form action="" class="formulario_login">
            <h2>Iniciar Sesión</h2>
            <input type="text" placeholder="Correo Electronico">
            <input type="password" placeholder="Contraseña">
            
            <button>Entrar</button>
        </form>

        <form action="proceso.php" method="post" class="formulario_registro" onsubmit="return validarRegUsuario()" id="registroDeUsuario">
            <h2>Registrarse</h2>

            <input type="text" placeholder="Nombre" id="username" class="form-control">
            <input type="text" placeholder="Apellido" id="fullname" class="form-control">
            <input type="date" id="FechaNacim" class="form-control">
            <input type="email" placeholder="Correo Electronico" id="email" class="form-control">
            <input type="password" placeholder="Contraseña" id="passwordid" class="form-control">
            <input type="text" placeholder="Provincia" class="form-control">
            <input type="text" placeholder="Pais" class="form-control">
            <button id="btnResumen" type="submit">Registrarse</button>
        </form>
    
    </div>

</div>

<br><br><br>

</main>

<br>
<?php require_once "php/parte_inferior.php"?>