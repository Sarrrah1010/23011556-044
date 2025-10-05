using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Asignment_2
{
    public partial class HistoryForm : Form
    {
        public HistoryForm(List<string> history)
        {
            InitializeComponent();
            lstHistory.Items.AddRange(history.ToArray());
            this.Text = "Calculation History";
        }
    }
}
