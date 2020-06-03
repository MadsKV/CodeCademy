using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaV4
{
    public partial class Form1 : Form
    {
        public string[] topping = { "Sausage", "Beef", "Kebab", "Salad", "Pepper", "Onions", "Chicken", "Chili", "Garlic" };
        public double[] toppingP = { 1.24, 1.99, 2.44, 1.24, 1.19, 1.29, 2.99, 0.99, 0.99 };
        
        public class Pizza
        {
            string _navn;
            string _size;
            double _price;
            
            public Pizza(string navnP, string sizeP, double priceP)
            {
                _navn = navnP;
                _size = sizeP;
                _price = priceP;
            }
        }

        public class Drink
        {
            string _navn;
            string _size;
            double _price;
            public Drink(string navnD, string sizeD, double priceD)
            {
                _navn = navnD;
                _size = sizeD;
                _price = priceD;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            BeefSize.Items.Add("Test");
            
        }
        private void BeefSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pizza BeefPizza = new Pizza("Beef Pizza", "Regular", 14.75);
            Pizza BeefPizzaLarge = new Pizza("Beef Pizza", "Family", 17.75);
        }

        private void HamSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pizza HamPizza = new Pizza("Ham Pizza", "Regular", 16.99);
            Pizza HamPizzaLarge = new Pizza("Ham Pizza", "Family", 19.99);
        }

        private void SaladSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pizza SaladPizza = new Pizza("Salad Pizza", "Regular", 15.45);
            Pizza SaladPizzaLarge = new Pizza("Salad Pizza", "Family", 18.75);
        }

        private void OwnSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pizza OwnPizza = new Pizza("Own Pizza", "Regular", 15.00);
            Pizza OwnPizzaLarge = new Pizza("Own Pizza", "Family", 18.00);
        }

        private void BeefAmount_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void HamAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaladAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void OwnAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void ColaSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            Drink SmallCola = new Drink("Cola", "Regular", 1.00);
            Drink Cola = new Drink("Cola", "Regular", 1.75);
            Drink LargeCola = new Drink("Cola", "Large", 3.25);
        }

        private void FantaSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            Drink SmallFanta = new Drink("Fanta", "Regular", 1.00);
            Drink Fanta = new Drink("Fanta", "Regular", 1.75);
            Drink LargeFanta = new Drink("Fanta", "Large", 3.25);
        }

        private void FaxiSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            Drink SmallFaxi = new Drink("Faxi", "Regular", 1.00);
            Drink Faxi = new Drink("Faxi", "Regular", 1.75);
            Drink LargeFaxi = new Drink("Faxi", "Large", 3.25);
        }

        private void ColaAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void FantaAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void FaxiAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void SumBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please correct your input", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void BeefSize_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            if (e.NewValue == CheckState.Checked)
            {
                SumBox.Items.Add("Beef Pizza.... 14.75");
                SumBox.Items.Add(BeefSize.SelectedItem.ToString());
            }
           else
            {
                SumBox.Items.Remove("Beef Pizza.... 14.75");
                SumBox.Items.Remove(BeefSize.SelectedItem.ToString());
                
            }
        }

        private void HamSize_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                SumBox.Items.Add(HamSize.SelectedItem.ToString());
            }
            else
            {
                SumBox.Items.Remove(HamSize.SelectedItem.ToString());
            }
        }

        private void SaladSize_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                SumBox.Items.Add(SaladSize.SelectedItem.ToString());
            }
            else
            {
                SumBox.Items.Remove(SaladSize.SelectedItem.ToString());
            }
        }

        private void OwnSize_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                SumBox.Items.Add(OwnSize.SelectedItem.ToString());
            }
            else
            {
                SumBox.Items.Remove(OwnSize.SelectedItem.ToString());
            }
        }
    }
}
