using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{ // give this class 4 members that are specific to Reptile
  // Set this class to inherit from your Animal Class
    public class Reptile
    {
        public Reptile()
        {
        }
        public string Scales { get; set; }
        public string Eggs { get; set; }
        public string Shell { get; set; }
        public string ColdBlooded { get; set; }

    }
}
