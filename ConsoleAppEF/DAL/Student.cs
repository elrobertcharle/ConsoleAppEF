using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEF.DAL
{
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int CourseId { get; set; }
        [ForeignKey(nameof(CourseId))]

        public int Score { get; set; }
        public virtual Course? Course { get; set; }
    }
}
