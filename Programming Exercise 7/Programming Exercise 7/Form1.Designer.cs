namespace Programming_Exercise_7
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelClientName = new System.Windows.Forms.Label();
            this.labelCheckingAccountBal = new System.Windows.Forms.Label();
            this.labelSavingAccountBalance = new System.Windows.Forms.Label();
            this.textBoxCheckingBal = new System.Windows.Forms.TextBox();
            this.textBoxSavingBal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonDeposit = new System.Windows.Forms.Button();
            this.buttonInterest = new System.Windows.Forms.Button();
            this.radioButtonSaving = new System.Windows.Forms.RadioButton();
            this.radioButtonChecking = new System.Windows.Forms.RadioButton();
            this.textBoxWitDep = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Active Clients";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(18, 85);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(164, 340);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // labelClientName
            // 
            this.labelClientName.AutoSize = true;
            this.labelClientName.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientName.Location = new System.Drawing.Point(220, 42);
            this.labelClientName.Name = "labelClientName";
            this.labelClientName.Size = new System.Drawing.Size(217, 36);
            this.labelClientName.TabIndex = 1;
            this.labelClientName.Text = "Choose Cilent";
            // 
            // labelCheckingAccountBal
            // 
            this.labelCheckingAccountBal.AutoSize = true;
            this.labelCheckingAccountBal.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheckingAccountBal.Location = new System.Drawing.Point(221, 99);
            this.labelCheckingAccountBal.Name = "labelCheckingAccountBal";
            this.labelCheckingAccountBal.Size = new System.Drawing.Size(345, 30);
            this.labelCheckingAccountBal.TabIndex = 2;
            this.labelCheckingAccountBal.Text = "Checking Account Balance";
            // 
            // labelSavingAccountBalance
            // 
            this.labelSavingAccountBalance.AutoSize = true;
            this.labelSavingAccountBalance.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSavingAccountBalance.Location = new System.Drawing.Point(221, 172);
            this.labelSavingAccountBalance.Name = "labelSavingAccountBalance";
            this.labelSavingAccountBalance.Size = new System.Drawing.Size(309, 30);
            this.labelSavingAccountBalance.TabIndex = 3;
            this.labelSavingAccountBalance.Text = "Saving Account Balance";
            // 
            // textBoxCheckingBal
            // 
            this.textBoxCheckingBal.BackColor = System.Drawing.Color.White;
            this.textBoxCheckingBal.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCheckingBal.Location = new System.Drawing.Point(226, 132);
            this.textBoxCheckingBal.Name = "textBoxCheckingBal";
            this.textBoxCheckingBal.ReadOnly = true;
            this.textBoxCheckingBal.Size = new System.Drawing.Size(530, 37);
            this.textBoxCheckingBal.TabIndex = 4;
            this.textBoxCheckingBal.Text = "$0";
            // 
            // textBoxSavingBal
            // 
            this.textBoxSavingBal.BackColor = System.Drawing.Color.White;
            this.textBoxSavingBal.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSavingBal.Location = new System.Drawing.Point(226, 205);
            this.textBoxSavingBal.Name = "textBoxSavingBal";
            this.textBoxSavingBal.Size = new System.Drawing.Size(530, 37);
            this.textBoxSavingBal.TabIndex = 5;
            this.textBoxSavingBal.Text = "$0";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(225, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Withdraw";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // buttonDeposit
            // 
            this.buttonDeposit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeposit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeposit.Location = new System.Drawing.Point(403, 387);
            this.buttonDeposit.Name = "buttonDeposit";
            this.buttonDeposit.Size = new System.Drawing.Size(191, 38);
            this.buttonDeposit.TabIndex = 7;
            this.buttonDeposit.Text = "Deposit";
            this.buttonDeposit.UseVisualStyleBackColor = false;
            this.buttonDeposit.Click += new System.EventHandler(this.ButtonDeposit_Click);
            // 
            // buttonInterest
            // 
            this.buttonInterest.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonInterest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInterest.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInterest.Location = new System.Drawing.Point(600, 387);
            this.buttonInterest.Name = "buttonInterest";
            this.buttonInterest.Size = new System.Drawing.Size(188, 38);
            this.buttonInterest.TabIndex = 8;
            this.buttonInterest.Text = "Interest";
            this.buttonInterest.UseVisualStyleBackColor = false;
            this.buttonInterest.Click += new System.EventHandler(this.ButtonInterest_Click);
            // 
            // radioButtonSaving
            // 
            this.radioButtonSaving.AutoSize = true;
            this.radioButtonSaving.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSaving.Location = new System.Drawing.Point(226, 289);
            this.radioButtonSaving.Name = "radioButtonSaving";
            this.radioButtonSaving.Size = new System.Drawing.Size(155, 25);
            this.radioButtonSaving.TabIndex = 9;
            this.radioButtonSaving.TabStop = true;
            this.radioButtonSaving.Text = "Saving Account";
            this.radioButtonSaving.UseVisualStyleBackColor = true;
            // 
            // radioButtonChecking
            // 
            this.radioButtonChecking.AutoSize = true;
            this.radioButtonChecking.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonChecking.Location = new System.Drawing.Point(403, 289);
            this.radioButtonChecking.Name = "radioButtonChecking";
            this.radioButtonChecking.Size = new System.Drawing.Size(177, 25);
            this.radioButtonChecking.TabIndex = 10;
            this.radioButtonChecking.TabStop = true;
            this.radioButtonChecking.Text = "Checking Account";
            this.radioButtonChecking.UseVisualStyleBackColor = true;
            // 
            // textBoxWitDep
            // 
            this.textBoxWitDep.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWitDep.Location = new System.Drawing.Point(225, 320);
            this.textBoxWitDep.Name = "textBoxWitDep";
            this.textBoxWitDep.Size = new System.Drawing.Size(530, 37);
            this.textBoxWitDep.TabIndex = 11;
            this.textBoxWitDep.Text = "0";
            this.textBoxWitDep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxWitDep_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxWitDep);
            this.Controls.Add(this.radioButtonChecking);
            this.Controls.Add(this.radioButtonSaving);
            this.Controls.Add(this.buttonInterest);
            this.Controls.Add(this.buttonDeposit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxSavingBal);
            this.Controls.Add(this.textBoxCheckingBal);
            this.Controls.Add(this.labelSavingAccountBalance);
            this.Controls.Add(this.labelCheckingAccountBal);
            this.Controls.Add(this.labelClientName);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelClientName;
        private System.Windows.Forms.Label labelCheckingAccountBal;
        private System.Windows.Forms.Label labelSavingAccountBalance;
        private System.Windows.Forms.TextBox textBoxCheckingBal;
        private System.Windows.Forms.TextBox textBoxSavingBal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonDeposit;
        private System.Windows.Forms.Button buttonInterest;
        private System.Windows.Forms.RadioButton radioButtonSaving;
        private System.Windows.Forms.RadioButton radioButtonChecking;
        private System.Windows.Forms.TextBox textBoxWitDep;
    }
}

