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

            
            
            //MessageBox.Show("Please correct your input", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
