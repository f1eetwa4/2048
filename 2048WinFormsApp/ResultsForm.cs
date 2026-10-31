using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _2048WinFormsApp
{
    public partial class ResultsForm : Form
    {
        
        public ResultsForm()
        {
            InitializeComponent();
        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            resultsDataGridView.DataSource = ResultsStorage.GetResults();
        }
    }
}
