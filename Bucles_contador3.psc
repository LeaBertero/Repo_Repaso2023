Proceso Bucles
	
	definir num Como Entero;
	
	num <- 0;
	
	si num = 0 Entonces
		Repetir
			escribir "Ingrese numero";
			leer num; 
		Hasta Que num > 0;
	FinSi
	
	Mientras num  > 0 Hacer
		num <- num + 1;
		escribir "incremento" , " " , num;
		
	FinMientras
	
	
FinProceso
