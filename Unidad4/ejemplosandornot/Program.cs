namespace ejemplosandornot;
class Program
{
    static void Main(string[] args)
    {
        // AND, OR, NOT
        //AND [y] Operador: &&
        //OR [o] Operador: ||
        //NOT Operador: !
        //v OP v AND v OP v

        //OR
        //true || false = true
        //false || true = true
        //true || true = true
        //false || false = false

        //AND
        //true && true = true
        //false && true = false
        //true && false = false
        //false && false = false
        
        int edad = 30;
        char inicial = 'J' ;
        
        if(!(inicial == 'J' || inicial == 'H') && edad > 20) {
            Console.WriteLine("21 OFF...");
        }
        Console.WriteLine("Fin Programa");
    }
}
