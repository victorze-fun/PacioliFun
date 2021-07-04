using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacioli.DesktopUI
{
    public partial class TransactionForm : Form
    {
        public TransactionForm()
        {
            InitializeComponent();
        }

        private void addEntryButton_Click(object sender, EventArgs e)
        {
            var item = new ListViewItem(accountTextBox.Text);
            item.SubItems.Add(DescriptionLabel.Text);
            item.SubItems.Add(debitTextBox.Text);
            item.SubItems.Add(creditTextBox.Text);
            entriesListView.Items.Add(item);

            accountTextBox.Clear();
            debitTextBox.Clear();
            creditTextBox.Clear();
            accountTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void recordButton_Click(object sender, EventArgs e)
        {
            if (entriesListView.Items.Count > 0)
            {
                for (int i = 0; i < entriesListView.Items.Count; i++)
                {
                    var item = entriesListView.Items[i];
                    string line = item.SubItems[0].Text + "|" + item.SubItems[1].Text + "|" + item.SubItems[2].Text + "|" + item.SubItems[3].Text;
                    MessageBox.Show(line);
                }
            }
                
        }

        private void removeEntryButton_Click(object sender, EventArgs e)
        {
            if (entriesListView.Items.Count > 0 && entriesListView.SelectedIndices.Count > 0)
            {
                entriesListView.Items.Remove(entriesListView.SelectedItems[0]);
                
            }
        }
    }
}
