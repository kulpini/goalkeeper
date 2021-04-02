using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Goalkeeper
{
    public partial class StatForm : Form
    {
        DBConnection connection;
        public StatForm()
        {
            InitializeComponent();
        }

        private void StatForm_Load(object sender, EventArgs e)
        {
            ClearData();
            connection = new DBConnection();
            ShowTeams();
        }

        private void ShowTeams()
        {
            string queryText = "SELECT * FROM team ORDER BY teamname";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(queryText, connection.connectionString);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "team");
            BindingSource bindingSource = new BindingSource(dataSet, "team");
            comboBoxTeam.DataSource = bindingSource;
            comboBoxTeam.DisplayMember = "teamname";
            comboBoxTeam.ValueMember = "ID";
            comboBoxTeam.SelectedIndex = -1;
        }

        private void comboBoxTeam_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxTeam.SelectedIndex != -1)
            {
                string queryText = "SELECT * FROM player WHERE teamId=" + comboBoxTeam.SelectedValue.ToString() + " ORDER BY number";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(queryText, connection.connectionString);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "player");
                BindingSource bindingSource = new BindingSource(dataSet, "player");
                comboBoxPlayer.DataSource = bindingSource;
                comboBoxPlayer.DisplayMember = "playername";
                comboBoxPlayer.ValueMember = "ID";
                comboBoxPlayer.SelectedIndex = -1;

                queryText = "SELECT * FROM game WHERE teamId=" + comboBoxTeam.SelectedValue.ToString() + " ORDER BY gamedate";
                OleDbDataAdapter dataAdapterDate = new OleDbDataAdapter(queryText, connection.connectionString);
                dataAdapterDate.Fill(dataSet, "game");
                BindingSource bindingSourceGame = new BindingSource(dataSet, "game");
                comboBoxGameDate.DataSource = bindingSourceGame;
                comboBoxGameDate.DisplayMember = "gamedate";
                comboBoxGameDate.ValueMember = "ID";
                comboBoxGameDate.SelectedIndex = -1;
            }
        }

        private void buttonShowStat_Click(object sender, EventArgs e)
        {
            if (comboBoxPlayer.SelectedIndex != -1)
            {
                int playerId = int.Parse(comboBoxPlayer.SelectedValue.ToString());
                if (checkBoxDate.Checked && comboBoxGameDate.SelectedIndex != -1)
                {
                    int gameId = int.Parse(comboBoxGameDate.SelectedIndex.ToString());
                    ShowStatByGame(playerId, gameId);
                }
                else
                    ShowStat(playerId);
            }
        }

        private void ShowStatByGame(int playerId, int gameId)
        {
            ClearData();
            int goalsCount = CountTotalGoalsInGame(playerId, gameId);
            if (goalsCount > 0)
            {
                OleDbConnection oleConnection = new OleDbConnection(connection.connectionString);
                oleConnection.Open();
                OleDbCommand command = oleConnection.CreateCommand();
                command.CommandText = "SELECT COUNT(goal) as cnt,goal FROM goal WHERE playerId=@playerid AND gameId=@gameid GROUP BY goal";
                command.Parameters.AddWithValue("@playerid", playerId);
                command.Parameters.AddWithValue("@gameid", gameId);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int goalZone = Convert.ToInt32(reader["goal"]);
                    int goalSum = Convert.ToInt32(reader["cnt"]);
                    int goalPercent = goalSum * 100 / goalsCount;
                    WriteGoalResult(goalZone, goalPercent);
                }
                oleConnection.Close();
            }
        }

        private void ShowStat(int playerId)
        {
            ClearData();
            int goalsCount = CountTotalGoals(playerId);
            if (goalsCount > 0)
            {
                OleDbConnection oleConnection = new OleDbConnection(connection.connectionString);
                oleConnection.Open();
                OleDbCommand command = oleConnection.CreateCommand();
                command.CommandText = "SELECT COUNT(goal) as cnt,goal FROM goal WHERE playerId=@playerid GROUP BY goal";
                command.Parameters.AddWithValue("@playerid", playerId);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int goalZone = Convert.ToInt32(reader["goal"]);
                    int goalSum = Convert.ToInt32(reader["cnt"]);
                    int goalPercent = goalSum * 100 / goalsCount;
                    WriteGoalResult(goalZone, goalPercent);
                }
                oleConnection.Close();
            }
        }

        private void WriteGoalResult(int zoneId, int goalPercent)
        {
            string labelName = "labelGoal" + Convert.ToString(zoneId);
            string percentValue = Convert.ToString(goalPercent) + "%";
            (this.panelGoals.Controls[labelName] as Label).Text = percentValue;
        }

        private void ClearData()
        {
            foreach (Control labelControl in panelGoals.Controls)
            {
                labelControl.Text = "0%";
            }
        }

        private int CountTotalGoals(int playerId)
        {
            OleDbConnection oleConnection = new OleDbConnection(connection.connectionString);
            oleConnection.Open();
            OleDbCommand command = oleConnection.CreateCommand();
            command.CommandText = "SELECT COUNT(ID) FROM goal WHERE playerId=@playerid";
            command.Parameters.AddWithValue("@playerid", playerId);
            int totalGoals = Convert.ToInt32(command.ExecuteScalar());
            oleConnection.Close();
            return totalGoals;
        }

        private int CountTotalGoalsInGame(int playerId, int gameId)
        {
            OleDbConnection oleConnection = new OleDbConnection(connection.connectionString);
            oleConnection.Open();
            OleDbCommand command = oleConnection.CreateCommand();
            command.CommandText = "SELECT COUNT(ID) FROM goal WHERE playerId=@playerid AND gameId=@gameid";
            command.Parameters.AddWithValue("@playerid", playerId);
            command.Parameters.AddWithValue("@gameid", gameId);
            int totalGoals = Convert.ToInt32(command.ExecuteScalar());
            oleConnection.Close();
            return totalGoals;
        }
    }
}
