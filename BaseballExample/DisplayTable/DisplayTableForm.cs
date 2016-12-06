using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Windows.Forms;
using BaseballExample;

namespace DisplayTable
{
    public partial class PlayerDisplay : Form
    {
        public PlayerDisplay()
        {
            InitializeComponent();

        }

        private BaseballExample.BaseballEntities dbcontext = new BaseballExample.BaseballEntities();

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            Validate();
            playerBindingSource.EndEdit();
            try
            {
                dbcontext.SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show(@"there was an issue", @"entity validation error");
                throw;
            }
        }

        private void PlayerDisplay_Load(object sender, EventArgs e)
        {
            dbcontext.Players.OrderBy(player => player.LastName).ThenBy(player => player.FirstName).Load();
            playerBindingSource.DataSource = dbcontext.Players.Local;
            comboBox1.Items.Add("SELECT PlayerId, FirstName, LastName, BattingAverage FROM Player");
            comboBox1.Items.Add("SELECT PlayerId, FirstName, LastName, BattingAverage FROM Player WHERE BattingAverage >= .3");
            comboBox1.Items.Add("SELECT PlayerId, FirstName, LastName, BattingAverage FROM Player WHERE LastName Bob");
            comboBox1.SelectedIndex = 0;
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            dbcontext.Players.OrderBy(player => player.LastName).ThenBy(player => player.FirstName).Load();
            playerBindingSource.DataSource = dbcontext.Players.Local;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((int) comboBox1.SelectedIndex)
            {
                case 0:
                    playerBindingSource.DataSource =
                        dbcontext.Players.Local.OrderBy(player => player.LastName).ThenBy(player => player.FirstName);
                    break;
                case 1:
                    playerBindingSource.DataSource =
                        dbcontext.Players.Local.OrderBy(player => player.LastName)
                            .ThenBy(player => player.FirstName)
                            .Where(player => player.BattingAverage >= .3);
                    break;
                case 2:
                    playerBindingSource.DataSource =
                        dbcontext.Players.Local.OrderBy(player => player.LastName)
                            .ThenBy(player => player.FirstName)
                            .Where(player => player.LastName == "Bob");
                    break;
                default:
                    playerBindingSource.DataSource =
                        dbcontext.Players.Local.OrderBy(player => player.LastName).ThenBy(player => player.FirstName);
                    break;
            }

        }
    }
}
