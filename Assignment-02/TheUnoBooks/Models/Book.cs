using System;
using System.ComponentModel.DataAnnotations;

namespace TheUnoBooks.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }

    }
}