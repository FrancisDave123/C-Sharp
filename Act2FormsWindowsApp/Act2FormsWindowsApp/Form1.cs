namespace Act2FormsWindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double lengthInCm = Convert.ToInt32(txtEnteredLength.Text);
            double inchPerCm = (lengthInCm * 0.39370079);
            double yardPerInch = (inchPerCm * 0.02777778);
            int yards = Convert.ToInt32(yardPerInch);
            double remainingYards = (yardPerInch - yards);
            double ftPerYards = (remainingYards * 3);
            int ft = Convert.ToInt32(ftPerYards);
            double remainingFt = (ftPerYards - ft);
            double inchPerFt = (remainingFt * 12);
            int inch = Convert.ToInt32(inchPerFt);

            lblResult.Text = yards + " yards, " + ft + " feet (foot), " + inch + " inches";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
