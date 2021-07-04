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
