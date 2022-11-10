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
              var variable = "/Home/VerInfoPeliculas?IdPelicula=" + resp.idPelicula;
              $('#mostrar').append('<a href=' + variable + ' ><img src="' + resp.foto +'" height="500px" width="auto" class="pt-3"></img></a>'); 
               },
         error:
          function(){
          console.log('error');
         }
    });

}


function FiltrarGeneros(){

      const opciones = document.querySelectorAll('.opcion');
      var a;
      opciones.forEach((e)=>{
        if (e.selected) {
           a = e.value;
          
        }
      });


    $.ajax({
      url: '/Home/PelisGenero',   
      type:'POST',    
      dataType:'JSON', 
      data:  {num:a},           
        success:
          function (resp){  
            
                     
              $('#Todas').hide();
              $('#Filtrada').html('');
              console.log(resp);

              resp.forEach(val => {
                
                var varr = "/Home/VerInfoPeliculas?IdPelicula=" + val.idPelicula;
              $('#Filtrada').append('<div class="col pt-5"><div class="card redondeado m-auto sombra mb-4" style="width: 18rem;"><a href =' + varr + '><img id="Todas" class="card-img-top transparencia" src="' + val.foto +' " height="350px" width="auto"></img></a><div class="card-body"><a id="Todas" class="sd h4 nomCards" href =' + varr + '      > ' + val.nombre  + ' </a></div></div></div>');
              

             
             
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



var btn2 = document.getElementById("myBtn2");
var modal2 = document.getElementById("myModal2");
var span2 = document.getElementsByClassName("close2")[0];

btn2.onclick = function() {
  modal2.style.display = "block";
}

// When the user clicks on <span> (x), close the modal
span2.onclick = function() {
  modal2.style.display = "none";
}

// When the user clicks anywhere outside of the modal, close it
window.onclick = function(event) {
  if (event.target == modal2) {
    modal2.style.display = "none";
  }
}







