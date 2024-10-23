namespace Form_2024_Week_1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double r;
        const double pi = 3.14;
        double result;
        private void btn_Area_Calculate_Click(object sender, EventArgs e)
        {
            r = Convert.ToDouble(radius_text.Text);
            result = pi * r * r;
            lbl_area.Text = "Area result is" + result.ToString();
            MessageBox.Show("Circle Area_Calculate is" + result);
        }

        private void btn_Perimeter_Calculate_Click(object sender, EventArgs e)
        {
            r = Convert.ToDouble(radius_text.Text);
            result = 2 * pi * r;
            lbl_perimeter.Text = "                Perimeter result is" + result.ToString();
            MessageBox.Show("Circle PErimeter_Calculate is" + result);
        }

        private void radius_text_TextChanged(object sender, EventArgs e)
        {
            lbl_r.Text = radius_text.Text + "cm";
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
