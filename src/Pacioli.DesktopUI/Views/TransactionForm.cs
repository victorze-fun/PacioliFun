using Pacioli.Entities;
using Pacioli.UseCases.Exceptions;
using Pacioli.UseCases.Interfaces.Boundaries;
using System;
using System.Windows.Forms;

namespace Pacioli.DesktopUI.Views
{
    public partial class TransactionForm : Form
    {
        private IRecordTransaction _recordTransaction;

        public TransactionForm(IRecordTransaction recordTransaction)
        {
            _recordTransaction = recordTransaction;
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
            var transaction = new Transaction();

            if (entriesListView.Items.Count > 0)
            {
                for (int i = 0; i < entriesListView.Items.Count; i++)
                {
                    Entry entry;
                    var item = entriesListView.Items[i];

                    if (item.SubItems[2].Text != string.Empty)
                    {
                        entry = new Entry(decimal.Parse(item.SubItems[2].Text));
                    }
                    else
                    {
                        entry = new Entry(-decimal.Parse(item.SubItems[3].Text));
                    }

                    transaction.AddEntry(entry);
                }
            }

            try
            {
                _recordTransaction.Save(transaction);
                MessageBox.Show("El asiento se guardo correctamente.");
            }
            catch (UnbalancedTransactionException)
            {
                MessageBox.Show($"No hay partida doble.\nDebe: {transaction.Debit}     Haber: {transaction.Credit}");
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
