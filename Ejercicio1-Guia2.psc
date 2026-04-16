//pide dos números y una opción:
//1 ? Sumar, 2 ? Restar, 3 ? Multiplicaciór, 4 ? Dividir - Muestra el resultado según la opción elegida.
Algoritmo Ejercicio1
	Definir num1, num2, opc Como Real
	Definir msj Como Caracter
	Escribir Sin Saltar "Digite dos valores numéricos: "
	leer num1
	leer num2
	
	//Menú de las operaciones
	Escribir "***************"
	Escribir "Menú Principal"
	Escribir "1 - suma"
	Escribir "2 - resta"
	Escribir "3 - Multiplicación"
	Escribir "4 - División"
	Escribir "5 - Salir"
	Escribir Sin Saltar "Digite el número según su Operacióm: "
	leer opc
	//evaluar la Opción
	Segun opc Hacer
		1:
			msj="El resultado de la suma es: "
			result=num1+num2
		2:
			msj="El resultado de la resta es: "
			result=num1-num2
		3:
			msj="El resultado de la Multiplicación es: "
			result=num1*num2
		4:
			msj="El resultado de la División es: "
			result=num1/num2
		5:
			msj="Saliendo del sistema"
		De Otro Modo:
			msj="Seleccione una opción correcta!!!"
	Fin Segun
	Escribir msj
	Escribir result
FinAlgoritmo
