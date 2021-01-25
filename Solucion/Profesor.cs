namespace SolucionConsola
{
    public class Profesor : IProfesor
    {
        public int notaDeberEstudiante1 { get; internal set; }
        public int notaDeberEstudiante2 { get; internal set; }
        public int notaExamenEstudiante1 { get; internal set; }
        public int notaExamenEstudiante2 { get; internal set; }
        int NotaFinalDeberes;
        int NotaFinalExamen;

        public int CalificarDeberes(int deber1, int deber2)
        {
            notaDeberEstudiante1 = deber1;
            notaDeberEstudiante2 = deber2;
            NotaFinalDeberes = notaDeberEstudiante2 + notaDeberEstudiante2;
            return  NotaFinalDeberes / 2;
        }

        public int CalificarExamen(int notaExamen1, int notaExamen2)
        {
            notaExamenEstudiante1 = notaExamen1;
            notaExamenEstudiante2 = notaExamen2;
            NotaFinalExamen = notaExamenEstudiante1 + notaExamenEstudiante1;
            return NotaFinalExamen / 2;
        }
    }
}