Proceso sin_titulo
	
	definir num como entero;
	definir s Como Caracter;
	
	num <- 1;
	s <- "s";
	
	Repetir
		si num = 0 Entonces
			
			Repetir
				num <- num + 1;
				
				escribir "Incrementando", " ", num;
				
				Esperar 2 Segundos;;
				
			Hasta Que  num = 10;
			
		SiNo
			
			escribir "Presione una tecla para salir";
			
			Esperar Tecla;
			
			
		FinSi
	Hasta Que s = "s";
	
	Escribir  "Fin del programa";
	
FinProceso
