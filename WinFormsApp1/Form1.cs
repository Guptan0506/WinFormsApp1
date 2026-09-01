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
            Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            decimal subtotal = Convert.ToDecimal(txtSubtotal.Text);
            var discountPercentage = 0m;
            if(subtotal>50 && subtotal<= 100)
            {
                discountPercentage = 0.1m;
            } else if (subtotal>100 && subtotal<=150)
            {
                discountPercentage = 0.15m;
            }else if (subtotal > 150)
            {
                discountPercentage = 0.2m;
            }

            var discountAmount = subtotal * discountPercentage;
            var total = subtotal - discountAmount;

            txtDiscPrt.Text = discountPercentage.ToString("P2"); //P2 means two decimal places
            txtDiscAmt.Text = discountAmount.ToString("C2"); //C2 means currency is dollar.
            txtTotal.Text = total.ToString("C2");
        }
    }
}
