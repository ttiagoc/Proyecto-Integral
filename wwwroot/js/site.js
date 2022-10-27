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
              val.forEach(resp => {
              $('#Filtrada').append('<img src="' + resp.foto +'"></img>'); 
             
            });
        },
         error:
          function(){
          console.log('error');
         }
    });

}

