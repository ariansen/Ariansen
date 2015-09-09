using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Web;

namespace Ariansen.Models
{
    public class Blogger : IEntity
    {   [Key]
        public int Id { get; set; }
        public String Heading { get; set; }
        public String Ingress { get; set; }
        public String BlogText { get; set; }
        public String CategoryId { get; set; }
        public int BlogParentId { get; set; }
        public ICollection<Category> Categories  { get; set; }
        public IRecursiveEntity<Blogger> Comments { get; set; } 
    }
}