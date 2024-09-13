using NUnit.Framework;
using Moq;
using DesignsPattern.Structural.Bridge;
using DesignsPattern.Utils.Display;
using FluentAssertions;
using DesignsPattern.Structural.Builder;

namespace DesignsPattern.Tests.Structural.Bridge
{
  

    namespace DesignsPattern.Tests.Structural.Bridge
    {
        [TestFixture]
        public class BridgerTests
        {
            [Test]
            public void ShouldSelectFuneralPolicyAndBuyCorrectly()
            {
                // Arrange
                var bridgerdata = new Mock<IOutput>();
                var builder = new BridgerBuilder()
                    .WithOutput(bridgerdata.Object)
                    .WithPolicyOption("1")
                    .WithActionOption("1");

                var bridger = builder.Build();

                // Act
                bridger.Run("1");

                // Assert
                bridgerdata.Verify(o => o.Display("Funeral Policy selected."), Times.Once);
                bridgerdata.Invocations.Should().ContainSingle(invocation => invocation.Arguments[0].ToString().Contains("Funeral Policy selected."));
            }

            [Test]
            public void ShouldSelectLifePolicyAndBuyFullCorrectly()
            {
                // Arrange
                var bridgerdata = new Mock<IOutput>();
                var builder = new BridgerBuilder()
                    .WithOutput(bridgerdata.Object)
                    .WithPolicyOption("2")
                    .WithActionOption("3");

                var bridger = builder.Build();

                // Act
                bridger.Run("2");

                // Assert
                bridgerdata.Verify(o => o.Display("Life Policy selected."), Times.Once);
                bridgerdata.Invocations.Should().ContainSingle(invocation => invocation.Arguments[0].ToString().Contains("Life Policy selected."));
            }

            [Test]
            public void ShouldDisplayInvalidPolicyOption()
            {
                // Arrange
                var bridgerdata = new Mock<IOutput>();
                var builder = new BridgerBuilder()
                    .WithOutput(bridgerdata.Object)
                    .WithPolicyOption("3");

                var bridger = builder.Build();

                // Act
                bridger.Run("3");

                // Assert
                bridgerdata.Verify(o => o.Display("Invalid option."), Times.Once);
                bridgerdata.Invocations.Should().ContainSingle(invocation => invocation.Arguments[0].ToString().Contains("Invalid option."));
            }

            [Test]
            public void ShouldDisplayInvalidActionOption()
            {
                // Arrange
                var bridgerdata = new Mock<IOutput>();
                var builder = new BridgerBuilder()
                    .WithOutput(bridgerdata.Object)
                    .WithPolicyOption("1")
                    .WithActionOption("4");

                var bridger = builder.Build();

                // Act
                bridger.Run("1");

                // Assert
                bridgerdata.Verify(o => o.Display("Invalid action."), Times.Once);
                bridgerdata.Invocations.Should().ContainSingle(invocation => invocation.Arguments[0].ToString().Contains("Invalid action."));
            }
        }
    }

}
