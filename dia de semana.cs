using System;

namespace Dias_de_semana
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] Dia = new string[7];

            Dia[0] = "Lunes";
            Dia[1] = "Martes";
            Dia[2] = "Miercoles";
            Dia[3] = "Jueves";
            Dia[4] = "Viernes";
            Dia[5] = "Sabado";
            Dia[6] = "Domingo";

            Console.WriteLine("Los Dias De Semana Son:");

            foreach (var dia in Dia)
            {
                Console.WriteLine(dia);

            }
        }
    }
}