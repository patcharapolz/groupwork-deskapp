using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GoogleMaps.LocationServices;
using FontAwesome.Sharp;
using WindowsFormsApp1.Forms;

namespace WindowsFormsApp1
{
    public partial class FormMainMenu : Form
    {

        //Fields
        bool admin = false;
        string key = "guadmin";
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public FormMainMenu()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 41);
            panelMenu.Controls.Add(leftBorderBtn);
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(11, 7, 17);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }

        private void close_btn_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void title_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void help_btn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FormHelp());
        }

        private void extractor_btn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new FormExtractor());
        }

        private void config_btn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            if(admin)
            { 
                OpenChildForm(new FormConfig());
            }
            else
            {
                if (currentChildForm != null)
                {
                    currentChildForm.Close();
                }
                Reset();
                status_icon.Visible = true;
                redeem_box.Visible = true;
                code_lb.Visible = true;
                submit_btn.Visible = true;
                logo.Visible = false;
                lblTitleChildForm.Text = "Home";
                iconCurrentChildForm.IconChar = IconChar.Key;
                iconCurrentChildForm.IconColor = Color.Gold;
            }
        }
        private void Reset()
        {
            DisableButton();
            status_icon.Visible = false;
            redeem_box.Visible = false;
            code_lb.Visible = false;
            submit_btn.Visible = false;
            leftBorderBtn.Visible = false;
            logo.Visible = true;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(13)))), ((int)(((byte)(89)))));
            lblTitleChildForm.Text = "Home";
        }


        private void submit_btn_Click(object sender, EventArgs e)
        {
            if (redeem_box.Text == key)
            {
                status_icon.IconChar = FontAwesome.Sharp.IconChar.Check;
                status_icon.IconColor = Color.Green;
                admin = true;
                ActivateButton(config_btn, RGBColors.color3);
                OpenChildForm(new FormConfig());
            }

            else
            {
                status_icon.IconChar = FontAwesome.Sharp.IconChar.Xmark;
                status_icon.IconColor = Color.Red;
            }
        }

        private void logo_box_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }
    }
}
