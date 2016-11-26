using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGitAlonso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFunc_Click(object sender, EventArgs e)
        {
            textBox1.Text = operacion2num(txtnum1.Text, txtnum2.Text).ToString();
        }

        private int operacion2num(string p_num1, string p_num2)
        {
            int res = 0;
            int i_num1;
            int i_num2;
            string ope = "*";

            try
            {
                i_num1 = Convert.ToInt16(p_num1);
                i_num2 = Convert.ToInt16(p_num2);
            }
            catch (Exception e)
            {

                throw new Exception ("Error al convertir a numero" + e.Message);
            }

            lblOpe.Text = ope;

            res = i_num1 * i_num2;
        

            return res;
        }


    }
}
