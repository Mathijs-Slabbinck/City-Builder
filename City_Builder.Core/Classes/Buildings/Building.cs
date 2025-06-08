using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using City_Builder.Core.Interfaces;
using City_Builder.Core.Classes.Citizens;

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
            public abstract Citizen AssignedCitizen { get; set; }

            public abstract void LevelUp(City city);
            public abstract void Produce(City city);

            public override string ToString()
            {
                return Name.ToString();
            }
        }
    }
