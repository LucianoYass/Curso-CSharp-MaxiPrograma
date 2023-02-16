namespace TPFinal_Cordoba;
class Program
{
    static void Main(string[] args)
    {
        // Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. A partir de dichos datos informar:
            // a. El mayor de los números pares.
            // b. La cantidad de números impares.
            // c. El menor de los números primos.
        // Nota: evaluar el uso de una función que analice si un número dado es primo o no y que devuelva true o false según corresponda.

        int n, mayorPares, cantImpares, menorPrimos;

        mayorPares = 0;
        cantImpares = 0;
        menorPrimos = int.MaxValue;

        Console.WriteLine("Ingrese un num");
        n = int.Parse(Console.ReadLine());
        
        while (n != 0) {
            if (par(n)) {
                if (n > mayorPares) {
                    mayorPares = n;
                }
            } else {
                cantImpares++;
            }

            if (primo(n)) {
                if (n < menorPrimos) {
                    menorPrimos = n;
                }
            }

            Console.WriteLine("Ingrese otro");
            n = int.Parse(Console.ReadLine());
        }
        
        Console.WriteLine("El menor de los primos es: " + menorPrimos);
        Console.WriteLine("El mayor de los pares es: " + mayorPares);
        Console.WriteLine("La cantidad de numeros impares es: " + cantImpares);
    }

    static bool par(int a) {
        if (a % 2 == 0) {
            return true;
        } else {
            return false;
        }
    }

    static bool primo(int a) {
        int con = 0;
        for (int i = 1; i <= a; i++) {
            if (a % i == 0) {
                con++;
            }
        }

        if (con == 2) {
            return true;
        } else {
            return false;
        }
    }
}
