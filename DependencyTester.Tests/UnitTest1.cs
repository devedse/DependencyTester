using Moq;
using System;
using Xunit;

namespace DependencyTester.Tests
{
    public class LoggerTest
    {
        [Fact]
        public void AddsDateTime()
        {
            //Arrange
            var writer = new Mock<IWriter>();
            var logger = new Logger(writer.Object);

            //Act
            logger.LogString("Hoi");

            //Assert
            writer.Verify(t => t.WriteLine(It.Is<string>(z => z.Length > 5)), Times.Once());
        }
    }
}
