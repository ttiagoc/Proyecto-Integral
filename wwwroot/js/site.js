// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$.ajax({
    url: '/Home/Filtros',
    data: $('#boton').serialize(),
    type:'POST',    
    dataType:'JSON',            
    success:
        function (respC){                      
           console.log('mee');
        },
    error:
        function(){
            console.log('error');
        }
    });