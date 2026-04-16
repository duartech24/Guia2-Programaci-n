internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("RANGO DE ESTUDIANTES");
        Console.WriteLine("Ingrese una letra(A,B,C,D,F)");
        char letra = Char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();

        switch (letra)
        {
            case 'A': 
                Console.WriteLine("Exelente");
                break;
            case 'B':
                Console.WriteLine("Bueno");
                break;
            case 'C':
                Console.WriteLine("Regular");
                break;
            case 'D':
                Console.WriteLine("Deficiente");
                break;
            case 'F':
                Console.WriteLine("Reprobado");
                break;
            default:
                Console.WriteLine("Escriba una letra válida!!");
                break ;
        }
    }
}