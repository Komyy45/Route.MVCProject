using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route.MVCProject.DAL.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Code is Required!")]
        public string Code { get; set; } = null!;

        [Required(ErrorMessage = "Name is Required!")]
        public string Name { get; set; } = null!;
        

        [Display(Name = "Creation Date")]
        public DateOnly CreationDate { get; set; }
    }
}
