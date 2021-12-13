using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAPanel.Models
{
    public class Setting
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string LogoImage { get; set; }
        [NotMapped]
        public IFormFile IformFile { get; set; }
        [MaxLength(50)]
        public string Address { get; set; }
        [MaxLength(100)]
        public string Phone { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(250)]
        public string WebSite { get; set; }
    }
}
