﻿namespace Tethos.NSubstitute
{
    using System;

    /// <summary>
    /// Static entry-point for generating <see cref="IAutoMockingContainer"/> containers used for auto-mocking.
    /// </summary>
    public class AutoMocking : IDisposable
    {
        private static readonly object Lock = new object();
        [ThreadStatic]
        private static IAutoMockingContainer @object = null;

        private AutoMocking()
        {
            this.IsReleased = false;
        }

        /// <summary>
        /// Gets ready to use auto-mocking container.
        /// </summary>
        public static IAutoMockingContainer Container
        {
            get
            {
                if (@object == null)
                {
                    lock (Lock)
                    {
                        if (@object == null)
                        {
                            @object = new AutoMockingTest().Container;
                        }
                    }
                }

                return @object;
            }
        }

        public bool IsReleased { get; private set; }

        public void Release()
        {
            this.IsReleased = true;
            AutoMocking.@object = null;
        }

        void IDisposable.Dispose()
        {
            this.Release();
        }
    }
}
