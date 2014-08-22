<?php 
	if($_POST["user"]=="prueba" && $_POST["password"]=="123456"){
	//incio la sessión
	session_start();
	//declaro las variables de sesión
	$_SESSION["autentificado"] = true;
	$_SESSION["usuario"] = $_POST["usuario"];
	header("Location:agregarusuario.php");
	}else{
	header("Location:inicio.php");
		}
?>