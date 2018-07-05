using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMDB.Models
{
    public class Movie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MovieId { get; set; }
        public string Name { get; set; }
        public List<MovieActor> MovieActors { get; set; }
        public int ProducerId { get; set; }
        public Producer Producer { get; set; }
    }
}
