namespace Goalkeeper
{
    partial class StatForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxPlayer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonShowStat = new System.Windows.Forms.Button();
            this.comboBoxTeam = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelGoals = new System.Windows.Forms.Panel();
            this.labelGoal2 = new System.Windows.Forms.Label();
            this.labelGoal3 = new System.Windows.Forms.Label();
            this.labelGoal4 = new System.Windows.Forms.Label();
            this.labelGoal5 = new System.Windows.Forms.Label();
            this.labelGoal6 = new System.Windows.Forms.Label();
            this.labelGoal7 = new System.Windows.Forms.Label();
            this.labelGoal8 = new System.Windows.Forms.Label();
            this.labelGoal9 = new System.Windows.Forms.Label();
            this.labelGoal1 = new System.Windows.Forms.Label();
            this.comboBoxGameDate = new System.Windows.Forms.ComboBox();
            this.checkBoxDate = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelGoals.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxDate);
            this.panel1.Controls.Add(this.comboBoxGameDate);
            this.panel1.Controls.Add(this.comboBoxPlayer);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonShowStat);
            this.panel1.Controls.Add(this.comboBoxTeam);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 156);
            this.panel1.TabIndex = 0;
            // 
            // comboBoxPlayer
            // 
            this.comboBoxPlayer.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxPlayer.FormattingEnabled = true;
            this.comboBoxPlayer.Location = new System.Drawing.Point(295, 45);
            this.comboBoxPlayer.Name = "comboBoxPlayer";
            this.comboBoxPlayer.Size = new System.Drawing.Size(328, 34);
            this.comboBoxPlayer.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(291, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Игрок:";
            // 
            // buttonShowStat
            // 
            this.buttonShowStat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowStat.ForeColor = System.Drawing.Color.Maroon;
            this.buttonShowStat.Location = new System.Drawing.Point(652, 34);
            this.buttonShowStat.Name = "buttonShowStat";
            this.buttonShowStat.Size = new System.Drawing.Size(121, 45);
            this.buttonShowStat.TabIndex = 2;
            this.buttonShowStat.Text = "Показать";
            this.buttonShowStat.UseVisualStyleBackColor = true;
            this.buttonShowStat.Click += new System.EventHandler(this.buttonShowStat_Click);
            // 
            // comboBoxTeam
            // 
            this.comboBoxTeam.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxTeam.FormattingEnabled = true;
            this.comboBoxTeam.Location = new System.Drawing.Point(26, 45);
            this.comboBoxTeam.Name = "comboBoxTeam";
            this.comboBoxTeam.Size = new System.Drawing.Size(215, 34);
            this.comboBoxTeam.TabIndex = 1;
            this.comboBoxTeam.SelectionChangeCommitted += new System.EventHandler(this.comboBoxTeam_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Команда:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelGoals);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 294);
            this.panel2.TabIndex = 1;
            // 
            // panelGoals
            // 
            this.panelGoals.Controls.Add(this.labelGoal2);
            this.panelGoals.Controls.Add(this.labelGoal3);
            this.panelGoals.Controls.Add(this.labelGoal4);
            this.panelGoals.Controls.Add(this.labelGoal5);
            this.panelGoals.Controls.Add(this.labelGoal6);
            this.panelGoals.Controls.Add(this.labelGoal7);
            this.panelGoals.Controls.Add(this.labelGoal8);
            this.panelGoals.Controls.Add(this.labelGoal9);
            this.panelGoals.Controls.Add(this.labelGoal1);
            this.panelGoals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGoals.Location = new System.Drawing.Point(0, 0);
            this.panelGoals.Name = "panelGoals";
            this.panelGoals.Size = new System.Drawing.Size(800, 294);
            this.panelGoals.TabIndex = 9;
            // 
            // labelGoal2
            // 
            this.labelGoal2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelGoal2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelGoal2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGoal2.Location = new System.Drawing.Point(359, 38);
            this.labelGoal2.Name = "labelGoal2";
            this.labelGoal2.Size = new System.Drawing.Size(70, 70);
            this.labelGoal2.TabIndex = 17;
            this.labelGoal2.Text = "10%";
            this.labelGoal2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGoal3
            // 
            this.labelGoal3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelGoal3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelGoal3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGoal3.Location = new System.Drawing.Point(430, 38);
            this.labelGoal3.Name = "labelGoal3";
            this.labelGoal3.Size = new System.Drawing.Size(70, 70);
            this.labelGoal3.TabIndex = 16;
            this.labelGoal3.Text = "10%";
            this.labelGoal3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGoal4
            // 
            this.labelGoal4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelGoal4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelGoal4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGoal4.Location = new System.Drawing.Point(288, 108);
            this.labelGoal4.Name = "labelGoal4";
            this.labelGoal4.Size = new System.Drawing.Size(70, 70);
            this.labelGoal4.TabIndex = 15;
            this.labelGoal4.Text = "10%";
            this.labelGoal4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGoal5
            // 
            this.labelGoal5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelGoal5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelGoal5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGoal5.Location = new System.Drawing.Point(359, 108);
            this.labelGoal5.Name = "labelGoal5";
            this.labelGoal5.Size = new System.Drawing.Size(70, 70);
            this.labelGoal5.TabIndex = 14;
            this.labelGoal5.Text = "10%";
            this.labelGoal5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGoal6
            // 
            this.labelGoal6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelGoal6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelGoal6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGoal6.Location = new System.Drawing.Point(430, 108);
            this.labelGoal6.Name = "labelGoal6";
            this.labelGoal6.Size = new System.Drawing.Size(70, 70);
            this.labelGoal6.TabIndex = 13;
            this.labelGoal6.Text = "10%";
            this.labelGoal6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGoal7
            // 
            this.labelGoal7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelGoal7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelGoal7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGoal7.Location = new System.Drawing.Point(288, 178);
            this.labelGoal7.Name = "labelGoal7";
            this.labelGoal7.Size = new System.Drawing.Size(70, 70);
            this.labelGoal7.TabIndex = 12;
            this.labelGoal7.Text = "10%";
            this.labelGoal7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGoal8
            // 
            this.labelGoal8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelGoal8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelGoal8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGoal8.Location = new System.Drawing.Point(359, 178);
            this.labelGoal8.Name = "labelGoal8";
            this.labelGoal8.Size = new System.Drawing.Size(70, 70);
            this.labelGoal8.TabIndex = 11;
            this.labelGoal8.Text = "10%";
            this.labelGoal8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGoal9
            // 
            this.labelGoal9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelGoal9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelGoal9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGoal9.Location = new System.Drawing.Point(430, 178);
            this.labelGoal9.Name = "labelGoal9";
            this.labelGoal9.Size = new System.Drawing.Size(70, 70);
            this.labelGoal9.TabIndex = 10;
            this.labelGoal9.Text = "10%";
            this.labelGoal9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGoal1
            // 
            this.labelGoal1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelGoal1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelGoal1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGoal1.Location = new System.Drawing.Point(288, 38);
            this.labelGoal1.Name = "labelGoal1";
            this.labelGoal1.Size = new System.Drawing.Size(70, 70);
            this.labelGoal1.TabIndex = 9;
            this.labelGoal1.Text = "10%";
            this.labelGoal1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxGameDate
            // 
            this.comboBoxGameDate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxGameDate.FormattingEnabled = true;
            this.comboBoxGameDate.Location = new System.Drawing.Point(295, 98);
            this.comboBoxGameDate.Name = "comboBoxGameDate";
            this.comboBoxGameDate.Size = new System.Drawing.Size(215, 34);
            this.comboBoxGameDate.TabIndex = 5;
            // 
            // checkBoxDate
            // 
            this.checkBoxDate.AutoSize = true;
            this.checkBoxDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxDate.Location = new System.Drawing.Point(128, 102);
            this.checkBoxDate.Name = "checkBoxDate";
            this.checkBoxDate.Size = new System.Drawing.Size(149, 27);
            this.checkBoxDate.TabIndex = 6;
            this.checkBoxDate.Text = "Игра за дату:";
            this.checkBoxDate.UseVisualStyleBackColor = true;
            // 
            // StatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Статистика бросков";
            this.Load += new System.EventHandler(this.StatForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelGoals.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxPlayer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonShowStat;
        private System.Windows.Forms.ComboBox comboBoxTeam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelGoals;
        private System.Windows.Forms.Label labelGoal2;
        private System.Windows.Forms.Label labelGoal3;
        private System.Windows.Forms.Label labelGoal4;
        private System.Windows.Forms.Label labelGoal5;
        private System.Windows.Forms.Label labelGoal6;
        private System.Windows.Forms.Label labelGoal7;
        private System.Windows.Forms.Label labelGoal8;
        private System.Windows.Forms.Label labelGoal9;
        private System.Windows.Forms.Label labelGoal1;
        private System.Windows.Forms.CheckBox checkBoxDate;
        private System.Windows.Forms.ComboBox comboBoxGameDate;
    }
}