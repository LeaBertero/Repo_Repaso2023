Proceso sin_titulo
	
	//variables para realizar la operacion
	definir num1, num2, total Como Entero;
	definir salir Como Caracter; //variable para salir
	
	definir signo como caracter;
	
	//variables definidas para el mensaje de bienvenida de la operacion que se va a realizar segun lo requiera el usuario
	definir signoSuma, signoResta, signoMult, signoDiv Como Caracter;
	definir mensajeSuma como caracter;
	//definir menuPrincipal Como Caracter;
	
	//variables inicializadas
	mensajeSuma <- "Para sumar";
	
	
	//variable para salir del programa segun el usuario lo requiera
	salir <- "salir";
	
	//operadores de los dos numeros que se van a sumar inicializados en cero
	num1 <- 0;
	num2 <- 0;
	
	total <- num1 + num2;
	
	escribir "Programa calculadora de operaciones de numeros enteros, presione una tecla para iniciar";
	Esperar Tecla;
	
	Limpiar Pantalla;
	
	Repetir
		
		escribir "/////// SUMA ///////";
		
		Escribir "";
		
		escribir "Ingrese el primer numero", " ", mensajeSuma;
		leer num1;
		
		escribir "Ingrese el segundo numero";
		leer num2;
		
		escribir "Ingrese el signo de operador para realizar la operacion";
		leer signoSuma;
		
		si signoSuma = "" Entonces
			
			Repetir
				escribir "No se ha ingresado ningun signo, ingrese un signo por favor";
				leer signoSuma;
			Hasta Que signoSuma = "+";
			
		FinSi
		
		total <- num1 + num2;
		
		escribir "Su total es de:", " " , total;
		Esperar Tecla;
		
		Limpiar Pantalla;
		
		
		
		
		escribir "Desea salir del progrma? - Ingrese (s)";
		leer salir;
		
	Hasta Que  salir = "s";
	
	Limpiar Pantalla;
	
	escribir "Gracias por utilizar nuestros productos, lo esperamos nuevamente";
	
	
FinProceso
