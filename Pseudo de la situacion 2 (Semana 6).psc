Algoritmo sin_titulo
	
	
	Escribir "ingrese la cantidad de respuestas correctas"
	Leer linea
	linea = num1
	
	Si (num1 >= 8) entonces 
		nota = num1 + 20/100
		escribir "Su calificacion califica como aprobatoria"
		escribir "Calificacion" nota
		finsi
		Si (num1 ==7)
			nota = num1
			escribir "Su calificacion califica como aprobatoria"
			escribir "Calificacion" nota
		FinSi
		Si (num1 <= 6) Entonces
			Escribir "Su nota no califica como aprobatoria"
			Escribir "Calificacion" nota
		FinSi
FinAlgoritmo
