using Cedeira.Essentials.NET.Diagnostics.Invariants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Cedmt_DomainCore.Channel.ValueObjects
{
    public class Meta
    {
        public int Total { get; }
        public int Page { get; }
        public int Limit { get; }

        protected Meta(int total, int page, int limit)
        {
            Total = total;
            Page = page;
            Limit = limit;
        }

        public static Meta Create(int total, int page, int limit)
        {
            //Todo incuir el  custom invariant.

            Invariants.For(total).IsNotNull();
            Invariants.For(page).IsNotNull();
            Invariants.For(limit).IsNotNull();

            return new Meta(total, page, limit);
        }

        public string ToString()
        {
            return $"Total: {Total}, Page: {Page}, Limit: {Limit}";
        }
    }
}
