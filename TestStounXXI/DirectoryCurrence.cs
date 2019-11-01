
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestStounXXI
{
    public class DirectoryCurr
    {
        public int Id { get; set;} 
        public string CharCode { get; set; }       
        public string CurrencyCode { get; set; }       
    }
}