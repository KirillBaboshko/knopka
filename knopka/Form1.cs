using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace knopka
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        private void Ubegat(object sender, EventArgs e)
        {
            Random r = new Random();
            button2.Left = r.Next(0, this.Size.Width - button2.Width); 
            button2.Top = r.Next(0, this.Size.Height - button2.Height);
        }
    }
}
