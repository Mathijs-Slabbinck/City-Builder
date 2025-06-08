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
    public class Citizen : ICitizen
    {
        protected Inventory hiringCost;
        private string firstName;
        private string lastName;
        private Genders gender;
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
        private JobTypes job;

        public string FirstName
        {
            get { return firstName; }
            private set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            private set { lastName = value; }
        }

        public Genders Gender
        {
            get { return gender; }
            private set { gender = value; }
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
                if (happiness > 100)
                {
                    happiness = 100;
                }

                if (happiness <= 0)
                {
                    // TO DO
                }
            }
        }

        public int Level
        {
            get { return level; }
            private set { level = value; }
        }

        public int Energy
        {
            get { return energy; }
            private set
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

        public int Strength
        {
            get { return strength; }
            private set
            {
                if (strength >= 10)
                {
                    throw new ArgumentException("Deze burger's kracht is al max level!");
                }
                strength = value;
            }
        }

        public int Perception
        {
            get { return perception; }
            private set
            {
                if (perception >= 10)
                {
                    throw new ArgumentException("Deze burger's perceptie is al max level!");
                }
                perception = value;
            }
        }

        public int Endurance
        {
            get { return endurance; }
            private set
            {
                if (endurance >= 10)
                {
                    throw new ArgumentException("Deze burger's uithoudingsvermogen is al max level!");
                }
                endurance = value;
            }
        }

        public int Charisma
        {
            get { return charisma; }
            private set
            {
                if (charisma >= 10)
                {
                    throw new ArgumentException("Deze burger's charisma is al max level!");
                }
                charisma = value;
            }
        }

        public int Intelligence
        {
            get { return intelligence; }
            private set
            {
                if (intelligence >= 10)
                {
                    throw new ArgumentException("Deze burger's intelligentie is al max level!");
                }
                intelligence = value;
            }
        }

        public int Agility
        {
            get { return agility; }
            private set
            {
                if (agility >= 10)
                {
                    throw new ArgumentException("Deze burger's behendigheid is al max level!");
                }
                agility = value;
            }
        }

        public int Luck
        {
            get { return luck; }
            private set
            {
                if (luck >= 10)
                {
                    throw new ArgumentException("Deze burger's geluk is al max level!");
                }
                luck = value;
            }
        }

        public JobTypes Job
        {
            get { return job; }
            private set { job = value; }
        }

        public Citizen(string firstName, string lastName, Genders gender, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Age = age;
            happiness = 100;
            Level = 1;
            energy = 100;
            Strength = 1;
            Perception = 1;
            Endurance = 1;
            Charisma = 1;
            Intelligence = 1;
            Agility = 1;
            Luck = 1;
            Job = JobTypes.Werkloos;
        }

        public Citizen(string firstName, string lastName, Genders gender, int age, int level) : this (firstName, lastName, gender, age)
        {
            Level = level;
        }

        public Citizen(string firstName, string lastName, Genders gender, int age, int level, int enegery) : this(firstName, lastName, gender, age, level)
        {
            Energy = enegery;
        }

        public Citizen(string firstName, string lastName, Genders gender, int age, int level, int enegery, int strength) : this(firstName, lastName, gender, age, level, enegery)
        {
            Strength = strength;
        }

        public Citizen(string firstName, string lastName, Genders gender, int age, int level, int enegery, int strength, int perception) : this(firstName, lastName, gender, age, level, enegery, strength)
        {
            Perception = perception;
        }

        public Citizen(string firstName, string lastName, Genders gender, int age, int level, int enegery, int strength, int perception, int endurance) : this(firstName, lastName, gender, age, level, enegery, strength, perception)
        {
            Endurance = endurance;
        }

        public Citizen(string firstName, string lastName, Genders gender, int age, int level, int enegery, int strength, int perception, int endurance, int charisma) : this(firstName, lastName, gender, age, level, enegery, strength, perception, endurance)
        {
            Charisma = charisma;
        }

        public Citizen(string firstName, string lastName, Genders gender, int age, int level, int enegery, int strength, int perception, int endurance, int charisma, int intelligence) : this(firstName, lastName, gender, age, level, enegery, strength, perception, endurance, charisma)
        {
            Intelligence = intelligence;
        }

        public Citizen(string firstName, string lastName, Genders gender, int age, int level, int enegery, int strength, int perception, int endurance, int charisma, int intelligence, int agility) : this(firstName, lastName, gender, age, level, enegery, strength, perception, endurance, charisma, intelligence)
        {
            Agility = agility;
        }

        public Citizen(string firstName, string lastName, Genders gender, int age, int level, int enegery, int strength, int perception, int endurance, int charisma, int intelligence, int agility, int luck) : this(firstName, lastName, gender, age, level, enegery, strength, perception, endurance, charisma, intelligence, agility)
        {
            Luck = luck;
        }

        public Citizen(string firstName, string lastName, Genders gender, int age, int level, int enegery, int strength, int perception, int endurance, int charisma, int intelligence, int agility, int luck, JobTypes job) : this(firstName, lastName, gender, age, level, enegery, strength, perception, endurance, charisma, intelligence, agility, luck)
        {
            Job = job;
        }

        public void LevelUp(City city, CitizenStats stat)
        {
            Inventory upgradeCost;
            int maxStatValue = 10;
            int currentStatValue = 0;

            switch (stat){
                case CitizenStats.level:
                    {
                        int multiplier = ((int)Math.Ceiling(Level * 1.5));
                        // Inventory in order : treeTrunks, planks, stones, iron, goldOres, gold, hay, bread, meat, electricity, money
                        upgradeCost = new Inventory(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, multiplier * 15);
                        maxStatValue = 100;
                        currentStatValue = Level;
                        break;
                    }
                case CitizenStats.strength:
                    {
                        int multiplier = ((int)Math.Ceiling(Strength * 1.5));
                        // Inventory in order : treeTrunks, planks, stones, iron, goldOres, gold, hay, bread, meat, electricity, money
                        upgradeCost = new Inventory(0, 0, 0, 0, 0, 0, 0, multiplier*3, multiplier*3, 0, multiplier*5);
                        currentStatValue = Strength;
                        break;
                    }
            }

            // WORK ON THIS

            if (currentStatValue <= maxStatValue)
            {
                // we create a multiplier based on the level of the building to increase the building cost every time
                int multiplier = ((int)Math.Ceiling(Level * 1.5));

                // Inventory in order : treeTrunks, planks, stones, iron, goldOres, gold, hay, bread, meat, electricity, money
                upgradeCost = new Inventory((multiplier * 5), (multiplier * 5), (multiplier * 5), 0, 0, 0, 0, 0, 0, 0, (multiplier * 10));

                if (city.CanAfford(upgradeCost))
                {
                    this.Level += 1;
                }
                else
                {
                    throw new ArgumentException("Je hebt niet genoeg grondstoffen!");
                }
            }
            else
            {
                throw new ArgumentException("Dit gebouw is al max level!");
            }
        }

        // TO DO (make the citizen change job and lose levels because of it)
        public void ChangeJob()
        {

        }
    }
}
