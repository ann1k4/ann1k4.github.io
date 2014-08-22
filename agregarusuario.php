<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Documento sin título</title>
<script src="SpryAssets/SpryValidationTextField.js" type="text/javascript"></script>
<link href="SpryAssets/SpryValidationTextField.css" rel="stylesheet" type="text/css" />
</head>

<body>
<form id="form1" name="form1" method ="post" action="agregarusuario1.php">
 <table width="200" border="1" align="center">
        <tr>
          <td>Usuario:</td>
          <td><label for="text"></label>
          <input type="text" name="Usuario" id="Usuario" placeholder="Digite su usuario" title="Ingrese su Usuario "required></td>
        </tr>
        <tr>
          <td>Password</td>
          <td><input type="Password" name="Password" id="Password" placeholder="Digite su contraseña" title="Ingrese su Contraseña "required></td>
          <tr>
          <td>Nombre:</td>
          <td><input type="text" name="Nombre" id="Password" placeholder="Digite su Nombre" title="Ingrese su Nombre "required></td>
        </tr>
        
        <tr>
          <td>Email:</td>
          <td><input type="Email" name="Email" id="Email" placeholder="Digite su Email" title="Ingrese su Email " required></td>
        </tr>
        
        <td>Identificaccion:</td>
          <td><input type="text" name="id" id="id" placeholder="Digite su Identificaccion"title="Ingrese su Identificacion" required></td>
        </tr>
        <tr>
          <td>&nbsp;</td>
          <td><input type="submit" name="button" id="button" value="Agregar">
          
          <input type="reset" name="button" id="button" value="Limpiar"></td></td>
          
        </tr>
      </table>
      </form>
      <p>
      <?php
	  include "config.php";
	  ?>
      </p>
</body>
</html>