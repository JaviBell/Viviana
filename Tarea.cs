using System;

class Program
{
    static void Main()
    {
        const int cantidadValores = 15;
        int[] valores = new int[cantidadValores];
        int suma = 0;

        // Solicitar valores al usuario
        for (int i = 0; i < cantidadValores; i++)
        {
            Console.Write($"Ingrese el valor {i + 1}: ");
            valores[i] = Convert.ToInt32(Console.ReadLine());
            suma += valores[i];
        }

        // Calcular promedio
        double promedio = (double)suma / cantidadValores;

        // Mostrar resultados
        Console.WriteLine($"La suma de los valores es: {suma}");
        Console.WriteLine($"El promedio de los valores es: {promedio}");
    }
}