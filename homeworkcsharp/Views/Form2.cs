using homeworkcsharp.Controllers;
using homeworkcsharp.Repository;
using System;
using System.Windows.Forms;

namespace homeworkcsharp.Views
{
    public partial class indexview : Form
    {
        public indexview()
        {
            InitializeComponent();
        }
        private void btnGetData_Click(object sender, EventArgs e)
        {

            UserController controller = new UserController();
            table.DataSource = controller.Index();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserController controller = new UserController();
            if (this.Validator()) controller.Store(
                        name.Text,
                        int.Parse(idNumber.Text),
                        doctor.Text,
                        dateTime.Text,
                        hourTime.Text,
                        speciality.Text
                );

            else
                MessageBox.Show("¡Hay errores en los datos, verifica e intenta nuevamente!");

            table.DataSource = controller.Index();

        }

        public bool Validator()
        {
            if (!int.TryParse(idNumber.Text, out _)) return false;

            if (   name.Text == "" || idNumber.Text == ""
                || doctor.Text == "" || dateTime.Text == ""
                || hourTime.Text == "" || speciality.Text == ""
                )
            {
                return false;

            }

            return true;

        }
    }
}
