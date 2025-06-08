using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using City_Builder.Core.Classes.Citizens;

namespace City_Builder.Core.Classes.Buildings
{
    public class Sawmill : Building  
    {
        private readonly Inventory constructionCost;
        private Inventory upgradeCost;
        private Citizen? assignedCitizen;

        public override Inventory ConstructionCost
        {
            get { return constructionCost; }
        }

        public override Inventory UpgradeCost
        {
            get { return upgradeCost; }
        }

        public override Citizen AssignedCitizen
        {
            get { if (assignedCitizen == null)
                {
                    return new Citizen():
                }
            }
            set { assignedCitizen = value; }
        }

        public Sawmill()
        {
            // Inventory in order : treeTrunks, planks, stones, iron, goldOres, gold, hay, bread, meat, electricity, money
            constructionCost = new Inventory(5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 10);
            upgradeCost = new Inventory(5, 5, 5, 0, 0, 0, 0, 0, 0, 0, 10);
        }

        public override void LevelUp(City city)
        {
            if (this.Level <= 5)
            {
                // we create a multiplier based on the level of the building to increase the building cost every time
                int multiplier = ((int)Math.Ceiling(Level * 1.5));

                // Inventory in order : treeTrunks, planks, stones, iron, goldOres, gold, hay, bread, meat, electricity, money
                upgradeCost = new Inventory((multiplier*5), (multiplier*5), (multiplier*5), 0, 0, 0, 0, 0, 0, 0, (multiplier*10));

                if(city.CanAfford(UpgradeCost))
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

        public override void Produce(City city)
        {
            switch (this.Level)
            {
                case 1:
                    city.Resources.Planks += (AssignedCitizen.Level + AssignedCitizen.Perception) * 1;
                    break;

                case 2:
                    city.Resources.Planks += (AssignedCitizen.Level + AssignedCitizen.Perception) * 2;
                    break;

                case 3:
                    city.Resources.Planks += (AssignedCitizen.Level + AssignedCitizen.Perception) * 3;
                    break;

                case 4:
                    city.Resources.Planks += (AssignedCitizen.Level + AssignedCitizen.Perception) * 4;
                    break;

                case 5:
                    city.Resources.Planks +=(AssignedCitizen.Level + AssignedCitizen.Perception) *5;
                    break;
            }
        }
    }
}
