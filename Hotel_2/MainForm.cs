using Hotel_2;

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
            listOfGuestsDataGridView.Rows.Clear();
            using (var context = new HotelContext())
            {
                var rooms = context.Rooms.Where(x => x.Status == "Зарезервировано");
                foreach (var room in rooms)
                {
                    listOfGuestsDataGridView.Rows.Add(room.Id, room.Name, room.Room1);
                }
            }
        }

        private void FreeRadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            listOfGuestsDataGridView.Rows.Clear();
            using (var context = new HotelContext())
            {
                var rooms = context.Rooms.Where(x => x.Status == "Свободны");
                foreach (var room in rooms)
                {
                    listOfGuestsDataGridView.Rows.Add(room.Id, room.Name, room.Room1);
                }
            }
        }

        private void OccupiedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            listOfGuestsDataGridView.Rows.Clear();
            using (var context = new HotelContext())
            {
                var rooms = context.Rooms.Where(x => x.Status == "Заняты");
                foreach (var room in rooms)
                {
                    listOfGuestsDataGridView.Rows.Add(room.Id, room.Name, room.Room1);
                }
            }
        }

        private void DischargedRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listOfGuestsDataGridView.Rows.Clear();
            using (var context = new HotelContext())
            {
                var rooms = context.Rooms.Where(x => x.Status == "Выписываются");
                foreach (var room in rooms)
                {
                    listOfGuestsDataGridView.Rows.Add(room.Id, room.Name, room.Room1);
                }
            }
        }

        private void listOfGuestsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (FreeRadioButton.Checked)
            {
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
                FullNameLabel.Text = $"{CurrentData.CurrentRoom.Name} {CurrentData.CurrentRoom.Surname}" +
                    $" {CurrentData.CurrentRoom.MiddleName}";
                EnterDateLable.Text = CurrentData.CurrentRoom.EnterDate;
                DepartureDateLable.Text = CurrentData.CurrentRoom.DepartureDate;
            }

        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CurrentData.CurrentRoom == null)
            {
                return;
            }
            using (var context = new HotelContext())
            {
                var room = context.Rooms.Where(x => x.Id == CurrentData.CurrentRoom.Id).FirstOrDefault();
                if (room != null) 
                {
                    room.Status = StatusComboBox.SelectedItem.ToString();
                }
                context.SaveChanges();
            }
        }
    }
}
