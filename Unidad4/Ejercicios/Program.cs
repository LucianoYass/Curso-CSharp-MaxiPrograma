namespace Ejercicios;
class Program
{
    static void Main(string[] args)
    {
        //1. Hacer un programa que solicite el ingreso de dos números y luego calcular:
        //La resta si el primero es mayor que el segundo.
        //La suma si son iguales.
        //El producto si el primero es menor.
        //Se deberá emitir un cartel por pantalla con el resultado correspondiente.

        //int a, b, resultado;

        //Console.WriteLine("Ingrese un numero");
        //a = int.Parse(Console.ReadLine());
        //Console.WriteLine("Ingrese otro numero");
        //b = int.Parse(Console.ReadLine());

        //if(a > b) {
        //    resultado = a - b;
        //} else if(a == b) {
        //    resultado = a + b;
        //} else {
        //    resultado = a * b;
        //}
        //Console.WriteLine("El resultado es "+resultado);


        //2. Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la cantidad de litros vendidos según la siguiente escala:

        //Si vende menos de 100 litros, no hay descuento.
        //Si vende entre 101 y 300 litros, el descuento es del 10%.
        //Si vende entre 301 y 500 litros, el descuento es del 15%.
        //Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
        //Hacer un programa que solicite el ingreso del importe total de la venta y la cantidad de litros vendidos y calcule y emita el importe con el descuento  aplicado..

        //float importeTotal, litrosVendidos, importeDescuento, total;

        //Console.WriteLine("Ingrese importe total");
        //importeTotal = float.Parse(Console.ReadLine());
        //Console.WriteLine("Ingrese cantidad de litros vendidos");
        //litrosVendidos = float.Parse(Console.ReadLine());

        //if(litrosVendidos < 100) {
        //    Console.WriteLine("No hay descuento. El total es "+importeTotal//);
        //} else if (litrosVendidos > 101 && litrosVendidos < 300) {
        //    importeDescuento = 10 * importeTotal / 100;
        //    total = importeTotal - importeDescuento;
        //    Console.WriteLine("10% OFF, en total queda "+total);
        //} else if (litrosVendidos > 301 && litrosVendidos < 500) {
        //    importeDescuento = 15 * importeTotal / 100;
        //    total = importeTotal - importeDescuento;
        //    Console.WriteLine("15% OFF, en total queda "+total);
        //} else {
        //    importeDescuento = 25 * importeTotal / 100;
        //    total = importeTotal - importeDescuento;
        //    Console.WriteLine("25% OFF, en total queda "+total);
        //}
        //Console.WriteLine("Fin del programa");

        //3. Una importante marca de computadoras permite elegir cierta configuración del equipo a comprar. Para ello existe la siguiente escala de precios:
        
        //              i5 (1)	    i7 (2)	    i9 (3)
        //8 RAM (1)	    USD 800	    USD 900	    USD 1200
        //16 RAM (2)	USD 900	    USD 1000	USD 1400
        //32 RAM (3)	USD 1000	USD 1400	USD 2000

        //Además, el equipo viene con un disco que permite almacenar 500 GB de información y que se puede ampliar a 1 TB si así lo desea, lo cual tiene un costo  adicional de USD 300. 
        //Hacer un programa que solicite la opción de procesador, la opción de memoria  RAM, y si extiende el disco o no (ingresa 1 para extender y 0 para no extender) y calcule y emita por pantalla el monto de la máquina seleccionada.
        //int procesador, ram, disco;
        //float montoFinal;

        //Console.WriteLine("Ingrese la opcion de procesador: ");
        //procesador = int.Parse(Console.ReadLine());
        //Console.WriteLine("Ingrese la opcion de ram: ");
        //ram = int.Parse(Console.ReadLine());
        //Console.WriteLine("Va a extender su disco? Ingrese 1 para si o 0 para no");
        //disco = int.Parse(Console.ReadLine());

        //if (procesador == 1 && ram == 1) {
        //    montoFinal = 800;
        //} else if (procesador == 1 && ram == 2) {
        //    montoFinal = 900;
        //} else if (procesador == 1 && ram == 3) {
        //    montoFinal = 1000;
        //} else if (procesador == 2 && ram == 1) {
        //    montoFinal = 900;
        //} else if (procesador == 2 && ram == 2) {
        //    montoFinal = 1000;
        //} else if (procesador == 2 && ram == 3) {
        //    montoFinal = 1400;
        //} else if (procesador == 3 && ram == 1) {
        //    montoFinal = 1200;
        //} else if (procesador == 3 && ram == 2) {
        //    montoFinal = 1400;
        //} else {
        //    montoFinal = 2000;
        //}

        //if (disco == 1) {
        //montoFinal = montoFinal + 300;
        //Console.WriteLine("Expande disco, el monto total va a ser de "+montoFinal);
        //} else {
        //Console.WriteLine("No expande disco, el monto total es "+montoFinal);
        //}

        //4. Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la suma de los dos primeros es mayor al producto del segundo con el tercero.

        /*int a, b, c, suma, producto;

        Console.WriteLine("Ingrese primer numero ");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese segundo numero ");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese tercer numero ");
        c = int.Parse(Console.ReadLine());

        suma = a + b;
        producto = b * c;

        if (suma > producto) {
            Console.WriteLine("La suma de los dos primeros es mayor al producto del segundo con el tercero: La suma "+suma+", el producto "+producto);
        } else {
            Console.WriteLine("La suma de los dos primeros no es mayor al producto del segundo con el tercero: La suma "+suma+", el producto "+producto);
        }*/

        //5. Hacer un programa para ingresar 4 números. Luego analizar e informar por pantalla si los mismos se encuentran ordenados de forma decreciente .

        /*int a, b, c, d;

        Console.WriteLine("Ingrese un numero");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese otro numero");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese otro numero");
        c = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese un ultimo numero");
        d = int.Parse(Console.ReadLine());

        if (a > b && b > c && c > d) {
            Console.WriteLine("Los numeros estan ordenados de forma decreciente.");
        } else {
            Console.WriteLine("Los numeros no estan ordenados de forma decreciente.");
        }
        Console.WriteLine("Fin de programa");*/

        //6. Hacer un programa que solicite el ingreso de un número y que luego emita un
        //cartel por pantalla aclarando si el mismo es múltiplo de 5.

        //int n;

        //Console.WriteLine("Ingrese un numero");
        //n = int.Parse(Console.ReadLine());

        //if (n%5 == 0) {
        //    Console.WriteLine("Es multiplo de 5");
        //} else {
        //    Console.WriteLine("No es multiplo de 5");
        //}
        //Console.WriteLine("Fin de programa");

        //7. Hacer un programa para ingresar dos números. Si el segundo es distinto de
        //cero, calcular la división del primero por el segundo y mostrar el resultado por
        //pantalla; caso contrario, emitir un cartel aclarando que no se puede dividir por
        //cero.

        //float a, b, resultado;

        //Console.WriteLine("Ingrese un numero");
        //a = float.Parse(Console.ReadLine());
        //Console.WriteLine("Ingrese otro numero");
        //b = float.Parse(Console.ReadLine());

        //if (b != 0) {
        //    resultado = a / b;
        //    Console.WriteLine("El resultado de la division del primero por el segundo es: "+resultado);
        //} else {
        //    Console.WriteLine("No se puede dividir por cero.");
        //}
        //Console.WriteLine("Fin del programa");

        //8. Hacer un programa que solicite el ingreso de las notas del primer parcial y del segundo parcial de una alumna de programación. 
        //El programa deberá analizar las notas y emitir la situación de la alumna según la siguiente escala:
        //a. Si tiene 8 o más en ambos parciales, emitir “aprobación directa”.
        //b. Si no tiene 8 o más en ambos pero tiene aprobados ambos parciales (se aprueba con 6 o más), emitir “rinde examen final”.
        //c. Si tiene menos de 6 en alguno de los dos parciales, emitir “debe recuperar”.
        //El programa debe emitir solo un cartel, el que corresponda.

        //int parcialUno, parcialDos;

        //Console.WriteLine("Ingrese la nota del primer parcial");
        //parcialUno = int.Parse(Console.ReadLine());
        //Console.WriteLine("Ingrese la nota del segundo parcial");
        //parcialDos = int.Parse(Console.ReadLine());

        //if(parcialUno >= 8 && parcialDos >= 8) {
        //    Console.WriteLine("Aprobacion directa.");
        //} else if (parcialUno >= 6 && parcialDos >= 6) {
        //    Console.WriteLine("Rinde examen final.");
        //} else {
        //    Console.WriteLine("Debe recuperar.");
        //}
        //Console.WriteLine("Fin del programa.");

        //9. Hacer un programa para ingresar por teclado la longitud de los tres lados de un triángulo y que luego determine e informe con un cartel aclaratorio a qué tipo
        //de triángulo corresponde:
        //a. Equilátero: cuando los tres lados sean iguales.
        //b. Isósceles: cuando dos de los tres lados sean iguales.
        //c. Escaleno: cuando todos los lados sean distintos.

        //int ladoUno, ladoDos, ladoTres;

        //Console.WriteLine("Ingrese la primer longitud:");
        //ladoUno = int.Parse(Console.ReadLine());
        //Console.WriteLine("Ingrese la segunda longitud:");
        //ladoDos = int.Parse(Console.ReadLine());
        //Console.WriteLine("Ingrese la tercer longitud:");
        //ladoTres = int.Parse(Console.ReadLine());

        //if(ladoUno == ladoDos && ladoDos == ladoTres && ladoTres == ladoUno) {
        //    Console.WriteLine("El triangulo es Equilatero.");
        //} else if (ladoUno == ladoDos || ladoDos == ladoTres || ladoTres == ladoUno) {
        //    Console.WriteLine("El triangulo es Isosceles.");
        //} else {
        //    Console.WriteLine("El triangulo es Escaleno.");
        //}
        //Console.WriteLine("Fin del programa.");

        //10. El negocio de desinfectante antes mencionado vende además detergente suelto, y los precios se aplican según la siguiente escala:
        //a. 25 ARS por litro los primeros 50 litros.
        //b. 20 ARS por litro si la venta es de 51 a 200 litros.
        //c. 15 ARS por litro si la venta es de 201 a 500 litros.
        //d. 10 ARS por litro si la venta es de más de 500 litros.
        //Además, si paga en efectivo, tiene un adicional del 10% sobre el importe final.
        //Hacer un programa que solicite la cantidad de litros vendidos y el tipo de pago
        //(ingresará 1 si paga en efectivo y 0 con cualquier otro medio de pago) y calcule y emita por pantalla el monto final a abonar por el cliente.

        //int litrosVendidos, tipoPago, adicional, importeFinal;

        //Console.WriteLine("Ingrese la cantidad de litros");
        //litrosVendidos = int.Parse(Console.ReadLine());
        //Console.WriteLine("Con que tipo de pago va a abonar? (ingrese 1 si es efectivo, 0 cualquier otro medio.)");
        //tipoPago = int.Parse(Console.ReadLine());

        //if(litrosVendidos <= 50) {
        //    importeFinal = 25 * litrosVendidos;
        //} else if (litrosVendidos <= 200) {
        //    importeFinal = 20 * litrosVendidos;
        //} else if (litrosVendidos <= 500) {
        //    importeFinal = 15 * litrosVendidos;
        //} else {
        //    importeFinal = 10 * litrosVendidos;
        //}

        //if(tipoPago == 1) {
        //   adicional = 10 * importeFinal / 100;
        //   importeFinal = importeFinal + adicional;
        //   Console.WriteLine("El importe final con 10% de racargo es de: "+importeFinal);
        //} else {
        //    Console.WriteLine("El importe final es de: "+importeFinal);
        //}

        //11. Hacer un programa que solicite cuatro números y emitir un cartel aclaratorio si son todos iguales entre sí, caso contrario, no emitir nada.
        //int a, b, c, d;

        //Console.WriteLine("Ingrese un numero");
        //a = int.Parse(Console.ReadLine());
        //Console.WriteLine("Ingrese otro numero");
        //b = int.Parse(Console.ReadLine());
        //Console.WriteLine("Ingrese otro numero");
        //c = int.Parse(Console.ReadLine());
        //Console.WriteLine("Ingrese el ultimo numero");
        //d = int.Parse(Console.ReadLine());

        //if (a == b && a == c && a == d && b == c && b == d && c == d) {
        //    Console.WriteLine("Son todos los numeros iguales.");
        //}
        //Console.WriteLine("Fin de programa.");

        //12. Hacer un programa para ingresar tres números y luego mostrarlos ordenados de menor a mayor.

        /*int a, b, c;

        Console.WriteLine("Ingrese el primer numero.");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese segundo numero.");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese un ultimo numero.");
        c = int.Parse(Console.ReadLine());

        if(a < b && b < c) {
            Console.WriteLine("Estan de menor a mayor: "+a+", "+b+", "+c+".");
        } else {
            Console.WriteLine("No estan ordenados.");
        }*/

        //13. Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la suma de los dos primeros es mayor al producto del segundo con el tercero.

        /*int a, b, c, suma, producto;

        Console.WriteLine("Ingrese un numero.");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese otro numero.");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese un tercer numero.");
        c = int.Parse(Console.ReadLine());

        suma = a + b;
        producto = b * c;

        if(suma > producto) {
            Console.WriteLine("Es mayor al producto");
        } else {
            Console.WriteLine("No es mayor.");
        }
        Console.WriteLine("Fin del programa.");*/
   }
}
