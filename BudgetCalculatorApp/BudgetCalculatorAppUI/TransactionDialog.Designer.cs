
namespace BudgetCalculatorAppUI
{
    partial class TransactionDialog
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.categoryNameTextBox = new System.Windows.Forms.TextBox();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.expenseTypeRadioButton = new System.Windows.Forms.RadioButton();
            this.arrivalTypeRadioButton = new System.Windows.Forms.RadioButton();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.doneButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Имя категории";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Дата";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Сумма";
            // 
            // categoryNameTextBox
            // 
            this.categoryNameTextBox.Location = new System.Drawing.Point(104, 64);
            this.categoryNameTextBox.Name = "categoryNameTextBox";
            this.categoryNameTextBox.Size = new System.Drawing.Size(168, 20);
            this.categoryNameTextBox.TabIndex = 8;
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(104, 12);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(168, 20);
            this.valueTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Тип категории";
            // 
            // expenseTypeRadioButton
            // 
            this.expenseTypeRadioButton.AutoSize = true;
            this.expenseTypeRadioButton.Checked = true;
            this.expenseTypeRadioButton.Location = new System.Drawing.Point(104, 93);
            this.expenseTypeRadioButton.Name = "expenseTypeRadioButton";
            this.expenseTypeRadioButton.Size = new System.Drawing.Size(83, 17);
            this.expenseTypeRadioButton.TabIndex = 14;
            this.expenseTypeRadioButton.TabStop = true;
            this.expenseTypeRadioButton.Text = "Исходящая";
            this.expenseTypeRadioButton.UseVisualStyleBackColor = true;
            // 
            // arrivalTypeRadioButton
            // 
            this.arrivalTypeRadioButton.AutoSize = true;
            this.arrivalTypeRadioButton.Location = new System.Drawing.Point(187, 93);
            this.arrivalTypeRadioButton.Name = "arrivalTypeRadioButton";
            this.arrivalTypeRadioButton.Size = new System.Drawing.Size(89, 17);
            this.arrivalTypeRadioButton.TabIndex = 15;
            this.arrivalTypeRadioButton.Text = "Приходящая";
            this.arrivalTypeRadioButton.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(104, 38);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(168, 20);
            this.dateTimePicker.TabIndex = 16;
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(12, 116);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(260, 23);
            this.doneButton.TabIndex = 17;
            this.doneButton.Text = "Внести";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // TransactionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 149);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.arrivalTypeRadioButton);
            this.Controls.Add(this.expenseTypeRadioButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categoryNameTextBox);
            this.Controls.Add(this.valueTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TransactionDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Change Transaction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox categoryNameTextBox;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton expenseTypeRadioButton;
        private System.Windows.Forms.RadioButton arrivalTypeRadioButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button doneButton;
    }
}