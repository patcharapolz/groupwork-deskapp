using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class FormRedeem : Form
    {
        string key = "guadmin";
        public FormRedeem()
        {
            InitializeComponent();
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {

            if (redeem_box.Text == key)
            {
                status_icon.IconChar = FontAwesome.Sharp.IconChar.Check;
                status_icon.IconColor = Color.Green;
            } 
            
            else
            {
                status_icon.IconChar = FontAwesome.Sharp.IconChar.Xmark;
                status_icon.IconColor = Color.Red;
            }
        }

        private void redeem_box_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox currentContainer = ((TextBox)sender);
            int caretPosition = currentContainer.SelectionStart;

            currentContainer.Text = currentContainer.Text.ToLower();
            currentContainer.SelectionStart = caretPosition++;
        }

    }
}
