//VECTORES - ARRAY - ARREGLO
// int n;
// int[] numeros = new int[10];

// for (int i = 0; i < 10; i++) {
    // Console.WriteLine("Ingrese la nota...");
    // n = int.Parse(Console.ReadLine());
    // numeros[i] = n;
// }

// int acu = 0;

// for (int i = 0; i < 10; i++) {
    // acu += numeros[i];
// }

// int prom = acu / 10;

// Console.WriteLine("El promedio es: "+prom);

//VECTORES DOUBLE

// double[] muestraMatutina = new double[31];
// double[] muestraVespertina = new double[31];
// double[] muestraNocturna = new double[31];

// int dia;
// double temperatura;

// Console.WriteLine("Cargue el registro matutino");
// for (int i = 0; i < 31; i++) {
    // Console.WriteLine("Ingrese el dia: ");
    // dia = int.Parse(Console.ReadLine());
    // Console.WriteLine("Ingrese temperatura registrada:");
    // temperatura = double.Parse(Console.ReadLine());

    // muestraMatutina[dia - 1] = temperatura;
// }
// for (int i = 0; i < 31; i++) {

// }
// for (int i = 0; i < 31; i++) {

// }

// double acu = 0;
// for(int i = 0; i < 31; i++) {
    // acu += muestraMatutina[i];
// }

// double[] sueldos = new double[50];
// int[] legajos = new int[50];

// for (int i = 0; i < 50; i++) {
    // sueldos[i] = 123;
    // legajos[i] = 456;
// }


//VECTORES BOOL
// bool[]  asistenciasQuincena1 = new bool[15];
// for (int i = 0; i < 15; i++) {
    
// }

// bool[] asistencia = new bool[100];
// int[] legajos = new int[100];

// for (int i = 0; i < 16; i++) {
    // for (int x = 0; x < 100; x++) {
        
    // }
// };

//CADENAS DE CARACTERES

// char[] frase = new char[10];
// //BARRA CERO
// frase[5] = '\0';
//marca la finalizacion de la cadena de caracteres

// char[] nombre = new char[10];
// char letra;
// int indice = 0;
// Console.WriteLine("iNGRESE EL NOMBRE LETRA POR LETRA");
// letra = char.Parse(Console.ReadLine());
// while (letra !='.' && indice < 10) {
    // nombre[indice] = letra;
    // letra = char.Parse(Console.ReadLine());
    // indice++;
// }

// if(indice == 10) {
    // indice--;
// }

// nombre[indice] = '\0';

// Console.WriteLine("hOLA");
// indice = 0;
// while (nombre[indice] != '\0') {
    // Console.Write(nombre[indice]);
    // indice++;
// }

//STRING
// string nombre;
// Console.WriteLine("Ingrese su nombre");
// nombre = Console.ReadLine();
// Console.WriteLine("Hola "+nombre);