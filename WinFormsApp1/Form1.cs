namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Fetch values from textboxes
            string name = txtName.Text;
            string age = txtAge.Text;
            string bloodGroup = txtBloodGroup.Text;

            // Display the result in a label (lblDisplay) or MessageBox
            pbxDisplay.Text = $"Name: {name}\nAge: {age}\nBlood Group: {bloodGroup}";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string age = txtAge.Text;
            string bloodGroup = txtBloodGroup.Text;

            // Create a bitmap image
            Bitmap bmp = new Bitmap(400, 200); // Set width & height
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White); // Background color
                Font font = new Font("Arial", 16, FontStyle.Bold);
                Brush brush = Brushes.Black;

                // Draw text on image
                g.DrawString($"Name: {name}", font, brush, new PointF(20, 20));
                g.DrawString($"Age: {age}", font, brush, new PointF(20, 60));
                g.DrawString($"Blood Group: {bloodGroup}", font, brush, new PointF(20, 100));
            }

            // Display the generated image in the PictureBox
            pbxDisplay.Image = bmp;
        }
    }
}
