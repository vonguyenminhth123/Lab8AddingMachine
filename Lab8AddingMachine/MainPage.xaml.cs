namespace Lab8AddingMachine
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnEvaluate_Click(object sender, EventArgs e)
        {
            calculateResult();
        }
        private void calculateResult()
        {
            float v1 = float.Parse(txtFirstNumber.Text);
            float v2 = float.Parse(txtSecondNumber.Text);
            float result = v1 + v2;
            lblResult.Text = result.ToString();
        }
    }
}