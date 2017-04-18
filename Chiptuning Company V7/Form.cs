using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chiptuning_Company_V7
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            SQLFunctions.Refresh(dataGridView);
        }

        private void SQL_select_button_Click(object sender, EventArgs e)
        {
            SQLFunctions.Select(dataGridView, Select_box.Text);

            Clean_boxes();
        }

        private void SQL_insert_button_Click(object sender, EventArgs e)
        {
            SQLFunctions.Insert(Vin_box.Text, Make_box.Text, Model_box.Text, Year_box.Text, Displacement_box.Text, Fuel_box.Text, Power_box.Text);
            SQLFunctions.Refresh(dataGridView);

            Clean_boxes();
        }

        private void SQL_update_button_Click(object sender, EventArgs e)
        {
            SQLFunctions.Update(Vin_box.Text, Make_box.Text, Model_box.Text, Year_box.Text, Displacement_box.Text, Fuel_box.Text, Power_box.Text);
            SQLFunctions.Refresh(dataGridView);

            Clean_boxes();
        }

        private void SQL_delete_button_Click(object sender, EventArgs e)
        {
            SQLFunctions.Delete(Delete_box.Text);
            SQLFunctions.Refresh(dataGridView);

            Clean_boxes();
        }

        private void EF_select_button_Click(object sender, EventArgs e)
        {
            EFFunctions.Select(dataGridView, Select_box.Text);

            Clean_boxes();
        }

        private void EF_insert_button_Click(object sender, EventArgs e)
        {
            EFFunctions.Insert(Vin_box.Text, Make_box.Text, Model_box.Text, Year_box.Text, Displacement_box.Text, Fuel_box.Text, Power_box.Text);
            SQLFunctions.Refresh(dataGridView);

            Clean_boxes();
        }

        private void EF_update_button_Click(object sender, EventArgs e)
        {
            EFFunctions.Update(Vin_box.Text, Make_box.Text, Model_box.Text, Year_box.Text, Displacement_box.Text, Fuel_box.Text, Power_box.Text);
            SQLFunctions.Refresh(dataGridView);

            Clean_boxes();
        }

        private void EF_delete_button_Click(object sender, EventArgs e)
        {
            EFFunctions.Delete(Delete_box.Text);
            SQLFunctions.Refresh(dataGridView);

            Clean_boxes();
        }

        private void Clean_boxes()
        {
            Select_box.Text = "";
            
            Vin_box.Text = "";
            Make_box.Text = "";
            Model_box.Text = "";
            Year_box.Text = "";
            Displacement_box.Text = "";
            Fuel_box.Text = "";
            Power_box.Text = "";

            Delete_box.Text = "";
        }

        private void Join_customer_button_Click(object sender, EventArgs e)
        {
            LINQFunctions.Join(dataGridView);
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            SQLFunctions.Refresh(dataGridView);
        }
    }
}
