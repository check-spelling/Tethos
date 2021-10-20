﻿using Castle.MicroKernel;
using Moq;
using System;

namespace Tethos.Tests.SUT
{
    internal class ConcreteAutoResolver : AutoResolver
    {
        public ConcreteAutoResolver(IKernel kernel) : base(kernel)
        {
        }

        public override Type DiamondType => typeof(Mock<>);

        public override object MapToTarget(object targetObject, Type targetType) => (Mock)targetObject;
    }
}
