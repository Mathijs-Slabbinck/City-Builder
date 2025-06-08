using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using City_Builder.Core.Classes.Buildings;
using City_Builder.Core.Interfaces;

namespace City_Builder.Core.Classes
{
    public class City
    {
        private Inventory resources;
        private List<IBuilding> buildings;
        private List<ICitizen> citizens;

        public Inventory Resources{
            get { return resources; }
            set { resources = value; }
        }

        public List<IBuilding> Buildings
        {
            get { return buildings; }
            private set { Buildings = value; }
        }

        public List<ICitizen> Citizens
        {
            get { return citizens; }
            private set { citizens = value; }
        }

        public City()
        {
            Inventory cityResources = new Inventory(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

            WoodcuttersHut woodcuttersHut = new WoodcuttersHut();
            Buildings.Add(woodcuttersHut);
        }

        public bool CanAfford(Inventory neededResources)
        {
            if (neededResources.TreeTrunks <= this.Resources.TreeTrunks &&
                neededResources.Planks <= this.Resources.Planks &&
                neededResources.Stones <= this.Resources.Stones &&
                neededResources.Iron <= this.Resources.Iron &&
                neededResources.GoldOre <= this.Resources.GoldOre &&
                neededResources.Gold <= this.Resources.Gold &&
                neededResources.Hay <= this.Resources.Hay &&
                neededResources.Bread <= this.Resources.Bread &&
                neededResources.Meat <= this.Resources.Meat &&
                neededResources.Electricity <= this.Resources.Electricity &&
                neededResources.Money <= this.Resources.Money)
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
