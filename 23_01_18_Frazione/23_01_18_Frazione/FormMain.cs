using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrazioneName;

namespace _23_01_18_Frazione
{
    public partial class FormMain : Form
    {
        Frazione f1, f2, f3;

        public FormMain()
        {
            InitializeComponent();
            comboBox_Operator.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Handler bottone risultato
        private void button_Uguale_Click(object sender, EventArgs e)
        {
            int n, d;
            int op;
            
            n = Convert.ToInt32(text_n1.Text);
            d = Convert.ToInt32(text_d1.Text);
            f1 = new Frazione(n,d);

            n = Convert.ToInt32(text_n2.Text);
            d = Convert.ToInt32(text_d2.Text);
            f2 = new Frazione(n,d);

            op = comboBox_Operator.SelectedIndex;
            switch (op)
            {
                case 0 : // + 
                    f3 = f1 + f2;
                    break;

                case 1: // -
                    f3 = f1 - f2;
                    break;

                case 2: // x 
                    f3 = f1 * f2; 
                    break;

                case 3: // /
                    f3 = f1 / f2;
                    break;
            }
            text_n_ris.Text = f3.n.ToString();
            text_d_ris.Text = f3.d.ToString();


        }

    }
}
