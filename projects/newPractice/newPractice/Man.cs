using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newPractice
{
    public class Man
    {
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Occupation { get; set; }

        public void ChangeGender ()
        {
            string newGender = Gender == "Man" ? "Woman" : "Man";
            Gender = newGender;
        }
        public bool CanDriveCar ()
        {
            return Age < 18;
        }

    }
}
