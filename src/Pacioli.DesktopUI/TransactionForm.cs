using Pacioli.Entities;
using Pacioli.UseCases;
using Pacioli.UseCases.Exceptions;
using Pacioli.UseCases.Interfaces.Repositories;
using System;
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

        class TransactionRepository : ITransactionRepository
        {
            public void Add(Transaction transaction)
            {
                MessageBox.Show("La Transacción se almacenó en la base de datos.");
            }
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
                var recordTransaction = new RecordTransaction(new TransactionRepository());
                recordTransaction.Save(transaction);
                MessageBox.Show("El asiento se guardo correctamente.");
            }
            catch (UnbalancedTransactionException)
            {
                MessageBox.Show("Error. Debe haber partida doble.");
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
