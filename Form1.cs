namespace Suma_de_Numeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateSum_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumber.Text, out int n) && n >= 0)
            {
                int result = SumRecursive(n);
                lblResult.Text = $"The sum of the first {n} numbers is {result}.";
            }
            else
            {
                MessageBox.Show("Please enter a valid non-negative number.");
            }
        }

        int SumRecursive(int n)
        {
            if (n == 0) return 0; // Condición de salida
            return n + SumRecursive(n - 1); // Segmento recursivo
        }
    }
   
}

