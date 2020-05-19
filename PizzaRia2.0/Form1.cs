﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaRia2._0
{
    public partial class Form1 : Form
    {
        List<Panel> listPanel = new List<Panel>();

        
        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = CollectionButton.Height;
            CollectionPage.BringToFront();
            SidePanel.Height = EatInButton.Height;
            EatInPage1.BringToFront();
            SidePanel.Height = HomeButton.Height;
            FrontPage1.BringToFront();

            

        }

        private void LogoPicture_Click(object sender, EventArgs e)
        {

        }

        private void FastFoodLabel_Click(object sender, EventArgs e)
        {

        }

        private void RestourentLabel_Click(object sender, EventArgs e)
        {

        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = HomeButton.Height;
            SidePanel.Top = HomeButton.Top;
            FrontPage1.BringToFront();
        }

        private void CollectionButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = CollectionButton.Height;
            SidePanel.Top = CollectionButton.Top;
            CollectionPage.BringToFront();

            
        }

        private void EatInButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = EatInButton.Height;
            SidePanel.Top = EatInButton.Top;
            EatInPage1.BringToFront();
        }

        private void TakeAwayButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = TakeAwayButton.Height;
            SidePanel.Top = TakeAwayButton.Top;
            EatInPage1.BringToFront();
        }

        private void SidePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void wholeCollection1_Load(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
