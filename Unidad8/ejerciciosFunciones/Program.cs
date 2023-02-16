// En este caso, la idea va a ser armar una función que resuelva algo y luego armar un main que interactúe con una persona para pedir y mostrar datos pero que llame a esa función para resolver lo planteado. Vamos?

// 1. Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos. Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y muestre por pantalla el monto total a pagar. Usar la función.

// static int producto(int a, int b) {
    // int r = a * b;
    // return r;
// }

// int n1, n2, prod;
// Console.WriteLine("Intrese un nro");
// n1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Intrese un otro");
// n2 = int.Parse(Console.ReadLine());

// prod = producto(n1, n2);

// Console.WriteLine("El producto es: " + prod);

// 2. Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es. Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.

// int n, con = 0;

// for (int i = 0; i < 5; i++) {
    // Console.WriteLine("Ingrese un nro");
    // n = int.Parse(Console.ReadLine());
    // if(par(n)) {
        // con++;
    // }
// }
// Console.WriteLine("La cantidad de nros pares es: " + con);

// static bool par(int a) {
    // if(a % 2 == 0) {
        // return true;
    // } else {
        // return false;
    // }
// }

// 3. Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es. Hacer un programa para ingresar números. El lote corta cuando se ingresa un número cero. Informar el promedio teniendo en cuenta sólo los números primos.

// int n, conPrimos = 0, acuPrimos = 0, promedio;
// Console.WriteLine("Ingrese un num");
// n = int.Parse(Console.ReadLine());
// while ( n != 0) {
    // if (primo(n)) {
        // conPrimos++;
        // acuPrimos+=n;
    // }
    // Console.WriteLine("Ingrese otro");
    // n = int.Parse(Console.ReadLine());
// }

// promedio = acuPrimos / conPrimos;
// Console.WriteLine("El promedio de los primos es: " + promedio);

// static bool primo(int a) {
    // int con = 0;
    // for (int i = 1; i <= 0; i++) {
        // if (a % i == 0) {
            // con++;
        // }
    // }

    // if (con == 2) {
        // return true;
    // } else {
        // return false;
    // }
// }

// 4. Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” que reciba un número por valor y una variable por referencia. Que analice el número y escriba variable recibida por referencia con:

// a. 1 si el número es positivo.
// b. -1 si el número es negativo.
// c. 0 si el número es cero.

// int numero, status = 9;
// Console.WriteLine("Ingrese un nro");
// numero = int.Parse(Console.ReadLine());

// positivoNegativoCero(numero, ref status);

// Console.WriteLine("El estado del valor " + numero + " es: " + status);

// static void positivoNegativoCero(int n, ref int estado) {
    // if (n > 0) {
        // estado = 1;
    // } else if (n == 0) {
        // estado = 0;
    // } else {
        // estado = -1;
    // }
// }

int h = -1, g = 10;

g-=h;

Console.WriteLine(g);