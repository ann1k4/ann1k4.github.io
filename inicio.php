<!doctype html>
<html>
    <head>
        <meta charset="utf-8">
        <title>Inicio</title>
        <link rel="stylesheet" href="Hojas de Estilo/styles.css"/>
        <style type="text/css">
        body {
	background-image: url(Imagenes/blue.jpg);
}
        </style>
    </head>
    <body>	
    	<div id="menu">
            <ul>
            	<li class="activo"><a href="inicio.php">Inicio</a></li>
                <li><a href="consultas.php">Consultas</a></li>
                <li><a href="estudiantes.php">Estudiantes</a></li>
                <li><a href="ingreso.php">Ingreso</a></li>
                <li><a href="prestamos.php">Prestamos</a></li>
                <div id="ingreso-u">
           	    	<img src="Imagenes/Sesion/usuario.png" width="40" height="40" alt=""/>
					<?php 
                        include("sesion.php");
                    ?>
                	<div id="bienvenido">
						<?php 
                    		echo "Bienvenido ".$_SESSION["usuario"];
                    	?>
                        <a href="salir.php">salir</a>
                	</div>
                </div>
          	</ul>
		</div>
	</body>
</html>