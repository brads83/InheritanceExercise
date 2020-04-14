using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{ // give this class 4 members that are specific to Bird
  // Set this class to inherit from your Animal Class
    public class Bird : Animal
    {

        public Bird()
        {
        }
        public string Feathers { get; set; }
        public string Wings { get; set; }
        public string Beak { get; set; }
        public string Call { get; set; }
    }
}
