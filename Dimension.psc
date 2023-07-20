Proceso sin_titulo
	Definir nombre como caracter;
	Dimension nombre[3];
	
	escribir "Sistema de carga de nombres";
	escribir "En este sistema solo podrá cargar 3 nombres... presione una tecla para iniciar...";
	Esperar Tecla;
	
	Limpiar Pantalla;
	
	Repetir
		escribir "Ingrese primer nombre";
		leer nombre[0];
		escribir "";
		escribir "Ingrese segundo nombre";
		leer nombre[1];
		escribir "";
		escribir "Ingrese tercer nombre";
		leer nombre[2];
		si nombre[] = nombre[] Entonces
			escribir "Carga finalizada";
			Esperar Tecla;
		FinSi
	Hasta Que nombre[2] = nombre[2];
	
	escribir "Presione une tecla para ver los nombres cargados";
	Esperar Tecla;
	
	Limpiar Pantalla;
	
	escribir "Los nombres cargados son:";
	escribir "";
	
	escribir "Primer nombre", nombre[0];
	escribir "Segundo nombre", nombre[1];
	escribir "Tercer nombre", nombre[2];
	
	escribir "";
	
	Escribir "Carga correcta, para salir presione (ENTER)";
	Esperar Tecla;
FinProceso
