using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnGame
{
    public partial class StrMenu : Form
    {
        public StrMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Play play = new Play();
            play.ShowDialog();
            this.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
           
            DialogResult dialogResult = MessageBox.Show("Sure", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
        }

        private void Rule_Click(object sender, EventArgs e)
        {
            this.Hide();
            RuleForm rule = new RuleForm();
            rule.ShowDialog();
            this.Show();
        }
    }
}