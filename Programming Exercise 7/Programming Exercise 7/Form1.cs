using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CheckingAccountNampespace;
using SavingAccountNamespace;
using Programming_Exercise_7;

namespace Programming_Exercise_7
{
    public partial class Form1 : Form
    {
        CheckingAccount c1 = new CheckingAccount("U1", 1, 54034.89, "Jabez", "Dailey");
        SavingAccount s1 = new SavingAccount("U1", 2, 5432.34, "Jabez", "Dailey");
        CheckingAccount c2 = new CheckingAccount("U2", 3, 10000, "Becky", "Bess");
        SavingAccount s2 = new SavingAccount("U2", 4, 3434534, "Becky", "Bess");

        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Add(c1.FName + " " + c1.LName);
            listBox1.Items.Add(c2.FName + " " + c1.LName);
        }

        private void TextBoxWitDep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 46
                                     && e.KeyChar != 8)
                e.Handled = true;
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = listBox1.GetItemText(listBox1.SelectedItem);
            if (listBox1.SelectedIndex == 0)
            {
                textBoxCheckingBal.Text = Convert.ToString(c1.AccountBal);
                textBoxSavingBal.Text = Convert.ToString(s1.AccountBal);
                labelClientName.Text = c1.FName + " " + c1.LName;
            }
            if (listBox1.SelectedIndex == 1)
            {
                textBoxCheckingBal.Text = Convert.ToString(c2.AccountBal);
                textBoxSavingBal.Text = Convert.ToString(s2.AccountBal);
                labelClientName.Text = c2.FName + " " + c2.LName;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                if (radioButtonChecking.Checked == true)
                {
                    c1.Withdraw(Math.Round(Convert.ToDouble(textBoxWitDep.Text),2));
                    textBoxCheckingBal.Text = Convert.ToString(Math.Round(c1.AccountBal, 2));

                }
                if (radioButtonSaving.Checked == true)
                {
                    s1.Withdraw(Math.Round(Convert.ToDouble(textBoxWitDep.Text), 2));
                    textBoxSavingBal.Text = Convert.ToString(Math.Round(s1.AccountBal, 2));
                }
            }
            if (listBox1.SelectedIndex == 1)
            {
                if (radioButtonChecking.Checked == true)
                {
                    c2.Withdraw(Math.Round(Convert.ToDouble(textBoxWitDep.Text), 2));
                    textBoxCheckingBal.Text = Convert.ToString(Math.Round(c2.AccountBal, 2));
                }
                if (radioButtonSaving.Checked == true)
                {
                    s2.Withdraw(Math.Round(Convert.ToDouble(textBoxWitDep.Text), 2));
                    textBoxSavingBal.Text = Convert.ToString(Math.Round(s2.AccountBal, 2));
                }
            }
        }

        private void ButtonDeposit_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                if (radioButtonChecking.Checked == true)
                {
                    c1.Deposit(Math.Round(Convert.ToDouble(textBoxWitDep.Text), 2));
                    textBoxCheckingBal.Text = Convert.ToString(Math.Round(c1.AccountBal, 2));

                }
                if (radioButtonSaving.Checked == true)
                {
                    s1.Deposit(Math.Round(Convert.ToDouble(textBoxWitDep.Text), 2));
                    textBoxSavingBal.Text = Convert.ToString(Math.Round(s1.AccountBal, 2));
                }
            }
            if (listBox1.SelectedIndex == 1)
            {
                if (radioButtonChecking.Checked == true)
                {
                    c2.Deposit(Math.Round(Convert.ToDouble(textBoxWitDep.Text), 2));
                    textBoxCheckingBal.Text = Convert.ToString(Math.Round(c2.AccountBal, 2));
                }
                if (radioButtonSaving.Checked == true)
                {
                    s2.Deposit(Math.Round(Convert.ToDouble(textBoxWitDep.Text), 2));
                    textBoxSavingBal.Text = Convert.ToString(Math.Round(s2.AccountBal, 2));
                }
            }
        }

        private void ButtonInterest_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                s1.CompoundInterest();
                textBoxSavingBal.Text = Convert.ToString(Math.Round(s1.AccountBal, 2));
            }
            if (listBox1.SelectedIndex == 1)
            {
                s2.CompoundInterest();
                textBoxSavingBal.Text = Convert.ToString(Math.Round(s2.AccountBal, 2));
            }
        }
    }
}
