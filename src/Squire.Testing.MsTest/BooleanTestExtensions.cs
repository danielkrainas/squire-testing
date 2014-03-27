namespace Squire.Testing.MsTest
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class BooleanTestExtensions
    {
        public static FluentAnd<FluentShould<bool>> BeTrue(this FluentShould<bool> should)
        {
            Assert.IsTrue(should.Target);
            return new FluentAnd<FluentShould<bool>>(should);
        }

        public static FluentAnd<FluentShould<bool>> BeFalse(this FluentShould<bool> should)
        {
            Assert.IsFalse(should.Target);
            return new FluentAnd<FluentShould<bool>>(should);
        }
    }
}
