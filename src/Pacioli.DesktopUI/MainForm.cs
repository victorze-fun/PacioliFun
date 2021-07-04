using System;
using System.Windows.Forms;

namespace Pacioli.DesktopUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void accounting_NewTransactionStripMenuItem_Click(object sender, EventArgs e)
        {
            var transactionForm = new TransactionForm();
            transactionForm.ShowDialog();
        }
    }
}
