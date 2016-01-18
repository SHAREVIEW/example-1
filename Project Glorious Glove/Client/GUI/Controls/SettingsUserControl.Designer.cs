namespace Client.GUI.Controls
{
    partial class SettingsUserControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.startApplicationCheckBox = new System.Windows.Forms.CheckBox();
            this.startServiceCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.comPortComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startApplicationCheckBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.startApplicationCheckBox, 2);
            this.startApplicationCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startApplicationCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startApplicationCheckBox.Location = new System.Drawing.Point(5, 32);
            this.startApplicationCheckBox.Name = "startApplicationCheckBox";
            this.startApplicationCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.startApplicationCheckBox.Size = new System.Drawing.Size(340, 18);
            this.startApplicationCheckBox.TabIndex = 0;
            this.startApplicationCheckBox.Text = "Запускать при старте приложение";
            this.startApplicationCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.startApplicationCheckBox.UseVisualStyleBackColor = true;
            // 
            // startServiceCheckBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.startServiceCheckBox, 2);
            this.startServiceCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startServiceCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startServiceCheckBox.Location = new System.Drawing.Point(5, 56);
            this.startServiceCheckBox.Name = "startServiceCheckBox";
            this.startServiceCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.startServiceCheckBox.Size = new System.Drawing.Size(340, 18);
            this.startServiceCheckBox.TabIndex = 1;
            this.startServiceCheckBox.Text = "Запускать при старте службу";
            this.startServiceCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.startServiceCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "COM-порт по умолчанию";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.Controls.Add(this.startApplicationCheckBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.comPortComboBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.startServiceCheckBox, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(350, 440);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // comPortComboBox
            // 
            this.comPortComboBox.BackColor = System.Drawing.Color.Black;
            this.comPortComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comPortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comPortComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comPortComboBox.ForeColor = System.Drawing.Color.White;
            this.comPortComboBox.FormattingEnabled = true;
            this.comPortComboBox.Location = new System.Drawing.Point(281, 5);
            this.comPortComboBox.MaxLength = 6;
            this.comPortComboBox.Name = "comPortComboBox";
            this.comPortComboBox.Size = new System.Drawing.Size(64, 21);
            this.comPortComboBox.TabIndex = 2;
            this.comPortComboBox.SelectedIndexChanged += new System.EventHandler(this.comPortComboBox_SelectedIndexChanged);
            // 
            // SettingsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "SettingsUserControl";
            this.Size = new System.Drawing.Size(350, 440);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox startApplicationCheckBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox startServiceCheckBox;
        private System.Windows.Forms.ComboBox comPortComboBox;
    }
}
