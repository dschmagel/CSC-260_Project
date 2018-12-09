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
            this.Button_ShowBracket = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Button_NumTeams = new System.Windows.Forms.Button();
            this.Label_InputTeams = new System.Windows.Forms.Label();
            this.Label__NumTeams = new System.Windows.Forms.Label();
            this.Label_NumRegGames = new System.Windows.Forms.Label();
            this.Label_BracketSize = new System.Windows.Forms.Label();
            this.Label_EliminationStyle = new System.Windows.Forms.Label();
            this.LB_NumTeams = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Drop_NumRegGames
            // 
            this.Drop_NumRegGames.FormattingEnabled = true;
            this.Drop_NumRegGames.Items.AddRange(new object[] {
            "4",
            "6",
            "8",
            "10",
            "12"});
            this.Drop_NumRegGames.Location = new System.Drawing.Point(57, 284);
            this.Drop_NumRegGames.Name = "Drop_NumRegGames";
            this.Drop_NumRegGames.Size = new System.Drawing.Size(271, 28);
            this.Drop_NumRegGames.TabIndex = 0;
            this.Drop_NumRegGames.SelectedIndexChanged += new System.EventHandler(this.Drop_NumRegGames_SelectedIndexChanged);
            // 
            // Drop__EliminationStyle
            // 
            this.Drop__EliminationStyle.FormattingEnabled = true;
            this.Drop__EliminationStyle.Items.AddRange(new object[] {
            "Single Elimination",
            "Best of 5 Series",
            "Best of 7 Series"});
            this.Drop__EliminationStyle.Location = new System.Drawing.Point(57, 584);
            this.Drop__EliminationStyle.Name = "Drop__EliminationStyle";
            this.Drop__EliminationStyle.Size = new System.Drawing.Size(270, 28);
            this.Drop__EliminationStyle.TabIndex = 1;
            this.Drop__EliminationStyle.SelectedIndexChanged += new System.EventHandler(this.Drop__EliminationStyle_SelectedIndexChanged);
            // 
            // Drop_SelectBracket
            // 
            this.Drop_SelectBracket.FormattingEnabled = true;
            this.Drop_SelectBracket.Items.AddRange(new object[] {
            "4",
            "8",
            "16"});
            this.Drop_SelectBracket.Location = new System.Drawing.Point(58, 444);
            this.Drop_SelectBracket.Name = "Drop_SelectBracket";
            this.Drop_SelectBracket.Size = new System.Drawing.Size(270, 28);
            this.Drop_SelectBracket.TabIndex = 2;
            this.Drop_SelectBracket.SelectedIndexChanged += new System.EventHandler(this.Drop_SelectBracket_SelectedIndexChanged);
            // 
            // TextBox_InputTeams
            // 
            this.TextBox_InputTeams.Location = new System.Drawing.Point(56, 30);
            this.TextBox_InputTeams.Name = "TextBox_InputTeams";
            this.TextBox_InputTeams.Size = new System.Drawing.Size(364, 26);
            this.TextBox_InputTeams.TabIndex = 3;
            this.TextBox_InputTeams.TextChanged += new System.EventHandler(this.TextBox_InputTeams_TextChanged);
            // 
            // Button_InputTeams
            // 
            this.Button_InputTeams.Location = new System.Drawing.Point(57, 78);
            this.Button_InputTeams.Name = "Button_InputTeams";
            this.Button_InputTeams.Size = new System.Drawing.Size(270, 42);
            this.Button_InputTeams.TabIndex = 4;
            this.Button_InputTeams.Text = "Input Teams";
            this.Button_InputTeams.UseVisualStyleBackColor = true;
            this.Button_InputTeams.Click += new System.EventHandler(this.Button_InputTeams_Click);
            // 
            // Button_NumRegGames
            // 
            this.Button_NumRegGames.Location = new System.Drawing.Point(58, 330);
            this.Button_NumRegGames.Name = "Button_NumRegGames";
            this.Button_NumRegGames.Size = new System.Drawing.Size(270, 70);
            this.Button_NumRegGames.TabIndex = 5;
            this.Button_NumRegGames.Text = "Select Number of Times Each Team Will Play Each Other";
            this.Button_NumRegGames.UseVisualStyleBackColor = true;
            this.Button_NumRegGames.Click += new System.EventHandler(this.Button_NumRegGames_Click);
            // 
            // Button_BracketSize
            // 
            this.Button_BracketSize.Location = new System.Drawing.Point(57, 491);
            this.Button_BracketSize.Name = "Button_BracketSize";
            this.Button_BracketSize.Size = new System.Drawing.Size(271, 50);
            this.Button_BracketSize.TabIndex = 6;
            this.Button_BracketSize.Text = "Select Bracket Size";
            this.Button_BracketSize.UseVisualStyleBackColor = true;
            this.Button_BracketSize.Click += new System.EventHandler(this.Button_BracketSize_Click);
            // 
            // Button_EliminationStyle
            // 
            this.Button_EliminationStyle.Location = new System.Drawing.Point(56, 627);
            this.Button_EliminationStyle.Name = "Button_EliminationStyle";
            this.Button_EliminationStyle.Size = new System.Drawing.Size(271, 55);
            this.Button_EliminationStyle.TabIndex = 7;
            this.Button_EliminationStyle.Text = "Select Elimination Style";
            this.Button_EliminationStyle.UseVisualStyleBackColor = true;
            this.Button_EliminationStyle.Click += new System.EventHandler(this.Button_EliminationStyle_Click);
            // 
            // Button_SimRegSeason
            // 
            this.Button_SimRegSeason.Location = new System.Drawing.Point(354, 659);
            this.Button_SimRegSeason.Name = "Button_SimRegSeason";
            this.Button_SimRegSeason.Size = new System.Drawing.Size(377, 178);
            this.Button_SimRegSeason.TabIndex = 8;
            this.Button_SimRegSeason.Text = "Simulate Regular Season";
            this.Button_SimRegSeason.UseVisualStyleBackColor = true;
            this.Button_SimRegSeason.Click += new System.EventHandler(this.Button_SimRegSeason_Click);
            // 
            // Button_SimPlayoffRound
            // 
            this.Button_SimPlayoffRound.Location = new System.Drawing.Point(792, 659);
            this.Button_SimPlayoffRound.Name = "Button_SimPlayoffRound";
            this.Button_SimPlayoffRound.Size = new System.Drawing.Size(371, 178);
            this.Button_SimPlayoffRound.TabIndex = 9;
            this.Button_SimPlayoffRound.Text = "Simulate Playoffs";
            this.Button_SimPlayoffRound.UseVisualStyleBackColor = true;
            this.Button_SimPlayoffRound.Click += new System.EventHandler(this.Button_SimPlayoffRound_Click);
            // 
            // Button_ShowBracket
            // 
            this.Button_ShowBracket.Location = new System.Drawing.Point(57, 735);
            this.Button_ShowBracket.Name = "Button_ShowBracket";
            this.Button_ShowBracket.Size = new System.Drawing.Size(271, 102);
            this.Button_ShowBracket.TabIndex = 11;
            this.Button_ShowBracket.Text = "Show Bracket";
            this.Button_ShowBracket.UseVisualStyleBackColor = true;
            this.Button_ShowBracket.Click += new System.EventHandler(this.Button_ShowBracket_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(354, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(809, 536);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Button_NumTeams
            // 
            this.Button_NumTeams.Location = new System.Drawing.Point(57, 200);
            this.Button_NumTeams.Name = "Button_NumTeams";
            this.Button_NumTeams.Size = new System.Drawing.Size(271, 49);
            this.Button_NumTeams.TabIndex = 14;
            this.Button_NumTeams.Text = "Select Number of Teams";
            this.Button_NumTeams.UseVisualStyleBackColor = true;
            this.Button_NumTeams.Click += new System.EventHandler(this.Button_NumTeams_Click);
            // 
            // Label_InputTeams
            // 
            this.Label_InputTeams.AutoSize = true;
            this.Label_InputTeams.Location = new System.Drawing.Point(54, 123);
            this.Label_InputTeams.Name = "Label_InputTeams";
            this.Label_InputTeams.Size = new System.Drawing.Size(0, 20);
            this.Label_InputTeams.TabIndex = 15;
            // 
            // Label__NumTeams
            // 
            this.Label__NumTeams.AutoSize = true;
            this.Label__NumTeams.Location = new System.Drawing.Point(54, 252);
            this.Label__NumTeams.Name = "Label__NumTeams";
            this.Label__NumTeams.Size = new System.Drawing.Size(0, 20);
            this.Label__NumTeams.TabIndex = 16;
            // 
            // Label_NumRegGames
            // 
            this.Label_NumRegGames.AutoSize = true;
            this.Label_NumRegGames.Location = new System.Drawing.Point(54, 403);
            this.Label_NumRegGames.Name = "Label_NumRegGames";
            this.Label_NumRegGames.Size = new System.Drawing.Size(0, 20);
            this.Label_NumRegGames.TabIndex = 17;
            // 
            // Label_BracketSize
            // 
            this.Label_BracketSize.AutoSize = true;
            this.Label_BracketSize.Location = new System.Drawing.Point(54, 544);
            this.Label_BracketSize.Name = "Label_BracketSize";
            this.Label_BracketSize.Size = new System.Drawing.Size(0, 20);
            this.Label_BracketSize.TabIndex = 18;
            // 
            // Label_EliminationStyle
            // 
            this.Label_EliminationStyle.AutoSize = true;
            this.Label_EliminationStyle.Location = new System.Drawing.Point(54, 685);
            this.Label_EliminationStyle.Name = "Label_EliminationStyle";
            this.Label_EliminationStyle.Size = new System.Drawing.Size(0, 20);
            this.Label_EliminationStyle.TabIndex = 19;
            // 
            // LB_NumTeams
            // 
            this.LB_NumTeams.FormattingEnabled = true;
            this.LB_NumTeams.ItemHeight = 20;
            this.LB_NumTeams.Items.AddRange(new object[] {
            "4",
            "8",
            "16",
            "32"});
            this.LB_NumTeams.Location = new System.Drawing.Point(57, 154);
            this.LB_NumTeams.Name = "LB_NumTeams";
            this.LB_NumTeams.Size = new System.Drawing.Size(271, 24);
            this.LB_NumTeams.TabIndex = 20;
            // 
            // DefaultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 876);
            this.Controls.Add(this.LB_NumTeams);
            this.Controls.Add(this.Label_EliminationStyle);
            this.Controls.Add(this.Label_BracketSize);
            this.Controls.Add(this.Label_NumRegGames);
            this.Controls.Add(this.Label__NumTeams);
            this.Controls.Add(this.Label_InputTeams);
            this.Controls.Add(this.Button_NumTeams);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Button_ShowBracket);
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
        private System.Windows.Forms.Button Button_ShowBracket;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Button_NumTeams;
        private System.Windows.Forms.Label Label_InputTeams;
        private System.Windows.Forms.Label Label__NumTeams;
        private System.Windows.Forms.Label Label_NumRegGames;
        private System.Windows.Forms.Label Label_BracketSize;
        private System.Windows.Forms.Label Label_EliminationStyle;
        private System.Windows.Forms.ListBox LB_NumTeams;
    }
}

