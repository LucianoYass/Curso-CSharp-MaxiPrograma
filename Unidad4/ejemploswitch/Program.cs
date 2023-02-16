namespace ejemploswitch;
class Program
{
    static void Main(string[] args)
    {
       //Switch
       //Evalua multiples opciones con su palabra reservada: switch()
       char letra = 'A';
       switch(letra) {
        case 'A':
            Console.WriteLine("A de ARREH LOCO");
            break;
        case 'H':
            break;
        default:
            Console.WriteLine("No coincide ninguna.");
            break;
       }
       
    }
}
