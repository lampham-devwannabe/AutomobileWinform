using LAB1_AutomobileWinform.BusinessObject;
using LAB1_AutomobileWinform.Repository;

namespace LAB1_AutomobileWinform
{
    public partial class frmCarDetails : Form
    {
        public frmCarDetails()
        {
            InitializeComponent();
        }
        //------------------------
        public ICarRepository CarRepository { get; set; }
        public bool InsertOrUpdate { get; set; } // true for update, false for insert
        public Car CarInfo { get; set; }
        //------------------------

        private void frmCarDetails_Load(object sender, EventArgs e)
        {
            cboManufacturer.SelectedIndex = 0;
            txtCarID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate) // update mode
            {
                // display car to perform updating
                txtCarID.Text = CarInfo.CarID.ToString();
                txtCarName.Text = CarInfo.CarName;
                txtPrice.Text = CarInfo.Price.ToString();
                txtReleaseYear.Text = CarInfo.ReleaseYear.ToString();
                cboManufacturer.Text = CarInfo.Manufacturer.Trim();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var car = new Car
                {
                    CarID = int.Parse(txtCarID.Text),
                    CarName = txtCarName.Text,
                    Manufacturer = cboManufacturer.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    ReleaseYear = int.Parse(txtReleaseYear.Text)
                };
                if (!InsertOrUpdate)
                {
                    CarRepository.AddCar(car);
                }
                else
                {
                    CarRepository.UpdateCar(car);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, !InsertOrUpdate ? "Add a new car" : "Update car information");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

    }
}
