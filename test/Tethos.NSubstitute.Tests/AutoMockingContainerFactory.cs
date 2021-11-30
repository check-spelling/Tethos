﻿namespace Tethos.NSubstitute.Tests
{
    using FluentAssertions;
    using global::NSubstitute;
    using Tethos.NSubstitute.Tests.Attributes;
    using Tethos.Tests.Common;
    using Xunit;

    public class AutoMockingContainerFactory
    {
        [Theory]
        [FactoryContainerData]
        [Trait("Category", "Integration")]
        public void Create_SimpleDependency_ShouldMatchValue(
            IAutoMockingContainer container,
            int expected)
        {
            // Arrange
            var sut = container.Resolve<SystemUnderTest>();
            container.Resolve<IMockable>()
                .Get()
                .Returns(expected);

            // Act
            var actual = sut.Exercise();

            // Assert
            actual.Should().Be(expected);
        }
    }
}