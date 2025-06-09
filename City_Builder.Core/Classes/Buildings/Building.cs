using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using City_Builder.Core.Interfaces;

namespace City_Builder.Core.Classes.Buildings
{
    public abstract class Building : IBuilding, IUpgradable
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
            protected set
            {
                if (value > 0 && value <= 5)
                {
                    level = value;
                }
                else if (value < 0)
                {
                    // the user should never be able to see this message
                    throw new ArgumentException("Critical error: Building level cannot be 0 or lower!");
                }
                else
                {
                    throw new ArgumentException("Dit gebouw is al max level!");
                }
            }
        }

        public string BuildingCostInfo
        {
            get { return GetBuildingCostInfo(); }
        }

        public abstract Inventory ConstructionCost { get; }

        public abstract Inventory UpgradeCost { get; }
        public abstract Citizen AssignedCitizen { get; set; }

        public abstract string BuildingInfo { get;  }

        public abstract void LevelUp(City city);
        public abstract void Produce(City city);

        private string GetBuildingCostInfo()
        {
            string infoString = "";
            if (ConstructionCost.TreeTrunks != 0)
            {
                infoString += "Boomstammen: " + ConstructionCost.TreeTrunks + " - ";
            }
            if (ConstructionCost.Planks != 0)
            {
                infoString += "Planken: " + ConstructionCost.Planks + " - ";
            }
            if (ConstructionCost.Stones != 0)
            {
                infoString += "Stenen: " + ConstructionCost.Stones + " - ";
            }
            if (ConstructionCost.Iron != 0)
            {
                infoString += "Ijzer: " + ConstructionCost.Iron + " - ";
            }
            if (ConstructionCost.GoldOre != 0)
            {
                infoString += "Gouderts: " + ConstructionCost.GoldOre + " - ";
            }
            if (ConstructionCost.Gold != 0)
            {
                infoString += "Goud: " + ConstructionCost.Gold + " - ";
            }
            if (ConstructionCost.Hay != 0)
            {
                infoString += "Hooi: " + ConstructionCost.Hay + " - ";
            }
            if(ConstructionCost.Bread != 0)
            {
                infoString += "Brood: " + ConstructionCost.Bread + " - ";
            }
            if (ConstructionCost.Meat != 0)
            {
                infoString += "Meat: " + ConstructionCost.Bread + " - ";
            }
            if (ConstructionCost.Electricity != 0)
            {
                infoString += "Elektriciteit: " + ConstructionCost.Bread + " - ";
            }
            if (ConstructionCost.Electricity != 0)
            {
                infoString += "Geld: " + ConstructionCost.Bread + " - ";
            }
            if(infoString != "")
            {
                infoString.Remove(infoString.Length - 2);
                return infoString;
            }
            else
            {
                return "Gratis!";
            }
            
        }

        public override string ToString()
        {
            return Name.ToString();
        }
    }
}
