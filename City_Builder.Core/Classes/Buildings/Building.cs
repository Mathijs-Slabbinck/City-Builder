    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using City_Builder.Core.Interfaces;

    namespace City_Builder.Core.Classes.Buildings
    {
        public abstract class Building : IBuilding
        {

            protected readonly BuildingTypes name;
            protected int level;


            public BuildingTypes Name
            {
                get { return name; }
            }

            public int Level
            {
                get { return level; }
                protected set { level = value; } 
            }

            public abstract Inventory ConstructionCost { get; }

            public abstract Inventory UpgradeCost { get; }

            public abstract void LevelUp(Inventory cityInventory);

            public override string ToString()
            {
                return Name.ToString();
            }

            protected bool CheckIfEnoughResources(Inventory cityInventory, Inventory neededResources)
            {
                if (neededResources.TreeTrunks <= cityInventory.TreeTrunks &&
                    neededResources.Planks <= cityInventory.Planks &&
                    neededResources.Stones <= cityInventory.Stones &&
                    neededResources.Iron <= cityInventory.Iron &&
                    neededResources.GoldOre <= cityInventory.GoldOre &&
                    neededResources.Gold <= cityInventory.Gold &&
                    neededResources.Hay <= cityInventory.Hay &&
                    neededResources.Bread <= cityInventory.Bread &&
                    neededResources.Meat <= cityInventory.Meat &&
                    neededResources.Electricity <= cityInventory.Electricity &&
                    neededResources.Money <= cityInventory.Money)
                {
                    return true;
                }
                else
                {
                return false;
                }
            }
        }
    }
