using Cedeira.Essentials.NET.Diagnostics.Invariants;
using Cedmt_DomainCore.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Cedmt_DomainCore.Channel.ValueObjects
{
    public class Subscriptions : ValueObjects<int>
    {
        protected Subscriptions(int value) : base(value) { }

        public static Subscriptions Create(int value)
        {
            Invariants.For(value).IsNotNull();

            return new Subscriptions(value);
        }
    }
}
