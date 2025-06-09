using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using City_Builder.Core.Enums;

namespace City_Builder.Core.Classes.Buildings
{
    public class Sawmill : Building  
    {
        private readonly Inventory constructionCost;
        private Inventory upgradeCost;
        private Citizen? assignedCitizen;
        private string buildingInfo = "Dit gebruik zorgt ervoor dat je boomstammen in planken kunt verwerken!";

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
            get {
                if (assignedCitizen == null)
                {
                    return new Citizen("No citizen assigned yet!", "", Genders.None, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, JobTypes.Werkloos);
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

        public Sawmill()
        {
            // Inventory in order : treeTrunks, planks, stones, iron, goldOres, gold, hay, bread, meat, electricity, money
            constructionCost = new Inventory(5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 10);
            upgradeCost = new Inventory(5, 5, 5, 0, 0, 0, 0, 0, 0, 0, 10);
        }

        public override void LevelUp(City city)
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

        public override void Produce(City city)
        {
            city.Resources.Planks += (AssignedCitizen.Level + AssignedCitizen.Perception) * this.Level;
        }

        public override string ToString()
        {
            return "zagerij";
        }
    }
}
