Proceso bucleContador
	
	definir contador como entero; //variable definida como un entero
	
	//contador <- 0;
	
	Para contador<-0 Hasta 5 Con Paso 1 Hacer //estructura inicial de for
		Repetir //inicio de estructura de repetir
			
			contador <- contador +1; //incremento de valores
			escribir " Contando... ", " ", contador; //muestra en pantalla contador
			Esperar Tecla; //espera a que el usuario presione una tecla para continuar incrementando
			
		Hasta Que contador = 5; //fin de estructura de repetición
	FinPara //fon de estructura de for
	
	Limpiar Pantalla;
	escribir ""; // renglón en blanco
	escribir "Finalizada la fase contador.."; // mensaje en pantalla que indica al usuario el final del programa
	
FinProceso
