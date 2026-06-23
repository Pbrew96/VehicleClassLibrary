/*
 * Patrick Brewster
 * CST - 250
 * 06/20/2026
 * Vehicle Class Library
 * Activity 1
 */
namespace VehicleStoreGUIApp
{
    public partial class FrmVehicleStore : Form
    {
        //Class level variables
        string currentVehicleType;
        public FrmVehicleStore()
        {
            InitializeComponent();
            // Initialize the current vehicle to create
            currentVehicleType = "";
        }

        private void RdoCarClickEH(object sender, EventArgs e)
        {
            // Update the selected vehicle variable
            currentVehicleType = "Car";
            //Change the label for the specialty boolean
            lblSpecialtyBoolean.Text = "Is the car a convertible?";
            // Change the label for the specialty decimal
            lblSpecialtyDecimal.Text = "Trunk Size (cubic feet):";

        }

        private void RdoMotorcycleClickEH(object sender, EventArgs e)
        {
            currentVehicleType = "Motorcycle";

        }

        private void RdoPickupClickEH(object sender, EventArgs e)
        {
            currentVehicleType = "Pickup";

        }

        private void RdoVehicleClickEH(object sender, EventArgs e)
        {
            currentVehicleType = "Vehicle";
        }
    }
}
