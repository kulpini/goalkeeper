namespace Goalkeeper
{
    partial class EditTeamForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTeamForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAddTeam = new System.Windows.Forms.Button();
            this.dataGridPlayers = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridTeams = new System.Windows.Forms.DataGridView();
            this.buttonDeletePlayer = new System.Windows.Forms.Button();
            this.buttonAddPlayer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTeams)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonSave.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
            this.buttonSave.Location = new System.Drawing.Point(252, 7);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(44, 44);
            this.buttonSave.TabIndex = 17;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.Location = new System.Drawing.Point(390, 7);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(44, 44);
            this.buttonDelete.TabIndex = 16;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAddTeam
            // 
            this.buttonAddTeam.FlatAppearance.BorderSize = 0;
            this.buttonAddTeam.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonAddTeam.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonAddTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddTeam.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddTeam.Image")));
            this.buttonAddTeam.Location = new System.Drawing.Point(340, 7);
            this.buttonAddTeam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddTeam.Name = "buttonAddTeam";
            this.buttonAddTeam.Size = new System.Drawing.Size(44, 44);
            this.buttonAddTeam.TabIndex = 15;
            this.buttonAddTeam.UseVisualStyleBackColor = true;
            this.buttonAddTeam.Click += new System.EventHandler(this.buttonAddTeam_Click);
            // 
            // dataGridPlayers
            // 
            this.dataGridPlayers.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridPlayers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPlayers.Location = new System.Drawing.Point(518, 57);
            this.dataGridPlayers.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridPlayers.Name = "dataGridPlayers";
            this.dataGridPlayers.RowHeadersVisible = false;
            this.dataGridPlayers.RowHeadersWidth = 51;
            this.dataGridPlayers.Size = new System.Drawing.Size(407, 442);
            this.dataGridPlayers.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.ForestGreen;
            this.label3.Location = new System.Drawing.Point(514, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Список игроков:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(23, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Название команды:";
            // 
            // dataGridTeams
            // 
            this.dataGridTeams.AllowUserToAddRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridTeams.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridTeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTeams.Location = new System.Drawing.Point(27, 57);
            this.dataGridTeams.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridTeams.Name = "dataGridTeams";
            this.dataGridTeams.RowHeadersVisible = false;
            this.dataGridTeams.RowHeadersWidth = 51;
            this.dataGridTeams.Size = new System.Drawing.Size(407, 442);
            this.dataGridTeams.TabIndex = 18;
            this.dataGridTeams.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridTeams_CellClick);
            // 
            // buttonDeletePlayer
            // 
            this.buttonDeletePlayer.FlatAppearance.BorderSize = 0;
            this.buttonDeletePlayer.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonDeletePlayer.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonDeletePlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeletePlayer.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeletePlayer.Image")));
            this.buttonDeletePlayer.Location = new System.Drawing.Point(881, 7);
            this.buttonDeletePlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeletePlayer.Name = "buttonDeletePlayer";
            this.buttonDeletePlayer.Size = new System.Drawing.Size(44, 44);
            this.buttonDeletePlayer.TabIndex = 20;
            this.buttonDeletePlayer.UseVisualStyleBackColor = true;
            this.buttonDeletePlayer.Click += new System.EventHandler(this.buttonDeletePlayer_Click);
            // 
            // buttonAddPlayer
            // 
            this.buttonAddPlayer.FlatAppearance.BorderSize = 0;
            this.buttonAddPlayer.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonAddPlayer.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonAddPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddPlayer.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddPlayer.Image")));
            this.buttonAddPlayer.Location = new System.Drawing.Point(831, 7);
            this.buttonAddPlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddPlayer.Name = "buttonAddPlayer";
            this.buttonAddPlayer.Size = new System.Drawing.Size(44, 44);
            this.buttonAddPlayer.TabIndex = 19;
            this.buttonAddPlayer.UseVisualStyleBackColor = true;
            this.buttonAddPlayer.Click += new System.EventHandler(this.buttonAddPlayer_Click);
            // 
            // EditTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 531);
            this.Controls.Add(this.buttonDeletePlayer);
            this.Controls.Add(this.buttonAddPlayer);
            this.Controls.Add(this.dataGridTeams);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAddTeam);
            this.Controls.Add(this.dataGridPlayers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditTeamForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Каталог команд";
            this.Load += new System.EventHandler(this.TeamList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTeams)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAddTeam;
        private System.Windows.Forms.DataGridView dataGridPlayers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridTeams;
        private System.Windows.Forms.Button buttonDeletePlayer;
        private System.Windows.Forms.Button buttonAddPlayer;
    }
}