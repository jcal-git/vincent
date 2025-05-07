using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projdcit
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            panel3.BorderStyle = BorderStyle.Fixed3D;
        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void logout_MouseClick(object sender, MouseEventArgs e)
        {
            panellogout.Visible = true;
            logout.BorderStyle = BorderStyle.Fixed3D;
        }

        private void label3_MouseClick(object sender, MouseEventArgs e)
        {
            panellogout.Visible = true;
            logout.BorderStyle = BorderStyle.Fixed3D;
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            panellogout.Visible = false;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            Form form = new Form1();
            form.Show();
            this.Hide();
        }

        private void panel3_MouseHover(object sender, EventArgs e)
        {
            panel3.BorderStyle = BorderStyle.FixedSingle;
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            panel3.BorderStyle = BorderStyle.None;
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            panel3.BorderStyle = BorderStyle.FixedSingle;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            panel3.BorderStyle = BorderStyle.None;
        }

        private void panelbutton2_MouseHover(object sender, EventArgs e)
        {
            panelbutton2.BorderStyle = BorderStyle.FixedSingle;
        }

        private void labelbutton2_MouseHover(object sender, EventArgs e)
        {
            panelbutton2.BorderStyle = BorderStyle.FixedSingle;
        }

        private void panelbutton2_MouseLeave(object sender, EventArgs e)
        {
            panelbutton2.BorderStyle = BorderStyle.None;
        }

        private void labelbutton2_MouseLeave(object sender, EventArgs e)
        {
            panelbutton2.BorderStyle = BorderStyle.None;
        }

        private void panelbutton3_MouseHover(object sender, EventArgs e)
        {
            panelbutton3.BorderStyle = BorderStyle.FixedSingle;
        }

        private void labelbutton3_MouseHover(object sender, EventArgs e)
        {
            panelbutton3.BorderStyle = BorderStyle.FixedSingle;
        }

        private void panelbutton3_MouseLeave(object sender, EventArgs e)
        {
            panelbutton3.BorderStyle = BorderStyle.None;
        }

        private void labelbutton3_MouseLeave(object sender, EventArgs e)
        {
            panelbutton3.BorderStyle = BorderStyle.None;
        }

        private void panelbutton2_MouseClick(object sender, MouseEventArgs e)
        {
            panelbutton2.BorderStyle = BorderStyle.Fixed3D;
        }

        private void labelbutton2_MouseClick(object sender, MouseEventArgs e)
        {
            panelbutton2.BorderStyle = BorderStyle.Fixed3D;
        }

        private void panelbutton3_MouseClick(object sender, MouseEventArgs e)
        {
            panelbutton3.BorderStyle = BorderStyle.Fixed3D;
        }

        private void labelbutton3_MouseClick(object sender, MouseEventArgs e)
        {
            panelbutton3.BorderStyle = BorderStyle.Fixed3D;
        }

        private void logout_MouseHover(object sender, EventArgs e)
        {
            logout.BorderStyle = BorderStyle.FixedSingle;
        }

        private void logout_MouseLeave(object sender, EventArgs e)
        {
            logout.BorderStyle = BorderStyle.None;
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            logout.BorderStyle = BorderStyle.FixedSingle;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            logout.BorderStyle = BorderStyle.None;
        }
    }
}
