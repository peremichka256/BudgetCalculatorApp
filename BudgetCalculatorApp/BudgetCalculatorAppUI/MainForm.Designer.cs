
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
            this.goBackButton = new System.Windows.Forms.Button();
            this.ReoirtButton = new System.Windows.Forms.Button();
            this.entryEditingButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.userDataPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userDataLabel = new System.Windows.Forms.Label();
            this.userFirstnameLabel = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.controlPanel.SuspendLayout();
            this.userDataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.controlPanel.Controls.Add(this.goBackButton);
            this.controlPanel.Controls.Add(this.ReoirtButton);
            this.controlPanel.Controls.Add(this.entryEditingButton);
            this.controlPanel.Controls.Add(this.exitButton);
            this.controlPanel.Controls.Add(this.removeButton);
            this.controlPanel.Controls.Add(this.addButton);
            this.controlPanel.Controls.Add(this.userDataPanel);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.controlPanel.Location = new System.Drawing.Point(0, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(200, 515);
            this.controlPanel.TabIndex = 0;
            // 
            // goBackButton
            // 
            this.goBackButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.goBackButton.FlatAppearance.BorderSize = 0;
            this.goBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goBackButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.goBackButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.goBackButton.Location = new System.Drawing.Point(0, 169);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(200, 23);
            this.goBackButton.TabIndex = 7;
            this.goBackButton.Text = "Назад";
            this.goBackButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // ReoirtButton
            // 
            this.ReoirtButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ReoirtButton.FlatAppearance.BorderSize = 0;
            this.ReoirtButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReoirtButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReoirtButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ReoirtButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReoirtButton.Location = new System.Drawing.Point(0, 469);
            this.ReoirtButton.Name = "ReoirtButton";
            this.ReoirtButton.Size = new System.Drawing.Size(200, 23);
            this.ReoirtButton.TabIndex = 6;
            this.ReoirtButton.Text = "Вывод отчёта";
            this.ReoirtButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReoirtButton.UseVisualStyleBackColor = true;
            // 
            // entryEditingButton
            // 
            this.entryEditingButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.entryEditingButton.FlatAppearance.BorderSize = 0;
            this.entryEditingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.entryEditingButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryEditingButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.entryEditingButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.entryEditingButton.Location = new System.Drawing.Point(0, 146);
            this.entryEditingButton.Name = "entryEditingButton";
            this.entryEditingButton.Size = new System.Drawing.Size(200, 23);
            this.entryEditingButton.TabIndex = 5;
            this.entryEditingButton.Text = "Изменить";
            this.entryEditingButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.entryEditingButton.UseVisualStyleBackColor = true;
            this.entryEditingButton.Click += new System.EventHandler(this.entryEditingButton_Click);
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
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.removeButton.FlatAppearance.BorderSize = 0;
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.removeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.removeButton.Location = new System.Drawing.Point(0, 123);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(200, 23);
            this.removeButton.TabIndex = 2;
            this.removeButton.Text = "Удалить";
            this.removeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addButton
            // 
            this.addButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addButton.Location = new System.Drawing.Point(0, 100);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(200, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Добавить";
            this.addButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // userDataPanel
            // 
            this.userDataPanel.Controls.Add(this.pictureBox1);
            this.userDataPanel.Controls.Add(this.userDataLabel);
            this.userDataPanel.Controls.Add(this.userFirstnameLabel);
            this.userDataPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.userDataPanel.Location = new System.Drawing.Point(0, 0);
            this.userDataPanel.Name = "userDataPanel";
            this.userDataPanel.Size = new System.Drawing.Size(200, 100);
            this.userDataPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::BudgetCalculatorAppUI.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(0, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // userDataLabel
            // 
            this.userDataLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userDataLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.userDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userDataLabel.ForeColor = System.Drawing.Color.White;
            this.userDataLabel.Location = new System.Drawing.Point(0, 16);
            this.userDataLabel.Margin = new System.Windows.Forms.Padding(3);
            this.userDataLabel.Name = "userDataLabel";
            this.userDataLabel.Size = new System.Drawing.Size(200, 16);
            this.userDataLabel.TabIndex = 2;
            this.userDataLabel.Text = "User Data";
            this.userDataLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // userFirstnameLabel
            // 
            this.userFirstnameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userFirstnameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.userFirstnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userFirstnameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.userFirstnameLabel.Location = new System.Drawing.Point(0, 0);
            this.userFirstnameLabel.Margin = new System.Windows.Forms.Padding(3);
            this.userFirstnameLabel.Name = "userFirstnameLabel";
            this.userFirstnameLabel.Size = new System.Drawing.Size(200, 16);
            this.userFirstnameLabel.TabIndex = 1;
            this.userFirstnameLabel.Text = "User Name";
            this.userFirstnameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(217, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(462, 491);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(691, 515);
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
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label userDataLabel;
        private System.Windows.Forms.Label userFirstnameLabel;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button entryEditingButton;
        private System.Windows.Forms.Button ReoirtButton;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

