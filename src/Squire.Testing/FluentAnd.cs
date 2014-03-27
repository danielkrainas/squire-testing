namespace Squire.Testing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class FluentAnd<T>
    {
        public FluentAnd(T target)
        {
            this.And = target;
        }

        public T And
        {
            get;
            private set;
        }
    }
}
