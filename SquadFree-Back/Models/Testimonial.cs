using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SquadFree_Back.Models
{
    public class Testimonial
    {
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
        public string Url { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Professsion { get; set; }
        [NotMapped,Required]
        public IFormFile Photo { get; set; }
    }
}
