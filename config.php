<?php
//configuracion de la base de datos.
$dbhost ="localhost"; //servidor
$dbuser ="Ana";//usuario
$dbpass ="123";//password
$dbname ="prueba";//base de datos

// Creadon conexion

$link = mysql_connect($dbhost,$dbuser,$dbpass);// conectamos la base de datos
mysql_select_db($dbname,$link); // seleccionamos la base de datos 
?>