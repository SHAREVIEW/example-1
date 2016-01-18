using System.Windows.Controls;

namespace Client.GUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.menuGroupBox = new System.Windows.Forms.GroupBox();
            this.menuListBox = new System.Windows.Forms.ListBox();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIconContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devicesUserControl = new Client.GUI.Controls.DevicesUserControl();
            this.settingsUserControl = new Client.GUI.Controls.SettingsUserControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.menuGroupBox.SuspendLayout();
            this.notifyIconContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Controls.Add(this.nameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.menuGroupBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.minimizeButton, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(590, 590);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.nameLabel, 2);
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameLabel.Font = new System.Drawing.Font("Bradley Hand ITC", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nameLabel.Location = new System.Drawing.Point(0, 0);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(540, 50);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Glorious Glove";
            this.nameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.nameLabel_MouseDown);
            this.nameLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.nameLabel_MouseMove);
            this.nameLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.nameLabel_MouseUp);
            // 
            // groupBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox, 2);
            this.groupBox.Controls.Add(this.devicesUserControl);
            this.groupBox.Controls.Add(this.settingsUserControl);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox.Location = new System.Drawing.Point(189, 50);
            this.groupBox.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox.Size = new System.Drawing.Size(401, 540);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            // 
            // menuGroupBox
            // 
            this.menuGroupBox.Controls.Add(this.menuListBox);
            this.menuGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuGroupBox.Location = new System.Drawing.Point(0, 50);
            this.menuGroupBox.Margin = new System.Windows.Forms.Padding(0);
            this.menuGroupBox.Name = "menuGroupBox";
            this.menuGroupBox.Padding = new System.Windows.Forms.Padding(1);
            this.menuGroupBox.Size = new System.Drawing.Size(189, 540);
            this.menuGroupBox.TabIndex = 3;
            this.menuGroupBox.TabStop = false;
            // 
            // menuListBox
            // 
            this.menuListBox.BackColor = System.Drawing.Color.Black;
            this.menuListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.menuListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuListBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)), true);
            this.menuListBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.menuListBox.FormattingEnabled = true;
            this.menuListBox.ItemHeight = 37;
            this.menuListBox.Items.AddRange(new object[] {
            "Устройства",
            "Жесты",
            "Настройки",
            "Помощь"});
            this.menuListBox.Location = new System.Drawing.Point(1, 14);
            this.menuListBox.Margin = new System.Windows.Forms.Padding(2);
            this.menuListBox.Name = "menuListBox";
            this.menuListBox.Size = new System.Drawing.Size(187, 525);
            this.menuListBox.TabIndex = 1;
            this.menuListBox.SelectedIndexChanged += new System.EventHandler(this.menuListBox_SelectedIndexChanged);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.minimizeButton.ForeColor = System.Drawing.Color.White;
            this.minimizeButton.Location = new System.Drawing.Point(540, 0);
            this.minimizeButton.Margin = new System.Windows.Forms.Padding(0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(50, 50);
            this.minimizeButton.TabIndex = 4;
            this.minimizeButton.Text = "_";
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.notifyIconContextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Glorious Glove at Your service";
            this.notifyIcon.Visible = true;
            // 
            // notifyIconContextMenuStrip
            // 
            this.notifyIconContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAppToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.notifyIconContextMenuStrip.Name = "notifyIconContextMenuStrip";
            this.notifyIconContextMenuStrip.Size = new System.Drawing.Size(166, 48);
            // 
            // showAppToolStripMenuItem
            // 
            this.showAppToolStripMenuItem.Name = "showAppToolStripMenuItem";
            this.showAppToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.showAppToolStripMenuItem.Text = "Show application";
            this.showAppToolStripMenuItem.Click += new System.EventHandler(this.showAppToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // devicesUserControl
            // 
            this.devicesUserControl.BackColor = System.Drawing.Color.Black;
            this.devicesUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.devicesUserControl.Location = new System.Drawing.Point(2, 15);
            this.devicesUserControl.Name = "devicesUserControl";
            this.devicesUserControl.Size = new System.Drawing.Size(397, 523);
            this.devicesUserControl.TabIndex = 0;
            // 
            // settingsUserControl
            // 
            this.settingsUserControl.BackColor = System.Drawing.Color.Black;
            this.settingsUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsUserControl.ForeColor = System.Drawing.Color.White;
            this.settingsUserControl.Location = new System.Drawing.Point(2, 15);
            this.settingsUserControl.Name = "settingsUserControl";
            this.settingsUserControl.Size = new System.Drawing.Size(397, 523);
            this.settingsUserControl.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowInTaskbar = false;
            this.Text = "Контроль устройств";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.menuGroupBox.ResumeLayout(false);
            this.notifyIconContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.GroupBox menuGroupBox;
        private System.Windows.Forms.ListBox menuListBox;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.GroupBox groupBox;
        private Controls.DevicesUserControl devicesUserControl;
        private Controls.SettingsUserControl settingsUserControl;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip notifyIconContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem showAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

