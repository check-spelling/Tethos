using FluentAssertions;
using Tethos;
using Tethos.Tests.Common;
using Xunit;

namespace ReferencedAssemblies.Tests
{
    public class BaseAutoMockingTestTests : BaseAutoMockingTest<AutoMockingContainer>
    {
        [Fact]
        public void Test_SimplyDependency_ShouldMatchValue()
        {
            // Arrange
            var sut = Container.Resolve<SystemUnderTest>();

            // Act
            var actual = sut.Do();

            // Assert
            actual.Should().BeInRange(0, 10);
        }
    }
}
