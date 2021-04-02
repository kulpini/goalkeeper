using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Goalkeeper
{
    public partial class AddTeamForm : Form
    {
        private DBConnection connection;
        public AddTeamForm()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxTeam.Text.Trim() == "")
            {
                MessageBox.Show("Не задано название команды!");
            }
            else
            {
                AddNewTeam();
            }
            MessageBox.Show("Команда добавлена!");
            ClearData();
        }

        private void ClearData()
        {
            textBoxTeam.Clear();
            dataGridPlayers.Rows.Clear();
        }

        private void AddNewTeam()
        {
            string teamName = textBoxTeam.Text.Trim();
            OleDbConnection oleDbConnection = new OleDbConnection(connection.connectionString);
            oleDbConnection.Open();
            OleDbCommand command = oleDbConnection.CreateCommand();
            command.CommandText = "INSERT INTO team (teamname) VALUES (@teamname)";
            command.Parameters.AddWithValue("@teamname", teamName);
            command.ExecuteNonQuery();
            command.CommandText = "SELECT @@IDENTITY";
            int teamId = (int)command.ExecuteScalar();
            oleDbConnection.Close();
            if (dataGridPlayers.Rows.Count>0)
                AddPlayersToTeam(teamId);
        }
        
        private void AddPlayersToTeam(int teamId)
        {
            OleDbConnection oleDbConnection = new OleDbConnection(connection.connectionString);
            oleDbConnection.Open();
            OleDbCommand command = oleDbConnection.CreateCommand();
            foreach (var datarow in dataGridPlayers.Rows)
            {
                command.CommandText = "INSERT INTO player(number,playername,teamId) VALUES (@number,@playername,@teamId)";
                int playerNumber = (int)(datarow as DataGridViewRow).Cells[0].Value;
                command.Parameters.AddWithValue("@number", playerNumber);
                string playerName = Convert.ToString((datarow as DataGridViewRow).Cells[1].Value);
                command.Parameters.AddWithValue("@playername", playerName);
                command.Parameters.AddWithValue("@teamId", teamId);
                command.ExecuteNonQuery();
            }
            oleDbConnection.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridPlayers.SelectedCells.Count > 0)
            {
                DialogResult result = MessageBox.Show("Удалить выбранного игрока?", "удаление записи", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes && dataGridPlayers.CurrentRow.Index > 0)
                {
                    dataGridPlayers.Rows.RemoveAt(dataGridPlayers.CurrentRow.Index);
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            dataGridPlayers.Rows.Add();
        }

        private void TeamForm_Load(object sender, EventArgs e)
        {
            connection = new DBConnection();
        }
    }
}
