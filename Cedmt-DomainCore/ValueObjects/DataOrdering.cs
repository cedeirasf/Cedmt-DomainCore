using Cedeira.Essentials.NET.Diagnostics.Invariants;
using System.Collections.Generic;

namespace Cedmt_DomainCore.Channel.ValueObjects.CriteriaChannel.DataOrdering
{
    public class DataOrdering
    {
        public string DataSetColumnName { get; }
        public bool OrderData { get; } = true;

        protected DataOrdering (string dataSetColumnName, bool orderData ) 
        {
            DataSetColumnName = dataSetColumnName;
            OrderData = orderData;
        }  
        
        public static DataOrdering Create(string dataSetColumnName, bool orderData)
        {
            Invariants.For(dataSetColumnName).IsNotNullOrEmpty();
            Invariants.For(orderData).IsNotNull();

            return new DataOrdering(dataSetColumnName, orderData); 
        }

        public string ToString()
        {
            return $"DataSetColumName: {DataSetColumnName}, OrderData: {OrderData}";
        }
    }
}
