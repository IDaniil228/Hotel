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
        /// <summary>
        /// �������� �����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            timer.Start();
            TimeLabel.Text = DateTime.Now.ToLongTimeString();
        }
        /// <summary>
        /// ���������� �������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToLongTimeString();
        }
        /// <summary>
        /// ���������� ��������� � DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReservedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                listOfGuestsDataGridView.Rows.Clear();
                using (var context = new HotelContext())
                {
                    var rooms = context.Rooms.Where(x => x.Status == "���������������");
                    foreach (var room in rooms)
                    {
                        listOfGuestsDataGridView.Rows.Add(room.Id, room.Name, room.Room1);
                    }
                    logger.Trace($"������� ������������ � �� � �������� ��  �� ������( ���-�� -{rooms.Count()})");
                    logger.Debug("������ ������� ���������� � ���������� � DataGridView");
                }
            }
            catch
            {
                logger.Fatal("�� ������� ������������ � ��");
                MessageBox.Show("������ ����������� � ��");
            }

        }
        /// <summary>
        /// ���������� ��������� � DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FreeRadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                listOfGuestsDataGridView.Rows.Clear();
                using (var context = new HotelContext())
                {
                    var rooms = context.Rooms.Where(x => x.Status == "��������");
                    foreach (var room in rooms)
                    {
                        listOfGuestsDataGridView.Rows.Add(room.Id, room.Name, room.Room1);
                    }
                    logger.Trace($"������� ������������ � �� � �������� ��  �� ������( ���-�� -{rooms.Count()})");
                    logger.Debug("������ ������� ���������� � ���������� � DataGridView");
                }
            }
            catch
            {
                logger.Fatal("�� ������� ������������ � ��");
                MessageBox.Show("������ ����������� � ��");
            }


        }
        /// <summary>
        /// ���������� ��������� � DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OccupiedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                listOfGuestsDataGridView.Rows.Clear();
                using (var context = new HotelContext())
                {
                    var rooms = context.Rooms.Where(x => x.Status == "������");
                    foreach (var room in rooms)
                    {
                        listOfGuestsDataGridView.Rows.Add(room.Id, room.Name, room.Room1);
                    }
                    logger.Trace($"������� ������������ � �� � �������� ��  �� ������( ���-�� -{rooms.Count()})");
                    logger.Debug("������ ������� ���������� � ���������� � DataGridView");
                }
            }
            catch
            {
                logger.Fatal("�� ������� ������������ � ��");
                MessageBox.Show("������ ����������� � ��");
            }

        }
        /// <summary>
        /// ���������� ��������� � DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DischargedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                listOfGuestsDataGridView.Rows.Clear();
                using (var context = new HotelContext())
                {
                    var rooms = context.Rooms.Where(x => x.Status == "������������");
                    foreach (var room in rooms)
                    {
                        listOfGuestsDataGridView.Rows.Add(room.Id, room.Name, room.Room1);
                    }
                    logger.Trace($"������� ������������ � �� � �������� ��  �� ������( ���-�� -{rooms.Count()})");
                    logger.Debug("������ ������� ���������� � ���������� � DataGridView");
                }
            }
            catch
            {
                logger.Fatal("�� ������� ������������ � ��");
                MessageBox.Show("������ ����������� � ��");
            }

        }
        /// <summary>
        /// ����� ���������� � ������� ������ ��� ������� �� ������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listOfGuestsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (FreeRadioButton.Checked)
            {
                CurrentData.CurrentRoom = null;
                PhotoPictureBox.Image = null;
                FullNameLabel.Text = String.Empty;
                EnterDateLable.Text = String.Empty;
                DepartureDateLable.Text = String.Empty;
                MessageBox.Show("������� ����� �� �������������");
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
                NumberLabel.Text = $"����� � {CurrentData.CurrentRoom.Room1}";
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
        /// <summary>
        /// �������� ����� �����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheckCard_Click(object sender, EventArgs e)
        {

            if (CurrentData.CurrentRoom == null)
            {
                return;
            }
            PersonCardForm form = new PersonCardForm();
            logger.Info("������� �������� � ����������� � ������������");
            form.ShowDialog();
        }
        /// <summary>
        /// ����� ��������� � ������� �� ������ � ��������� ������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// ����� ������ � ��������� ������ ��� ������� 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchTextBox_Click(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == "����� �� ������ �������")
            {
                SearchTextBox.Text = string.Empty;
                SearchTextBox.ForeColor = Color.Black;
            }
        }
        /// <summary>
        /// �c�� ������ ������, �� ��������� ��������� 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchTextBox_Leave(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == string.Empty)
            {
                SearchTextBox.Text = "����� �� ������ �������";
                SearchTextBox.ForeColor = Color.Gray;
            }
            if (SearchTextBox.Text == string.Empty)
            {
                logger.Error("� ������ ������ �� �������� �������� �����");
            }
        }
    }
}
