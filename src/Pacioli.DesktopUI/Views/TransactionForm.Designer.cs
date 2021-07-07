
namespace Pacioli.DesktopUI.Views
{
    partial class TransactionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.accountTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.debitTextBox = new System.Windows.Forms.TextBox();
            this.creditTextBox = new System.Windows.Forms.TextBox();
            this.entriesListView = new System.Windows.Forms.ListView();
            this.accountColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.descriptionColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.debitColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.creditColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.addEntryButton = new System.Windows.Forms.Button();
            this.recordButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.removeEntryButton = new System.Windows.Forms.Button();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cuenta:";
            // 
            // accountTextBox
            // 
            this.accountTextBox.Location = new System.Drawing.Point(87, 17);
            this.accountTextBox.Name = "accountTextBox";
            this.accountTextBox.Size = new System.Drawing.Size(100, 23);
            this.accountTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Debe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Haber:";
            // 
            // debitTextBox
            // 
            this.debitTextBox.Location = new System.Drawing.Point(87, 46);
            this.debitTextBox.Name = "debitTextBox";
            this.debitTextBox.Size = new System.Drawing.Size(100, 23);
            this.debitTextBox.TabIndex = 1;
            this.debitTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // creditTextBox
            // 
            this.creditTextBox.Location = new System.Drawing.Point(311, 46);
            this.creditTextBox.Name = "creditTextBox";
            this.creditTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.creditTextBox.Size = new System.Drawing.Size(100, 23);
            this.creditTextBox.TabIndex = 2;
            this.creditTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // entriesListView
            // 
            this.entriesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.accountColumnHeader,
            this.descriptionColumnHeader,
            this.debitColumnHeader,
            this.creditColumnHeader});
            this.entriesListView.FullRowSelect = true;
            this.entriesListView.HideSelection = false;
            this.entriesListView.Location = new System.Drawing.Point(13, 90);
            this.entriesListView.Name = "entriesListView";
            this.entriesListView.Size = new System.Drawing.Size(534, 245);
            this.entriesListView.TabIndex = 11;
            this.entriesListView.UseCompatibleStateImageBehavior = false;
            this.entriesListView.View = System.Windows.Forms.View.Details;
            // 
            // accountColumnHeader
            // 
            this.accountColumnHeader.Name = "accountColumnHeader";
            this.accountColumnHeader.Text = "Cuenta";
            // 
            // descriptionColumnHeader
            // 
            this.descriptionColumnHeader.Name = "descriptionColumnHeader";
            this.descriptionColumnHeader.Text = "Descripción";
            this.descriptionColumnHeader.Width = 280;
            // 
            // debitColumnHeader
            // 
            this.debitColumnHeader.Name = "debitColumnHeader";
            this.debitColumnHeader.Text = "Débito";
            this.debitColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.debitColumnHeader.Width = 95;
            // 
            // creditColumnHeader
            // 
            this.creditColumnHeader.Name = "creditColumnHeader";
            this.creditColumnHeader.Text = "Crédito";
            this.creditColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.creditColumnHeader.Width = 95;
            // 
            // addEntryButton
            // 
            this.addEntryButton.Location = new System.Drawing.Point(444, 16);
            this.addEntryButton.Name = "addEntryButton";
            this.addEntryButton.Size = new System.Drawing.Size(102, 23);
            this.addEntryButton.TabIndex = 3;
            this.addEntryButton.Text = "Agregar";
            this.addEntryButton.UseVisualStyleBackColor = true;
            this.addEntryButton.Click += new System.EventHandler(this.addEntryButton_Click);
            // 
            // recordButton
            // 
            this.recordButton.Location = new System.Drawing.Point(311, 366);
            this.recordButton.Name = "recordButton";
            this.recordButton.Size = new System.Drawing.Size(102, 23);
            this.recordButton.TabIndex = 5;
            this.recordButton.Text = "Registrar";
            this.recordButton.UseVisualStyleBackColor = true;
            this.recordButton.Click += new System.EventHandler(this.recordButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(444, 366);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(103, 23);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Salir";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Debe:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Haber:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(13, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "1,300.00";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(206, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Diferencia:";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(103, 369);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "1,300.00";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(194, 369);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "1,300.00";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // removeEntryButton
            // 
            this.removeEntryButton.Location = new System.Drawing.Point(444, 46);
            this.removeEntryButton.Name = "removeEntryButton";
            this.removeEntryButton.Size = new System.Drawing.Size(102, 23);
            this.removeEntryButton.TabIndex = 4;
            this.removeEntryButton.Text = "Eliminar";
            this.removeEntryButton.UseVisualStyleBackColor = true;
            this.removeEntryButton.Click += new System.EventHandler(this.removeEntryButton_Click);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.Location = new System.Drawing.Point(193, 20);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(245, 20);
            this.DescriptionLabel.TabIndex = 12;
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 401);
            this.ControlBox = false;
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.recordButton);
            this.Controls.Add(this.removeEntryButton);
            this.Controls.Add(this.addEntryButton);
            this.Controls.Add(this.entriesListView);
            this.Controls.Add(this.creditTextBox);
            this.Controls.Add(this.debitTextBox);
            this.Controls.Add(this.accountTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "TransactionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TRANSACCIÓN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox accountTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox debitTextBox;
        private System.Windows.Forms.TextBox creditTextBox;
        private System.Windows.Forms.ListView entriesListView;
        private System.Windows.Forms.Button addEntryButton;
        private System.Windows.Forms.Button recordButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader accountColumnHeader;
        private System.Windows.Forms.ColumnHeader descriptionColumnHeader;
        private System.Windows.Forms.ColumnHeader debitColumnHeader;
        private System.Windows.Forms.ColumnHeader creditColumnHeader;
        private System.Windows.Forms.Button removeEntryButton;
        private System.Windows.Forms.Label DescriptionLabel;
    }
}