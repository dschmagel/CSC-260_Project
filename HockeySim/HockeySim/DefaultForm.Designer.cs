namespace HockeySim
{
    partial class DefaultForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefaultForm));
            this.Drop_NumRegGames = new System.Windows.Forms.ComboBox();
            this.Drop__EliminationStyle = new System.Windows.Forms.ComboBox();
            this.Drop_SelectBracket = new System.Windows.Forms.ComboBox();
            this.TextBox_InputTeams = new System.Windows.Forms.TextBox();
            this.Button_InputTeams = new System.Windows.Forms.Button();
            this.Button_NumRegGames = new System.Windows.Forms.Button();
            this.Button_BracketSize = new System.Windows.Forms.Button();
            this.Button_EliminationStyle = new System.Windows.Forms.Button();
            this.Button_SimRegSeason = new System.Windows.Forms.Button();
            this.Button_SimPlayoffRound = new System.Windows.Forms.Button();
            this.Button_ShowStandings = new System.Windows.Forms.Button();
            this.Button_ShowBracket = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Drop_NumRegGames
            // 
            this.Drop_NumRegGames.FormattingEnabled = true;
            this.Drop_NumRegGames.Location = new System.Drawing.Point(56, 155);
            this.Drop_NumRegGames.Name = "Drop_NumRegGames";
            this.Drop_NumRegGames.Size = new System.Drawing.Size(181, 28);
            this.Drop_NumRegGames.TabIndex = 0;
            this.Drop_NumRegGames.SelectedIndexChanged += new System.EventHandler(this.Drop_NumRegGames_SelectedIndexChanged);
            // 
            // Drop__EliminationStyle
            // 
            this.Drop__EliminationStyle.FormattingEnabled = true;
            this.Drop__EliminationStyle.Location = new System.Drawing.Point(57, 430);
            this.Drop__EliminationStyle.Name = "Drop__EliminationStyle";
            this.Drop__EliminationStyle.Size = new System.Drawing.Size(181, 28);
            this.Drop__EliminationStyle.TabIndex = 1;
            this.Drop__EliminationStyle.SelectedIndexChanged += new System.EventHandler(this.Drop__EliminationStyle_SelectedIndexChanged);
            // 
            // Drop_SelectBracket
            // 
            this.Drop_SelectBracket.FormattingEnabled = true;
            this.Drop_SelectBracket.Location = new System.Drawing.Point(57, 304);
            this.Drop_SelectBracket.Name = "Drop_SelectBracket";
            this.Drop_SelectBracket.Size = new System.Drawing.Size(181, 28);
            this.Drop_SelectBracket.TabIndex = 2;
            this.Drop_SelectBracket.SelectedIndexChanged += new System.EventHandler(this.Drop_SelectBracket_SelectedIndexChanged);
            // 
            // TextBox_InputTeams
            // 
            this.TextBox_InputTeams.Location = new System.Drawing.Point(56, 30);
            this.TextBox_InputTeams.Name = "TextBox_InputTeams";
            this.TextBox_InputTeams.Size = new System.Drawing.Size(180, 26);
            this.TextBox_InputTeams.TabIndex = 3;
            this.TextBox_InputTeams.TextChanged += new System.EventHandler(this.TextBox_InputTeams_TextChanged);
            // 
            // Button_InputTeams
            // 
            this.Button_InputTeams.Location = new System.Drawing.Point(57, 78);
            this.Button_InputTeams.Name = "Button_InputTeams";
            this.Button_InputTeams.Size = new System.Drawing.Size(181, 42);
            this.Button_InputTeams.TabIndex = 4;
            this.Button_InputTeams.Text = "Input Teams";
            this.Button_InputTeams.UseVisualStyleBackColor = true;
            this.Button_InputTeams.Click += new System.EventHandler(this.Button_InputTeams_Click);
            // 
            // Button_NumRegGames
            // 
            this.Button_NumRegGames.Location = new System.Drawing.Point(57, 201);
            this.Button_NumRegGames.Name = "Button_NumRegGames";
            this.Button_NumRegGames.Size = new System.Drawing.Size(181, 70);
            this.Button_NumRegGames.TabIndex = 5;
            this.Button_NumRegGames.Text = "Select Number of Regular Season Games";
            this.Button_NumRegGames.UseVisualStyleBackColor = true;
            this.Button_NumRegGames.Click += new System.EventHandler(this.Button_NumRegGames_Click);
            // 
            // Button_BracketSize
            // 
            this.Button_BracketSize.Location = new System.Drawing.Point(56, 351);
            this.Button_BracketSize.Name = "Button_BracketSize";
            this.Button_BracketSize.Size = new System.Drawing.Size(181, 42);
            this.Button_BracketSize.TabIndex = 6;
            this.Button_BracketSize.Text = "Select Bracket Size";
            this.Button_BracketSize.UseVisualStyleBackColor = true;
            // 
            // Button_EliminationStyle
            // 
            this.Button_EliminationStyle.Location = new System.Drawing.Point(56, 473);
            this.Button_EliminationStyle.Name = "Button_EliminationStyle";
            this.Button_EliminationStyle.Size = new System.Drawing.Size(181, 42);
            this.Button_EliminationStyle.TabIndex = 7;
            this.Button_EliminationStyle.Text = "Select Elimination Style";
            this.Button_EliminationStyle.UseVisualStyleBackColor = true;
            this.Button_EliminationStyle.Click += new System.EventHandler(this.Button_EliminationStyle_Click);
            // 
            // Button_SimRegSeason
            // 
            this.Button_SimRegSeason.Location = new System.Drawing.Point(56, 641);
            this.Button_SimRegSeason.Name = "Button_SimRegSeason";
            this.Button_SimRegSeason.Size = new System.Drawing.Size(238, 65);
            this.Button_SimRegSeason.TabIndex = 8;
            this.Button_SimRegSeason.Text = "Simulate Regular Season";
            this.Button_SimRegSeason.UseVisualStyleBackColor = true;
            this.Button_SimRegSeason.Click += new System.EventHandler(this.Button_SimRegSeason_Click);
            // 
            // Button_SimPlayoffRound
            // 
            this.Button_SimPlayoffRound.Location = new System.Drawing.Point(57, 726);
            this.Button_SimPlayoffRound.Name = "Button_SimPlayoffRound";
            this.Button_SimPlayoffRound.Size = new System.Drawing.Size(238, 65);
            this.Button_SimPlayoffRound.TabIndex = 9;
            this.Button_SimPlayoffRound.Text = "Simulate Playoff Round";
            this.Button_SimPlayoffRound.UseVisualStyleBackColor = true;
            this.Button_SimPlayoffRound.Click += new System.EventHandler(this.Button_SimPlayoffRound_Click);
            // 
            // Button_ShowStandings
            // 
            this.Button_ShowStandings.Location = new System.Drawing.Point(344, 664);
            this.Button_ShowStandings.Name = "Button_ShowStandings";
            this.Button_ShowStandings.Size = new System.Drawing.Size(181, 42);
            this.Button_ShowStandings.TabIndex = 10;
            this.Button_ShowStandings.Text = "Show Standings";
            this.Button_ShowStandings.UseVisualStyleBackColor = true;
            this.Button_ShowStandings.Click += new System.EventHandler(this.Button_ShowStandings_Click);
            // 
            // Button_ShowBracket
            // 
            this.Button_ShowBracket.Location = new System.Drawing.Point(344, 712);
            this.Button_ShowBracket.Name = "Button_ShowBracket";
            this.Button_ShowBracket.Size = new System.Drawing.Size(181, 42);
            this.Button_ShowBracket.TabIndex = 11;
            this.Button_ShowBracket.Text = "Show Bracket";
            this.Button_ShowBracket.UseVisualStyleBackColor = true;
            this.Button_ShowBracket.Click += new System.EventHandler(this.Button_ShowBracket_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(273, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(869, 570);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // DefaultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 845);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Button_ShowBracket);
            this.Controls.Add(this.Button_ShowStandings);
            this.Controls.Add(this.Button_SimPlayoffRound);
            this.Controls.Add(this.Button_SimRegSeason);
            this.Controls.Add(this.Button_EliminationStyle);
            this.Controls.Add(this.Button_BracketSize);
            this.Controls.Add(this.Button_NumRegGames);
            this.Controls.Add(this.Button_InputTeams);
            this.Controls.Add(this.TextBox_InputTeams);
            this.Controls.Add(this.Drop_SelectBracket);
            this.Controls.Add(this.Drop__EliminationStyle);
            this.Controls.Add(this.Drop_NumRegGames);
            this.Name = "DefaultForm";
            this.Text = "Hockey Sim";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Drop_NumRegGames;
        private System.Windows.Forms.ComboBox Drop__EliminationStyle;
        private System.Windows.Forms.ComboBox Drop_SelectBracket;
        private System.Windows.Forms.TextBox TextBox_InputTeams;
        private System.Windows.Forms.Button Button_InputTeams;
        private System.Windows.Forms.Button Button_NumRegGames;
        private System.Windows.Forms.Button Button_BracketSize;
        private System.Windows.Forms.Button Button_EliminationStyle;
        private System.Windows.Forms.Button Button_SimRegSeason;
        private System.Windows.Forms.Button Button_SimPlayoffRound;
        private System.Windows.Forms.Button Button_ShowStandings;
        private System.Windows.Forms.Button Button_ShowBracket;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

