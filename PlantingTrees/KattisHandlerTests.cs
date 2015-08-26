using System;
using System.IO;
using System.Text;
using NUnit.Framework;

namespace PlantingTrees
{
    [TestFixture]
    public class KattisHandlerTests
    {
        [Test]
        public void Should_ProcessInput()
        {
            // Arrange
            const string sampleInput = "4\n2 3 4 3";
            using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(sampleInput)))
            {
                // Act
                KattisHandler handler = new KattisHandler(ms);

                // Assert
                Assert.That(handler.N, Is.EqualTo(4));
                CollectionAssert.AreEqual(handler.Trees, new[] { 2, 3, 4, 3 });
            }
        }

        [Test]
        public void ReadInt_Should_CorrectlyRead1()
        {
            // Arrange
            var reader = new StringReader("1");

            // Act
            var result = KattisHandler.ReadInt(reader);

            // Assert
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void ReadInt_Should_CorrectlyRead123456()
        {
            // Arrange
            var reader = new StringReader("1230456");

            // Act
            var result = KattisHandler.ReadInt(reader);

            // Assert
            Assert.That(result, Is.EqualTo(1230456));
        }

        [Test]
        public void Solve_Should_GiveCorrectAnswer()
        {
            // Arrange
            KattisHandler handler = new KattisHandler();
            handler.N = 6;
            handler.Trees = new[] { 39, 38, 9, 39, 20 };
            const int expectedResult = 42;

            // Act
            var result = handler.Solve();

            // Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Solve_Should_GiveCorrectAnswer2()
        {
            // Arrange
            KattisHandler handler = new KattisHandler();
            handler.N = 4;
            handler.Trees = new[] { 2, 3, 4, 3 };
            const int expectedResult = 7;

            // Act
            var result = handler.Solve();

            // Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
