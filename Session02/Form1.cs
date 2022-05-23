using MD.PersianDateTime.Standard;
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
            var persianDateTime = new PersianDateTime(DateTime.Now);


            var date = DateTime.Now;
            
            var result = DateUtils.GetJalaliMonthName(date);
            MessageBox.Show(result);
        }

        private void btnOutSample_Click(object sender, EventArgs e)
        {
            //int days;
            //var jalali = DateUtils.ToJalaliAndDays_out(new DateTime(2022, 5, 22), out days);

            var jalali = DateUtils.ToJalaliAndDays_out(new DateTime(2022, 5, 22), out int days);
            MessageBox.Show(days.ToString());
            MessageBox.Show(jalali);
        }

        private void btnRefSample_Click(object sender, EventArgs e)
        {
            int days = 0;
            var jalali = DateUtils.ToJalaliAndDays_ref(new DateTime(2022, 5, 22), ref days);
            MessageBox.Show(days.ToString());
            MessageBox.Show(jalali);
        }

        private void btnTouple_Click(object sender, EventArgs e)
        {
            var x_ = 100;
            var y_ = 200;
            var label_ = "center";

            //Tuple -> نا همگون - tedad 7   - () -> .item1, .item2
            //Array -> همگون    - namahdood - [] -> [0],...

            var point1 = (100, 200, "center");

            //Alias
            var point2 = (x:100, y:200, label:"center");


            point2 = point1;


            //var jalali = DateUtils.ToJalaliAndDays_touple(new DateTime(2022, 5, 22));
            //MessageBox.Show(jalali.Item1);
            //MessageBox.Show(jalali.Item2.ToString());


            var (jalali, days) = DateUtils.ToJalaliAndDays_touple(new DateTime(2022, 5, 22));
            //var (jalali, days) = ("1401/3/1", 2);
            MessageBox.Show(days.ToString());
            MessageBox.Show(jalali);
        }
    }
}