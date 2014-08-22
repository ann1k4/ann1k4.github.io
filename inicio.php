<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Documento sin título</title>

</head>

<body>

<style>
form{
	margin:0 auto;
	text-align:center;
	width:400px
}
span{
	color:#F00;
	font-size:2em;
	
	
	}
</style>

<form action="control.php" method="post" name="autentification_frm" enctype="application/x-www-from-urlencoded">

	<?php 
	error_reporting(E_ALL ^ E_NOTICE); /* solamente mensajes de errores */
	if ($_GET["error"]==""){ /* poner en el navergador ?error=no */
		echo"<span> Ingresa tus Datos</span>";
	}else{
		echo"Verifica tus Datos ";
		}


?>
	<table border="0..">
          <tr>
              <td>&nbsp;</td>
              <td>&nbsp;</td>
              <td>&nbsp;</td>
              <td>&nbsp;</td>
            </tr>
            <tr>
              <td>Username</td>
              <td><input name="user" type="text" placeholder="Escribe tu Usuario" title="Ingrese su Usuario" required /></td>
              <td>&nbsp;</td>
              <td>&nbsp;</td>
            </tr>
            <tr>
              <td><label>Password</label></td>
              <td><input name="password" type="password" placeholder="Escribe tu Contraseña" title="Ingrese su contraseña" required /></td>
              <td>&nbsp;</td>
              <td>&nbsp;</td>
            </tr>
            <tr>
              <td>&nbsp;</td>
              <td><input name="login" type="submit" value="Login In" /></td>
              <td>&nbsp;</td>
              <td>&nbsp;</td>
            </tr>
  </table>
</form>
</body>
</html>
