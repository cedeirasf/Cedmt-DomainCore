using Cedeira.Essentials.NET.Diagnostics.Invariants;

namespace Cedmt_DomainCore.ValueObjects
{
    public class LastSync : ValueObjects<DateTime>
    {
        public LastSync(DateTime value) : base(value) { }
        
        public static LastSync Create(DateTime value) 
        {
            Invariants.For(value).IsNotNull();  

            return new LastSync(value);     
        }    
    }
}
