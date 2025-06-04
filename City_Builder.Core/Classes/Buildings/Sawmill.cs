using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace City_Builder.Core.Classes.Buildings
{
    public class Sawmill : Building  
    {
        private readonly Inventory constructionCost;
        private Inventory upgradeCost;

        public override Inventory ConstructionCost
        {
            get { return constructionCost; }
        }

        public override Inventory UpgradeCost
        {
            get { return upgradeCost; }
        }

        public Sawmill()
        {
            // Inventory in order : treeTrunks, planks, stones, iron, goldOres, gold, hay, bread, meat, electricity, money
            constructionCost = new Inventory(5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 10);
            upgradeCost = new Inventory(5, 5, 5, 0, 0, 0, 0, 0, 0, 0, 10);
        }

        public override void LevelUp(Inventory cityInventory)
        {
            if (this.Level >= 5)
            {
                // we create a multiplier based on the level of the building to increase the building cost every time
                int multiplier = ((int)Math.Ceiling(Level * 1.5));

                // Inventory in order : treeTrunks, planks, stones, iron, goldOres, gold, hay, bread, meat, electricity, money
                upgradeCost = new Inventory((multiplier*5), (multiplier*5), (multiplier*5), 0, 0, 0, 0, 0, 0, 0, (multiplier*10));

                if(CheckIfEnoughResources(cityInventory, UpgradeCost))
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

        public void Produce(City city)
        {
            switch (this.Level)
            {
                case 1:

                    break;

                case 2:

                    break;

                case 3:

                    break;

                case 4:

                    break;

                case 5:

                    break;
            }
        }
    }
}
