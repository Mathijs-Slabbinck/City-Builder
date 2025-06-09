using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using City_Builder.Core.Classes;
using City_Builder.Core.Classes.Buildings;
using City_Builder.Core.Interfaces;

namespace City_Builder.Core.Classes
{
    public class City
    {
        private Inventory resources;
        private List<IBuilding> ownedBuildings = new List<IBuilding>();
        private List<IBuilding> unOwnedBuildings = new List<IBuilding>();
        private List<Citizen> citizens = new List<Citizen>();

        public Inventory Resources{
            get { return resources; }
            set { resources = value; }
        }

        public List<IBuilding> OwnedBuildings
        {
            get { return ownedBuildings; }
            set { ownedBuildings = value; }
        }

        public List<IBuilding> UnOwnedBuildings
        {
            get { return unOwnedBuildings; }
            set { unOwnedBuildings = value; }
        }

        public List<Citizen> Citizens
        {
            get { return citizens; }
            private set { citizens = value; }
        }

        public City()
        {
            resources = new Inventory(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            Citizen citizen = new Citizen();
            Citizens.Add(citizen);
            FillUnOwnedBuildings();
        }

        public City(Inventory resources) : base()
        {
            this.resources = resources;
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
        private void FillUnOwnedBuildings()
        {
            WoodcuttersHut woodcuttersHut = new WoodcuttersHut();
            UnOwnedBuildings.Add(woodcuttersHut);
            
            Sawmill sawmill = new Sawmill();
            UnOwnedBuildings.Add(sawmill);
        }
    }
}
