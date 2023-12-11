using ClinicaPublic.Repositories;
using ClinicaPublic.Services.Service;
using Moq;
using System.Security.Principal;

namespace ClinicaPublic.Test
{
    public class TestExamen
    {
        [Fact]
        public void InsertExamen()
        {
            // Arrange
            var examen = new Examen();
            examen.Id = 0;
            examen.Nombre = "Test name";
            examen.Precio = 100;

            var mockRepository = new Mock<IExamenRepository>();
            var result = false;
            mockRepository.Setup(r => r.Insert(examen)).Returns(result);
            var sut = new ExamenService(mockRepository.Object);

            // Act

            bool expected = sut.Insert(new Examen
            {
                Id = 0,
                Nombre = "Examen 2",
                Precio = 250,
                FechaRegistro = DateTime.UtcNow
            });

            // Assert
            Assert.True(expected == result);
        }
    }
}