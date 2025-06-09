using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using City_Builder.Core.Interfaces;
using City_Builder.Core.Enums;
using System.Runtime.CompilerServices;

namespace City_Builder.Core.Classes
{
    public class Citizen : IUpgradable
    {
        protected Inventory hiringCost = new Inventory(0, 0 ,0, 0, 0, 0, 0, 0, 0, 0, 0);
        private string firstName = "";
        private string lastName = "";
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
            set
            { 
                if(value < 0)
                {
                    throw new ArgumentException("Leeftijd kan niet kleiner dan 0 zijn!");
                }
                else
                {
                    age = value;
                }
            }
        }

        public int Happiness
        {
            get { return happiness; }
            set
            {
                happiness = value;
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

        public Inventory HiringCost
        {
            get { return hiringCost; }
            set { hiringCost = value; }
        }

        public Citizen()
        {
            Random random = new Random();
            Gender = GetRandomGender();
            FirstName = CreateRandomName(Gender, NameTypes.firstname);
            LastName = CreateRandomName(Gender, NameTypes.lastname);
            Age = random.Next(18, 25);
            Job = JobTypes.Werkloos;
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
        }

        public Citizen(string firstName, string lastName, Genders gender, int age) : base()
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Age = age;
            HiringCost = GetHiringCost();
        }

        public Citizen(string firstName, string lastName, Genders gender, int age, int level) : this(firstName, lastName, gender, age)
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

            switch (stat)
            {
                case CitizenStats.level:
                    {
                        int multiplier = (int)Math.Ceiling(Level * 1.5);
                        // Inventory in order : treeTrunks, planks, stones, iron, goldOres, gold, hay, bread, meat, electricity, money
                        upgradeCost = new Inventory(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, multiplier * 15);
                        maxStatValue = 100;
                        currentStatValue = Level;

                        if (currentStatValue <= maxStatValue)
                        {
                            if (city.CanAfford(upgradeCost))
                            {
                                Level += 1;
                            }
                            else
                            {
                                throw new ArgumentException("Je hebt niet genoeg grondstoffen!");
                            }
                        }
                        else
                        {
                            throw new ArgumentException("Deze stat is al max level!");
                        }
                    }
                    break;
                case CitizenStats.strength:
                    {
                        int multiplier = (int)Math.Ceiling(Strength * 1.5);
                        // Inventory in order : treeTrunks, planks, stones, iron, goldOres, gold, hay, bread, meat, electricity, money
                        upgradeCost = new Inventory(0, 0, 0, 0, 0, 0, 0, multiplier * 3, multiplier * 3, 0, multiplier * 5);
                        currentStatValue = Strength;

                        if (currentStatValue <= maxStatValue)
                        {
                            if (city.CanAfford(upgradeCost))
                            {
                                Strength += 1;
                            }
                            else
                            {
                                throw new ArgumentException("Je hebt niet genoeg grondstoffen!");
                            }
                        }
                        else
                        {
                            throw new ArgumentException("Deze stat is al max level!");
                        }
                    }
                    break;
                case CitizenStats.perception:
                    {
                        int multiplier = (int)Math.Ceiling(Perception * 1.5);
                        // Inventory in order : treeTrunks, planks, stones, iron, goldOres, gold, hay, bread, meat, electricity, money
                        upgradeCost = new Inventory(0, 0, 0, 0, 0, 0, 0, multiplier * 3, multiplier * 3, 0, multiplier * 5);
                        currentStatValue = Strength;

                        if (currentStatValue <= maxStatValue)
                        {
                            if (city.CanAfford(upgradeCost))
                            {
                                Perception += 1;
                            }
                            else
                            {
                                throw new ArgumentException("Je hebt niet genoeg grondstoffen!");
                            }
                        }
                        else
                        {
                            throw new ArgumentException("Deze stat is al max level!");
                        }
                    }
                    break;
                case CitizenStats.endurance:
                    {
                        int multiplier = (int)Math.Ceiling(Endurance * 1.5);
                        // Inventory in order : treeTrunks, planks, stones, iron, goldOres, gold, hay, bread, meat, electricity, money
                        upgradeCost = new Inventory(0, 0, 0, 0, 0, 0, 0, multiplier * 3, multiplier * 3, 0, multiplier * 5);
                        currentStatValue = Endurance;

                        if (currentStatValue <= maxStatValue)
                        {
                            if (city.CanAfford(upgradeCost))
                            {
                                Endurance += 1;
                            }
                            else
                            {
                                throw new ArgumentException("Je hebt niet genoeg grondstoffen!");
                            }
                        }
                        else
                        {
                            throw new ArgumentException("Deze stat is al max level!");
                        }
                    }
                    break;
                case CitizenStats.charisma:
                    {
                        int multiplier = (int)Math.Ceiling(Charisma * 1.5);
                        // Inventory in order : treeTrunks, planks, stones, iron, goldOres, gold, hay, bread, meat, electricity, money
                        upgradeCost = new Inventory(0, 0, 0, 0, 0, multiplier * 3, 0, 0, multiplier * 3, 0, multiplier * 5);
                        currentStatValue = Charisma;

                        if (currentStatValue <= maxStatValue)
                        {
                            if (city.CanAfford(upgradeCost))
                            {
                                Charisma += 1;
                            }
                            else
                            {
                                throw new ArgumentException("Je hebt niet genoeg grondstoffen!");
                            }
                        }
                        else
                        {
                            throw new ArgumentException("Deze stat is al max level!");
                        }
                    }
                    break;
                case CitizenStats.intelligence:
                    {
                        int multiplier = (int)Math.Ceiling(Intelligence * 1.5);
                        // Inventory in order : treeTrunks, planks, stones, iron, goldOres, gold, hay, bread, meat, electricity, money
                        upgradeCost = new Inventory(0, 0, 0, 0, 0, multiplier * 3, 0, 0, multiplier * 3, 0, multiplier * 5);
                        currentStatValue = Intelligence;

                        if (currentStatValue <= maxStatValue)
                        {
                            if (city.CanAfford(upgradeCost))
                            {
                                Intelligence += 1;
                            }
                            else
                            {
                                throw new ArgumentException("Je hebt niet genoeg grondstoffen!");
                            }
                        }
                        else
                        {
                            throw new ArgumentException("Deze stat is al max level!");
                        }
                    }
                    break;
                case CitizenStats.agility:
                    {
                        int multiplier = (int)Math.Ceiling(Intelligence * 1.5);
                        // Inventory in order : treeTrunks, planks, stones, iron, goldOres, gold, hay, bread, meat, electricity, money
                        upgradeCost = new Inventory(0, 0, 0, 0, 0, 0, 0, multiplier * 3, multiplier * 3, 0, multiplier * 5);
                        currentStatValue = Intelligence;

                        if (currentStatValue <= maxStatValue)
                        {
                            if (city.CanAfford(upgradeCost))
                            {
                                Agility += 1;
                            }
                            else
                            {
                                throw new ArgumentException("Je hebt niet genoeg grondstoffen!");
                            }
                        }
                        else
                        {
                            throw new ArgumentException("Deze stat is al max level!");
                        }
                    }
                    break;
                case CitizenStats.luck:
                    {
                        int multiplier = (int)Math.Ceiling(Luck * 1.5);
                        // Inventory in order : treeTrunks, planks, stones, iron, goldOres, gold, hay, bread, meat, electricity, money
                        upgradeCost = new Inventory(0, 0, 0, 0, 0, 0, multiplier * 3, 0, multiplier * 3, 0, multiplier * 5);
                        currentStatValue = Luck;

                        if (currentStatValue <= maxStatValue)
                        {
                            if (city.CanAfford(upgradeCost))
                            {
                                Luck += 1;
                            }
                            else
                            {
                                throw new ArgumentException("Je hebt niet genoeg grondstoffen!");
                            }
                        }
                        else
                        {
                            throw new ArgumentException("Deze stat is al max level!");
                        }
                    }
                    break;
            }
        }

