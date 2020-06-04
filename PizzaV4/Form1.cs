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

        List<Object> listTemp = new List<object>();
        private void BeefSize_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //if (BeefSize.CheckedItems.Count >= 0)
            //{
            //    SumBox.Items.Add(BeefSize.SelectedItem);
            //}

            if (e.NewValue == CheckState.Checked)
            {
                listTemp.Add(BeefSize.SelectedItem);
                //SumBox.Items.Clear();
                //foreach (var topping in BeefSize.CheckedItems)
                //{
                //    if (!SumBox.Items.Contains(BeefSize.SelectedItem))
                //    {
                //        SumBox.Items.Add(topping.ToString());
                        
                //    }
                //    foreach (var sumItem in SumBox.Items)
                //    {
                //        if (topping != sumItem)
                //        {
                            
                //            break;
                //        }
                //    }
                //}
            }
            else
            {
                listTemp.Remove(BeefSize.SelectedItem);
                //SumBox.Items.Remove("Beef Pizza.... 14.75$");
                //SumBox.Items.Remove(BeefSize.SelectedItem.ToString());
            }
            Total_list();
            //SumBox.Items.Clear();
            //SumBox.Items.Add("Beef Pizza 14.75$");
            //listTemp.Sort();
            //foreach (var item in listTemp)
            //{
            //    SumBox.Items.Add(item);
            //}
        }
        List<Object> listTemp2 = new List<object>();
        private void HamSize_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            if (e.NewValue == CheckState.Checked)
            {
                listTemp2.Add(HamSize.SelectedItem);
            }
            else
            {
                listTemp2.Remove(HamSize.SelectedItem);
            }

            SumBox.Items.Clear();
            SumBox.Items.Add("Ham Pizza 16.99$");
            listTemp2.Sort();
            foreach (var item in listTemp2)
            {
                SumBox.Items.Add(item);
            }
        }
        List<Object> listTemp3 = new List<object>();
        private void SaladSize_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                listTemp3.Add(SaladSize.SelectedItem);
            }
            else
            {
                listTemp3.Remove(SaladSize.SelectedItem);
            }

            SumBox.Items.Clear();
            SumBox.Items.Add("Salad Pizza 15.45$");
            listTemp3.Sort();
            foreach (var item in listTemp3)
            {
                SumBox.Items.Add(item);
            }
        }
        List<Object> listTemp4 = new List<object>();
        private void OwnSize_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                listTemp4.Add(OwnSize.SelectedItem);
            }
            else
            {
                listTemp4.Remove(OwnSize.SelectedItem);
            }

            SumBox.Items.Clear();
            SumBox.Items.Add("Own Pizza 15.00$");
            listTemp4.Sort();
            foreach (var item in listTemp4)
            {
                SumBox.Items.Add(item);
            }

        }

        private void Sorter()
        {
            foreach (var list in BeefSize.Items)
            {

            }
        }

        List<Object> totalList = new List <object>();
        private void Total_list()
        {
            totalList.Clear();
            SumBox.Items.Clear();
            //listTemp.Sort();
            //listTemp2.Sort();
            //listTemp3.Sort();
            //listTemp4.Sort();
            totalList.AddRange(listTemp);
            totalList.AddRange(listTemp2);
            totalList.AddRange(listTemp3);
            totalList.AddRange(listTemp4);

            foreach (var item in totalList)
            {
                SumBox.Items.Add(item);

            }
        }
        private void ColaSize_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                SumBox.Items.Add(ColaSize.SelectedItem.ToString());
            }
            else
            {
                SumBox.Items.Remove(ColaSize.SelectedItem.ToString());
            }
        }

        private void FantaSize_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                SumBox.Items.Add(FantaSize.SelectedItem.ToString());
            }
            else
            {
                SumBox.Items.Remove(FantaSize.SelectedItem.ToString());
            }
        }

        private void FaxiSize_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                SumBox.Items.Add(FaxiSize.SelectedItem.ToString());
            }
            else
            {
                SumBox.Items.Remove(FaxiSize.SelectedItem.ToString());
            }
        }
    }
}
