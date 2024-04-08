using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.Data.Entities
{
    public class Exercice
    {
        public int Id { get; set; }

        public string Name { get; set; }
        
        public string Description { get; set; }

        public string DifLevel { get; set; }

        public string MuscleGroup { get; set; }


    
    }
}
