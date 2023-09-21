namespace NewsLinkerContactForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            resetToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            nameLabel = new Label();
            addressLabel = new Label();
            emailLabel = new Label();
            phoneLabel = new Label();
            contactLabel = new Label();
            phoneSupportMessage = new Label();
            emailSupportMessage = new Label();
            nameTextBox = new TextBox();
            emailTextBox = new TextBox();
            addressTextBox = new TextBox();
            phoneTextBox = new TextBox();
            emailRadioButton = new RadioButton();
            phoneRadioButton = new RadioButton();
            submitButton = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            listBox1 = new ListBox();
            contactNewsLinkerHeading = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            toolStrip1 = new ToolStrip();
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(28, 28);
            menuStrip1.Items.AddRange(new ToolStripItem[] { resetToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1558, 40);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // resetToolStripMenuItem
            // 
            resetToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            resetToolStripMenuItem.Size = new Size(82, 36);
            resetToolStripMenuItem.Text = "Reset";
            resetToolStripMenuItem.Click += resetToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(71, 36);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            nameLabel.Location = new Point(61, 216);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(70, 30);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Name";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            addressLabel.Location = new Point(61, 284);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(90, 30);
            addressLabel.TabIndex = 2;
            addressLabel.Text = "Address";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            emailLabel.Location = new Point(61, 348);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(64, 30);
            emailLabel.TabIndex = 3;
            emailLabel.Text = "Email";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            phoneLabel.Location = new Point(61, 415);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(73, 30);
            phoneLabel.TabIndex = 4;
            phoneLabel.Text = "Phone";
            // 
            // contactLabel
            // 
            contactLabel.AutoSize = true;
            contactLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            contactLabel.Location = new Point(61, 482);
            contactLabel.Name = "contactLabel";
            contactLabel.Size = new Size(265, 30);
            contactLabel.TabIndex = 5;
            contactLabel.Text = "Preferred Contact Method";
            // 
            // phoneSupportMessage
            // 
            phoneSupportMessage.AutoSize = true;
            phoneSupportMessage.Location = new Point(205, 572);
            phoneSupportMessage.Name = "phoneSupportMessage";
            phoneSupportMessage.Size = new Size(348, 30);
            phoneSupportMessage.TabIndex = 6;
            phoneSupportMessage.Text = "Contact NewsLinker on 123-456-789";
            phoneSupportMessage.Visible = false;
            // 
            // emailSupportMessage
            // 
            emailSupportMessage.AutoSize = true;
            emailSupportMessage.Location = new Point(205, 528);
            emailSupportMessage.Name = "emailSupportMessage";
            emailSupportMessage.Size = new Size(340, 30);
            emailSupportMessage.TabIndex = 7;
            emailSupportMessage.Text = "Team will contact you within 2 days";
            emailSupportMessage.Visible = false;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(223, 211);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(228, 35);
            nameTextBox.TabIndex = 8;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(223, 345);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(228, 35);
            emailTextBox.TabIndex = 9;
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(223, 279);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(228, 35);
            addressTextBox.TabIndex = 10;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(223, 412);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(228, 35);
            phoneTextBox.TabIndex = 11;
            // 
            // emailRadioButton
            // 
            emailRadioButton.AutoSize = true;
            emailRadioButton.BackgroundImageLayout = ImageLayout.None;
            emailRadioButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            emailRadioButton.Location = new Point(80, 528);
            emailRadioButton.Name = "emailRadioButton";
            emailRadioButton.Size = new Size(89, 34);
            emailRadioButton.TabIndex = 12;
            emailRadioButton.TabStop = true;
            emailRadioButton.Text = "Email";
            emailRadioButton.UseVisualStyleBackColor = true;
            emailRadioButton.CheckedChanged += emailRadioButton_CheckedChanged;
            // 
            // phoneRadioButton
            // 
            phoneRadioButton.AutoSize = true;
            phoneRadioButton.BackgroundImageLayout = ImageLayout.None;
            phoneRadioButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            phoneRadioButton.Location = new Point(80, 572);
            phoneRadioButton.Name = "phoneRadioButton";
            phoneRadioButton.Size = new Size(98, 34);
            phoneRadioButton.TabIndex = 13;
            phoneRadioButton.TabStop = true;
            phoneRadioButton.Text = "Phone";
            phoneRadioButton.UseVisualStyleBackColor = true;
            phoneRadioButton.CheckedChanged += phoneRadioButton_CheckedChanged;
            // 
            // submitButton
            // 
            submitButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            submitButton.Location = new Point(61, 657);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(131, 40);
            submitButton.TabIndex = 14;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            tabControl1.Location = new Point(587, 169);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(930, 567);
            tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(listBox1);
            tabPage1.Location = new Point(4, 40);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(922, 523);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Customer List";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Fill;
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 31;
            listBox1.Location = new Point(3, 3);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(916, 517);
            listBox1.TabIndex = 0;
            // 
            // contactNewsLinkerHeading
            // 
            contactNewsLinkerHeading.AutoSize = true;
            contactNewsLinkerHeading.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            contactNewsLinkerHeading.Location = new Point(80, 83);
            contactNewsLinkerHeading.Name = "contactNewsLinkerHeading";
            contactNewsLinkerHeading.Size = new Size(419, 57);
            contactNewsLinkerHeading.TabIndex = 16;
            contactNewsLinkerHeading.Text = "Contact NewsLinker";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(28, 28);
            toolStrip1.Location = new Point(0, 40);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1558, 25);
            toolStrip1.TabIndex = 17;
            toolStrip1.Text = "toolStrip1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1558, 894);
            Controls.Add(toolStrip1);
            Controls.Add(contactNewsLinkerHeading);
            Controls.Add(tabControl1);
            Controls.Add(submitButton);
            Controls.Add(phoneRadioButton);
            Controls.Add(emailRadioButton);
            Controls.Add(phoneTextBox);
            Controls.Add(addressTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(emailSupportMessage);
            Controls.Add(phoneSupportMessage);
            Controls.Add(contactLabel);
            Controls.Add(phoneLabel);
            Controls.Add(emailLabel);
            Controls.Add(addressLabel);
            Controls.Add(nameLabel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem resetToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Label nameLabel;
        private Label addressLabel;
        private Label emailLabel;
        private Label phoneLabel;
        private Label contactLabel;
        private Label phoneSupportMessage;
        private Label emailSupportMessage;
        private TextBox nameTextBox;
        private TextBox emailTextBox;
        private TextBox addressTextBox;
        private TextBox phoneTextBox;
        private RadioButton emailRadioButton;
        private RadioButton phoneRadioButton;
        private Button submitButton;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private ListBox listBox1;
        private Label contactNewsLinkerHeading;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ToolStrip toolStrip1;
    }
}