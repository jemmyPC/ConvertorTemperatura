using System;
using System.Windows.Forms;

namespace DPRN1_U1_EA_JEPC
{
    public partial class Form1 : Form
    {

        public double farenhait = 32;
        public double celsius = 0;
        public double kelvin = 273.15;




        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

       
        private void Resolver()
        {
            if (ingreso.Text != "" && ingreso.Text != "-")
            {
                double dato = Convert.ToDouble(ingreso.Text);
                int valIngreso = comboBoxEntrada.SelectedIndex;
                int valSalida = comboBoxSalida.SelectedIndex;

                // 0 = celcius  
                // 1 = Fare
                // 2 = Kelvin
                switch (valIngreso)
                {
                    case 0:

                        if (valSalida == 0)
                            comboBoxEntrada.SelectedIndex = 1;

                        if (valSalida == 1)
                            salida.Text = (dato * 1.8 + 32).ToString();

                        if (valSalida == 2)
                            salida.Text = (dato * 273.15 + 32).ToString();
                        break;

                    case 1:

                        if (valSalida == 0)
                            salida.Text = ((dato - 32) / 1.8).ToString();

                        if (valSalida == 1)
                            comboBoxEntrada.SelectedIndex = 2;

                        if (valSalida == 2)
                            salida.Text = (((dato - 32) / 1.8) + 273.15).ToString();
                        break;
                    case 2:

                        if (valSalida == 0)
                            salida.Text = (dato - 273.15).ToString();

                        if (valSalida == 1)
                            salida.Text = ((dato - 273.15) * 1.8 + 32).ToString();

                        if (valSalida == 2)
                            comboBoxEntrada.SelectedIndex = 0;
                        break;
                }
            }
            else
            {
                salida.Clear();
            }
        }

        private void ingreso_TextChanged(object sender, EventArgs e)
        {
            Resolver();
        }

        private void comboBoxEntrada_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Desea hacer otra converion?");
            Resolver();
        }

        private void comboBoxSalida_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Desea hacer otra converion?");
            Resolver();
        }

      
    }
}

