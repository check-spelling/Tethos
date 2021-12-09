﻿namespace Tethos.FakeItEasy.Tests.AutoMockingTest.Configuration.IncludeNonPublicTypes
{
    using AutoFixture.Xunit2;
    using FluentAssertions;
    using global::FakeItEasy;
    using Tethos.Tests.Common;
    using Xunit;

    public class PropertyNonPublicTypesEnabledTests : FakeItEasy.AutoMockingTest
    {
        public override AutoMockingConfiguration AutoMockingConfiguration => new() { IncludeNonPublicTypes = true };

        [Theory]
        [AutoData]
        [Trait("Category", "Integration")]
        public void Resolve_WithIncludeNonPublicTypesEnabled_ShouldMatch(int expected)
        {
            // Arrange
            var sut = this.Container.Resolve<InternalSystemUnderTest>();
            var mock = this.Container.Resolve<IMockable>();
            A.CallTo(() => mock.Get()).Returns(expected);

            // Act
            var actual = sut.Exercise();

            // Assert
            actual.Should().Be(expected);
        }
    }
}