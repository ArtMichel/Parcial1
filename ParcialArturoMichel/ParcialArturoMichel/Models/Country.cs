using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ParcialArturoMichel.Models
{
    public class Country
    {
        [Key]
        [Required]
        [StringLength(3, ErrorMessage = "El Alphacode debe ser de 3 caracteres",MinimumLength = 3)]
        public string Alpha3code { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Revise su region", MinimumLength = 2)]
        public string Region { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Nombre invalido", MinimumLength = 2)]
        public string Name { get; set; }
        [Required]
        [Range(1, 99999999)]
        public int Area { get; set; }
        [Required]
        public List<string> Callingcodes { get; set; }
        [Required]
        public List<string> Languages { get; set; }
        [Required]
        [Url]
        public string Flag { get; set; }
    }
}