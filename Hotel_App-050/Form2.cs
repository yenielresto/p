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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dateLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Variables para indicar la fecha y hora de la computadora  

            string fecha = DateTime.Now.ToString("dd/MM/yyyy");
            string hora = DateTime.Now.ToString("HH:mm:ss");

            dateLabel.Text = fecha;
            timeLabel.Text = hora;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //CLose
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear

            nightsTextBox.Clear();
            nightChargesTextBox.Clear();
            roomServiceTextBox.Clear();
            telephoneTextBox.Clear();
            miscTextBox.Clear();

            //Limpiar los labels de la forma

            roomChargesLabel.Text = "";
            addittionalChargesLabel.Text = "";
            subtototalLabel.Text = "";
            taxLabel.Text = "";
            totalChargesLabel.Text = "";

            nightsTextBox.Focus();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void roomChargesLabel_Click(object sender, EventArgs e)
        {

        }

        private void calculateChargesButton_Click(object sender, EventArgs e)
        {

            try
            {
            int nights = 0;
            decimal nightCharges = 0m, roomService = 0m, telephone = 0m, misc = 0m;
            decimal roomCharges = 0m, additionalCharges = 0m, subtotal = 0m, tax = 0m, totalCharges = 0m;

            const decimal TAX = .115m;

            //Input y Conversion:
            nights = int.Parse(nightsTextBox.Text.Trim());
            nightCharges = decimal.Parse(nightChargesTextBox.Text.Trim());
            roomService = decimal.Parse(roomServiceTextBox.Text.Trim());
            telephone = decimal.Parse(telephoneTextBox.Text.Trim());
            misc = decimal.Parse(miscTextBox.Text.Trim());

            //Processing
            roomCharges = nights * nightCharges;
            additionalCharges = roomService + telephone + misc;
            subtotal = roomCharges + additionalCharges;
            tax = subtotal * TAX;
            totalCharges = subtotal + tax;

            roomChargesLabel.Text = roomCharges.ToString("c");
            addittionalChargesLabel.Text = additionalCharges.ToString("c");
            subtototalLabel.Text = subtotal.ToString("c");
            taxLabel.Text = tax.ToString("c");
            totalChargesLabel.Text = totalCharges.ToString("c");
            }
            catch {
                MessageBox.Show("Por favor, ingrese valores numericos en todos los campos", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }

            //Variables locales:
            
        }
    }
}
