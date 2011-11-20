using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Swtor.Business.Entities
{
    public class Text
    {
        public int TextId { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }

        public Text()
        {
            DateCreated = DateTime.Now;
        }
    }
}
