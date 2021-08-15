
namespace Nemesis
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
            this.components = new System.ComponentModel.Container();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.injectButton = new System.Windows.Forms.Button();
            this.executeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.execute2Button = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Commands = new System.Windows.Forms.Label();
            this.sendCommand = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.walkSpeed = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.jumpPower = new System.Windows.Forms.NumericUpDown();
            this.applyButton = new System.Windows.Forms.Button();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tpButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.walkSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jumpPower)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(10, 46);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(515, 277);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // injectButton
            // 
            this.injectButton.Location = new System.Drawing.Point(10, 346);
            this.injectButton.Name = "injectButton";
            this.injectButton.Size = new System.Drawing.Size(91, 34);
            this.injectButton.TabIndex = 1;
            this.injectButton.Text = "Inject";
            this.injectButton.UseVisualStyleBackColor = true;
            this.injectButton.Click += new System.EventHandler(this.injectButton_Click);
            // 
            // executeButton
            // 
            this.executeButton.Location = new System.Drawing.Point(240, 346);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(91, 34);
            this.executeButton.TabIndex = 2;
            this.executeButton.Text = "Execute";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(434, 346);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(91, 34);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // execute2Button
            // 
            this.execute2Button.Location = new System.Drawing.Point(337, 346);
            this.execute2Button.Name = "execute2Button";
            this.execute2Button.Size = new System.Drawing.Size(91, 34);
            this.execute2Button.TabIndex = 4;
            this.execute2Button.Text = "Execute Lua C";
            this.execute2Button.UseVisualStyleBackColor = true;
            this.execute2Button.Click += new System.EventHandler(this.execute2Button_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Fly",
            "Infinite Jump",
            "ESP",
            "Btools",
            "Ctrl Click TP",
            "FPS Gui",
            "Jailbreak GUI"});
            this.listBox1.Location = new System.Drawing.Point(543, 46);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(124, 277);
            this.listBox1.TabIndex = 5;
            // 
            // Commands
            // 
            this.Commands.AutoSize = true;
            this.Commands.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold);
            this.Commands.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Commands.Location = new System.Drawing.Point(561, 18);
            this.Commands.Name = "Commands";
            this.Commands.Size = new System.Drawing.Size(75, 25);
            this.Commands.TabIndex = 6;
            this.Commands.Text = "Scripts";
            // 
            // sendCommand
            // 
            this.sendCommand.Location = new System.Drawing.Point(556, 346);
            this.sendCommand.Name = "sendCommand";
            this.sendCommand.Size = new System.Drawing.Size(91, 34);
            this.sendCommand.TabIndex = 7;
            this.sendCommand.Text = "Send Command";
            this.sendCommand.UseVisualStyleBackColor = true;
            this.sendCommand.Click += new System.EventHandler(this.sendCommand_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "NEMESIS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(190, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Not Injected";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(728, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Speed";
            // 
            // walkSpeed
            // 
            this.walkSpeed.Location = new System.Drawing.Point(703, 47);
            this.walkSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.walkSpeed.Name = "walkSpeed";
            this.walkSpeed.Size = new System.Drawing.Size(120, 20);
            this.walkSpeed.TabIndex = 11;
            this.walkSpeed.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(728, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Jump";
            // 
            // jumpPower
            // 
            this.jumpPower.Location = new System.Drawing.Point(703, 98);
            this.jumpPower.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.jumpPower.Name = "jumpPower";
            this.jumpPower.Size = new System.Drawing.Size(120, 20);
            this.jumpPower.TabIndex = 13;
            this.jumpPower.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(716, 137);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(91, 34);
            this.applyButton.TabIndex = 14;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(703, 252);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(120, 20);
            this.usernameBox.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(682, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "TP to (username)";
            // 
            // tpButton
            // 
            this.tpButton.Location = new System.Drawing.Point(716, 289);
            this.tpButton.Name = "tpButton";
            this.tpButton.Size = new System.Drawing.Size(91, 34);
            this.tpButton.TabIndex = 17;
            this.tpButton.Text = "Go";
            this.tpButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(856, 393);
            this.Controls.Add(this.tpButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.jumpPower);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.walkSpeed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendCommand);
            this.Controls.Add(this.Commands);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.execute2Button);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.injectButton);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Nemesis";
            ((System.ComponentModel.ISupportInitialize)(this.walkSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jumpPower)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button injectButton;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button execute2Button;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label Commands;
        private System.Windows.Forms.Button sendCommand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown walkSpeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown jumpPower;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button tpButton;
    }
}

