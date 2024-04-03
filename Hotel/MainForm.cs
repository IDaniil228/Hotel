using Hotel;

namespace Hotel
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            TimeLabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void ReservedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //ListOfPeopleListView.Items.Clear();
            //using (var context = new HotelContext())
            //{
            //    var persons = context.People;
            //    foreach (var person in persons)
            //    {
            //        if (person.Status == "Зарезервировано")
            //        {
            //            ListOfPeopleListView.Items.Add(person.FullName);
            //        }
            //    }
            //}
        }

        private void FreeRadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            //ListOfPeopleListView.Items.Clear();
            //using (var context = new HotelContext())
            //{
            //    var persons = context.People;
            //    foreach (var person in persons)
            //    {
            //        if (person.Status == "Сводобно")
            //        {
            //            ListOfPeopleListView.Items.Add(person.Room);
            //        }
            //    }
            //}
        }
    }
}
