//funcion que valida los datos ingresados en el formulario

function validarRegUsuario() {
    var nombre, apellido,email, pass, fNacim, cuil;
  
    //arrastro los valores del formulario
    nombre = document.getElementById('username').value;
    apellido = document.getElementById('fullname').value;
    email = document.getElementById('email').value;
    pass = document.getElementById('passwordid').value;
    fNacim = document.getElementById('FechaNacim').value;
    cuil = document.getElementById('cuil').value;
    prov = document.getElementById('provincia').value;
    pais = document.getElementById('pais').value;
  
  
    //verifico que todos los campos contengan datos, si no muestro un alert:
    if (nombre === '') {
      alert('El campo nombre deben estar completo');
      return false;
    }

    else if (nombre.length<= 2) {
      alert('El campo nombre debe tener mas de dos caracteres');
      return false;
    }

    if (apellido === '' ) {
      alert('El campo apellido deben estar completo');
      return false;
    }
    else if (apellido.length<= 2) {
      alert('El campo apellido debe tener mas de dos caracteres');
      return false;
    }

    if (fNacim === '') {
      alert('El campo fecha deben estar completo');
      return false;
    }

      //verifico si es mayor de 18 años
      if (calcularEdad(fNacim) < 18) {
        alert(
          'Revise la fecha de nacimiento. El empleado debe ser mayor de 18 a\u00f1os'
        );
        return false;     
      } 

      if (email === '') {
        alert('El campo email deben estar completo');
        return false;
      }

    //valido que el email sea valido:
    if (
      !/^(([^<>()[\]\.,;:\s@\"]+(\.[^<>()[\]\.,;:\s@\"]+)*)|(\".+\"))@(([^<>()[\]\.,;:\s@\"]+\.)+[^<>()[\]\.,;:\s@\"]{2,})$/i.test(
        email
      )
    ) {
      alert('Debes ingresar un email válido.');
      return false;
    }

    if (pass=== '') {
      alert('El campo contraseña deben estar completo');
      return false;
    }

    if (pass=== '') {
      alert('El campo contraseña deben estar completo');
      return false;
    }

    if (cuil=== '') {
      alert('El campo cuil deben estar completo');
      return false;
    }
   
  

    if (prov=== '') {
      alert('El campo provincia deben estar completo');
      return false;
    }

    if (pais=== '') {
      alert('El campo pais deben estar completo');
      return false;
    }

   
     alert('registro completado exitosamente');
   

    
    }
  
  //permite calcular la edad para verificar si la persona es mayor de 18 años
  function calcularEdad(fechaNac) {

    let hoy = new Date();
    let fechaNacimiento = new Date(fechaNac);
  //El getFullYear()método devuelve el año de una fecha como un número de cuatro dígitos:
  //El getMonth()método devuelve el mes de una fecha como un número (0-11):
  //El getDate()método devuelve el día de una fecha como un número (1-31):
    let edad = hoy.getFullYear() - fechaNacimiento.getFullYear();
    let diferenciaMeses = hoy.getMonth() - fechaNacimiento.getMonth();
    if (
      diferenciaMeses < 0 || (diferenciaMeses === 0 && hoy.getDate() < fechaNacimiento.getDate())
    ) {
      edad--;
    }
    alert("Edad "+edad+" años")
    return edad;
  }

 

document.getElementById("btn_login").addEventListener("click",iniSesion);
document.getElementById("btn_registro").addEventListener("click",iniRegistro);

// se ejecuta cuando la pagina este haciendo resize
window.addEventListener("resize",anchoPagina);

// hacer resize automaticamente sin ejecutarla
//anchoPagina();

//Declaracion de Variables
var contenedor_loginRegistro=document.querySelector(".caja_delantera_loginRegistro");
var formulario_login=document.querySelector(".formulario_login");
var formulario_registro=document.querySelector(".formulario_registro");

var cajaTrasera_login=document.querySelector(".caja_trasera_login");
var cajaTrasera_registro=document.querySelector(".caja_trasera_registro");

  function iniRegistro(){
    if(window.innerWidth>767)//si el ancho de la pantalla es mayor a767px
    {
      formulario_registro.style.display="block"; //registro
      formulario_login.style.display="none";
      contenedor_loginRegistro.style.left="410px";
      //aparece y desaparece la caja del texto
      cajaTrasera_registro.style.opacity="0";
      cajaTrasera_login.style.opacity="1";
    }else{
      formulario_registro.style.display="block";
      contenedor_loginRegistro.style.left="0px";
      formulario_login.style.display="none"; 
      //aparece y desaparece la caja del texto
      cajaTrasera_registro.style.display="none";  //registro
      cajaTrasera_login.style.display="block";
      cajaTrasera_login.style.opacity="1";
    }
  }
  function iniSesion(){
    if(window.innerWidth>767)
    {
    formulario_registro.style.display="none";   
    formulario_login.style.display="block";
    contenedor_loginRegistro.style.left="10px";
    //aparece y desaparece la caja del texto
    cajaTrasera_registro.style.opacity="1";
    cajaTrasera_login.style.opacity="0";
    }else{
    formulario_registro.style.display="none";
    contenedor_loginRegistro.style.left="0px";
    formulario_login.style.display="block";
    //aparece y desaparece la caja del texto
    cajaTrasera_registro.style.display="block";
    cajaTrasera_login.style.display="none";
    }
  }

  function anchoPagina(){
    if(window.innerWidth>767)
    {
    cajaTrasera_login.style.display="block";
    cajaTrasera_registro.style.display="block";
    }else{
    cajaTrasera_registro.style.display="block"; 
    cajaTrasera_registro.style.opacity="1"; 
    cajaTrasera_login.style.display="none";
    formulario_login.style.display="block";
    formulario_registro.style.display="none";
    contenedor_loginRegistro.style.left="0px";
    }

  }

  anchoPagina() // ejecuto la funcion despues de crearla

  function validarRegLogin() {
    var nombre, apellido,email, pass, telef, direcc, fNacim;
  
    //traigo valores del formulario
    EmailLogin = document.getElementById('usuarioLogin').value;
    PassLogin = document.getElementById('pasLogin').value;

     if (EmailLogin === '') {
        alert('El campo email deben estar completo');
        return false;
      }
      
    if (PassLogin=== '') {
      alert('El campo contraseña deben estar completo');
      return false;
    }

     alert('registro completado exitosamente');
    }

    function validarContacto() {
      var nombre, apellido,email, pass, telef, direcc, fNacim;
    
      //traigo valores del formulario
      ValNom = document.getElementById('validationServer01').value;
      ValApe = document.getElementById('validationServer02').value;
      ValEma = document.getElementById('validationEmail').value;
      ValText = document.getElementById('validationTextarea').value;
  
     //verifico que todos los campos contengan datos, si no muestro un alert:
    if (ValNom.length<= 2) {
      alert('El campo nombre debe tener mas de dos caracteres');
      return false;
    }

    if (ValApe.length<= 2) {
      alert('El campo apellido debe tener mas de dos caracteres');
      return false;
    }

    if (
      !/^(([^<>()[\]\.,;:\s@\"]+(\.[^<>()[\]\.,;:\s@\"]+)*)|(\".+\"))@(([^<>()[\]\.,;:\s@\"]+\.)+[^<>()[\]\.,;:\s@\"]{2,})$/i.test(
        ValEma
      )
    ) {
      alert('Debes ingresar un email válido.');
      return false;
    }

    if (ValText.length<= 10) {
      alert('El campo Texto debe tener mas de diez caracteres');
      return false;
    }
  
       alert('registro completado exitosamente');
      }

    function redireccion() {
      var tiempo = 2000;
    
      setTimeout(function () {
        window.location = 'index.php';
      }, tiempo);
    }

   