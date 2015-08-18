using System.Collections.Generic;
using System.Linq;
using BaseApp.Web.Controllers;
using BaseApp.Web.Controllers.APIs;
using NUnit.Framework;

namespace BaseApp.Tests.Web.Controllers
{
    [TestFixture]
    public class ExamplesControllerTest
    {
        [Test]
        public void Get()
        {
            // Arrange
            ExamplesController controller = new ExamplesController();

            // Act
            IEnumerable<string> result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
            Assert.AreEqual("value1", result.ElementAt(0));
            Assert.AreEqual("value2", result.ElementAt(1));
        }

        [Test]
        public void GetById()
        {
            // Arrange
            ExamplesController controller = new ExamplesController();

            // Act
            string result = controller.Get(5);

            // Assert
            Assert.AreEqual("value", result);
        }

        [Test]
        public void Post()
        {
            // Arrange
            ExamplesController controller = new ExamplesController();

            // Act
            controller.Post("value");

            // Assert
        }

        [Test]
        public void Put()
        {
            // Arrange
            ExamplesController controller = new ExamplesController();

            // Act
            controller.Put(5, "value");

            // Assert
        }

        [Test]
        public void Delete()
        {
            // Arrange
            ExamplesController controller = new ExamplesController();

            // Act
            controller.Delete(5);

            // Assert
        }
    }
}
