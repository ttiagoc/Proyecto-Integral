// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function CambiarFoto(){

    $.ajax({
      url: '/Home/PeliculaRandom',   
      type:'POST',    
      dataType:'JSON',            
        success:
          function (resp){                      
              $('#Descubrir').hide();
              $('#mostrar').html('');
              
              $('#mostrar').append('<img src="' + resp.foto +'" height="500px" width="auto" class="pt-3"></img>'); 
               },
         error:
          function(){
          console.log('error');
         }
    });

}


function FiltrarGeneros(){

    $.ajax({
      url: '/Home/PelisGenero',   
      type:'POST',    
      dataType:'JSON', 
      data: $('#formGeneros').serialize(),           
        success:
          function (resp){                      
              $('#Todas').hide();
              $('#Filtrada').html('');
              console.log(resp);

              resp.forEach(val => {
              $('#Filtrada').append('<img src="' + val.foto +'"></img>'); 
              $('#Filtrada').append('<h1>HOLAA</h1>'); 
             
            });
        },
         error:
          function(){
          console.log('error');
         }
    });

}



// Get the modal
var modal = document.getElementById("myModal");

// Get the button that opens the modal
var btn = document.getElementById("myBtn");

// Get the <span> element that closes the modal
var span = document.getElementsByClassName("close")[0];

// When the user clicks on the button, open the modal
btn.onclick = function() {
  modal.style.display = "block";
}

// When the user clicks on <span> (x), close the modal
span.onclick = function() {
  modal.style.display = "none";
}

// When the user clicks anywhere outside of the modal, close it
window.onclick = function(event) {
  if (event.target == modal) {
    modal.style.display = "none";
  }
}