using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SearchApp
{
    public partial class Form1 : Form
    {
        private string textPattern = @"[A-Za-z]\w+";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lstMatched.Items.Clear();

            foreach (string item in lstText.Items)
            {
                if (item.Equals(txtBox.Text))
                {
                    lstMatched.Items.Add(txtBox.Text);
                }
            }

            if (Regex.IsMatch(txtBox.Text, textPattern) && !lstText.Items.Contains(txtBox.Text))
            {
                lstText.Items.Add(txtBox.Text);
                txtBox.Clear();
            }
            else
            {
                txtBox.Clear();
            }
        }
    }
}