        // TO DO (make the citizen change job and lose levels because of it)
        public void ChangeJob()
        {

        }

        private Inventory GetHiringCost()
        {
            int goldCost = (int)Math.Ceiling( (int)Math.Ceiling(Level * 1.5) *1.5 );
            int moneyCost = Strength + Perception + Endurance + Charisma + Intelligence + Agility + Luck;
            Inventory hiringCost = new Inventory(0, 0, 0, 0, 0, goldCost, 0, 3, 3, 0, moneyCost);
            return hiringCost; 
        }

        private Genders GetRandomGender()
        {
            Random random = new Random();
            Genders[] validGenders = Enum.GetValues(typeof(Genders)).Cast<Genders>().Where(g => g != Genders.None).ToArray();
            Genders randomGender = validGenders[random.Next(validGenders.Length)];
            return randomGender;
        }

        private string CreateRandomName(Genders gender, NameTypes nameType)
        {
            Random random = new Random();

            if (nameType == NameTypes.lastname)
            {
                List<string> lastNames = new List<string>()
                {
                "Smith", "Johnson", "Williams", "Jones", "Brown", "Davis", "Miller", "Wilson", "Moore", "Taylor",
                "Anderson", "Thomas", "Jackson", "White", "Harris", "Martin", "Thompson", "Garcia", "Martinez", "Roberts",
                "Clark", "Rodriguez", "Lewis", "Lee", "Walker", "Hall", "Allen", "Young", "King", "Wright",
                "Scott", "Torres", "Nguyen", "Hill", "Adams", "Baker", "Gonzalez", "Nelson", "Carter", "Mitchell",
                "Perez", "Robinson", "Hernandez", "Gomez", "Duncan", "Sanchez", "Morris", "Cook", "Reed", "Morgan",
                "Bell", "Murphy", "Bailey", "Rivera", "Cooper", "Richards", "Wood", "James", "Gonzalez", "Gray",
                "Jameson", "Ross", "Graham", "Davis", "Parker", "Evans", "Jenkins", "Patel", "Perry", "Russell",
                "Sanders", "Price", "Watson", "Hunter", "Cameron", "Fox", "Bryant", "Riley", "Austin", "Kim",
                "Gibson", "Johnston", "Burns", "Foster", "Cole", "Hamilton", "Wells", "Bryan", "Spencer", "Hughes",
                "Chavez", "Simmons", "Alexander", "Schmidt", "Bishop", "Ford", "Griffin", "Chavez", "Bates", "George",
                "Wagner", "Mendoza", "Sullivan", "Daniels", "Hansen", "Lynch", "Hoffman", "Hicks", "Shaw", "Wallace",
                "Gardner", "Cameron", "Cunningham", "Alvarez", "Chang", "Jenkins", "Dixon", "Mason", "Webb", "Ruiz",
                "Burnett", "Snyder", "Carr", "Hopkins", "Hart", "Edwards", "Austin", "Lowe", "Ramos", "Fletcher",
                "Patrick", "Freeman", "Curtis", "Griffith", "Black", "Kelley", "Dean", "Reynolds", "Dawson", "Chang",
                "Stewart", "Norris", "Ramirez", "Harrison", "Lamar", "Walsh", "Stone", "Webb", "Carson", "Stewart",
                "Howell", "Meyer", "Fernandez", "Burgess", "Carlson", "Bryant", "Richards", "Simmons", "Ramos", "Fox",
                "Chavez", "Hunt", "Johns", "Byrd", "Richmond", "Harrison", "Patterson", "Jimenez", "Chang", "Blair",
                "Newton", "Walters", "Cameron", "Porter", "Fleming", "Austin", "Garrett", "Jordan", "Blackwell", "Pearson",
                "Douglas", "Singh", "Hughes", "Franklin", "Cameron", "Hudson", "Fowler", "Bowers", "Lambert", "Green",
                "Kim", "Murray", "Hines", "Daniels", "Carlson", "Martinez", "Palmer", "Russell", "Coleman", "Sims",
                "Powers", "Weaver", "Lloyd", "Cameron", "Carroll", "Murray", "James", "Garrison", "Zimmerman", "Hodge",
                "Matthews", "Chang", "Fox", "Sanchez", "Travis", "Morris", "Jensen", "Wong", "Morales", "Wallace",
                "Elliott", "Sullivan", "Wade", "Bennett", "Davenport", "Shaffer", "Patel", "Hicks", "Hines", "Rowe",
                "Love", "Burns", "Freeman", "Reed", "Lutz", "Kirk", "Kim", "Bowers", "Leonard", "Walter", "Farmer",
                "Holmes", "Webster", "Bradley", "Gregory", "Wallace", "Whitehead", "Garrett", "Miller", "Chen", "Gentry",
                "Morrison", "Hughes", "Curtis", "Glover", "Griffith", "Burns", "Kennedy", "Harrison", "Mills", "Peters",
                "Harrison", "Craig", "Nash", "Vazquez", "Holland", "Ferguson", "Hodge", "George", "Fischer", "Nichols",
                "Franklin", "Taylor", "Davis", "Anderson", "Becker", "McCarthy", "Sweeney", "Willis", "Graham", "Burns"
                };

                int randomForLastName = random.Next(lastNames.Count);

                return lastNames[randomForLastName];
            }
            else if (nameType == NameTypes.firstname)
            {
                List<string> firstNames = new List<string>();

                switch (gender)
                {
                    case Genders.Male:
                    {
                        firstNames = new List<string>()
                        {
                        "Liam", "Noah", "Aiden", "Lucas", "Mason", "Ethan", "James", "Benjamin", "Elijah", "Alexander",
                        "William", "Daniel", "Michael", "Jacob", "Sebastian", "Jack", "Samuel", "David", "Matthew", "Joseph",
                        "Isaac", "Matthew", "Henry", "Owen", "Gabriel", "Carter", "Julian", "Luke", "Leo", "Anthony",
                        "Grayson", "Jackson", "Myles", "Ryan", "Cameron", "Hunter", "Nathan", "Isaiah", "Thomas", "Andrew",
                        "Aaron", "Christopher", "Isaiah", "Cooper", "Lincoln", "Joshua", "Isaac", "Charlie", "Wyatt", "Jameson",
                        "Victor", "Leo", "Caden", "Eli", "Miles", "Xander", "Oscar", "Eliot", "Seth", "Luca", "Kai",
                        "Kaden", "Dean", "Miles", "Landon", "Harrison", "Theo", "Parker", "Chase", "Benjamin", "Jacob",
                        "Elijah", "Joseph", "Logan", "Dylan", "Aidan", "Max", "Kai", "Kaden", "Luke", "Jack", "Carter",
                        "Henry", "Isaiah", "Daniel", "Owen", "Gabriel", "Lucas", "Ethan", "David", "Elijah", "Mason",
                        "James", "Joseph", "Ryan", "Matthew", "Samuel", "Jacob", "Ethan", "Carter", "Jack", "Eli",
                        "Isaac", "Benjamin", "Zachary", "Aaron", "Nathaniel", "Seth", "Jackson", "Nolan", "Elliot", "Lucas",
                        "Daniel", "Blake", "Logan", "Connor", "Joseph", "Finn", "Ethan", "Aiden", "Gabriel", "Maximus",
                        "Elliott", "Sebastian", "Dylan", "Bennett", "Miles", "Cameron", "Wyatt", "Eli", "Jaden", "Zane",
                        "Cole", "Austin", "Brandon", "Mason", "Henry", "Riley", "Eliot", "Christopher", "Zachary", "Ian",
                        "Thomas", "Luke", "Cole", "Liam", "Jack", "Mason", "Julian", "Isaiah", "Victor", "Oliver",
                        "Ryan", "Carter", "Gavin", "Sebastian", "Maxwell", "Elian", "Reed", "Asher", "Theo", "Jaxon",
                        "Benjamin", "Sawyer", "Damian", "Isaiah", "Jesse", "Ezra", "Maverick", "Spencer", "Grayson", "Roman",
                        "Tobias", "Zachariah", "Jasper", "Leo", "Hudson", "Elliot", "Dominic", "Beau", "Jackson", "Blake",
                        "Finnley", "Ezekiel", "Rhett", "Mason", "Graham", "Brock", "Anderson", "Colton", "Maddox", "Dallas",
                        "Jace", "Wesley", "Emmett", "Bennett", "Caleb", "Grayson", "Ethan", "Harrison", "Ryder", "Landon",
                        "Brady", "Grant", "Nash", "Chase", "Finley", "Zane", "Milo", "Quinn", "Jace", "Rylan", "Hayden",
                        "Jonah", "Kyler", "Maxim", "Tanner", "Maximus", "Oliver", "Preston", "Jaxson", "Paxton", "Zane",
                        "Gage", "Emerson", "Beckett", "Graham", "Kieran", "Silas", "Chandler", "Reed", "Maddox", "Bryce",
                        "Kellan", "Dante", "Cole", "Brandon", "Oliver", "Luca", "Weston", "Bodhi", "Milo", "Max"
                        };
                        
                        int randomForFirstName = random.Next(firstNames.Count);
                        return firstNames[randomForFirstName];
                    }

                    case Genders.Female:
                    {
                        firstNames = new List<string>()
                        {
                        "Emma", "Olivia", "Sophia", "Isabella", "Mia", "Amelia", "Harper", "Evelyn", "Abigail", "Ella",
                        "Scarlett", "Aria", "Grace", "Lily", "Chloe", "Layla", "Zoe", "Nora", "Avery", "Hannah",
                        "Charlotte", "Lillian", "Eleanor", "Ellie", "Zoey", "Audrey", "Sadie", "Nina", "Stella", "Victoria",
                        "Leah", "Addison", "Mackenzie", "Hazel", "Maya", "Lucy", "Caroline", "Ruby", "Samantha", "Eden",
                        "Willow", "Anna", "Madeline", "Maya", "Savannah", "Mila", "Eliza", "Lily", "Kennedy", "Chloe",
                        "Sophie", "Autumn", "Kaitlyn", "Reagan", "Alice", "Paisley", "Adeline", "Violet", "Brooklyn", "Ivy",
                        "Gabriella", "Brooklyn", "Sierra", "Aubrey", "Riley", "Madison", "Ariana", "Ella", "Lila", "Penelope",
                        "Jasmine", "Aurora", "Ruby", "Josephine", "Madison", "Sophie", "Arianna", "Maria", "Elise", "Brianna",
                        "Kaitlyn", "Hazel", "Sophie", "Landon", "Eve", "Isabella", "Archer", "Samantha", "Caitlyn", "Avery",
                        "Leah", "Violet", "Maya", "Ruby", "Norah", "Olivia", "Riley", "Addison", "Eliana", "Lana",
                        "Zoey", "Amelia", "Lucy", "Aubrey", "Charlotte", "Lydia", "Tessa", "Olivia", "Mackenzie", "Gianna",
                        "Luna", "Caroline", "Quinn", "Ava", "Autumn", "Paisley", "Willa", "Leila", "Piper", "Laila",
                        "Aria", "Ella", "Ariana", "Zara", "Natalie", "Holly", "Adeline", "Clara", "Emery", "Sophie",
                        "Charlotte", "Tessa", "Blair", "Skylar", "Vivian", "Megan", "Lillian", "Lucia", "Gemma", "Holly",
                        "Marley", "Vera", "Maggie", "Allison", "Lydia", "Sarah", "Maya", "Sadie", "Lena", "Bailey",
                        "Scarlett", "Layla", "Abigail", "Charlotte", "Emily", "Hazel", "Charlotte", "Isla", "Sierra",
                        "Emily", "Clara", "Madeline", "Stella", "Ivy", "Amara", "Paige", "Vivienne", "Camila", "Emilia",
                        "Avery", "Leah", "Emma", "Delilah", "Adeline", "Carolina", "Josephine", "Hazel", "June", "Delilah",
                        "Tatum", "Emma", "Freya", "Hannah", "Quinn", "Olive", "Mckenna", "Maggie", "Lucy", "Chloe",
                        "Savannah", "Eve", "Olivia", "Mikayla", "Madeline", "Anastasia", "Miriam", "Aubrey", "Sophie",
                        "Faith", "Ruby", "Sophia", "Stella", "Cora", "Sophia", "Celia", "Sierra", "Holly", "Wren",
                        "Lillian", "Kelsey", "Addison", "Violet", "Eden", "Maeve", "Clara", "Amaya", "Ellie", "Sabrina"
                        };

                        int randomForFirstName = random.Next(firstNames.Count);
                        return firstNames[randomForFirstName];
                    }

                    default:
                    {
                        throw new ArgumentException("The Citizen needs to have a valid gender!");
                    }
                }
            }
            else
            {
                throw new ArgumentException("No valid nameType was passed!");
            }
        }

        public override string ToString()
        {
            return $"{Job}: {FirstName} {LastName}";
        }
    }
}
