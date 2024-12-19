namespace Cedmt_DomainCore.Abstractions
{
    public abstract class ValueObjects<T>
    {
        protected readonly T Value;

        internal ValueObjects(T value)
        {
            Value = value;
        }

        public string ToString()
        {
            return Value.ToString();
        }
    }
}
