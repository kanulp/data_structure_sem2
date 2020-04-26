using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatePattern
{
    public partial class Form1 : Form
    {
        private Account account;
        public Form1()
        {
            account = new Account("100 200 300 4000");
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            string transactionType = TransationTypeCombo.Text;
            double transactionAmount = Convert.ToDouble(TransactionAmtTextBox.Text);
            bool result = false;

            if (transactionType.Equals("Deposit"))
            {

                Account account = this.account;
                result = account.deposit(transactionAmount);
            }
            if (transactionType.Equals("Withdraw"))
            {
                Account account = this.account;
                result = account.withdraw(transactionAmount);
            }
            if (result)
            {
                ResultLabel.Text = "Transaction Successful:: " + "Balance=" +
                  this.account.getBalance();
            }
            else
            {
                ResultLabel.Text = "Transaction Was Not Successful:: " +
                  "Overdraw Limit Exceeded::" + "Balance=" + this.account.getBalance();
            }
            


        }
    }
}
