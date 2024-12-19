using Cedeira.Essentials.NET.Diagnostics.Invariants;
using Cedmt_DomainCore.Abstractions;

namespace Cedmt_DomainCore.Channel.ValueObjects
{
    public class KeyChannel : ValueObjects<string>
    {
        protected string Value { get; }

        protected KeyChannel(string value) : base(value) { }

        public static KeyChannel Create(string value)
        {
            Invariants.For(value).IsNotNullOrEmpty();

            return new KeyChannel(value);
        }

    }
}
