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
        /// <summary>
        /// Заполнение формы информацией о госте 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PersonCardForm_Load(object sender, EventArgs e)
        {
            if (CurrentData.CurrentRoom.Animal == 1)
            {
                AnimalCheckBox.CheckState = CheckState.Checked;
                PaymentLabel.Text = $"{CalculatePayment((int)CurrentData.CurrentRoom.DaysAtTheHotel, 1250)} рублей";
            }
            else
            {
                AnimalCheckBox.CheckState = CheckState.Unchecked;
                PaymentLabel.Text = $"{CalculatePayment((int)CurrentData.CurrentRoom.DaysAtTheHotel, 1000)} рублей";
            }
            FullNameLabel.Text = $"{CurrentData.CurrentRoom.Surname} {CurrentData.CurrentRoom.Name}" +
                $" {CurrentData.CurrentRoom.MiddleName}";
            BirthDayLable.Text = CurrentData.CurrentRoom.BirthDay;
            if (CurrentData.CurrentRoom.DaysAtTheHotel * 1250 == 0)
            {
                logger.Warn("С гостя не взимается плата за проживание");
            }
        }
        /// <summary>
        ///  Запрещает менять сначение в CheckBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnimalCheckBox_Click(object sender, EventArgs e)
        {
            if (sender is CheckBox)
                ((CheckBox)sender).Checked = !((CheckBox)sender).Checked;
        }
        /// <summary>
        /// Расчет платежа 
        /// </summary>
        /// <param name="days"></param>
        /// <param name="price"></param>
        /// <returns></returns>
        public int CalculatePayment(int days, int price)
        {
            return days * price;
        }
    }
}
