using NLog;

namespace Hotel_5
{
    public partial class PersonCardForm : Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public PersonCardForm()
        {
            InitializeComponent();
        }

        private void PersonCardForm_Load(object sender, EventArgs e)
        {
            if (CurrentData.CurrentRoom.Animal == 1)
            {
                AnimalCheckBox.CheckState = CheckState.Checked;
                PaymentLabel.Text = $"{CurrentData.CurrentRoom.DaysAtTheHotel * 1000} рублей";
            }
            else
            {
                AnimalCheckBox.CheckState = CheckState.Unchecked;
                PaymentLabel.Text = $"{CurrentData.CurrentRoom.DaysAtTheHotel * 1250} рублей";
            }
            FullNameLabel.Text = $"{CurrentData.CurrentRoom.Surname} {CurrentData.CurrentRoom.Name}" +
                $" {CurrentData.CurrentRoom.MiddleName}";
            BirthDayLable.Text = CurrentData.CurrentRoom.BirthDay;
            if (CurrentData.CurrentRoom.DaysAtTheHotel * 1250 == 0)
            {
                logger.Warn("С гостя не взимается плата за проживание");
            }
        }

        private void AnimalCheckBox_Click(object sender, EventArgs e)
        {
            if (sender is CheckBox)
                ((CheckBox)sender).Checked = !((CheckBox)sender).Checked;
        }

        //public int CalculatePayMent(int days, int price)
        //{
        //    if()
        //}
    }
}
