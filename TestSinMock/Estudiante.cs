namespace PruebaSinMock
{
    internal class Estudiante
    {
        public bool ApruebaMateria { get; internal set; }
        public bool AplicaBeca { get; internal set; }

        internal void RevisarNota(int minimoNota, int calificacionMateria1)
        {
            if (calificacionMateria1 >= minimoNota)
            {
                ApruebaMateria = true;
            }
            else if (calificacionMateria1 <= minimoNota)
            {
                ApruebaMateria = true;
            }
        }

        internal void RevisarNotaParaAplicarBeca(int minimoNota, int calificacionMateria1)
        {
            if (calificacionMateria1 >= minimoNota)
            {
                AplicaBeca = true;
            }
        }
    }
}