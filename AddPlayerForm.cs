using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Goalkeeper
{
    public partial class AddPlayerForm : Form
    {
        private string playerName;
        private int playerNumber;

        public string PlayerName
        {
            get { return playerName; }
        }

        public int PlayerNumber
        {
            get { return playerNumber; }
        }

        public AddPlayerForm()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void buttonAddPlayer_Click(object sender, EventArgs e)
        {
            if (textBoxPlayerName.Text.Trim() != "")
            {
                if (textBoxNumber.Text.Trim() != "")
                {
                    playerName = textBoxPlayerName.Text.Trim();
                    try
                    {
                        playerNumber = int.Parse(textBoxNumber.Text);
                        this.DialogResult = DialogResult.OK;
                    }
                    catch
                    {
                        MessageBox.Show("Неверный формат номера!");
                    }
                }
                else
                    MessageBox.Show("Не задан номер игрока!");
            }
            else
                MessageBox.Show("Не задано имя игрока!");
        }
    }
}
