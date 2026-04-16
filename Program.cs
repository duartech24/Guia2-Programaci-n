internal class Program
{
    //pide dos números y una opción:
    //1 ? Sumar, 2 ? Restar, 3 ? Multiplicaciór, 4 ? Dividir - Muestra el resultado según la opción elegida.
    private static void Main(string[] args)
    {
        Console.WriteLine("Escriba dos valores numéricos");
        double num1=Convert.ToDouble(Console.ReadLine());
        double num2=Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\n****MENÚ PRINCIPAL****");
        Console.WriteLine("1- Suma");
        Console.WriteLine("2- Resta");
        Console.WriteLine("3- Multiplicación");
        Console.WriteLine("4- División");
        Console.WriteLine("5- Salir");
        Console.Write("Digite el valor según la Operación: [ ]");
        int opc=Convert.ToInt32(Console.ReadLine());

        //Evaluar con switch
        string msj = "";
        double result = 0;
        switch (opc)
        {
            case 1:
                msj = "\nSUMA\nLa suma es: ";
                result = num1 + num2;
                break;
            case 2:
                msj = "\nRESTA\nLa resta es: ";
                result = num1 - num2;
                break;
            case 3:
                msj = "\nMULTIPLICACIÓN\nLa multiplicación es: ";
                result = num1 * num2;
                break;
            case 4:
                msj = "\nDIVISIÓN\nLa suma es: ";
                result = num1 / num2;
                break;
            case 5:
                msj = "Saliendo del sistema...";
                break;
            default:
                msj = "Digite una opción válida!!!";
                break;
        }
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Blue;//Fondo
        Console.ForegroundColor = ConsoleColor.White;//letra
        Console.WriteLine(msj);
        Console.WriteLine(result);
    }
}