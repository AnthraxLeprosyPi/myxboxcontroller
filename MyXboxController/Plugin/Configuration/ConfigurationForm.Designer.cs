using J2i.Net.XInputWrapper;
namespace MyXboxController.Plugin.Config {
    partial class ConfigurationForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label isAPressedLabel;
            System.Windows.Forms.Label isBackPressedLabel;
            System.Windows.Forms.Label isBPressedLabel;
            System.Windows.Forms.Label isConnectedLabel;
            System.Windows.Forms.Label isDPadDownPressedLabel;
            System.Windows.Forms.Label isDPadLeftPressedLabel;
            System.Windows.Forms.Label isDPadRightPressedLabel;
            System.Windows.Forms.Label isDPadUpPressedLabel;
            System.Windows.Forms.Label isLeftShoulderPressedLabel;
            System.Windows.Forms.Label isLeftStickPressedLabel;
            System.Windows.Forms.Label isRightShoulderPressedLabel;
            System.Windows.Forms.Label isRightStickPressedLabel;
            System.Windows.Forms.Label isStartPressedLabel;
            System.Windows.Forms.Label isXPressedLabel;
            System.Windows.Forms.Label isYPressedLabel;
            System.Windows.Forms.Label leftTriggerLabel;
            System.Windows.Forms.Label rightTriggerLabel;
            System.Windows.Forms.Label xLabel;
            System.Windows.Forms.Label yLabel;
            System.Windows.Forms.Label xLabel1;
            System.Windows.Forms.Label yLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigurationForm));
            this.label16 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Mapping = new System.Windows.Forms.TabPage();
            this.isAPressedCheckBox = new System.Windows.Forms.CheckBox();
            this.xboxControllerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.isBPressedCheckBox = new System.Windows.Forms.CheckBox();
            this.isXPressedCheckBox = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.xTextBox1 = new System.Windows.Forms.TextBox();
            this.yTextBox1 = new System.Windows.Forms.TextBox();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.yTextBox = new System.Windows.Forms.TextBox();
            this.isBackPressedCheckBox = new System.Windows.Forms.CheckBox();
            this.isConnectedCheckBox = new System.Windows.Forms.CheckBox();
            this.isDPadDownPressedCheckBox = new System.Windows.Forms.CheckBox();
            this.isDPadLeftPressedCheckBox = new System.Windows.Forms.CheckBox();
            this.isDPadRightPressedCheckBox = new System.Windows.Forms.CheckBox();
            this.isDPadUpPressedCheckBox = new System.Windows.Forms.CheckBox();
            this.isLeftShoulderPressedCheckBox = new System.Windows.Forms.CheckBox();
            this.isLeftStickPressedCheckBox = new System.Windows.Forms.CheckBox();
            this.isRightShoulderPressedCheckBox = new System.Windows.Forms.CheckBox();
            this.isRightStickPressedCheckBox = new System.Windows.Forms.CheckBox();
            this.isStartPressedCheckBox = new System.Windows.Forms.CheckBox();
            this.leftTriggerTextBox = new System.Windows.Forms.TextBox();
            this.rightTriggerTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.isOnlineDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.uriPlexSectionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uriPlexBaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serverCapabilitiesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            isAPressedLabel = new System.Windows.Forms.Label();
            isBackPressedLabel = new System.Windows.Forms.Label();
            isBPressedLabel = new System.Windows.Forms.Label();
            isConnectedLabel = new System.Windows.Forms.Label();
            isDPadDownPressedLabel = new System.Windows.Forms.Label();
            isDPadLeftPressedLabel = new System.Windows.Forms.Label();
            isDPadRightPressedLabel = new System.Windows.Forms.Label();
            isDPadUpPressedLabel = new System.Windows.Forms.Label();
            isLeftShoulderPressedLabel = new System.Windows.Forms.Label();
            isLeftStickPressedLabel = new System.Windows.Forms.Label();
            isRightShoulderPressedLabel = new System.Windows.Forms.Label();
            isRightStickPressedLabel = new System.Windows.Forms.Label();
            isStartPressedLabel = new System.Windows.Forms.Label();
            isXPressedLabel = new System.Windows.Forms.Label();
            isYPressedLabel = new System.Windows.Forms.Label();
            leftTriggerLabel = new System.Windows.Forms.Label();
            rightTriggerLabel = new System.Windows.Forms.Label();
            xLabel = new System.Windows.Forms.Label();
            yLabel = new System.Windows.Forms.Label();
            xLabel1 = new System.Windows.Forms.Label();
            yLabel1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Mapping.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xboxControllerBindingSource)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // isAPressedLabel
            // 
            isAPressedLabel.AutoSize = true;
            isAPressedLabel.Location = new System.Drawing.Point(14, 11);
            isAPressedLabel.Name = "isAPressedLabel";
            isAPressedLabel.Size = new System.Drawing.Size(66, 13);
            isAPressedLabel.TabIndex = 0;
            isAPressedLabel.Text = "Is APressed:";
            // 
            // isBackPressedLabel
            // 
            isBackPressedLabel.AutoSize = true;
            isBackPressedLabel.Location = new System.Drawing.Point(257, 190);
            isBackPressedLabel.Name = "isBackPressedLabel";
            isBackPressedLabel.Size = new System.Drawing.Size(87, 13);
            isBackPressedLabel.TabIndex = 2;
            isBackPressedLabel.Text = "Is Back Pressed:";
            // 
            // isBPressedLabel
            // 
            isBPressedLabel.AutoSize = true;
            isBPressedLabel.Location = new System.Drawing.Point(14, 36);
            isBPressedLabel.Name = "isBPressedLabel";
            isBPressedLabel.Size = new System.Drawing.Size(66, 13);
            isBPressedLabel.TabIndex = 4;
            isBPressedLabel.Text = "Is BPressed:";
            // 
            // isConnectedLabel
            // 
            isConnectedLabel.AutoSize = true;
            isConnectedLabel.Location = new System.Drawing.Point(505, 166);
            isConnectedLabel.Name = "isConnectedLabel";
            isConnectedLabel.Size = new System.Drawing.Size(73, 13);
            isConnectedLabel.TabIndex = 6;
            isConnectedLabel.Text = "Is Connected:";
            // 
            // isDPadDownPressedLabel
            // 
            isDPadDownPressedLabel.AutoSize = true;
            isDPadDownPressedLabel.Location = new System.Drawing.Point(14, 131);
            isDPadDownPressedLabel.Name = "isDPadDownPressedLabel";
            isDPadDownPressedLabel.Size = new System.Drawing.Size(120, 13);
            isDPadDownPressedLabel.TabIndex = 8;
            isDPadDownPressedLabel.Text = "Is DPad Down Pressed:";
            // 
            // isDPadLeftPressedLabel
            // 
            isDPadLeftPressedLabel.AutoSize = true;
            isDPadLeftPressedLabel.Location = new System.Drawing.Point(14, 161);
            isDPadLeftPressedLabel.Name = "isDPadLeftPressedLabel";
            isDPadLeftPressedLabel.Size = new System.Drawing.Size(110, 13);
            isDPadLeftPressedLabel.TabIndex = 10;
            isDPadLeftPressedLabel.Text = "Is DPad Left Pressed:";
            // 
            // isDPadRightPressedLabel
            // 
            isDPadRightPressedLabel.AutoSize = true;
            isDPadRightPressedLabel.Location = new System.Drawing.Point(257, 11);
            isDPadRightPressedLabel.Name = "isDPadRightPressedLabel";
            isDPadRightPressedLabel.Size = new System.Drawing.Size(117, 13);
            isDPadRightPressedLabel.TabIndex = 12;
            isDPadRightPressedLabel.Text = "Is DPad Right Pressed:";
            // 
            // isDPadUpPressedLabel
            // 
            isDPadUpPressedLabel.AutoSize = true;
            isDPadUpPressedLabel.Location = new System.Drawing.Point(257, 41);
            isDPadUpPressedLabel.Name = "isDPadUpPressedLabel";
            isDPadUpPressedLabel.Size = new System.Drawing.Size(106, 13);
            isDPadUpPressedLabel.TabIndex = 14;
            isDPadUpPressedLabel.Text = "Is DPad Up Pressed:";
            // 
            // isLeftShoulderPressedLabel
            // 
            isLeftShoulderPressedLabel.AutoSize = true;
            isLeftShoulderPressedLabel.Location = new System.Drawing.Point(257, 71);
            isLeftShoulderPressedLabel.Name = "isLeftShoulderPressedLabel";
            isLeftShoulderPressedLabel.Size = new System.Drawing.Size(125, 13);
            isLeftShoulderPressedLabel.TabIndex = 16;
            isLeftShoulderPressedLabel.Text = "Is Left Shoulder Pressed:";
            // 
            // isLeftStickPressedLabel
            // 
            isLeftStickPressedLabel.AutoSize = true;
            isLeftStickPressedLabel.Location = new System.Drawing.Point(257, 101);
            isLeftStickPressedLabel.Name = "isLeftStickPressedLabel";
            isLeftStickPressedLabel.Size = new System.Drawing.Size(107, 13);
            isLeftStickPressedLabel.TabIndex = 18;
            isLeftStickPressedLabel.Text = "Is Left Stick Pressed:";
            // 
            // isRightShoulderPressedLabel
            // 
            isRightShoulderPressedLabel.AutoSize = true;
            isRightShoulderPressedLabel.Location = new System.Drawing.Point(257, 131);
            isRightShoulderPressedLabel.Name = "isRightShoulderPressedLabel";
            isRightShoulderPressedLabel.Size = new System.Drawing.Size(132, 13);
            isRightShoulderPressedLabel.TabIndex = 20;
            isRightShoulderPressedLabel.Text = "Is Right Shoulder Pressed:";
            // 
            // isRightStickPressedLabel
            // 
            isRightStickPressedLabel.AutoSize = true;
            isRightStickPressedLabel.Location = new System.Drawing.Point(257, 161);
            isRightStickPressedLabel.Name = "isRightStickPressedLabel";
            isRightStickPressedLabel.Size = new System.Drawing.Size(114, 13);
            isRightStickPressedLabel.TabIndex = 22;
            isRightStickPressedLabel.Text = "Is Right Stick Pressed:";
            // 
            // isStartPressedLabel
            // 
            isStartPressedLabel.AutoSize = true;
            isStartPressedLabel.Location = new System.Drawing.Point(14, 189);
            isStartPressedLabel.Name = "isStartPressedLabel";
            isStartPressedLabel.Size = new System.Drawing.Size(84, 13);
            isStartPressedLabel.TabIndex = 24;
            isStartPressedLabel.Text = "Is Start Pressed:";
            // 
            // isXPressedLabel
            // 
            isXPressedLabel.AutoSize = true;
            isXPressedLabel.Location = new System.Drawing.Point(14, 62);
            isXPressedLabel.Name = "isXPressedLabel";
            isXPressedLabel.Size = new System.Drawing.Size(66, 13);
            isXPressedLabel.TabIndex = 26;
            isXPressedLabel.Text = "Is XPressed:";
            // 
            // isYPressedLabel
            // 
            isYPressedLabel.AutoSize = true;
            isYPressedLabel.Location = new System.Drawing.Point(14, 92);
            isYPressedLabel.Name = "isYPressedLabel";
            isYPressedLabel.Size = new System.Drawing.Size(66, 13);
            isYPressedLabel.TabIndex = 28;
            isYPressedLabel.Text = "Is YPressed:";
            // 
            // leftTriggerLabel
            // 
            leftTriggerLabel.AutoSize = true;
            leftTriggerLabel.Location = new System.Drawing.Point(481, 251);
            leftTriggerLabel.Name = "leftTriggerLabel";
            leftTriggerLabel.Size = new System.Drawing.Size(64, 13);
            leftTriggerLabel.TabIndex = 30;
            leftTriggerLabel.Text = "Left Trigger:";
            // 
            // rightTriggerLabel
            // 
            rightTriggerLabel.AutoSize = true;
            rightTriggerLabel.Location = new System.Drawing.Point(481, 277);
            rightTriggerLabel.Name = "rightTriggerLabel";
            rightTriggerLabel.Size = new System.Drawing.Size(71, 13);
            rightTriggerLabel.TabIndex = 32;
            rightTriggerLabel.Text = "Right Trigger:";
            // 
            // xLabel
            // 
            xLabel.AutoSize = true;
            xLabel.Location = new System.Drawing.Point(769, 166);
            xLabel.Name = "xLabel";
            xLabel.Size = new System.Drawing.Size(17, 13);
            xLabel.TabIndex = 34;
            xLabel.Text = "X:";
            // 
            // yLabel
            // 
            yLabel.AutoSize = true;
            yLabel.Location = new System.Drawing.Point(769, 192);
            yLabel.Name = "yLabel";
            yLabel.Size = new System.Drawing.Size(17, 13);
            yLabel.TabIndex = 36;
            yLabel.Text = "Y:";
            // 
            // xLabel1
            // 
            xLabel1.AutoSize = true;
            xLabel1.Location = new System.Drawing.Point(769, 252);
            xLabel1.Name = "xLabel1";
            xLabel1.Size = new System.Drawing.Size(17, 13);
            xLabel1.TabIndex = 38;
            xLabel1.Text = "X:";
            // 
            // yLabel1
            // 
            yLabel1.AutoSize = true;
            yLabel1.Location = new System.Drawing.Point(769, 278);
            yLabel1.Name = "yLabel1";
            yLabel1.Size = new System.Drawing.Size(17, 13);
            yLabel1.TabIndex = 40;
            yLabel1.Text = "Y:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Trebuchet MS", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(197)))), ((int)(((byte)(60)))));
            this.label16.Location = new System.Drawing.Point(12, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(302, 43);
            this.label16.TabIndex = 6;
            this.label16.Text = "MyXboxController";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.Mapping);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(825, 216);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(161, 220);
            this.tabControl1.TabIndex = 7;
            // 
            // Mapping
            // 
            this.Mapping.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Mapping.BackgroundImage")));
            this.Mapping.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Mapping.Controls.Add(this.isAPressedCheckBox);
            this.Mapping.Controls.Add(this.isBPressedCheckBox);
            this.Mapping.Controls.Add(this.isXPressedCheckBox);
            this.Mapping.Controls.Add(this.comboBox1);
            this.Mapping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mapping.Location = new System.Drawing.Point(4, 22);
            this.Mapping.Name = "Mapping";
            this.Mapping.Padding = new System.Windows.Forms.Padding(3);
            this.Mapping.Size = new System.Drawing.Size(153, 194);
            this.Mapping.TabIndex = 3;
            this.Mapping.Text = "Button Mapping";
            // 
            // isAPressedCheckBox
            // 
            this.isAPressedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.xboxControllerBindingSource, "IsAPressed", true));
            this.isAPressedCheckBox.Location = new System.Drawing.Point(234, 162);
            this.isAPressedCheckBox.Name = "isAPressedCheckBox";
            this.isAPressedCheckBox.Size = new System.Drawing.Size(15, 24);
            this.isAPressedCheckBox.TabIndex = 30;
            this.isAPressedCheckBox.UseVisualStyleBackColor = true;
            // 
            // xboxControllerBindingSource
            // 
            this.xboxControllerBindingSource.DataSource = typeof(XboxController);
            // 
            // isBPressedCheckBox
            // 
            this.isBPressedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.xboxControllerBindingSource, "IsBPressed", true));
            this.isBPressedCheckBox.Location = new System.Drawing.Point(288, 106);
            this.isBPressedCheckBox.Name = "isBPressedCheckBox";
            this.isBPressedCheckBox.Size = new System.Drawing.Size(16, 24);
            this.isBPressedCheckBox.TabIndex = 31;
            this.isBPressedCheckBox.UseVisualStyleBackColor = true;
            // 
            // isXPressedCheckBox
            // 
            this.isXPressedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.xboxControllerBindingSource, "IsXPressed", true));
            this.isXPressedCheckBox.Location = new System.Drawing.Point(178, 106);
            this.isXPressedCheckBox.Name = "isXPressedCheckBox";
            this.isXPressedCheckBox.Size = new System.Drawing.Size(17, 24);
            this.isXPressedCheckBox.TabIndex = 32;
            this.isXPressedCheckBox.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(271, 286);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.propertyGrid1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(450, 325);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.Location = new System.Drawing.Point(3, 3);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(444, 319);
            this.propertyGrid1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(xLabel1);
            this.tabPage2.Controls.Add(this.xTextBox1);
            this.tabPage2.Controls.Add(yLabel1);
            this.tabPage2.Controls.Add(this.yTextBox1);
            this.tabPage2.Controls.Add(xLabel);
            this.tabPage2.Controls.Add(this.xTextBox);
            this.tabPage2.Controls.Add(yLabel);
            this.tabPage2.Controls.Add(this.yTextBox);
            this.tabPage2.Controls.Add(isAPressedLabel);
            this.tabPage2.Controls.Add(isBackPressedLabel);
            this.tabPage2.Controls.Add(this.isBackPressedCheckBox);
            this.tabPage2.Controls.Add(isBPressedLabel);
            this.tabPage2.Controls.Add(isConnectedLabel);
            this.tabPage2.Controls.Add(this.isConnectedCheckBox);
            this.tabPage2.Controls.Add(isDPadDownPressedLabel);
            this.tabPage2.Controls.Add(this.isDPadDownPressedCheckBox);
            this.tabPage2.Controls.Add(isDPadLeftPressedLabel);
            this.tabPage2.Controls.Add(this.isDPadLeftPressedCheckBox);
            this.tabPage2.Controls.Add(isDPadRightPressedLabel);
            this.tabPage2.Controls.Add(this.isDPadRightPressedCheckBox);
            this.tabPage2.Controls.Add(isDPadUpPressedLabel);
            this.tabPage2.Controls.Add(this.isDPadUpPressedCheckBox);
            this.tabPage2.Controls.Add(isLeftShoulderPressedLabel);
            this.tabPage2.Controls.Add(this.isLeftShoulderPressedCheckBox);
            this.tabPage2.Controls.Add(isLeftStickPressedLabel);
            this.tabPage2.Controls.Add(this.isLeftStickPressedCheckBox);
            this.tabPage2.Controls.Add(isRightShoulderPressedLabel);
            this.tabPage2.Controls.Add(this.isRightShoulderPressedCheckBox);
            this.tabPage2.Controls.Add(isRightStickPressedLabel);
            this.tabPage2.Controls.Add(this.isRightStickPressedCheckBox);
            this.tabPage2.Controls.Add(isStartPressedLabel);
            this.tabPage2.Controls.Add(this.isStartPressedCheckBox);
            this.tabPage2.Controls.Add(isXPressedLabel);
            this.tabPage2.Controls.Add(isYPressedLabel);
            this.tabPage2.Controls.Add(leftTriggerLabel);
            this.tabPage2.Controls.Add(this.leftTriggerTextBox);
            this.tabPage2.Controls.Add(rightTriggerLabel);
            this.tabPage2.Controls.Add(this.rightTriggerTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(450, 325);
            this.tabPage2.TabIndex = 5;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // xTextBox1
            // 
            this.xTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.xboxControllerBindingSource, "RightThumbStick.X", true));
            this.xTextBox1.Location = new System.Drawing.Point(792, 249);
            this.xTextBox1.Name = "xTextBox1";
            this.xTextBox1.Size = new System.Drawing.Size(100, 20);
            this.xTextBox1.TabIndex = 39;
            // 
            // yTextBox1
            // 
            this.yTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.xboxControllerBindingSource, "RightThumbStick.Y", true));
            this.yTextBox1.Location = new System.Drawing.Point(792, 275);
            this.yTextBox1.Name = "yTextBox1";
            this.yTextBox1.Size = new System.Drawing.Size(100, 20);
            this.yTextBox1.TabIndex = 41;
            // 
            // xTextBox
            // 
            this.xTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.xboxControllerBindingSource, "LeftThumbStick.X", true));
            this.xTextBox.Location = new System.Drawing.Point(792, 163);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(100, 20);
            this.xTextBox.TabIndex = 35;
            // 
            // yTextBox
            // 
            this.yTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.xboxControllerBindingSource, "LeftThumbStick.Y", true));
            this.yTextBox.Location = new System.Drawing.Point(792, 189);
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.Size = new System.Drawing.Size(100, 20);
            this.yTextBox.TabIndex = 37;
            // 
            // isBackPressedCheckBox
            // 
            this.isBackPressedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.xboxControllerBindingSource, "IsBackPressed", true));
            this.isBackPressedCheckBox.Location = new System.Drawing.Point(395, 185);
            this.isBackPressedCheckBox.Name = "isBackPressedCheckBox";
            this.isBackPressedCheckBox.Size = new System.Drawing.Size(104, 24);
            this.isBackPressedCheckBox.TabIndex = 3;
            this.isBackPressedCheckBox.Text = "checkBox1";
            this.isBackPressedCheckBox.UseVisualStyleBackColor = true;
            // 
            // isConnectedCheckBox
            // 
            this.isConnectedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.xboxControllerBindingSource, "IsConnected", true));
            this.isConnectedCheckBox.Location = new System.Drawing.Point(643, 161);
            this.isConnectedCheckBox.Name = "isConnectedCheckBox";
            this.isConnectedCheckBox.Size = new System.Drawing.Size(104, 24);
            this.isConnectedCheckBox.TabIndex = 7;
            this.isConnectedCheckBox.Text = "checkBox1";
            this.isConnectedCheckBox.UseVisualStyleBackColor = true;
            // 
            // isDPadDownPressedCheckBox
            // 
            this.isDPadDownPressedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.xboxControllerBindingSource, "IsDPadDownPressed", true));
            this.isDPadDownPressedCheckBox.Location = new System.Drawing.Point(152, 126);
            this.isDPadDownPressedCheckBox.Name = "isDPadDownPressedCheckBox";
            this.isDPadDownPressedCheckBox.Size = new System.Drawing.Size(104, 24);
            this.isDPadDownPressedCheckBox.TabIndex = 9;
            this.isDPadDownPressedCheckBox.Text = "checkBox1";
            this.isDPadDownPressedCheckBox.UseVisualStyleBackColor = true;
            // 
            // isDPadLeftPressedCheckBox
            // 
            this.isDPadLeftPressedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.xboxControllerBindingSource, "IsDPadLeftPressed", true));
            this.isDPadLeftPressedCheckBox.Location = new System.Drawing.Point(152, 156);
            this.isDPadLeftPressedCheckBox.Name = "isDPadLeftPressedCheckBox";
            this.isDPadLeftPressedCheckBox.Size = new System.Drawing.Size(104, 24);
            this.isDPadLeftPressedCheckBox.TabIndex = 11;
            this.isDPadLeftPressedCheckBox.Text = "checkBox1";
            this.isDPadLeftPressedCheckBox.UseVisualStyleBackColor = true;
            // 
            // isDPadRightPressedCheckBox
            // 
            this.isDPadRightPressedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.xboxControllerBindingSource, "IsDPadRightPressed", true));
            this.isDPadRightPressedCheckBox.Location = new System.Drawing.Point(395, 6);
            this.isDPadRightPressedCheckBox.Name = "isDPadRightPressedCheckBox";
            this.isDPadRightPressedCheckBox.Size = new System.Drawing.Size(104, 24);
            this.isDPadRightPressedCheckBox.TabIndex = 13;
            this.isDPadRightPressedCheckBox.Text = "checkBox1";
            this.isDPadRightPressedCheckBox.UseVisualStyleBackColor = true;
            // 
            // isDPadUpPressedCheckBox
            // 
            this.isDPadUpPressedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.xboxControllerBindingSource, "IsDPadUpPressed", true));
            this.isDPadUpPressedCheckBox.Location = new System.Drawing.Point(395, 36);
            this.isDPadUpPressedCheckBox.Name = "isDPadUpPressedCheckBox";
            this.isDPadUpPressedCheckBox.Size = new System.Drawing.Size(104, 24);
            this.isDPadUpPressedCheckBox.TabIndex = 15;
            this.isDPadUpPressedCheckBox.Text = "checkBox1";
            this.isDPadUpPressedCheckBox.UseVisualStyleBackColor = true;
            // 
            // isLeftShoulderPressedCheckBox
            // 
            this.isLeftShoulderPressedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.xboxControllerBindingSource, "IsLeftShoulderPressed", true));
            this.isLeftShoulderPressedCheckBox.Location = new System.Drawing.Point(395, 66);
            this.isLeftShoulderPressedCheckBox.Name = "isLeftShoulderPressedCheckBox";
            this.isLeftShoulderPressedCheckBox.Size = new System.Drawing.Size(104, 24);
            this.isLeftShoulderPressedCheckBox.TabIndex = 17;
            this.isLeftShoulderPressedCheckBox.Text = "checkBox1";
            this.isLeftShoulderPressedCheckBox.UseVisualStyleBackColor = true;
            // 
            // isLeftStickPressedCheckBox
            // 
            this.isLeftStickPressedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.xboxControllerBindingSource, "IsLeftStickPressed", true));
            this.isLeftStickPressedCheckBox.Location = new System.Drawing.Point(395, 96);
            this.isLeftStickPressedCheckBox.Name = "isLeftStickPressedCheckBox";
            this.isLeftStickPressedCheckBox.Size = new System.Drawing.Size(104, 24);
            this.isLeftStickPressedCheckBox.TabIndex = 19;
            this.isLeftStickPressedCheckBox.Text = "checkBox1";
            this.isLeftStickPressedCheckBox.UseVisualStyleBackColor = true;
            // 
            // isRightShoulderPressedCheckBox
            // 
            this.isRightShoulderPressedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.xboxControllerBindingSource, "IsRightShoulderPressed", true));
            this.isRightShoulderPressedCheckBox.Location = new System.Drawing.Point(395, 126);
            this.isRightShoulderPressedCheckBox.Name = "isRightShoulderPressedCheckBox";
            this.isRightShoulderPressedCheckBox.Size = new System.Drawing.Size(104, 24);
            this.isRightShoulderPressedCheckBox.TabIndex = 21;
            this.isRightShoulderPressedCheckBox.Text = "checkBox1";
            this.isRightShoulderPressedCheckBox.UseVisualStyleBackColor = true;
            // 
            // isRightStickPressedCheckBox
            // 
            this.isRightStickPressedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.xboxControllerBindingSource, "IsRightStickPressed", true));
            this.isRightStickPressedCheckBox.Location = new System.Drawing.Point(395, 156);
            this.isRightStickPressedCheckBox.Name = "isRightStickPressedCheckBox";
            this.isRightStickPressedCheckBox.Size = new System.Drawing.Size(104, 24);
            this.isRightStickPressedCheckBox.TabIndex = 23;
            this.isRightStickPressedCheckBox.Text = "checkBox1";
            this.isRightStickPressedCheckBox.UseVisualStyleBackColor = true;
            // 
            // isStartPressedCheckBox
            // 
            this.isStartPressedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.xboxControllerBindingSource, "IsStartPressed", true));
            this.isStartPressedCheckBox.Location = new System.Drawing.Point(152, 184);
            this.isStartPressedCheckBox.Name = "isStartPressedCheckBox";
            this.isStartPressedCheckBox.Size = new System.Drawing.Size(104, 24);
            this.isStartPressedCheckBox.TabIndex = 25;
            this.isStartPressedCheckBox.Text = "checkBox1";
            this.isStartPressedCheckBox.UseVisualStyleBackColor = true;
            // 
            // leftTriggerTextBox
            // 
            this.leftTriggerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.xboxControllerBindingSource, "LeftTrigger", true));
            this.leftTriggerTextBox.Location = new System.Drawing.Point(619, 248);
            this.leftTriggerTextBox.Name = "leftTriggerTextBox";
            this.leftTriggerTextBox.Size = new System.Drawing.Size(104, 20);
            this.leftTriggerTextBox.TabIndex = 31;
            // 
            // rightTriggerTextBox
            // 
            this.rightTriggerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.xboxControllerBindingSource, "RightTrigger", true));
            this.rightTriggerTextBox.Location = new System.Drawing.Point(619, 274);
            this.rightTriggerTextBox.Name = "rightTriggerTextBox";
            this.rightTriggerTextBox.Size = new System.Drawing.Size(104, 20);
            this.rightTriggerTextBox.TabIndex = 33;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::MyXboxController.Properties.Resources.xboxControllerButtonY;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.xboxControllerBindingSource, "IsYPressed", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pictureBox2.Location = new System.Drawing.Point(597, 96);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 39);
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::MyXboxController.Properties.Resources.xbox_logo;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(916, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // isOnlineDataGridViewCheckBoxColumn
            // 
            this.isOnlineDataGridViewCheckBoxColumn.DataPropertyName = "IsOnline";
            this.isOnlineDataGridViewCheckBoxColumn.HeaderText = "IsOnline";
            this.isOnlineDataGridViewCheckBoxColumn.Name = "isOnlineDataGridViewCheckBoxColumn";
            this.isOnlineDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isOnlineDataGridViewCheckBoxColumn.Width = 59;
            // 
            // uriPlexSectionsDataGridViewTextBoxColumn
            // 
            this.uriPlexSectionsDataGridViewTextBoxColumn.DataPropertyName = "UriPlexSections";
            this.uriPlexSectionsDataGridViewTextBoxColumn.HeaderText = "UriPlexSections";
            this.uriPlexSectionsDataGridViewTextBoxColumn.Name = "uriPlexSectionsDataGridViewTextBoxColumn";
            this.uriPlexSectionsDataGridViewTextBoxColumn.ReadOnly = true;
            this.uriPlexSectionsDataGridViewTextBoxColumn.Width = 58;
            // 
            // uriPlexBaseDataGridViewTextBoxColumn
            // 
            this.uriPlexBaseDataGridViewTextBoxColumn.DataPropertyName = "UriPlexBase";
            this.uriPlexBaseDataGridViewTextBoxColumn.HeaderText = "UriPlexBase";
            this.uriPlexBaseDataGridViewTextBoxColumn.Name = "uriPlexBaseDataGridViewTextBoxColumn";
            this.uriPlexBaseDataGridViewTextBoxColumn.ReadOnly = true;
            this.uriPlexBaseDataGridViewTextBoxColumn.Width = 59;
            // 
            // serverCapabilitiesDataGridViewTextBoxColumn
            // 
            this.serverCapabilitiesDataGridViewTextBoxColumn.DataPropertyName = "ServerCapabilities";
            this.serverCapabilitiesDataGridViewTextBoxColumn.HeaderText = "ServerCapabilities";
            this.serverCapabilitiesDataGridViewTextBoxColumn.Name = "serverCapabilitiesDataGridViewTextBoxColumn";
            this.serverCapabilitiesDataGridViewTextBoxColumn.Width = 58;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(998, 448);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(508, 1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 35;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = global::MyXboxController.Properties.Resources.xboxControllerButtonY;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Location = new System.Drawing.Point(388, 150);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(42, 39);
            this.pictureBox5.TabIndex = 36;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImage = global::MyXboxController.Properties.Resources.xboxControllerButtonY;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox6.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.xboxControllerBindingSource, "IsYPressed", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pictureBox6.Location = new System.Drawing.Point(597, 150);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(42, 39);
            this.pictureBox6.TabIndex = 37;
            this.pictureBox6.TabStop = false;
            // 
            // ConfigurationForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackgroundImage = global::MyXboxController.Properties.Resources.config_ctripes;
            this.ClientSize = new System.Drawing.Size(998, 448);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox3);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "ConfigurationForm";
            this.Text = "Configuration";
            this.tabControl1.ResumeLayout(false);
            this.Mapping.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xboxControllerBindingSource)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.BindingSource plexServerBindingSource;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn serverCapabilitiesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isOnlineDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uriPlexSectionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uriPlexBaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPassDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource baseConnectionInfoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn friendlyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uriPlexBaseDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn plexVersionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isMyPlexDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isBonjourDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isManualDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn machineIdentifierDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox xTextBox1;
        private System.Windows.Forms.BindingSource xboxControllerBindingSource;
        private System.Windows.Forms.TextBox yTextBox1;
        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.TextBox yTextBox;
        private System.Windows.Forms.CheckBox isBackPressedCheckBox;
        private System.Windows.Forms.CheckBox isConnectedCheckBox;
        private System.Windows.Forms.CheckBox isDPadDownPressedCheckBox;
        private System.Windows.Forms.CheckBox isDPadLeftPressedCheckBox;
        private System.Windows.Forms.CheckBox isDPadRightPressedCheckBox;
        private System.Windows.Forms.CheckBox isDPadUpPressedCheckBox;
        private System.Windows.Forms.CheckBox isLeftShoulderPressedCheckBox;
        private System.Windows.Forms.CheckBox isLeftStickPressedCheckBox;
        private System.Windows.Forms.CheckBox isRightShoulderPressedCheckBox;
        private System.Windows.Forms.CheckBox isRightStickPressedCheckBox;
        private System.Windows.Forms.CheckBox isStartPressedCheckBox;
        private System.Windows.Forms.TextBox leftTriggerTextBox;
        private System.Windows.Forms.TextBox rightTriggerTextBox;
        private System.Windows.Forms.TabPage Mapping;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox isAPressedCheckBox;
        private System.Windows.Forms.CheckBox isBPressedCheckBox;
        private System.Windows.Forms.CheckBox isXPressedCheckBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        

    }
}