Proceso sin_titulo
	
	definir imagen Como Caracter;
	//definir s, n  Como Caracter;
	definir desicion Como Caracter;
	
	desicion <- "s";
	desicion <- "n";
	imagen <- "PerritosJugando.jpeg";
	
	escribir "Desea mostrar la imagen? - Seleccione (S), para, si y (N), Para, no";
	leer desicion;
	
	si desicion = "s" Entonces
		
		escribir "La imagen a mostrar es:", " ", imagen;
		Esperar Tecla;
		
	SiNo
		
		si  desicion = "n" Entonces
			Limpiar Pantalla;
			
		FinSi
		
		Escribir "La imagen no se puede visualizar";
		
	FinSi
	
	
	escribir "Programa finalizado, presione una tecla";
	Esperar Tecla;
	
	escribir"";
	
	
	Esperar Tecla;
	
FinProceso
