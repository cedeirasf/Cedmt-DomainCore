using Cedeira.Essentials.NET.Diagnostics.Invariants;

namespace Cedmt_DomainCore.Channel.ValueObjects.CriteriaChannel.Filter
{
    public class Filter
    {
        protected string DataSetColumnName { get; }
        public string Operator { get; }
        public string Value { get; }

        protected Filter(string dataSetColumnName, string Operator, string Value)
        {
            DataSetColumnName = dataSetColumnName;
            this.Operator = Operator;
            this.Value = Value;
        }

        public static Filter Create(string dataSetColumnName, string Operator, string Value)
        {
            Invariants.For(dataSetColumnName).IsNotNullOrEmpty();
            Invariants.For(Operator).IsNotNullOrEmpty();
            Invariants.For(Value).IsNotNullOrEmpty();

            string ConvertedOperator = ConvertOperator(Operator);

            return new Filter(dataSetColumnName, ConvertedOperator, Value);
        }

        private static string ConvertOperator(string Operator)
        {
            return Operator switch
            {
                "=" => "==",
                "!=" => "!=",
                ">" => ">",
                "<" => "<",
                ">=" => ">=",
                "<=" => "<=",
                "beginsWith" => "LIKE",
                "in" => "IN",
                "contains" => "Contains",
                "startsWith" => "StartsWith",
                "endsWith" => "EndsWith",
                "between" => "BETWEEN",
                "isnull" => "isnull",
                "isnotnull" => "isnotnull",
                _ => throw new ArgumentException($"Operador no soportado: {Operator}")
            };
        }

        public string ToString()
        {
            return $"DataSetColumName: {DataSetColumnName}, Operator: {this.Operator}, Value:  {this.Value}";
        }

    }
}
