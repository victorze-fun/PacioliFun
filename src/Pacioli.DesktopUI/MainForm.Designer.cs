
namespace Pacioli.DesktopUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.accountingStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accounting_NewTransactionStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountingStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(565, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip";
            // 
            // accountingStripMenuItem
            // 
            this.accountingStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accounting_NewTransactionStripMenuItem});
            this.accountingStripMenuItem.Name = "accountingStripMenuItem";
            this.accountingStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.accountingStripMenuItem.Text = "Contabilidad";
            // 
            // accounting_NewTransactionStripMenuItem
            // 
            this.accounting_NewTransactionStripMenuItem.Name = "accounting_NewTransactionStripMenuItem";
            this.accounting_NewTransactionStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.accounting_NewTransactionStripMenuItem.Text = "Nueva transacción";
            this.accounting_NewTransactionStripMenuItem.Click += new System.EventHandler(this.accounting_NewTransactionStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 425);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem accountingStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accounting_NewTransactionStripMenuItem;
    }
}