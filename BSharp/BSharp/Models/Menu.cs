﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HNCHOME.Models
{
    public class Menu
    {
        [Key]
        public Guid MenuId { get; set; }
        public string? Title { get; set; }
        public string? Link { get; set; }
        public Guid ParentId { get; set; }
        [ForeignKey("LanguageId")]
        public Guid LanguageId { get; set; }
        public Language Language { get; set; }

    }
}
