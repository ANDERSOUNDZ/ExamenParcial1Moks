using System;

namespace SolucionConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Notas Profesor");

            Estudiante estudiante = new Estudiante();
            var NotaDeberEstudiante1 = estudiante.NotasDeberPresentacion1(3,4);
            var NotaDeberEstudiante2  = estudiante.NotasDeberPresentacion2(9, 5);
            var NotaExamenEstudiante1 = estudiante.NotasExposicionFinalExamenParcial1(3,7);
            var NotaExamenEstudiante2 = estudiante.NotasExposicionFinalExamenParcial1(7,1);
            Console.WriteLine("La nota de Deber de la presentacion 1 es: {0}",NotaDeberEstudiante1);
            Console.WriteLine("La nota de Deber de la presentacion 2 es: {0}", NotaDeberEstudiante2);
            Console.WriteLine("La nota de Deber de la presentacion del Examen Final Primer Parcial es: {0}", NotaExamenEstudiante1);
            Console.WriteLine("La nota de Deber de la presentacion del Examen Final Segundo Parcial es : {0}", NotaExamenEstudiante2);

            Profesor profesor = new Profesor
            {
                notaDeberEstudiante1= NotaDeberEstudiante1,
                notaDeberEstudiante2= NotaDeberEstudiante2,
                notaExamenEstudiante1= NotaExamenEstudiante1,
                notaExamenEstudiante2= NotaExamenEstudiante2
            };

            Console.WriteLine("La nota Final del Semestre en Deberes de los dos Parciales es: {0}", profesor.CalificarDeberes(NotaDeberEstudiante1, NotaDeberEstudiante2));
            Console.WriteLine("La nota Final del Semestre en Examenes de los dos Parciales es: {0}", profesor.CalificarExamen(NotaExamenEstudiante1, NotaExamenEstudiante2));
        }
    }
}