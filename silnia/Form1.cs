namespace silnia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //pobieram stopie�
            int st = Convert.ToInt32(stopien.Text);
            int silnia = 1;
            //licz� silnie
            for (int i=1; i<=st; i++)
            {
                silnia *= i;
            }
            //wy�wetlam wynik 
            wynik.Text = silnia.ToString();
        }
    }
}
