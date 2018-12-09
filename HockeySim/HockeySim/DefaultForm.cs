using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HockeySim
{
    public partial class DefaultForm : Form
    {
        public string FilePath = "";
        public int NumTeams = 0;
        public int MatchCount = 0;
        public int BracketSize = 0;
        public int EliminationStyle = 0;

        public DefaultForm()
        {
            InitializeComponent();

            string dir = System.AppContext.BaseDirectory;
            dir = dir.Substring(0, dir.Length - 20);

            //string teamFile = Console.ReadLine();

            //List<string> teamList = System.IO.File.ReadAllLines(dir + teamFile).ToList();

            TextBox_InputTeams.Text = dir;
        }



        private void Button_InputTeams_Click(object sender, EventArgs e)
        {
            FilePath = TextBox_InputTeams.Text;
            Label_InputTeams.Text = FilePath;
        }

        private void Button_NumRegGames_Click(object sender, EventArgs e)
        {
            int choice;

            if (int.TryParse(Drop_NumRegGames.SelectedText, out choice))
            {
                MatchCount = Convert.ToInt32(Drop_NumRegGames.SelectedValue.ToString());
            }

            //MatchCount = Convert.ToInt16(Drop_NumRegGames.SelectedValue);
            Label_NumRegGames.Text = Convert.ToString(choice);
        }

        private void Button_EliminationStyle_Click(object sender, EventArgs e)
        {
            string choice = Drop__EliminationStyle.SelectedText;

            if(choice == "Single Elimination")
            {
                EliminationStyle = 1;
                Label_EliminationStyle.Text = Convert.ToString(EliminationStyle);
            }

            else if (choice == "Best of 5 Series")
            {
                EliminationStyle = 5;
                Label_EliminationStyle.Text = Convert.ToString(EliminationStyle);
            }

            else if (choice == "Best of 7 Series")
            {
                EliminationStyle = 7;
                Label_EliminationStyle.Text = Convert.ToString(EliminationStyle);
            }

            else
            {
                Label_EliminationStyle.Text = "Please make a selection from the dropbox above";
            }
        }

        private void Button_SimRegSeason_Click(object sender, EventArgs e)
        {

        }

        private void Button_SimPlayoffRound_Click(object sender, EventArgs e)
        {

        }

        private void Button_ShowStandings_Click(object sender, EventArgs e)
        {

        }

        private void Button_ShowBracket_Click(object sender, EventArgs e)
        {

        }

        private void TextBox_InputTeams_TextChanged(object sender, EventArgs e)
        {

        }

        private void Drop_NumRegGames_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Drop_SelectBracket_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Drop__EliminationStyle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button_BracketSize_Click(object sender, EventArgs e)
        {
            BracketSize = Convert.ToInt16(Drop_SelectBracket.SelectedValue);
            Label_BracketSize.Text = Convert.ToString(BracketSize);
        }

        private void Button_NumTeams_Click(object sender, EventArgs e)
        {
            //NumTeams = Convert.ToInt16(LB_NumTeams.GetItemText(LB_NumTeams.SelectedItem));
            Label__NumTeams.Text = LB_NumTeams.GetItemText(LB_NumTeams.SelectedItem);
        }
    }
}
