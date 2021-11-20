namespace Tethos.xUnit.Demo
{
    using global::FakeItEasy;
    using Tethos.FakeItEasy;
    using Tethos.Tests.Common;
    using Xunit;

    public class ContainerFromBaseClass : AutoMockingTest
    {
        [Fact]
        [Trait("", "Demo")]
        public void Do_WithMock_ShouldReturn42()
        {
            // Arrange
            var expected = 42;
            var sut = this.Container.Resolve<SystemUnderTest>();
            var mock = this.Container.Resolve<IMockable>();

            A.CallTo(() => mock.Do()).Returns(expected);

            // Act
            var actual = sut.Do();

            // Assert
            Assert.Equal(actual, expected);
        }
    }
}
