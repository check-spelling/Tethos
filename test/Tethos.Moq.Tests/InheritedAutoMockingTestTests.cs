﻿namespace Tethos.Moq.Tests
{
    using AutoFixture.Xunit2;
    using global::Moq;
    using Tethos.Moq.Tests.SUT;
    using Xunit;

    public class InheritedAutoMockingTestTests
    {
        [Theory]
        [AutoData]
        [Trait("Category", "Unit")]
        public void Dispose_ShouldDisposeMock(InheritedAutoMockingTest sut)
        {
            // Act
            sut.Dispose();

            // Assert
            sut.Proxy.Verify(mock => mock.Dispose(), Times.Once);
        }

        [Theory]
        [AutoData]
        [Trait("Category", "Unit")]
        public void Dispose_NullContainer_ShouldNotDisposeMock(InheritedAutoMockingTest sut)
        {
            // Arrange
            sut.Container = null;

            // Act
            sut.Dispose();

            // Assert
            sut.Proxy.Verify(mock => mock.Dispose(), Times.Never);
        }
    }
}
