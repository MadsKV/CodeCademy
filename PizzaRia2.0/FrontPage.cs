﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaRia2._0
{
    public partial class FrontPage : UserControl
    {
        public FrontPage()
        {
            InitializeComponent();
        }

        private void FrontPage_Load(object sender, EventArgs e)
        {

        }

        private void PremiumOrderButton_Click(object sender, EventArgs e)
        {
            WholeCollection rf = new WholeCollection();
            MainControleClass.ShowControl(rf, Content);
        }
    }
}
