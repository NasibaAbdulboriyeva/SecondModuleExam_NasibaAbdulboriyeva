using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondModuleExam.Services.Dtos
{
   public class MovieDto
    {
        public Guid Id { get; set; }
        public string Tittle { get; set; }
        public string Director { get; set; }
        public int DurationMinutes { get; set; }
        public double Rating { get; set; }
        public long BoxOfficeEarnings { get; set; }
        public DateTime RealeseDate { get; set; }
    }
}
