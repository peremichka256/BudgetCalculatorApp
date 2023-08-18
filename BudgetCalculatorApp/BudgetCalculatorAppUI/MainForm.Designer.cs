
namespace BudgetCalculatorAppUI
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.controlPanel = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.removeTransactionButton = new System.Windows.Forms.Button();
            this.addTransactionButton = new System.Windows.Forms.Button();
            this.userDataPanel = new System.Windows.Forms.Panel();
            this.userDataLabel = new System.Windows.Forms.Label();
            this.userFirstnameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.controlPanel.SuspendLayout();
            this.userDataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.controlPanel.Controls.Add(this.button1);
            this.controlPanel.Controls.Add(this.exitButton);
            this.controlPanel.Controls.Add(this.reportButton);
            this.controlPanel.Controls.Add(this.removeTransactionButton);
            this.controlPanel.Controls.Add(this.addTransactionButton);
            this.controlPanel.Controls.Add(this.userDataPanel);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.controlPanel.Location = new System.Drawing.Point(0, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(200, 515);
            this.controlPanel.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.exitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitButton.Location = new System.Drawing.Point(0, 492);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(200, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Завершение работы";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // reportButton
            // 
            this.reportButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.reportButton.FlatAppearance.BorderSize = 0;
            this.reportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.reportButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportButton.Location = new System.Drawing.Point(0, 146);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(200, 23);
            this.reportButton.TabIndex = 3;
            this.reportButton.Text = "Вывод отчётности";
            this.reportButton.UseVisualStyleBackColor = true;
            // 
            // removeTransactionButton
            // 
            this.removeTransactionButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.removeTransactionButton.FlatAppearance.BorderSize = 0;
            this.removeTransactionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeTransactionButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeTransactionButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.removeTransactionButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeTransactionButton.Location = new System.Drawing.Point(0, 123);
            this.removeTransactionButton.Name = "removeTransactionButton";
            this.removeTransactionButton.Size = new System.Drawing.Size(200, 23);
            this.removeTransactionButton.TabIndex = 2;
            this.removeTransactionButton.Text = "Удалить транзакцию";
            this.removeTransactionButton.UseVisualStyleBackColor = true;
            this.removeTransactionButton.Click += new System.EventHandler(this.removeTransactionButton_Click);
            // 
            // addTransactionButton
            // 
            this.addTransactionButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addTransactionButton.FlatAppearance.BorderSize = 0;
            this.addTransactionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTransactionButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTransactionButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addTransactionButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addTransactionButton.Location = new System.Drawing.Point(0, 100);
            this.addTransactionButton.Name = "addTransactionButton";
            this.addTransactionButton.Size = new System.Drawing.Size(200, 23);
            this.addTransactionButton.TabIndex = 1;
            this.addTransactionButton.Text = "Добавить транзакцию";
            this.addTransactionButton.UseVisualStyleBackColor = true;
            this.addTransactionButton.Click += new System.EventHandler(this.addTransactionButton_Click);
            // 
            // userDataPanel
            // 
            this.userDataPanel.Controls.Add(this.userDataLabel);
            this.userDataPanel.Controls.Add(this.userFirstnameLabel);
            this.userDataPanel.Controls.Add(this.pictureBox1);
            this.userDataPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.userDataPanel.Location = new System.Drawing.Point(0, 0);
            this.userDataPanel.Name = "userDataPanel";
            this.userDataPanel.Size = new System.Drawing.Size(200, 100);
            this.userDataPanel.TabIndex = 0;
            // 
            // userDataLabel
            // 
            this.userDataLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userDataLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.userDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userDataLabel.ForeColor = System.Drawing.Color.White;
            this.userDataLabel.Location = new System.Drawing.Point(0, 84);
            this.userDataLabel.Name = "userDataLabel";
            this.userDataLabel.Size = new System.Drawing.Size(200, 16);
            this.userDataLabel.TabIndex = 2;
            this.userDataLabel.Text = "User Data";
            // 
            // userFirstnameLabel
            // 
            this.userFirstnameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userFirstnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userFirstnameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.userFirstnameLabel.Location = new System.Drawing.Point(0, 56);
            this.userFirstnameLabel.Name = "userFirstnameLabel";
            this.userFirstnameLabel.Size = new System.Drawing.Size(200, 16);
            this.userFirstnameLabel.TabIndex = 1;
            this.userFirstnameLabel.Text = "User Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(73, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(217, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(438, 491);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Изменить свои данные";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(667, 515);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.controlPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.controlPanel.ResumeLayout(false);
            this.userDataPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Panel userDataPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addTransactionButton;
        private System.Windows.Forms.Label userDataLabel;
        private System.Windows.Forms.Label userFirstnameLabel;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Button removeTransactionButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button button1;
    }
}

