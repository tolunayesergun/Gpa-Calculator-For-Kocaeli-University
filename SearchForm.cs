using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GpaCalculator
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main.searchWord = textBox1.Text;
            if (textBox1.Text == "") this.DialogResult = DialogResult.Cancel;
            else this.DialogResult = DialogResult.OK;
        }
        

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Enter))
            {
                Main.searchWord = textBox1.Text;
                if (textBox1.Text == "") this.DialogResult = DialogResult.Cancel;
                else this.DialogResult = DialogResult.OK;
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = Main.searchWord;
        }
    }
}
