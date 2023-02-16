namespace ciclowhile;
class Program
{
    static void Main(string[] args)
    {
        //CICLO WHILE
        int n, con = 0;
        
        Console.WriteLine("Ingrese un numero:");
        n = int.Parse(Console.ReadLine());

        while(n !=0) {
            con++;
            Console.WriteLine("Ingrese un numero:");
            n = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Ingresaste "+ con +" numeros.");
    }
}
