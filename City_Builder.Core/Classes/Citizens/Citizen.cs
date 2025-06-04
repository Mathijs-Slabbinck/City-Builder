using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using City_Builder.Core.Interfaces;
using City_Builder.Core.Classes;
using City_Builder.Core.Enums;

namespace City_Builder.Core.Classes.Citizens
{
    public abstract class Citizen : ICitizen
    {
        protected string firstName;
        protected string lastName;
        protected Genders gender;
        private int age;
        private int happiness;
        private int level;
        private int energy;
        private int strength;
        private int perception;
        private int endurance;
        private int charisma;
        private int intelligence;
        private int agility;
        private int luck;

        public string FirstName
        {
            get { return firstName; }
        }

        public string LastName
        {
            get { return lastName; }
        }

        public Genders Gender
        {
            get { return gender; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public int Happiness
        {
            get { return happiness; }
            set { happiness = value; 
                  if(happiness > 100)
                  {
                    happiness = 100;
                  }

                  if(happiness <= 0)
                  {
                    // TO DO
                  }
                }
        }

        public int Level
        {
            get { return level; }
            protected set { level = value; }
        }

        public int Energy
        {
            get { return energy; }
            protected set
            {
                energy = value;
                if (energy > 100)
                {
                    energy = 100;
                }

                if (energy <= 0)
                {
                    // TO DO
                }
            }
        }

        // TO DO
        public void LevelUp(Inventory cityInventory, Inventory upgradeCost)
        {

        }

        // TO DO (make the citizen change job and lose levels because of it)
        public void ChangeJob()
        {

        }
    }
}
