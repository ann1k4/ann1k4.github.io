<?php 
session_start(); 
include('config.php');

// Actualizamos en funcion del id que recibimos 
$idusuario = $_POST['id']; 
$query = "delete from usuarios where id = '$idusuario'";

$result = mysql_query($query);  
echo " 
<p>El registro ha sido eliminado con exito.</p> 
"; 
?> 

