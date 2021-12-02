<?php require_once "php/parte_superior.php"?>
<br>

<main>
<section >
    <div class="contenedor__todo "> 

        <form class="g-3">
            <div class="col-md-12">
              <label for="validationServer01" class="form-label">Nombre</label>
              <input type="text" class="form-control is-valid" id="validationServer01" value="Mark" required>
              <div class="valid-feedback">
                Looks good!
              </div>
            </div>
            <div class="col-md-12">
              <label for="validationServer02" class="form-label">Apellido</label>
              <input type="text" class="form-control is-valid" id="validationServer02" value="Otto" required>
              <div class="valid-feedback">
                Looks good!
              </div>
            </div>
            
            <div class="col-md-12">
                <label for="validationTextarea" class="text-danger">email</label>
                <input name="email" type="email" class="form-control" id="email" placeholder="Email" aria-label="Email" required>
                <div class="valid-feedback">Valid.</div>
                <div class="invalid-feedback">Por favor rellene este campo.</div>
            </div>

            <div class="mb-3">
                <label for="validationTextarea" class="form-label">Textarea</label>
                <textarea class="form-control is-invalid" id="validationTextarea" placeholder="Required example textarea" required></textarea>
                <div class="invalid-feedback">
                  Please enter a message in the textarea.
                </div>
              </div>
            


            <div class="col-12">
              <button class="btn btn-primary" type="submit">Submit form</button>
            </div>
          </form>
    </div> 
</section>

</main>
<?php require_once "php/parte_inferior.php"?>