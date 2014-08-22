<?php
session_start(); 
include('config.php');

 ?>
<html>
<head>
<title>Video Club</title>
</head>
<body bgcolor=#FFFFFF background="agenda/Imagenes/back.gif" bgproperties="fixed">
<table width="99%" border="0">
  <tr> 
    <td><table width="600" border="0" align="center" id="table1" style="font-family: Verdana; font-size: 8pt">
      <tr>
        <td colspan="2"><h3 align="center">Eliminaci&oacute;n de datos</h3></td>
      </tr>
      <form method="POST" action="borrarusuario.php">
        <tr>
          <td width="50%">&nbsp;</td>
          <td width="50%">&nbsp;</td>
        </tr>
        <tr>
          <td width="50%"><p align="center"><b>ID del registro a eliminar: </b></td>
          <td width="50%"><p align="center">
            <input name="id" type="text" id="id" size="20">
          </td>
        </tr>
        <tr>
          <td width="50%">&nbsp;</td>
          <td width="50%">&nbsp;</td>
        </tr>
        <tr>
          <td width="100%" colspan="2"><p align="center">
              <input type="submit" value="Eliminar" name="B1">
          </td>
        </tr>
      </form>
    </table></td>
  </tr>
</table>
</body>

        
