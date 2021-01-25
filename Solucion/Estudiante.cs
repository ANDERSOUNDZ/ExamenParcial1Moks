namespace SolucionConsola
{
    internal class Estudiante : IEstudiante
    {
        int NotafinalExpocision1;
        int NotafinalExpocision2;
        int NotaFinalParcialExamen1;
        int NotaFinalParcialExamen2;

        public int NotasDeberPresentacion1(int Exposicion, int Presentacion)
        {
            NotafinalExpocision1 = Exposicion + Presentacion;
            return NotafinalExpocision1/2;
        }

        public int NotasDeberPresentacion2(int Exposicion, int Presentacion)
        {
            NotafinalExpocision2 = Exposicion + Presentacion;
            return NotafinalExpocision2 / 2;
        }

        public int NotasExposicionFinalExamenParcial1(int Exposicion, int Presentacion)
        {
            NotaFinalParcialExamen1 = Exposicion + Presentacion;
            return NotaFinalParcialExamen1 / 2;
        }

        public int NotasExposicionFinalExamenParcial2(int Exposicion, int Presentacion)
        {
            NotaFinalParcialExamen2 = Exposicion + Presentacion;
            return NotaFinalParcialExamen2 / 2;
        }
    }
}