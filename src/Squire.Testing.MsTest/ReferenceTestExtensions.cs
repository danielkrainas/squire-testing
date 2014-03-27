namespace Squire.Testing.MsTest
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class ReferenceTestExtensions 
    {
        public static FluentAnd<FluentShould<T>> BeTheSameAs<T>(this FluentShould<T> should, T expected)
            where T : class
        {
            Assert.AreSame(expected, should.Target);
            return new FluentAnd<FluentShould<T>>(should);
        }

        public static FluentAnd<FluentShould<T>> BeNull<T>(this FluentShould<T> should)
            where T : class
        {
            Assert.IsNull(should.Target);
            return new FluentAnd<FluentShould<T>>(should);
        }

        public static FluentAnd<FluentShould<T>> NotBeNull<T>(this FluentShould<T> should)
            where T : class
        {
            Assert.IsNotNull(should.Target);
            return new FluentAnd<FluentShould<T>>(should);
        }
    }
}
