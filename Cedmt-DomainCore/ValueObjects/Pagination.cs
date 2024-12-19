using Cedeira.Essentials.NET.Diagnostics.Invariants;

namespace Cedmt_DomainCore.Channel.ValueObjects.CriteriaChannel.Pagination
{
    public class Pagination 
    {
        public int PageNumber { get; }
        public int RecordsNumber { get; }

        public  Pagination(int pageNumber, int recordsNumber)
        { 
            PageNumber = pageNumber;   
            RecordsNumber = recordsNumber;
        }

        public static Pagination Create(int pageNumber, int recordsNumber) 
        {
            //Todo : sumar invariant custom 

            Invariants.For(pageNumber).IsNotNull(); 
            Invariants.For(recordsNumber).IsNotNull();  

            return new Pagination(pageNumber, recordsNumber); 
        }     

        public string ToString()
        {
            return $"PageNumber: {PageNumber}, RecordsNumber: {RecordsNumber} ";
        }          

    }
}
