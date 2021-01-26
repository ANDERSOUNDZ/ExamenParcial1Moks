using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebaSinMock
{
    [TestClass]
    public class AprobarMateriaSinMock
    {
        [TestMethod]
        public void DadoQueExisteExamenDelParcialDeEstudianteCuandoSeaMayorQue7PuedeAprobarLaMateria()
        {
            int minimoNota = 7;
            int calificacionMateria1 = 8;

            Estudiante estudiante = new Estudiante();
            estudiante.RevisarNota(minimoNota, calificacionMateria1);

            Assert.IsTrue(estudiante.ApruebaMateria);
        }

        [TestMethod]
        public void DadoQueExisteExamenDelParcialDeEstudianteCuandoSeaMenorQue7NoApruebaLaMateria()
        {
            int minimoNota = 7;
            int calificacionMateria1 = 3;

            Estudiante estudiante = new Estudiante();
            estudiante.RevisarNota(minimoNota, calificacionMateria1);

            Assert.IsTrue(estudiante.ApruebaMateria);
        }

        [TestMethod]
        public void DadoQueExisteExamenDelParcialDeEstudianteCuandoSeaMayorQue7AplicaAUnaBeca()
        {
            int minimoNota = 8;
            int calificacionMateria1 = 9;

            Estudiante estudiante = new Estudiante();
            estudiante.RevisarNotaParaAplicarBeca(minimoNota, calificacionMateria1);

            Assert.IsTrue(estudiante.AplicaBeca);
        }
    }
}
