using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestStounXXI
{
    public class ExchangeRat
    {  
        public int Id { get; set; }
        public DateTime Data { get; set; }   
        public string CharCode { get; set; } 
        public decimal Rate { get; set; }    
    }
}