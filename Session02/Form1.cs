using Session02.Utilities;

namespace Session02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnJalali2Miladi_Click(object sender, EventArgs e)
        {

        }

        private void btnMiladi2Jalali_Click(object sender, EventArgs e)
        {
            var date = DateTime.Now;
            var result = DateUtils.MiladiToJalali(date);
            MessageBox.Show(result);

        }
    }
}