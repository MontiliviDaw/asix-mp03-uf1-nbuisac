namespace WinFormsApp1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            int a, b, c;
            a = Convert.ToInt32(numero1.Text);
            b = Convert.ToInt32(numero2.Text);
            c = a + b;
            resultat.Text = c.ToString();
        }
    }
}
