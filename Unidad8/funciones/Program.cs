//FUNCIONES
//PARTES DE LA FUNCION
//CABECERA
//1. TIPO DE DATO
//2. NOMBRE
//3. opcional: PARAMETROS
//CUERPO
//Definicion / logica
//opcional: retorno de valor / resultado

int n1 = 0, n2 = 0, resultado;

pedirDatos(ref n1, ref n2);

resultado = sumar(n1, n2);

Console.WriteLine("El resultado es: " + resultado);

//Ejemplo de parametro por valor
static int sumar(int a, int b) {
    int r;
    r = a + b;
    return r;
}

//Ejemplo de parametro por referencia
static void pedirDatos(ref int j, ref int h) {
    Console.WriteLine("Ingrese un nro:");
    j = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese otro:");
    h = int.Parse(Console.ReadLine());
}