using NLog;

namespace Hotel_5
{
    public partial class MainForm : Form
    {

        List<DataGridViewRow> rows = new List<DataGridViewRow>();
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            timer.Start();
            TimeLabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void ReservedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                listOfGuestsDataGridView.Rows.Clear();
                using (var context = new HotelContext())
                {
                    var rooms = context.Rooms.Where(x => x.Status == "Зарезервировано");
                    foreach (var room in rooms)
                    {
                        listOfGuestsDataGridView.Rows.Add(room.Id, room.Name, room.Room1);
                    }
                    logger.Trace($"Успешно подключились к БД и извлекли из  неё записи( кол-во -{rooms.Count()})");
                    logger.Debug("Записи успешно обработаны и загруженны в DataGridView");
                }
            }
            catch
            {
                logger.Fatal("Не удалось подключитсья к БД");
                MessageBox.Show("Ошибка подключения к БД");
            }

        }

        private void FreeRadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                listOfGuestsDataGridView.Rows.Clear();
                using (var context = new HotelContext())
                {
                    var rooms = context.Rooms.Where(x => x.Status == "Свободны");
                    foreach (var room in rooms)
                    {
                        listOfGuestsDataGridView.Rows.Add(room.Id, room.Name, room.Room1);
                    }
                    logger.Trace($"Успешно подключились к БД и извлекли из  неё записи( кол-во -{rooms.Count()})");
                    logger.Debug("Записи успешно обработаны и загруженны в DataGridView");
                }
            }
            catch
            {
                logger.Fatal("Не удалось подключитсья к БД");
                MessageBox.Show("Ошибка подключения к БД");
            }


        }

        private void OccupiedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                listOfGuestsDataGridView.Rows.Clear();
                using (var context = new HotelContext())
                {
                    var rooms = context.Rooms.Where(x => x.Status == "Заняты");
                    foreach (var room in rooms)
                    {
                        listOfGuestsDataGridView.Rows.Add(room.Id, room.Name, room.Room1);
                    }
                    logger.Trace($"Успешно подключились к БД и извлекли из  неё записи( кол-во -{rooms.Count()})");
                    logger.Debug("Записи успешно обработаны и загруженны в DataGridView");
                }
            }
            catch
            {
                logger.Fatal("Не удалось подключитсья к БД");
                MessageBox.Show("Ошибка подключения к БД");
            }

        }

        private void DischargedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                listOfGuestsDataGridView.Rows.Clear();
                using (var context = new HotelContext())
                {
                    var rooms = context.Rooms.Where(x => x.Status == "Выписываются");
                    foreach (var room in rooms)
                    {
                        listOfGuestsDataGridView.Rows.Add(room.Id, room.Name, room.Room1);
                    }
                    logger.Trace($"Успешно подключились к БД и извлекли из  неё записи( кол-во -{rooms.Count()})");
                    logger.Debug("Записи успешно обработаны и загруженны в DataGridView");
                }
            }
            catch
            {
                logger.Fatal("Не удалось подключитсья к БД");
                MessageBox.Show("Ошибка подключения к БД");
            }

        }

        private void listOfGuestsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (FreeRadioButton.Checked)
            {
                CurrentData.CurrentRoom = null;
                PhotoPictureBox.Image = null;
                FullNameLabel.Text = String.Empty;
                EnterDateLable.Text = String.Empty;
                DepartureDateLable.Text = String.Empty;
                MessageBox.Show("Команта никем не забронирована");
                return;
            }
            StatusComboBox.Enabled = true;
            listOfGuestsDataGridView.CurrentRow.Selected = true;
            int currentID = (int)listOfGuestsDataGridView.Rows[e.RowIndex].Cells["ID"].Value;
            using (var context = new HotelContext())
            {
                foreach (var room in context.Rooms)
                {
                    if (room.Id == currentID)
                    {
                        CurrentData.CurrentRoom = room;
                        break;
                    }
                }
                NumberLabel.Text = $"Номер № {CurrentData.CurrentRoom.Room1}";
                if (CurrentData.CurrentRoom.Photo != null)
                {
                    var imageMemoryStream = new MemoryStream(CurrentData.CurrentRoom.Photo);
                    PhotoPictureBox.Image = Image.FromStream(imageMemoryStream);
                }
                StatusComboBox.SelectedItem = CurrentData.CurrentRoom.Status;
                FullNameLabel.Text = $"{CurrentData.CurrentRoom.Surname} {CurrentData.CurrentRoom.Name}" +
                    $" {CurrentData.CurrentRoom.MiddleName}";
                EnterDateLable.Text = CurrentData.CurrentRoom.EnterDate;
                DepartureDateLable.Text = CurrentData.CurrentRoom.DepartureDate;
            }
        }

        private void btnCheckCard_Click(object sender, EventArgs e)
        {

            if (CurrentData.CurrentRoom == null)
            {
                return;
            }
            PersonCardForm form = new PersonCardForm();
            logger.Info("Открыта карточка с информацией о пользователе");
            form.ShowDialog();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            rows.Clear();
            if (SearchTextBox.Text == string.Empty)
            {
                if (ReservedRadioButton.Checked == true)
                {
                    ReservedRadioButton_CheckedChanged(sender, e);
                }
                else if (FreeRadioButton.Checked == true)
                {
                    FreeRadioButton4_CheckedChanged(sender, e);
                }
                else if (OccupiedRadioButton.Checked == true)
                {
                    OccupiedRadioButton_CheckedChanged(sender, e);
                }
                else if (DischargedRadioButton.Checked == true)
                {
                    DischargedRadioButton_CheckedChanged(sender, e);
                }
                SearchTextBox_Click(sender, e);
                return;
            }

            foreach (DataGridViewRow row in listOfGuestsDataGridView.Rows)
            {
                if (row.Cells[1].Value == null)
                {
                    return;
                }
                if (row.Cells[2].Value.ToString().ToLower().StartsWith(SearchTextBox.Text.ToLower()))
                {
                    rows.Add(row);
                }
            }
            listOfGuestsDataGridView.Rows.Clear();
            foreach (var row in rows)
            {
                listOfGuestsDataGridView.Rows.Add(row);
            }
        }

        private void SearchTextBox_Click(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == "Поиск по номеру комнаты")
            {
                SearchTextBox.Text = string.Empty;
                SearchTextBox.ForeColor = Color.Black;
            }
        }
        /// <summary>
        /// Еcли строка пустая, то добавляет подсказку 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchTextBox_Leave(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == string.Empty)
            {
                SearchTextBox.Text = "Поиск по номеру комнаты";
                SearchTextBox.ForeColor = Color.Gray;
            }
            if (SearchTextBox.Text == string.Empty)
            {
                logger.Error("В строку поиска не добавлен начальны текст");
            }
        }
    }
}
