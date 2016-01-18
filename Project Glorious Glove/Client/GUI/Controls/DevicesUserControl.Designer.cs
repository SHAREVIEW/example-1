namespace Client.GUI.Controls
{
    partial class DevicesUserControl
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
            this.commonTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.availableConnectionGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.connectionsListBox = new System.Windows.Forms.ListBox();
            this.addConnectionButton = new System.Windows.Forms.Button();
            this.statusGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.typeConnectionLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.typeDeviceLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameDeviceLabel = new System.Windows.Forms.Label();
            this.statusConnectionLabel = new System.Windows.Forms.Label();
            this.closeConnectionButton = new System.Windows.Forms.Button();
            this.commonTableLayoutPanel.SuspendLayout();
            this.availableConnectionGroupBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.statusGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // commonTableLayoutPanel
            // 
            this.commonTableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.commonTableLayoutPanel.ColumnCount = 1;
            this.commonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.commonTableLayoutPanel.Controls.Add(this.availableConnectionGroupBox, 0, 1);
            this.commonTableLayoutPanel.Controls.Add(this.statusGroupBox, 0, 0);
            this.commonTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commonTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.commonTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.commonTableLayoutPanel.Name = "commonTableLayoutPanel";
            this.commonTableLayoutPanel.Padding = new System.Windows.Forms.Padding(1);
            this.commonTableLayoutPanel.RowCount = 2;
            this.commonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.commonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.commonTableLayoutPanel.Size = new System.Drawing.Size(350, 440);
            this.commonTableLayoutPanel.TabIndex = 0;
            // 
            // availableConnectionGroupBox
            // 
            this.availableConnectionGroupBox.Controls.Add(this.tableLayoutPanel2);
            this.availableConnectionGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.availableConnectionGroupBox.ForeColor = System.Drawing.Color.White;
            this.availableConnectionGroupBox.Location = new System.Drawing.Point(2, 155);
            this.availableConnectionGroupBox.Margin = new System.Windows.Forms.Padding(1);
            this.availableConnectionGroupBox.Name = "availableConnectionGroupBox";
            this.availableConnectionGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.availableConnectionGroupBox.Size = new System.Drawing.Size(346, 283);
            this.availableConnectionGroupBox.TabIndex = 1;
            this.availableConnectionGroupBox.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.connectionsListBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.addConnectionButton, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 15);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(342, 266);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // connectionsListBox
            // 
            this.connectionsListBox.BackColor = System.Drawing.Color.Black;
            this.connectionsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connectionsListBox.ForeColor = System.Drawing.Color.White;
            this.connectionsListBox.FormattingEnabled = true;
            this.connectionsListBox.Location = new System.Drawing.Point(3, 48);
            this.connectionsListBox.Name = "connectionsListBox";
            this.connectionsListBox.Size = new System.Drawing.Size(336, 215);
            this.connectionsListBox.TabIndex = 0;
            // 
            // addConnectionButton
            // 
            this.addConnectionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addConnectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addConnectionButton.Location = new System.Drawing.Point(3, 3);
            this.addConnectionButton.Name = "addConnectionButton";
            this.addConnectionButton.Size = new System.Drawing.Size(336, 39);
            this.addConnectionButton.TabIndex = 1;
            this.addConnectionButton.Text = "Добавить устройство";
            this.addConnectionButton.UseVisualStyleBackColor = true;
            this.addConnectionButton.Click += new System.EventHandler(this.addConnectionButton_Click);
            // 
            // statusGroupBox
            // 
            this.statusGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.statusGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusGroupBox.ForeColor = System.Drawing.Color.White;
            this.statusGroupBox.Location = new System.Drawing.Point(2, 2);
            this.statusGroupBox.Margin = new System.Windows.Forms.Padding(1);
            this.statusGroupBox.Name = "statusGroupBox";
            this.statusGroupBox.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.statusGroupBox.Size = new System.Drawing.Size(346, 151);
            this.statusGroupBox.TabIndex = 0;
            this.statusGroupBox.TabStop = false;
            this.statusGroupBox.Text = "Информация о подключении";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.typeConnectionLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.typeDeviceLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.nameDeviceLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.statusConnectionLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.closeConnectionButton, 2, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 16);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(346, 135);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // typeConnectionLabel
            // 
            this.typeConnectionLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.typeConnectionLabel, 2);
            this.typeConnectionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typeConnectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeConnectionLabel.Location = new System.Drawing.Point(134, 70);
            this.typeConnectionLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.typeConnectionLabel.Name = "typeConnectionLabel";
            this.typeConnectionLabel.Size = new System.Drawing.Size(207, 18);
            this.typeConnectionLabel.TabIndex = 9;
            this.typeConnectionLabel.Text = "N/A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(5, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Тип соединения:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(5, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Состояние:";
            // 
            // typeDeviceLabel
            // 
            this.typeDeviceLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.typeDeviceLabel, 2);
            this.typeDeviceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typeDeviceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeDeviceLabel.Location = new System.Drawing.Point(134, 48);
            this.typeDeviceLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.typeDeviceLabel.Name = "typeDeviceLabel";
            this.typeDeviceLabel.Size = new System.Drawing.Size(207, 18);
            this.typeDeviceLabel.TabIndex = 6;
            this.typeDeviceLabel.Text = "N/A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(5, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Название:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(5, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Тип устройства:";
            // 
            // nameDeviceLabel
            // 
            this.nameDeviceLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.nameDeviceLabel, 2);
            this.nameDeviceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameDeviceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameDeviceLabel.Location = new System.Drawing.Point(134, 26);
            this.nameDeviceLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameDeviceLabel.Name = "nameDeviceLabel";
            this.nameDeviceLabel.Size = new System.Drawing.Size(207, 18);
            this.nameDeviceLabel.TabIndex = 5;
            this.nameDeviceLabel.Text = "N/A";
            // 
            // statusConnectionLabel
            // 
            this.statusConnectionLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.statusConnectionLabel, 2);
            this.statusConnectionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusConnectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusConnectionLabel.Location = new System.Drawing.Point(134, 4);
            this.statusConnectionLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.statusConnectionLabel.Name = "statusConnectionLabel";
            this.statusConnectionLabel.Size = new System.Drawing.Size(207, 18);
            this.statusConnectionLabel.TabIndex = 4;
            this.statusConnectionLabel.Text = "Не подключено";
            // 
            // closeConnectionButton
            // 
            this.closeConnectionButton.AutoSize = true;
            this.closeConnectionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.closeConnectionButton.Enabled = false;
            this.closeConnectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeConnectionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeConnectionButton.Location = new System.Drawing.Point(242, 95);
            this.closeConnectionButton.Margin = new System.Windows.Forms.Padding(3, 3, 10, 10);
            this.closeConnectionButton.Name = "closeConnectionButton";
            this.closeConnectionButton.Size = new System.Drawing.Size(92, 28);
            this.closeConnectionButton.TabIndex = 7;
            this.closeConnectionButton.Text = "Отключить";
            this.closeConnectionButton.UseVisualStyleBackColor = true;
            // 
            // DevicesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.commonTableLayoutPanel);
            this.MinimumSize = new System.Drawing.Size(350, 440);
            this.Name = "DevicesUserControl";
            this.Size = new System.Drawing.Size(350, 440);
            this.commonTableLayoutPanel.ResumeLayout(false);
            this.availableConnectionGroupBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.statusGroupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel commonTableLayoutPanel;
        private System.Windows.Forms.GroupBox availableConnectionGroupBox;
        private System.Windows.Forms.GroupBox statusGroupBox;
        private System.Windows.Forms.Button addConnectionButton;
        private System.Windows.Forms.ListBox connectionsListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label typeDeviceLabel;
        private System.Windows.Forms.Label nameDeviceLabel;
        private System.Windows.Forms.Label statusConnectionLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button closeConnectionButton;
        private System.Windows.Forms.Label typeConnectionLabel;
        private System.Windows.Forms.Label label4;
    }
}
