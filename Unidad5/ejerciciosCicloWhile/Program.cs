namespace ejerciciosCicloWhile;
class Program
{
    static void Main(string[] args)
    {
        // 1. Hacer un programa para mostrar los números del 1 al 10. No se debe realizar ningún pedido de datos. USANDO WHILE.
            // int n = 0;

            // while(n < 10) {
                // n++;
                // Console.WriteLine(n);
            // }

        // 2. Hacer un programa para mostrar los números del 10 al 1. No se debe realizar ningún pedido de datos. USANDO WHILE.

            // int n = 11;

            // while(n > 1) {
                // n--;
                // Console.WriteLine(n);
            // }

        // 3. Hacer un programa que solicite la edad de un grupo de personas. El programa deberá pedir edades hasta que se ingrese una edad menor a 18 años. Deberá mostrar por pantalla cuántas personas mayores se registraron.

            // int edades, conMayores = 0;

            // Console.WriteLine("Ingresa una edad: ");
            // edades = int.Parse(Console.ReadLine());

            // while (edades > 18) {
                // edades = int.Parse(Console.ReadLine());
                // conMayores++;
            // };

            // Console.WriteLine("Se registraron "+conMayores+" personas mayores de edad.");

        // 4. Hacer un programa que solicite dos números y luego muestre los números entre el menor y el mayor de ellos. Acordate, usando While.

            // int n1, n2, menor, mayor;

            // Console.WriteLine("Ingrese dos numeros");
            // n1 = int.Parse(Console.ReadLine());
            // n2 = int.Parse(Console.ReadLine());

            // if (n1 > n2) {
                // menor = n2;
                // mayor = n1;
            // } else {
                // menor = n1;
                // mayor = n2;
            // };

            // while (menor < mayor) {
                // menor++;
                // Console.WriteLine("Los numeros entre medio son: "+menor);
            // };

        // 5. Hacer un programa que muestre los números del 1 al 100 de 5 en 5. Ejemplo: 0, 5, 10, 15, 20.... 100. Usando While.

            // int n = 0, acu = 0;

            // while (n < 100) {
                // n = acu+=5;
                // Console.WriteLine(n);
            // }

        // 6. Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio si el mismo es primo o no es primo. Nota: usando While. Ya lo hicimos con FOR, ahora con While.

            // int n, con = 2;
            // bool isPrime = true;

            // Console.WriteLine("Ingrese un numero");
            // n = int.Parse(Console.ReadLine());

            // while (con < n) {
                // if (n % con == 0) {
                    // isPrime = false;
                    // break;
                // }
                // con++;
            // };
            // if (isPrime) {
                // Console.WriteLine("Es primo");
            // } else {
                // Console.WriteLine("No es primo");
            // }


        // 7. Hacer un programa que solicite una lista de números que corta cuando se ingresa un cero y luego mostrar por pantalla el máximo de ellos y la posición en la que fue ingresado.

            // int n, posicion = 1, pMax = posicion;

            // Console.WriteLine("Ingrese un num");
            // n = int.Parse(Console.ReadLine());
            
            // int max = n;

            // while(n != 0) {
                // n = int.Parse(Console.ReadLine());
                // if (n > max) {
                    // max = n;
                    // pMax = posicion++;
                // }
            
            // }

            // // Console.WriteLine("El numero mayor es "+max+" y la posicion es "+posicion);

        // 8. Hacer un programa que solicite una lista de números que corta cuando se ingresa un cero y luego mostrar por pantalla el menor y el segundo menor.

            // int n = -1, min = int.MaxValue, min2 = int.MaxValue;

            // Console.WriteLine("Ingrese un num");
            // n = int.Parse(Console.ReadLine());

            // while(n != 0) {
                // n = int.Parse(Console.ReadLine());
                // if (n < min) {
                    // min2 = min;
                    // min = n; 
                // }  else if (n < min2) {
                    // min2 = n;
                // }
            // }
            // //  Console.WriteLine("El primer menor es "+min+" y el segundo es " +min2);

        // 9. Realizar el nuevamente el ejercicio 8 pero ahora debe devolver además la posición en la que fue encontrado cada uno de los mínimos.

            // int n = -1, min = int.MaxValue, min2 = int.MaxValue, posicion = 0, pMax1 = posicion, pMax2 = posicion;

            // Console.WriteLine("Ingrese un num");
            // n = int.Parse(Console.ReadLine());

            // while(n != 0) {
                // n = int.Parse(Console.ReadLine());
                // if (n < min) {
                    // min2 = min;
                    // min = n;
                    // pMax2 = pMax1;
                    // pMax1 = posicion++;
                // }  else if (n < min2) {
                    // min2 = n;
                    // pMax2 = posicion++;
                // };
            // }
            // Console.WriteLine("El primer menor es "+min+", su posicion es "+pMax1+" y el segundo es " +min2+", su posicion es "+pMax2);


        // 10. Hacer un programa que solicite una lista de números que corta cuando se ingresa un cero y luego emitir por pantalla el máximo de los números negativos y el mínimo de los números positivos.

            // int n = -1, bN = 0, bP = 0, min = 0, max = 0;

            // Console.WriteLine("Ingrese un num");
            // while (n != 0) {
                // n = int.Parse(Console.ReadLine());
                // if (n > 0) {
                    // if (bP == 0) {
                        // min = n;
                        // bP = 1;
                    // } else if (n < min) {
                        // min = n;
                    // }
                // } else {
                    // if (bN == 0) {
                        // max = n;
                        // bN = 1;
                    // } else if (n > max) {
                        // max = n;
                    // }
                // }
            // }
            // // Console.WriteLine("El max negativo es "+max+" el min positivo es "+min);

        // 11. Hacer un programa para ingresar una lista de números que corta cuando se ingresa un cero y luego mostrar: la cantidad de números primos, la cantidad de números pares, la cantidad de positivos y la cantidad de negativos.

        // int n = -1, cp = 0, cn = 0, cpa = 0, cpr = 0;

        // Console.WriteLine("Ingresa un num");

        // while (n != 0) {
            // n = int.Parse(Console.ReadLine());
            // if (n > 0) {
                // cp++;
            // } else if (n < 0) {
                // cn++;
            // }

            // if (n % 2 == 0 && n != 0) {
                // cpa++;
            // }

            // int con = 0, j = 2;

            // if (n % 2 != 0 && n!=0) {
                // while (j <= n/2) {
                    // if (n%j == 0) {
                        // con++;
                        // break;
                    // }
                    // j++;
                // }

                // if (con == 0) {
                    // cpr++;
                // }
            // }     
        // }
        // Console.WriteLine("La cantidad de primos es "+cpr+" la cantidad de pares es "+cpa+" la cantidad de positivos es "+cp+" la cantidad de negativos es "+cn);
    }
}
