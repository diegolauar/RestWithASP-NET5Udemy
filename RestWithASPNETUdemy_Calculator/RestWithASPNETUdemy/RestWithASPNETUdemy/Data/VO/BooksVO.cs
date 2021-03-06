using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithASPNETUdemy.Model
{
    public class BooksVO 
    {
        public long Id { get; set; }
        public string Author { get; set; }        
        public DateTime LaunchDate { get; set; }     
        public decimal Price { get; set; }  
        public string Title { get; set; }
    }
}