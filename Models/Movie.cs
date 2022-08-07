using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Vidly.Models
{
    [ValidateAntiForgeryToken]
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        public string Genre { get; set; }
        public string ReleaseDate { get; set; }
        public DateTime DateAdded { get; set; }
        [Required]
        [Range(1, 20)]
        public int NumberInStock { get; set; }
    }
    }

