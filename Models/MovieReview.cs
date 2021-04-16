using System;
using System.ComponentModel.DataAnnotations;

namespace Movie.Models
{
    public class MovieReview
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        
        public string Review { get; set; }
	    public int MovieId { get; set; }
    }
}