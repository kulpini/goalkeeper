using System;
using System.Data;
using System.Data.OleDb;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Goalkeeper
{
    public partial class EditTeamForm : Form
    {
        private DBConnection connection;
        public EditTeamForm()
        {
            InitializeComponent();
        }

        private void TeamList_Load(object sender, EventArgs e)
        {
            connection = new DBConnection();
            ShowTeamList();
        }

        private void ShowTeamList()
        {
            string queryText = "SELECT * FROM team ORDER BY teamname";
            OleDbDataAdapter adapter = new OleDbDataAdapter(queryText, connection.connectionString);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "team");
            dataGridTeams.DataSource = dataSet.Tables["team"].DefaultView;
            dataGridTeams.Columns["ID"].Visible = false;
            dataGridTeams.Columns["teamname"].HeaderCell.Value = "Название команды";
            dataGridTeams.Columns["teamname"].Width = 200;
        }

        private void ShowPlayers(int teamId)
        {
            string queryText = "SELECT * FROM player WHERE teamId=" + Convert.ToString(teamId) + " ORDER BY number";
            OleDbDataAdapter adapter = new OleDbDataAdapter(queryText, connection.connectionString);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset, "player");
            dataGridPlayers.DataSource = dataset.Tables["player"].DefaultView;
            dataGridPlayers.Columns["ID"].Visible = false;
            dataGridPlayers.Columns["teamId"].Visible = false;
            dataGridPlayers.Columns["number"].HeaderCell.Value = "Номер";
            dataGridPlayers.Columns["number"].Width = 90;
            dataGridPlayers.Columns["playername"].HeaderCell.Value = "Имя игрока";
            dataGridPlayers.Columns["playername"].Width = 180;
        }

        private void buttonAddTeam_Click(object sender, EventArgs e)
        {
            AddTeamForm addTeamForm = new AddTeamForm();
            addTeamForm.ShowDialog();
            ShowTeamList();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridTeams.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Удалить команду из списка?", "Удаление данных", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int teamId = Convert.ToInt32(dataGridTeams.CurrentRow.Cells["ID"].Value);
                    DeleteTeam(teamId);
                    ShowTeamList();
                }
            }
        }

        private void DeleteTeam(int teamId)
        {
            OleDbConnection oleConnection = new OleDbConnection(connection.connectionString);
            oleConnection.Open();
            OleDbCommand command = oleConnection.CreateCommand();
            command.CommandText = "DELETE FROM team WHERE ID=@teamid";
            command.Parameters.AddWithValue("@teamid", teamId);
            command.ExecuteNonQuery();
            oleConnection.Close();
        }

        private void buttonDeletePlayer_Click(object sender, EventArgs e)
        {
            if (dataGridPlayers.CurrentCell != null)
            {
                DialogResult result = MessageBox.Show("Удалить игрока из команды?", "удаление записи....", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int playerId = Convert.ToInt32(dataGridPlayers.CurrentRow.Cells["ID"].Value);
                    int teamId = Convert.ToInt32(dataGridTeams.CurrentRow.Cells["ID"].Value);
                    DeletePlayer(playerId);
                    ShowPlayers(teamId);
                }
            }
        }

        private void DeletePlayer(int playerId)
        {
            OleDbConnection oleConnection = new OleDbConnection(connection.connectionString);
            oleConnection.Open();
            OleDbCommand command = oleConnection.CreateCommand();
            command.CommandText = "DELETE FROM player WHERE ID=@playerid";
            command.Parameters.AddWithValue("@playerid", playerId);
            command.ExecuteNonQuery();
            oleConnection.Close();
        }

        private void buttonAddPlayer_Click(object sender, EventArgs e)
        {
            if (dataGridTeams.CurrentCell != null)
            {
                AddPlayerForm addPlayerForm = new AddPlayerForm();
                DialogResult result = addPlayerForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string playerName = addPlayerForm.PlayerName;
                    int playerNumber = addPlayerForm.PlayerNumber;
                    int teamId = Convert.ToInt32(dataGridTeams.CurrentRow.Cells["ID"].Value);
                    AddPlayer(teamId, playerName, playerNumber);
                    ShowPlayers(teamId);
                }
            }
        }

        public void AddPlayer(int teamId, string playerName, int playerNumber)
        {
            OleDbConnection oleConnection = new OleDbConnection(connection.connectionString);
            oleConnection.Open();
            OleDbCommand command = oleConnection.CreateCommand();
            command.CommandText = "INSERT INTO player ([number],[playername],[teamId]) VALUES (@playernumber,@playername,@teamid)";
            command.Parameters.AddWithValue("@playernumber", playerNumber);
            command.Parameters.AddWithValue("@playername", playerName);
            command.Parameters.AddWithValue("@teamid", teamId);
            command.ExecuteNonQuery();
            oleConnection.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (dataGridTeams.CurrentCell != null)
            {
                int teamId = Convert.ToInt32(dataGridTeams.CurrentRow.Cells["ID"].Value);
                string teamName = Convert.ToString(dataGridTeams.CurrentRow.Cells["teamname"].Value);
                SaveTeam(teamId, teamName);
                SavePlayers(teamId);
                MessageBox.Show("Информация о выбранной команде сохранена.");
            }
        }

        private void SaveTeam(int teamId, string teamName)
        {
            OleDbConnection oleConnection = new OleDbConnection(connection.connectionString);
            oleConnection.Open();
            OleDbCommand command = oleConnection.CreateCommand();
            command.CommandText = "UPDATE team SET teamname = @teamname WHERE ID = @teamid";
            command.Parameters.AddWithValue("@teamname", teamName);
            command.Parameters.AddWithValue("@teamiId", teamId);
            command.ExecuteNonQuery();
            oleConnection.Close();
        }

        private void SavePlayers(int teamId)
        {
            if (dataGridPlayers.Rows.Count > 0)
            {
                OleDbConnection oleConnection = new OleDbConnection(connection.connectionString);
                oleConnection.Open();
                OleDbCommand command = oleConnection.CreateCommand();
                for (int i = 0; i < dataGridPlayers.Rows.Count; i++)
                {
                    command.Parameters.Clear();
                    int playerId = Convert.ToInt32(dataGridPlayers.Rows[i].Cells["ID"].Value);
                    int playerNumber = Convert.ToInt32(dataGridPlayers.Rows[i].Cells["number"].Value);
                    string playerName = Convert.ToString(dataGridPlayers.Rows[i].Cells["playername"].Value);
                    command.CommandText = "UPDATE player SET [number] = @playernumber, [playername] = @playername WHERE ID = @playerid";
                    command.Parameters.AddWithValue("@playernumber", playerNumber);
                    command.Parameters.AddWithValue("@playername", playerName);
                    command.Parameters.AddWithValue("@playerid", playerId);
                    command.ExecuteNonQuery();
                }
                oleConnection.Close();
            }
        }

        private void dataGridTeams_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int teamId = Convert.ToInt32(dataGridTeams.CurrentRow.Cells["ID"].Value);
            ShowPlayers(teamId);
        }
    }
}
