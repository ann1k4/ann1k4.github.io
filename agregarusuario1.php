<meta http-equiv="refresh" content="3;URL=file:agregarusuario.php" />
<?php
//conectar a la base de datos

include "config.php";
//include "file:///G|/head.php";

//paso de variables

 $Nombre1 = $_POST['Nombre'];
 $Usuario1 = $_POST['Usuario'];
 $Password1 = md5($_POST['Password']);
 $Email1 = $_POST['Email'];
 $Id1 = $_POST['id'];
 
 //inserta datos
 if($Nombre1!='' && $Usuario1 !='' && $Password1!=''){ 
 mysql_query("INSERT INTO usuarios (Nombre, Usuario, Password, Email, id)values('$Nombre1', '$Usuario1', '$Password1', '$Email1', '$Id1')");
echo
 "<script type='text/javascript'>alert('submitted successfully!')

 </script>";
 //header("location:agregarusuario.php"); 

 }else{
	echo "<script type='text/javascript'>alert('submitted successfully!')</script>";

	 };
	 
	
?>
