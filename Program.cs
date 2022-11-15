using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPU3D_Ejemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Si el maestro es categoria C y tiene una antiguedad de mas de 5 años, se asiganraá
                uun bono adicional de 700 pesos por año.
             */

            //Trabajar con estructuras selectivas SWITTCH
            string nombreProfesor, careraProfesor, categoriaProfesor;
            double sueldoProfesor = 90.00, totalHoras, pagoCategoria;

            //Pedir valores para las variables
            Console.WriteLine("Ingresa el nombre completo del profesor");
            nombreProfesor = Console.ReadLine();
            //---
            Console.WriteLine("Ingresa la carrera de adscripción profesor \n ISIC \t IIND \t IGEM");
            careraProfesor = Console.ReadLine();
            //---
            Console.WriteLine("Ingresa la categoria de adscripción profesor \n A \t B \t C");
            categoriaProfesor = Console.ReadLine();
            //---
            Console.WriteLine("Ingresa la cantidad de horas a la semana asignadas al profesor ");
            totalHoras = Convert.ToDouble( Console.ReadLine());
            if (totalHoras <= 0 || totalHoras > 40)
            {
                Console.WriteLine("Horas no validas");
                System.Threading.Thread.Sleep(1000);
                return;
            }

            //Generar el witch
            switch (categoriaProfesor)
            {
                case "A":
                    pagoCategoria = 1.0035;
                    sueldoProfesor = (sueldoProfesor * totalHoras)*pagoCategoria;
                    Console.WriteLine("El maestro llamado {0}, con categoria {1}, percibirá un sueldo de {2} a la semana, por un total de {3} horas.", nombreProfesor, categoriaProfesor, sueldoProfesor, totalHoras);
                    break;
                case "B":
                    pagoCategoria = 1.0048;
                    sueldoProfesor = (sueldoProfesor * totalHoras) * pagoCategoria;
                    Console.WriteLine("El maestro llamado {0}, con categoria {1}, percibirá un sueldo de {2} a la semana, por un total de {3} horas.", nombreProfesor, categoriaProfesor, sueldoProfesor, totalHoras);
                    break;
                case "C":
                    byte antiguedad;
                    double bono;
                    pagoCategoria = 1.0063;
                    sueldoProfesor = (sueldoProfesor * totalHoras) * pagoCategoria;
                    Console.WriteLine("Ingresa con número la antiguedad del maestro.");
                    antiguedad = Convert.ToByte( Console.ReadLine());
                    if (antiguedad >= 5)
                    {
                        bono = (700 * antiguedad) / 52;

                        Console.WriteLine("Sueldo base: ${0}", sueldoProfesor);
                        Console.WriteLine("Bono de antiguedad: ${0}", bono);
                        sueldoProfesor = sueldoProfesor + bono;
                        Console.WriteLine("Sueldo mas bono de antiguedad: ${0}", sueldoProfesor);
                    }                    
                    Console.WriteLine("El maestro llamado {0}, con categoria {1}, percibirá un sueldo de {2} a la semana, por un total de {3} horas.", nombreProfesor, categoriaProfesor, sueldoProfesor, totalHoras);
                    break;
                default:
                    Console.WriteLine("Elije una categoria valida");
                    break;
            }
            Console.ReadKey();
            /* Paeticipaciones:
                +
                Hugo, Pedro, Tanuis, Jonathan, Miriam
                -
                Eleazar
             */
        }
    }
}
