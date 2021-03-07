using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_y_perimtro_triangulo
{
    class Program
    {
        static void Main(string[] args)
        {

            double altura;
            double baset;
            double hipotenusa;
            double area;
            double perimetro;
            double hipotenusa2;


            Console.WriteLine("Escribe la base del triangulo: ");
            baset = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escribe la altura del triangulo: ");
            altura = Convert.ToDouble(Console.ReadLine());


            area = (baset * altura) / 2;


            hipotenusa = (baset * baset) + (altura * altura);

            hipotenusa2= Math.Sqrt(hipotenusa);

            perimetro = baset + altura + hipotenusa2;

            Console.WriteLine("El area es: " + area);
            Console.WriteLine("El perimetro es: " + perimetro );

            Console.ReadKey();

        }
    }
}
