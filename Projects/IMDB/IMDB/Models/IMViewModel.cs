using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace IMDB.Models
{
    public class IMViewModel
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public List<Actor> Actors { get; set; }
        public List<SelectListItem> ActorsList { get; set; }
        public Producer Producer { get; set; }
        public int ProducerId { get; set; }
    }
}
