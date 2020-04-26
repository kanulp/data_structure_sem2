namespace StatePattern
{
    partial class Form1
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
            this.TransactionTypeLabel = new System.Windows.Forms.Label();
            this.TransationTypeCombo = new System.Windows.Forms.ComboBox();
            this.TransactionAmtTextBox = new System.Windows.Forms.TextBox();
            this.TransactionAmtLabel = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TransactionTypeLabel
            // 
            this.TransactionTypeLabel.AutoSize = true;
            this.TransactionTypeLabel.Location = new System.Drawing.Point(40, 46);
            this.TransactionTypeLabel.Name = "TransactionTypeLabel";
            this.TransactionTypeLabel.Size = new System.Drawing.Size(93, 13);
            this.TransactionTypeLabel.TabIndex = 0;
            this.TransactionTypeLabel.Text = "Transaction Type:";
            // 
            // TransationTypeCombo
            // 
            this.TransationTypeCombo.FormattingEnabled = true;
            this.TransationTypeCombo.Items.AddRange(new object[] {
            "Deposit",
            "Withdraw"});
            this.TransationTypeCombo.Location = new System.Drawing.Point(139, 43);
            this.TransationTypeCombo.Name = "TransationTypeCombo";
            this.TransationTypeCombo.Size = new System.Drawing.Size(121, 21);
            this.TransationTypeCombo.TabIndex = 1;
            // 
            // TransactionAmtTextBox
            // 
            this.TransactionAmtTextBox.Location = new System.Drawing.Point(139, 70);
            this.TransactionAmtTextBox.Name = "TransactionAmtTextBox";
            this.TransactionAmtTextBox.Size = new System.Drawing.Size(121, 20);
            this.TransactionAmtTextBox.TabIndex = 2;
            // 
            // TransactionAmtLabel
            // 
            this.TransactionAmtLabel.AutoSize = true;
            this.TransactionAmtLabel.Location = new System.Drawing.Point(28, 73);
            this.TransactionAmtLabel.Name = "TransactionAmtLabel";
            this.TransactionAmtLabel.Size = new System.Drawing.Size(105, 13);
            this.TransactionAmtLabel.TabIndex = 3;
            this.TransactionAmtLabel.Text = "Transaction Amount:";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(93, 101);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(40, 13);
            this.ResultLabel.TabIndex = 4;
            this.ResultLabel.Text = "Result:";
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Location = new System.Drawing.Point(58, 140);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(75, 23);
            this.ExecuteButton.TabIndex = 5;
            this.ExecuteButton.Text = "Execute";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(139, 140);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 197);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ExecuteButton);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.TransactionAmtLabel);
            this.Controls.Add(this.TransactionAmtTextBox);
            this.Controls.Add(this.TransationTypeCombo);
            this.Controls.Add(this.TransactionTypeLabel);
            this.Name = "Form1";
            this.Text = "State Pattern";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TransactionTypeLabel;
        private System.Windows.Forms.ComboBox TransationTypeCombo;
        private System.Windows.Forms.TextBox TransactionAmtTextBox;
        private System.Windows.Forms.Label TransactionAmtLabel;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

