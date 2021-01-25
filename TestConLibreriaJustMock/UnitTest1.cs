using Microsoft.VisualStudio.TestTools.UnitTesting;
using Telerik.JustMock;
using Telerik.JustMock.Helpers;

namespace PruebaJustMock
{
    [TestClass]
    public class AprobarMateria
    {
        [TestMethod]
        public void DadoQueExisteExamenParcialUnoYDosDeEstudianteCuandoSeaMayorQue7PuedeAprobarLaMateria()
        {
            string Materia = "Semiotica 1";
            int CalificacionExamen1 = 7;
            //int CalificacionExamen2 = 8;

            var profesor = Mock.Create<Profesor>();
            profesor.Arrange(notasEstudianteExamenPrimerParcial
                => notasEstudianteExamenPrimerParcial.CalificarExamen(Materia))
                .Returns(CalificacionExamen1);

            Estudiante estudiante = new Estudiante();
            estudiante.RevisaSuNota(profesor,CalificacionExamen1,Materia);

            Assert.IsTrue(estudiante.ApruebaLaMateria);
            profesor.Assert(notasEstudianteExamenPrimerParcial
                => notasEstudianteExamenPrimerParcial.CalificarExamen(Materia));
        }
    }
}
