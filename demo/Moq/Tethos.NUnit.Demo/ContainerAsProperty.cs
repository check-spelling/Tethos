namespace Tethos.NUnit.Demo
{
    using global::Moq;
    using global::NUnit.Framework;
    using Tethos.Moq;
    using Tethos.Tests.Common;

    public class ContainerAsProperty
    {
        public ContainerAsProperty()
        {
            this.Container = AutoMockingContainerFactory.Create();
        }

        public IAutoMockingContainer Container { get; }

        [Test]
        [Category("Demo")]
        public void Exercise_WithMock_ShouldReturn42()
        {
            // Arrange
            var expected = 42;
            var sut = this.Container.Resolve<SystemUnderTest>();

            this.Container.Resolve<Mock<IMockable>>()
                .Setup(mock => mock.Get())
                .Returns(expected);

            // Act
            var actual = sut.Exercise();

            // Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
