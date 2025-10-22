using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jubileu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         

        private void button1_Click(string item)
        {
            string i = item.Trim();
         if(i != " ")
            {
                Lista.Items.Add(i);
            }


            
        }
        private void enterPressed(object sender,System.Windows.Forms.KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
               button1_Click(valor.Text);
                valor.Text = " ";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(valor.Text.Trim() != " ")
            {
                Lista.Items.Remove(Lista.SelectedItem);
            }
        }

    }
}
