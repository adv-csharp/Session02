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
            var result = DateUtils.JalaliToMiladi("1401/3/2");
            MessageBox.Show(result.ToLongDateString());
        }

        private void btnMiladi2Jalali_Click(object sender, EventArgs e)
        {
            var date = DateTime.Now;
            //var result = DateUtils.MiladiToJalali(date);

            //extention method
            var result = date.ToJalali();
            

            MessageBox.Show(result);

        }

        private void btnJalaliMonthName_Click(object sender, EventArgs e)
        {
            var date = DateTime.Now;
            var result = DateUtils.GetJalaliMonthName(date);
            MessageBox.Show(result);
        }
    }
}