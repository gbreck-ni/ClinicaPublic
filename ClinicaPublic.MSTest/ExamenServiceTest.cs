using ClinicaPublic.Repositories;
using ClinicaPublic.Services.Service;
using Moq;
using System.Security.Principal;

namespace ClinicaPublic.MSTest
{
    [TestClass]
    public class ExamenServiceTest
    {
        [TestMethod]
        public void InsertExamenServiceTest()
        {
            //
            // Arrange
            //
            var examen = new Examen();
            bool insertRepositoryResult = false;

            var mockRepository = new Mock<IExamenRepository>();
            mockRepository.Setup(r => r.Insert(examen)).Returns(insertRepositoryResult);
            var sut = new ExamenService(mockRepository.Object); // sut: System Under Test

            //
            // Act
            //
            bool expected = sut.Insert(new Examen
            {
                Id = 0,
                Nombre = "Examen 2",
                Precio = 250,
                FechaRegistro = DateTime.UtcNow
            });

            //
            // Assert
            //
            Assert.AreEqual(expected, insertRepositoryResult);
        }

        [TestMethod]
        public void UpdateExamenServiceTest()
        {
            //
            // Arrange
            //
            var examen = new Examen();
            bool repositoryResult = false;

            var mockRepository = new Mock<IExamenRepository>();
            mockRepository.Setup(r => r.Update(examen)).Returns(repositoryResult);
            var sut = new ExamenService(mockRepository.Object); // sut: System Under Test

            //
            // Act
            //
            bool expected = sut.Update(new Examen
            {
                Id = 2,
                Nombre = "Examen 2",
                Precio = 250,
                FechaRegistro = DateTime.UtcNow
            });

            //
            // Assert
            //
            Assert.AreEqual(expected, repositoryResult);
        }
    }
}