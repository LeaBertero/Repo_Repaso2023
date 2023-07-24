Proceso sin_titulo
	
	definir producto Como Caracter;
	definir precio Como Real;
	
	Dimension producto[2,2];
	Dimension precio[2,2];
	
	escribir "Ingrese producto";
	leer producto[0,0];
	
	Limpiar Pantalla;
	
	escribir "Ingrese precio";
	leer precio[0,0];
	
	escribir "Presione una tecla";
	Esperar Tecla;
	
	escribir "Ingrese producto";
	leer producto[1,1];
	
	Limpiar Pantalla;
	
	escribir "Ingrese precio";
	leer precio[1,1];
	
	escribir "Presione una tecla para ver los productos con sus precios";
	Esperar Tecla;
	
	escribir "";
	
	Escribir "Producto:", " ", producto[0,0];
	escribir "$", " ", precio[0,0];
	Escribir "Producto:" , producto[1,1]; 
	escribir "$", precio[1,1];
	
	
	
	
	
FinProceso
