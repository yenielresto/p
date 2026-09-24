using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_App_050
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Metodo para cerrar la forma.
            this.Close();
        }

        private void directionsButton_Click(object sender, EventArgs e)
        {
            directionsLabel.Visible=true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
