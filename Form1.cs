namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static bool jeden, dwa, trzy, cztery, piec, szesc, siedem, osiem, dziewiec, zero;
        public static bool proc, ce, c, usuwaniee, znak1xx, pow, sqrt, dzielenie, razy, plus, minus, plusminus, rownania, przecin;
        private void znakproc_Click(object sender, EventArgs e)
        {

        }

        private void clearever_Click(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {

        }

        private void usuwanie_Click(object sender, EventArgs e)
        {

        }

        private void znak1x_Click(object sender, EventArgs e)
        {

        }

        private void znakpow_Click(object sender, EventArgs e)
        {

        }

        private void znaksqrt_Click(object sender, EventArgs e)
        {

        }

        private void znakdzielenia_Click(object sender, EventArgs e)
        {

        }

        private void liczbasiedem_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("7");
        }

        private void liczbaosiem_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("8");
        }

        private void liczbadziewiec_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("9");
        }

        private void znakrazy_Click(object sender, EventArgs e)
        {

        }

        private void liczbacztery_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("4");
        }

        private void liczbapiec_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("5");
        }

        private void liczbaszesc_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("6");
        }

        private void znakminus_Click(object sender, EventArgs e)
        {
            minus = true;
            a = Convert.ToDouble(textBox1.Text);
            minus = false;
        }

        private void liczbadwa_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("2");
        }

        private void liczbatrzy_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("3");
        }

        private void znakplus_Click(object sender, EventArgs e)
        {

        }

        private void znakplusminus_Click(object sender, EventArgs e)
        {

        }

        private void liczbazero_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("0");
        }

        private void przecinek_Click(object sender, EventArgs e)
        {

        }

        private void znakrownania_Click(object sender, EventArgs e)
        {

        }

        private void liczbajeden_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("1");
        }

        
    }
}