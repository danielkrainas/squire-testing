namespace Squire.Testing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class ShouldExtensions
    {
        public static FluentShould<T> Should<T>(this T target)
        {
            return new FluentShould<T>(target);
        }
    }
}
