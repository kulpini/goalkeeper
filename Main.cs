using System;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;

namespace Goalkeeper
{
    public partial class mainForm : Form
    {
        private DBConnection connection;
        private int gameTime, gameID;
        private bool gameStarted;
        private OleDbCommand gameCommand;
        private OleDbConnection gameConnection;
        enum zoneType
        {
            Position,
            Breakaway
        }

        private zoneType zone;
        public mainForm()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (comboBoxTeam.SelectedIndex > -1)
            {
                StartGame();
            }
            else
                MessageBox.Show("Не выбрана команда!");
        }

        private void StartGame()
        {
            gameConnection.Open();
            gameTime = 0;
            gameStarted = true;
            GameTimer.Enabled = true;
            int teamId = Convert.ToInt32(comboBoxTeam.SelectedValue.ToString());
            ShowPlayersList(teamId);
            ClearInputFields();
            AddNewGame(teamId);
        }

        private void buttonEditTeam_Click(object sender, EventArgs e)
        {
            EditTeamForm editTeamForm = new EditTeamForm();
            editTeamForm.ShowDialog();
            ShowTeams();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            connection = new DBConnection();
            gameConnection = new OleDbConnection(connection.connectionString);
            gameCommand = gameConnection.CreateCommand();
            ShowTeams();
        }

        private void ShowTeams()
        {
            string queryText = "SELECT * FROM team ORDER BY teamname";
            OleDbDataAdapter adapter = new OleDbDataAdapter(queryText, connection.connectionString);
            DataTable table = new DataTable();
            adapter.Fill(table);
            comboBoxTeam.DataSource = table;
            comboBoxTeam.DisplayMember = "teamname";
            comboBoxTeam.ValueMember = "ID";
            comboBoxTeam.SelectedIndex = -1;
        }

        private void buttonAddTeam_Click(object sender, EventArgs e)
        {
            AddTeamForm teamForm = new AddTeamForm();
            teamForm.ShowDialog();
            ShowTeams();
        }

        private void ShowPlayersList(int teamId)
        {
            string queryText = "SELECT * FROM player WHERE teamId=" + Convert.ToString(teamId) + " ORDER BY number";
            OleDbDataAdapter adapter = new OleDbDataAdapter(queryText, connection.connectionString);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset, "player");
            dataGridPlayers.DataSource = dataset.Tables["player"].DefaultView;
            dataGridPlayers.Columns["ID"].Visible = false;
            dataGridPlayers.Columns["teamId"].Visible = false;
            dataGridPlayers.Columns["number"].HeaderCell.Value = "Номер";
            dataGridPlayers.Columns["number"].Width = 70;
            dataGridPlayers.Columns["playername"].HeaderCell.Value = "Имя игрока";
            dataGridPlayers.Columns["playername"].Width = 200;
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            gameTime += 1;
            if (gameTime>3600)
            {
                MessageBox.Show("Игра окончена!");
                ClearInputFields();
                dataGridPlayers.Rows.Clear();
                gameTime = 0;
                gameStarted = false;
                GameTimer.Enabled = false;
            }
            labelTimer.Text = (gameTime / 60).ToString("D2") + ":" + (gameTime % 60).ToString("D2");
        }

        private void dataGridPlayers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gameStarted)
            {
                string playername = Convert.ToString(dataGridPlayers.CurrentRow.Cells["playername"].Value);
                labelGoalInfo.Text = $"игрок - {playername}";
                int playerId = Convert.ToInt32(dataGridPlayers.CurrentRow.Cells["ID"].Value);
                panelPosition.Visible = true;
            }
        }

        private void buttonPosition_Click(object sender, EventArgs e)
        {
            zone = zoneType.Position;
            labelGoalInfo.Text += "\nЗона - \"Позиция\"";
            panelZones.Visible = true;
        }

        private void buttonBreakAway_Click(object sender, EventArgs e)
        {
            zone = zoneType.Breakaway;
            labelGoalInfo.Text += "\nЗона - \"Отрыв\"";
            panelZones.Visible = true;
        }

        private void SetGoal(object sender)
        {
            string goalPictureName = (sender as PictureBox).Name;
            int goal = Convert.ToInt32(goalPictureName.Substring(goalPictureName.Length - 1));
            int playerId = Convert.ToInt32(dataGridPlayers.CurrentRow.Cells["ID"].Value);
            SaveGoal(playerId, goal, (int)zone);
            ClearInputFields();
        }

        private void ClearInputFields()
        {
            labelGoalInfo.Text = "";
            panelZones.Visible = false;
            panelPosition.Visible = false;
            gameCommand.Parameters.Clear();
        }

        private void SaveGoal(int playerId, int goal, int zone)
        {
            gameCommand.Parameters.Clear();
            gameCommand.CommandText = "INSERT INTO goal ([goal],[playerId],[zone],[gameId]) VALUES (@goal,@playerid,@zone,@gameid)";
            gameCommand.Parameters.AddWithValue("@goal", goal);
            gameCommand.Parameters.AddWithValue("@playerid", playerId);
            gameCommand.Parameters.AddWithValue("@zone", zone);
            gameCommand.Parameters.AddWithValue("@gameid", gameID);
            gameCommand.ExecuteNonQuery();
        }

        private void pictureGoal1_Click(object sender, EventArgs e)
        {
            SetGoal(sender);
        }

        private void buttonStatistics_Click(object sender, EventArgs e)
        {
            StatForm statForm = new StatForm();
            statForm.ShowDialog();
        }

        private void AddNewGame(int teamId)
        {
            gameCommand.Parameters.Clear();
            gameCommand.CommandText = "INSERT INTO game(teamId,gamedate) VALUES (@teamid,@gamedate)";
            gameCommand.Parameters.AddWithValue("@teamid", teamId);
            gameCommand.Parameters.AddWithValue("@gamedate", (DateTime.Now).ToString("yyyy.MM.dd"));
            gameCommand.ExecuteNonQuery();
            gameCommand.CommandText = "SELECT @@IDENTITY";
            gameID = (int)gameCommand.ExecuteScalar();
        }
    }
}
