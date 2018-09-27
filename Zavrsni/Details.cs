using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zavrsni
{
    public partial class Details : Form
    {
        public Details()
        {
            InitializeComponent();
        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.learningAppDataSet);

        }

        private void Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'learningAppDataSet.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.learningAppDataSet.User);

        }

        private void iDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cityTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void permisionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
