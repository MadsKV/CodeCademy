using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace PizzaRia2._0
{
    class MainControleClass
    {
        public static void ShowControl(System.Windows.Forms.Control control , System.Windows.Forms.Control Content)
        {
            Content.Controls.Clear();

            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();

            Content.Controls.Add(control);
        }
        
    }
}
