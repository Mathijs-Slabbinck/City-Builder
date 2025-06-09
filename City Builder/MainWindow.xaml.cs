using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using City_Builder.Core;
using City_Builder.Core.Classes;
using City_Builder.Core.Classes.Buildings;
using City_Builder.Core.Interfaces;

namespace City_Builder
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        City city = new City();

        public MainWindow()
        {
            InitializeComponent();
            UpdateBuildingLists();
            UpdateCitizenList();
            UpdateResourcesList();
        }


        public void UpdateBuildingLists()
        {
            lstBuildBuildings.Items.Clear();
            foreach(IBuilding unownedBuilding in city.UnOwnedBuildings)
            {
                lstBuildBuildings.Items.Add(unownedBuilding);
            }

            lstOwnedBuildings.Items.Clear();
            foreach(IBuilding ownedBuilding in city.OwnedBuildings)
            {
                lstOwnedBuildings.Items.Add(ownedBuilding);
            }
        }

        private void UpdateCitizenList()
        {
            lstInhabitants.Items.Clear();
            foreach(Citizen citizen in city.Citizens)
            {
                lstInhabitants.Items.Add(citizen);
            }
        }

        private void UpdateResourcesList()
        {
            lblTrunks.Content = city.Resources.TreeTrunks;
            lblPlanks.Content = city.Resources.Planks;
            lblStones.Content = city.Resources.Stones;
            lblIron.Content = city.Resources.Iron;
            lblGoldOre.Content = city.Resources.GoldOre;
            lblGold.Content = city.Resources.Gold;
            lblHay.Content = city.Resources.Hay;
            lblBread.Content = city.Resources.Bread;
            lblMeat.Content = city.Resources.Meat;
            lblElectricity.Content = city.Resources.Electricity;
            lblMoney.Content = city.Resources.Money;

        }

        private void ShowCitizenInfo(Citizen citizen)
        {
            lblCitizenName.Content = $"{citizen.FirstName} {citizen.LastName}";
            lblCitizenGender.Content = citizen.Gender;
            lblCitizenJob.Content = citizen.Job;
            lblCitizenAge.Content = citizen.Age;
            lblCitizenHappiness.Content = citizen.Happiness;
            lblCitizenLvl.Content = citizen.Level;
            lblCitizenEnergy.Content = citizen.Energy;
            lblCitizenStrength.Content = citizen.Strength;
            lblCitizenPerception.Content = citizen.Perception;
            lblCitizenEndurance.Content = citizen.Endurance;
            lblCitizenCharisma.Content = citizen.Charisma;
            lblCitizenIntelligence.Content = citizen.Intelligence;
            lblCitizenAgility.Content = citizen.Agility;
            lblCitizenLuck.Content = citizen.Luck;
        }

        private void ShowBuildingInfo(IBuilding building)
        {
            lstBuildingInfo.Items.Clear();
            lstBuildingInfo.Items.Add(building.Name.ToString().ToUpper());
            lstBuildingInfo.Items.Add(building.BuildingInfo);
            lstBuildingInfo.Items.Add("");
            lstBuildingInfo.Items.Add("KOSTPRIJS:");
            lstBuildingInfo.Items.Add(building.BuildingCostInfo);
            lstBuildingInfo.Items.Add("");
            lstBuildingInfo.Items.Add("KOOP GEBOUW");
        }

        private void LstInhabitants_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(lstInhabitants.SelectedIndex != -1)
            {
                Citizen selectedCitizen = (Citizen)lstInhabitants.SelectedItem;
                ShowCitizenInfo(selectedCitizen);
            }
        }

        private void LstBuildBuildings_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lstBuildBuildings.SelectedIndex != -1)
            {
                IBuilding building = (IBuilding)lstBuildBuildings.SelectedItem;
                ShowBuildingInfo(building);
            }

        }
    }
}