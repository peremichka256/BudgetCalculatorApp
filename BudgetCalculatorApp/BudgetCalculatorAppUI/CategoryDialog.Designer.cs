
namespace BudgetCalculatorAppUI
{
    partial class CategoryDialog
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
            this.doneButton = new System.Windows.Forms.Button();
            this.arrivalTypeRadioButton = new System.Windows.Forms.RadioButton();
            this.expenseCategoryRadioButton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(12, 64);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(260, 23);
            this.doneButton.TabIndex = 23;
            this.doneButton.Text = "Внести";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // arrivalTypeRadioButton
            // 
            this.arrivalTypeRadioButton.AutoSize = true;
            this.arrivalTypeRadioButton.Location = new System.Drawing.Point(187, 41);
            this.arrivalTypeRadioButton.Name = "arrivalTypeRadioButton";
            this.arrivalTypeRadioButton.Size = new System.Drawing.Size(62, 17);
            this.arrivalTypeRadioButton.TabIndex = 22;
            this.arrivalTypeRadioButton.Text = "Приход";
            this.arrivalTypeRadioButton.UseVisualStyleBackColor = true;
            // 
            // expenseCategoryRadioButton
            // 
            this.expenseCategoryRadioButton.AutoSize = true;
            this.expenseCategoryRadioButton.Checked = true;
            this.expenseCategoryRadioButton.Location = new System.Drawing.Point(104, 41);
            this.expenseCategoryRadioButton.Name = "expenseCategoryRadioButton";
            this.expenseCategoryRadioButton.Size = new System.Drawing.Size(61, 17);
            this.expenseCategoryRadioButton.TabIndex = 21;
            this.expenseCategoryRadioButton.TabStop = true;
            this.expenseCategoryRadioButton.Text = "Расход";
            this.expenseCategoryRadioButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Тип категории";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Имя категории";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(104, 12);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(168, 20);
            this.nameTextBox.TabIndex = 18;
            // 
            // CategoryDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 98);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.arrivalTypeRadioButton);
            this.Controls.Add(this.expenseCategoryRadioButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CategoryDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Change Category";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.RadioButton arrivalTypeRadioButton;
        private System.Windows.Forms.RadioButton expenseCategoryRadioButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTextBox;
    }
}