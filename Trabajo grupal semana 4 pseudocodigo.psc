Proceso CompraConDescuento
	
    Definir c_producto1, c_producto2 Como Real
    Definir descuento, subtotal, total Como Real
    Definir producto1, producto2 Como Real
    Definir linea Como Cadena
	
    producto1 <- 2.20
    producto2 <- 10
    descuento <- 15
	
    Escribir "Registre cantidad de producto 1:"
    Leer linea
    c_producto1 <- ConvertirANumero(linea)
	
    Escribir "Registre cantidad de producto 2:"
    Leer linea
    c_producto2 <- ConvertirANumero(linea)
	
    subtotal <- (producto1 * c_producto1) + (producto2 * c_producto2)
	
    Si subtotal >= 100 Entonces
        total <- subtotal - (subtotal * descuento / 100)
        Escribir "El total a pagar es: ", total
    Sino
        total <- subtotal
        Escribir "El total a pagar es: ", total
    FinSi
	
    Escribir "¿Desea continuar con su compra? (s/n):"
    Leer linea
	
    Si linea = "s" Entonces
        Escribir "Gracias por su compra"
    Sino
        Escribir "Compra cancelada"
    FinSi
	
FinProceso