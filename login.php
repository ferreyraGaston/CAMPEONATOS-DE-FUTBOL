<?php require_once "php/parte_superior.php"?>
<br>

<main class="LoginMain">


<div class="contenedor__todo">
    <div class="caja_trasera">

        <div class="caja_trasera_login">
        <h3>¿Ya tienes una Cuenta?</h3>
        <p>Inicio sesión para ingresar a la página</p>
        <p>sino está registrado haga clic en el botón registrarse</p>
        <button id="btn_login">Iniciar Sesión</button>
        </div>

        <div class="caja_trasera_registro">
            <h3>¿Aún no tienes una Cuenta?</h3>
            <p>Regístrate para que puedas iniciar sesión</p>
            <button id="btn_registro">Registrarse</button>
        </div>

    </div>

    <div class="caja_delantera_loginRegistro">

        <form action="validarLogin.php" method="Post" class="formulario_login" onsubmit="return validarRegLogin()">
            <h2>Iniciar Sesión</h2>
            <input type="text" placeholder="Nombre de usuario" id="usuarioLogin" name="usuarioLogin">
            <input type="password" placeholder="Contraseña" id="pasLogin" name="pasLogin">
            
            <button type="submit">Entrar</button>
        </form>

        <form action="proceso.php" method="post" class="formulario_registro" onsubmit="return validarRegUsuario()" id="registroDeUsuario">
            <h2>Registrarse</h2>

            
            <input type="text" placeholder="Nombre" id="username" name="username" class="form-control">
            <input type="text" placeholder="Apellido" id="fullname" name="fullname" class="form-control">
            <input type="date" id="FechaNacim" name="FechaNacim" class="form-control">
            <input type="email" placeholder="Correo Electrónico" id="email" name="email" class="form-control">
            <input type="password" placeholder="Contraseña" id="passwordid" name="passwordid" class="form-control">
            <input type="text" placeholder="cuil" class="form-control" name="cuil" id="cuil">
            <input type="text" placeholder="Provincia" class="form-control" name="provincia" id="provincia">
            <input type="text" placeholder="País" class="form-control" name="pais" id="pais">
            <button id="btnResumen" type="submit">Registrarse</button>
        </form>
    
    </div>

</div>

<br><br><br>

</main>

<br>
<?php require_once "php/parte_inferior.php"?>