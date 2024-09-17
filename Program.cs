using System.Diagnostics.Tracing;

string opcion = "";

string EvaluarNúmero(int numero)
{
    string evaluacion = "";

    if (numero == 0)
    {
        evaluacion = "CERO";
    }
    else if(numero > 0)
    {
        evaluacion = "POSITIVO";
    }
    else
    {
        evaluacion = "NEGATIVO";
    }

    return evaluacion;
}

void DiaSemana(int numero)
{
    switch (numero) 
    { 
        case 1:
            Console.WriteLine("El día es LUNES");
            break;
        case 2:
            Console.WriteLine("El día es MARTES");
            break;
        case 3:
            Console.WriteLine("El día es MIÉRCOLES");
            break;
        case 4:
            Console.WriteLine("El día es JUEVES");
            break;
        case 5:
            Console.WriteLine("El día es VIERNES");
            break;
        case 6:
            Console.WriteLine("El día es SÁBADO");
            break;
        case 7:
            Console.WriteLine("El día es DOMINGO");
            break;       
        default:
            Console.WriteLine("NO representa un DÍA de la Semana");
            break;
    }
}

int Suma100Numeros() {
    int suma = 0;

    for (int i = 1; i<=100; i++)
    {
        suma = suma + i;
    }
    
    return suma;
}

void NumeroLimite(int numero)
{
    for (int i = 1;i<=numero; i++)
    {
        Console.WriteLine(i);
    }
}

double AreaCirculo(double radio)
{
    double area = 0;

    area = Math.PI * Math.Pow(radio,2);

    return area;
}

void MostarArreglo()
{
    string[] arreglo = new string[4];

    arreglo[0] = "Primavera";
    arreglo[1] = "Verano";
    arreglo[2] = "Otoño";
    arreglo[3] = "Invierno";

    foreach (var item in arreglo)
    {
        Console.WriteLine(item);
    }
}

void ListaNombres()
{
    List<string> nombres = new List<string>();
    nombres.Add("José");
    nombres.Add("Ruth");
    nombres.Add("Suge");
    nombres.Add("Martha");
    nombres.Add("Eloy");

    foreach (var item in nombres)
    {
        Console.WriteLine(item);
    }
}


do
{
    Console.WriteLine("MENU");
    Console.WriteLine("-------------------------");
    Console.WriteLine("1) Evaluar número");
    Console.WriteLine("2) Evaluar día de semana (número): Lunes=1, Martes=2, etc.");
    Console.WriteLine("3) Suma de los 100 primeros números naturales");
    Console.WriteLine("4) Límite de impresión");
    Console.WriteLine("5) Cálculo del área de un círculo");
    Console.WriteLine("6) Mostrar arreglo unidimensional");
    Console.WriteLine("7) Mostrar nombres de alumnos del curso C#");
    Console.WriteLine("8) Presion S para SALIR");

    opcion = Console.ReadLine();

    Console.WriteLine("\n");

    switch (opcion)
    {
        case "1":
            int numero = 0;
            Console.WriteLine("Ingrese Número : ");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El número es : " + EvaluarNúmero(numero));
            break;

        case "2":
            int numeroDia = 0;
            Console.WriteLine("Ingrese Número (Día) : ");
            numeroDia = Convert.ToInt32(Console.ReadLine());
            DiaSemana(numeroDia);
            break;

        case "3":            
            Console.WriteLine("La suma de los 100 primeros números es : " + Suma100Numeros());
            break;

        case "4":
            int numeroLimite = 0;
            Console.WriteLine("Ingrese Número Límite a imprimir : ");
            numeroLimite = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            NumeroLimite(numeroLimite);
            break;

        case "5":
            double radio = 0;
            Console.WriteLine("Ingrese el radio de un círculo : ");
            radio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El área del círculo es : " + AreaCirculo(radio));
            break;

        case "6":
            MostarArreglo();
            break;

        case "7":
            ListaNombres();
            break;

        case "8":
            Console.WriteLine("Gracias por participar...");
            break;
    }
} while (opcion != "8");