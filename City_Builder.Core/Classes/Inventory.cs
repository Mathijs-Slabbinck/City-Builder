using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace City_Builder.Core.Classes
{
    public class Inventory
    {
        private int treeTrunks;
        private int planks;
        private int stones;
        private int iron;
        private int goldOres;
        private int gold;
        private int hay;
        private int bread;
        private int meat;
        private int electricity;
        private int money;

        public int TreeTrunks
        {
            get { return treeTrunks; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Grondstoffen kunnen niet onder nul gaan!");
                }
                treeTrunks = value;
            }
        }

        public int Planks
        {
            get { return planks; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Grondstoffen kunnen niet onder nul gaan!");
                }
                planks = value;
            }
        }

        public int Stones
        {
            get { return stones; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Grondstoffen kunnen niet onder nul gaan!");
                }
                stones = value;
            }
        }

        public int Iron
        {
            get { return iron; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Grondstoffen kunnen niet onder nul gaan!");
                }
                iron = value;
            }
        }

        public int GoldOre
        {
            get { return goldOres; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Grondstoffen kunnen niet onder nul gaan!");
                }
                goldOres = value;
            }
        }

        public int Gold
        {
            get { return gold; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Grondstoffen kunnen niet onder nul gaan!");
                }
                gold = value;
            }
        }

        public int Hay
        {
            get { return hay; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Grondstoffen kunnen niet onder nul gaan!");
                }
                hay = value;
            }
        }

        public int Bread
        {
            get { return gold; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Grondstoffen kunnen niet onder nul gaan!");
                }
                bread = value;
            }
        }

        public int Meat
        {
            get { return gold; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Grondstoffen kunnen niet onder nul gaan!");
                }
                meat = value;
            }
        }

        public int Electricity
        {
            get { return electricity; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Grondstoffen kunnen niet onder nul gaan!");
                }
                electricity = value;
            }
        }

        public int Money
        {
            get { return money; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Grondstoffen kunnen niet onder nul gaan!");
                }
                money = value;
            }
        }

        public Inventory(int treeTrunks)
        {
            TreeTrunks = treeTrunks;
        }

        public Inventory(int treeTrunks, int planks) : this(treeTrunks)
        {
            TreeTrunks = treeTrunks;
            Planks = planks;
        }

        public Inventory(int treeTrunks, int planks, int stones) : this(treeTrunks, planks)
        {
            TreeTrunks = treeTrunks;
            Planks = planks;
            Stones = stones;
        }

        public Inventory(int treeTrunks, int planks, int stones, int iron) : this(treeTrunks, planks, stones)
        {
            TreeTrunks = treeTrunks;
            Planks = planks;
            Stones = stones;
            Iron = iron;
        }

        public Inventory(int treeTrunks, int planks, int stones, int iron, int goldOre) : this(treeTrunks, planks, stones, iron)
        {
            TreeTrunks = treeTrunks;
            Planks = planks;
            Stones = stones;
            Iron = iron;
            GoldOre = goldOre;
        }

        public Inventory(int treeTrunks, int planks, int stones, int iron, int goldOre, int gold) : this(treeTrunks, planks, stones, iron, goldOre)
        {
            TreeTrunks = treeTrunks;
            Planks = planks;
            Stones = stones;
            Iron = iron;
            GoldOre = goldOre;
            Gold = gold;
        }

        public Inventory(int treeTrunks, int planks, int stones, int iron, int goldOre, int gold, int hay) : this(treeTrunks, planks, stones, iron, goldOre, gold)
        {
            TreeTrunks = treeTrunks;
            Planks = planks;
            Stones = stones;
            Iron = iron;
            GoldOre = goldOre;
            Gold = gold;
            Hay = hay;
        }

        public Inventory(int treeTrunks, int planks, int stones, int iron, int goldOre, int gold, int hay, int bread) : this(treeTrunks, planks, stones, iron, goldOre, gold, hay)
        {
            TreeTrunks = treeTrunks;
            Planks = planks;
            Stones = stones;
            Iron = iron;
            GoldOre = goldOre;
            Gold = gold;
            Hay = hay;
            Bread = bread;
        }

        public Inventory(int treeTrunks, int planks, int stones, int iron, int goldOre, int gold, int hay, int bread, int meat) : this(treeTrunks, planks, stones, iron, goldOre, gold, hay, bread)
        {
            TreeTrunks = treeTrunks;
            Planks = planks;
            Stones = stones;
            Iron = iron;
            GoldOre = goldOre;
            Gold = gold;
            Hay = hay;
            Bread = bread;
            Meat = meat;
        }

        public Inventory(int treeTrunks, int planks, int stones, int iron, int goldOre, int gold, int hay, int bread, int meat, int electricity) : this(treeTrunks, planks, stones, iron, goldOre, gold, hay, bread, meat)
        {
            TreeTrunks = treeTrunks;
            Planks = planks;
            Stones = stones;
            Iron = iron;
            GoldOre = goldOre;
            Gold = gold;
            Hay = hay;
            Bread = bread;
            Meat = meat;
            Electricity = electricity;
        }

        public Inventory(int treeTrunks, int planks, int stones, int iron, int goldOre, int gold, int hay, int bread, int meat, int electricity, int money) : this(treeTrunks, planks, stones, iron, goldOre, gold, hay, bread, meat, electricity)
        {
            TreeTrunks = treeTrunks;
            Planks = planks;
            Stones = stones;
            Iron = iron;
            GoldOre = goldOre;
            Gold = gold;
            Hay = hay;
            Bread = bread;
            Meat = meat;
            Electricity = electricity;
            Money = money;
        }

        public void Subtract(Inventory resources)
        {
            TreeTrunks -= resources.TreeTrunks;
            Planks -= resources.Planks;
            Stones -= resources.Stones;
            Iron -= resources.Iron;
            GoldOre -= resources.GoldOre;
            Gold -= resources.Gold;
            Hay -= Hay;
            Bread -= bread;
            Meat -= meat;
            Electricity -= resources.Electricity;
            Money -= resources.Money;
        }

        public void Add(Inventory resources)
        {
            TreeTrunks += resources.TreeTrunks;
            Planks += resources.Planks;
            Stones += resources.Stones;
            Iron += resources.Iron;
            GoldOre += resources.GoldOre;
            Gold += resources.Gold;
            Hay += Hay;
            Bread += bread;
            Meat += meat;
            Electricity += resources.Electricity;
            Money += resources.Money;
        }

        public override string ToString()
        {
            string ResourcesString = "";

            if (TreeTrunks != 0)
            {
                ResourcesString += "Houtblokken: " + TreeTrunks + "\n";
            }

            if (Planks != 0)
            {
                ResourcesString += "Planken: " + Planks + "\n";
            }

            if (Stones != 0)
            {
                ResourcesString += "Stenen: " + Stones + "\n";
            }

            if (Iron != 0)
            {
                ResourcesString += "Stenen: " + Iron + "\n";
            }

            if (GoldOre != 0)
            {
                ResourcesString += "Goud Erts: " + GoldOre + "\n";
            }

            if (Gold != 0)
            {
                ResourcesString += "Goudstaven: " + Gold;
            }

            if (Hay != 0)
            {
                ResourcesString += "Goudstaven: " + Hay;
            }

            if (Bread != 0)
            {
                ResourcesString += "Goudstaven: " + Bread;
            }

            if (Meat != 0)
            {
                ResourcesString += "Goudstaven: " + Meat;
            }

            if (Electricity != 0)
            {
                ResourcesString += "Electriciteit: " + Electricity;
            }

            if (Money != 0)
            {
                ResourcesString += "Geld: " + Money;
            }

            return ResourcesString;
        }
    }
}
