using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WikipediaNET;

namespace WindowsFormsPavlovaProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

       
        private void SearchButton_Click(object sender, EventArgs e)
        {
            Wikipedia wikipedia = new Wikipedia();
            wikipedia.Limit = 1;
            WikipediaNET.Objects.QueryResult results = wikipedia.Search(SearchText.Text);
            WikipediaNET.Objects.Search link = results.Search[0];
            WebResult.Url = link.Url;
        }

        private void SearchText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchButton_Click(this, new EventArgs());
            }
        }

       
    }
}
