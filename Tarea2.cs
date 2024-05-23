using System;

class Program
{
    static void Main()
    {
        const int inventarioInicial = 1000;
        const int umbralMinimo = 200;
        int inventario = inventarioInicial;
        int dias = 0;

        // Simular el control de inventario durante 30 días
        for (int i = 1; i <= 30; i++)
        {
            // Simular entrega de vacunas
            Console.WriteLine($"Día {i}: Vacunas disponibles = {inventario}");

            // Verificar si el inventario baja del umbral mínimo
            if (inventario < umbralMinimo)
            {
                Console.WriteLine($"ALERTA: Inventario bajo el umbral mínimo de {umbralMinimo} unidades.");
            }

            // Reducir el inventario aleatoriamente entre 10 y 50 unidades
            Random random = new Random();
            int entrega = random.Next(10, 51);
            inventario -= entrega;
            dias++;
        }

        // Mostrar resultados finales
        Console.WriteLine($"Total de días simulados: {dias}");
        Console.WriteLine($"Inventario final: {inventario}");
    }
}
