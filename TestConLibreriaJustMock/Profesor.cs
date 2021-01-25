using System;

namespace PruebaJustMock
{
    internal class Profesor
    {
        public Profesor()
        {
        }

        public bool ApruebaEstudiante { get; internal set; }

        internal void CalificarExamen(Estudiante estudiante, int notaExamenFinal, string materia)
        {
            throw new NotImplementedException();
        }
    }
}