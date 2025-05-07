namespace projdcit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            labelpass.Font = new Font(labelpass.Font, FontStyle.Underline);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            panellogin.Visible = true;
            panelbutton1.BorderStyle = BorderStyle.Fixed3D;
            panelsignin.Visible = false;
        }

        private void label3_MouseClick(object sender, MouseEventArgs e)
        {
            panellogin.Visible = true;
            panelbutton1.BorderStyle = BorderStyle.Fixed3D;
            panelsignin.Visible = false;
        }

        private void labelpass_MouseLeave(object sender, EventArgs e)
        {
            labelpass.Font = new Font(labelpass.Font, FontStyle.Italic);
        }

        private void panel3_MouseHover(object sender, EventArgs e)
        {
            panelbutton1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void panelbutton1_MouseLeave(object sender, EventArgs e)
        {
            panelbutton1.BorderStyle = BorderStyle.None;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_MouseHover_1(object sender, EventArgs e)
        {
            panelbutton1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void panelbutton2_MouseClick(object sender, MouseEventArgs e)
        {
            panelbutton2.BorderStyle = BorderStyle.Fixed3D;
            panellogin.Visible = false;
        }

        private void panelbutton2_MouseHover(object sender, EventArgs e)
        {
            panelbutton2.BorderStyle = BorderStyle.FixedSingle;
        }

        private void panelbutton2_MouseLeave(object sender, EventArgs e)
        {
            panelbutton2.BorderStyle = BorderStyle.None;
        }

        private void labelpass_MouseClick(object sender, MouseEventArgs e)
        {
            Form form = new Form3();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new Form2();
            form.Show();
            this.Hide();
        }

        private void panelbutton2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_MouseClick(object sender, MouseEventArgs e)
        {
            panellogin.Visible = false;
            panelsignin.Visible = true;
            panelbutton2.BorderStyle = BorderStyle.Fixed3D;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label15_MouseClick(object sender, MouseEventArgs e)
        {
            panelsignin.Visible = false;
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            panelbutton2.BorderStyle = BorderStyle.FixedSingle;
        }
    }
}
