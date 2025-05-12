using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Load : Form
    {
        int time = 10;
        public Load()
        {
            InitializeComponent();
        }

        private void Start(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Update(object sender, EventArgs e)
        {
            time--;
            if(time == 0)
            {
                this.Hide();
                new GameView().Show();
            }
        }
    }
}
