using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace IMDB.Models
{
    public class IMViewModel
    {
        public int MovieId { get; set; }
        [Required]
        public string MovieName { get; set; }
        [CustomValidation(typeof(Validator),"ValidateActors")]
        public List<Actor> Actors { get; set; }
        public List<SelectListItem> ActorsList { get; set; }
        [CustomValidation(typeof(Validator), "ValidateProducer")]
        public Producer Producer { get; set; }

        public int ProducerId { get; set; }
    }
    public class Validator
    {

        public static ValidationResult ValidateActors(List<Actor> actors)
        {
            if (actors == null || (actors != null && actors.Count() <= 0))
            {
                return new ValidationResult("Actors field is required:");
            }
            return ValidationResult.Success;
        }
        public static ValidationResult ValidateProducer(Producer producer)
        {
            if (producer == null || (producer != null && string.IsNullOrWhiteSpace(producer.Name)))
            {
                return new ValidationResult("Producer field is required:");
            }
            return ValidationResult.Success;
        }
    }
}
