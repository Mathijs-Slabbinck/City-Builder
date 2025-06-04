using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using City_Builder.Core.Enums;

namespace City_Builder.Core.Classes.Citizens
{
    public class WoodCutter : Citizen
    {
        private readonly JobTypes job;

        public JobTypes Job
        {
            get { return job; }
        }


        public WoodCutter(string firstName, string lastName, Genders gender, JobTypes job, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.job = job;
            Age = age;
            Happiness = 100;
            Level = 1;
            Energy = 100;
        }
    }
}
