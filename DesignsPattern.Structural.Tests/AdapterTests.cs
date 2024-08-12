using DesignsPattern.Structural.Adapter;
using DesignsPattern.Structural.Adapter.Model;
using FluentAssertions;
using Moq;

namespace DesignsPattern.Structural.Tests
{
    public class Tests
    {
        [TestFixture]
        public class AdapterTests
        {
            private Mock<ExternalApiRepsonse> _mockExternalApiService;
            private PersonServiceAdapter _personServiceAdapter;

            [SetUp]
            public void SetUp()
            {
                _mockExternalApiService = new Mock<ExternalApiRepsonse>();
                _personServiceAdapter = new PersonServiceAdapter(_mockExternalApiService.Object);
            }

            [Test]
            public void GetPersonDetails_ReturnsPersonDetailsInJsonFormat()
            {
                // Arrange
                double testId = 123;
                string xmlResponse = "<person><id>123</id><name>Sim Dlamuka</name><age>30></age><address>26 Dr langalibalele dube street</address></person>";
                string expectedJsonResponse = "{\"person\":{\"id\":\"123\",\"name\":\"Sim Dlamuka\",\"age\":\"30\",\"address\":\"26 Dr langalibalele dube street\"}}";

                _mockExternalApiService
                    .Setup(x => x.GetPersonDetailsXml(testId))
                    .Returns(xmlResponse);

                // Act
                string actualJsonResponse = _personServiceAdapter.GetPersonDetails(testId);

                // Assert
                expectedJsonResponse.Should().Be(expectedJsonResponse);
            }

            [Test]
            public void GetPersonDetails_InvalidId_ReturnsErrorMessage()
            {
                // Arrange
                double invalidId = -1;
                string expectedErrorMessage = "Invalid ID provided";

                _mockExternalApiService
                    .Setup(x => x.GetPersonDetailsXml(invalidId))
                    .Returns((string)null);

                // Act
                string actualJsonResponse = _personServiceAdapter.GetPersonDetails(invalidId);

                // Assert
                actualJsonResponse.Should().Be(expectedErrorMessage);
            }
        }
    }
}
