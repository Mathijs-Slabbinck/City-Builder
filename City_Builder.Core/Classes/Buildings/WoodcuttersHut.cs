using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using City_Builder.Core.Enums;

namespace City_Builder.Core.Classes.Buildings
{
    public class WoodcuttersHut : Building
    {
        private readonly Inventory constructionCost;
        private Inventory upgradeCost;
        private Citizen assignedCitizen;
        private readonly string buildingInfo = "Dit gebouw zorgt ervoor dat je boomstammen kunt krijgen.";

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
            get
            {
                if (assignedCitizen == null)
                {
                    return new Citizen("No citizen assigned yet!", "", Genders.None, 0);
                }
                else
                {
                    return assignedCitizen;
                }
            }
            set { assignedCitizen = value; }
        }

        public override string BuildingInfo
        {
            get { return buildingInfo; }
        }

        public WoodcuttersHut()
        {
            // Inventory in order : treeTrunks, planks, stones, iron, goldOres, gold, hay, bread, meat electricity, money
            constructionCost = new Inventory(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            upgradeCost = new Inventory(10, 5, 10, 0, 0, 0, 0, 0, 0, 0, 10);
        }

        public override void LevelUp(City city)
        {
            if (this.Level <= 5)
            {
                // we create a multiplier based on the level of the building to increase the building cost every time
                int multiplier = ((int)Math.Ceiling(Level * 1.5));

                // Inventory in order : treeTrunks, planks, stones, iron, goldOres, gold, hay, bread, meat, electricity, money
                upgradeCost = new Inventory((multiplier * 5), (multiplier * 5), (multiplier * 5), 0, 0, 0, 0, 0, 0, 0, (multiplier * 10));

                if (city.CanAfford(UpgradeCost))
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
                    if(city.Resources.TreeTrunks < 1)
                    {
                        throw new ArgumentException("Je hebt niet genoeg boomstammen om te produceren!");
                    }
                    city.Resources.Planks += (AssignedCitizen.Level + AssignedCitizen.Strength) * 1;
                    break;

                case 2:
                    if (city.Resources.TreeTrunks < 1)
                    {
                        throw new ArgumentException("Je hebt niet genoeg boomstammen om te produceren!");
                    }
                    city.Resources.Planks += (AssignedCitizen.Level + AssignedCitizen.Strength) * 2;
                    break;

                case 3:
                    if (city.Resources.TreeTrunks < 2)
                    {
                        throw new ArgumentException("Je hebt niet genoeg boomstammen om te produceren!");
                    }
                    city.Resources.Planks += (AssignedCitizen.Level + AssignedCitizen.Strength) * 3;
                    break;

                case 4:
                    if (city.Resources.TreeTrunks < 2)
                    {
                        throw new ArgumentException("Je hebt niet genoeg boomstammen om te produceren!");
                    }
                    city.Resources.Planks += (AssignedCitizen.Level + AssignedCitizen.Strength) * 4;
                    break;

                case 5:
                    if (city.Resources.TreeTrunks < 2)
                    {
                        throw new ArgumentException("Je hebt niet genoeg boomstammen om te produceren!");
                    }
                    city.Resources.Planks += (AssignedCitizen.Level + AssignedCitizen.Strength) * 5;
                    break;
            }
        }

        public override string ToString()
        {
            return "houthakkershut";
        }
    }
}
