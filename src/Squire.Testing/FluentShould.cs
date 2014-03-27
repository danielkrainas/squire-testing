namespace Squire.Testing
{
    public class FluentShould<T>
    {
        public FluentShould(T target)
        {
            this.Target = target;
        }

        public T Target
        {
            get;
            private set;
        }
    }
}
