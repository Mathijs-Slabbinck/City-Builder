using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using City_Builder.Core.Classes;

namespace City_Builder.Core.Interfaces
{
    public interface IBuilding
    {
        BuildingTypes Name { get; }
        int Level { get; }
        Inventory ConstructionCost { get; }

        void LevelUp(Inventory cityInventory);
        string ToString();
    }
}
