namespace Squire.Testing.MsTest
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class ShouldExtensions
    {
        public static FluentAnd<FluentShould<T>> Be<T>(this FluentShould<T> should, T expected)
        {
            Assert.AreEqual(expected, should.Target);
            return new FluentAnd<FluentShould<T>>(should);
        }

        public static FluentAnd<FluentShould<T>> NotBe<T>(this FluentShould<T> should, T value)
        {
            Assert.AreNotEqual(value, should.Target);
            return new FluentAnd<FluentShould<T>>(should);
        }
    }
}
