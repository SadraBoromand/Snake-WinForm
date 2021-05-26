using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_2
{
    public partial class Game_Over : Form
    {
        public Game_Over()
        {
            InitializeComponent();
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            new Game().ShowDialog();
            this.Close();
        }
    }
}
