<?php require_once "php/parte_superior.php"?>
<br>

<main>
<section >
    <div class="contenedor__todo "> 


        <form action="/action_page.php" class="was-validated" onsubmit="return validarContacto()">
            <div class="mb-3 mt-3">
              <label for="uname" class="form-label">Nombre:</label>
              <input type="text" class="form-control" id="validationServer01" placeholder="Ingrese su Nombre" name="validationServer01" required>
              <div class="valid-feedback">Valid.</div>
              <div class="invalid-feedback">Por favor rellene este campo.</div>
            </div>
            <div class="mb-3">
                <label for="validationServer02" class="form-label">Apellido:</label>
              <input type="text" class="form-control" id="validationServer02" placeholder="Ingrese su Apellido" name="validationServer02" required>
              <div class="valid-feedback">Valid.</div>
              <div class="invalid-feedback">Por favor rellene este campo.</div>
            </div>

            <div class="mb-3">
                <label for="pwd" class="form-label">Email:</label>
                <input type="email" class="form-control" id="validationEmail" placeholder="Infrese su email" name="validationEmail" required>
                <div class="valid-feedback">Valid.</div>
                <div class="invalid-feedback">Por favor rellene este campo.</div>
              </div>

            <div class="mb-3">
            <label for="pwd" class="form-label">Mensaje:</label>
            <textarea class="form-control" id="validationTextarea" placeholder="Deje aquí su mensaje" required></textarea>
            <div class="valid-feedback">Valid.</div>
            <div class="invalid-feedback">Por favor rellene este campo.</div>
            </div>
 
            <button type="submit" class="btn btn-primary">Enviar</button>
          </form> 


    </div> 
</section>

</main>
<?php require_once "php/parte_inferior.php"?>