namespace Vypinac
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.shutDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alarmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.AktualnyCas);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Kristen ITC", 24.75F);
            this.label4.Location = new System.Drawing.Point(281, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 45);
            this.label4.TabIndex = 9;
            this.label4.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Kristen ITC", 24.75F);
            this.label5.Location = new System.Drawing.Point(173, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 45);
            this.label5.TabIndex = 8;
            this.label5.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Kristen ITC", 24.75F);
            this.label6.Location = new System.Drawing.Point(64, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 45);
            this.label6.TabIndex = 7;
            this.label6.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Kristen ITC", 24.75F);
            this.label7.Location = new System.Drawing.Point(244, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 45);
            this.label7.TabIndex = 10;
            this.label7.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Kristen ITC", 24.75F);
            this.label8.Location = new System.Drawing.Point(136, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 45);
            this.label8.TabIndex = 11;
            this.label8.Text = ":";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shutDownToolStripMenuItem,
            this.restartToolStripMenuItem,
            this.alarmToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(437, 25);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // shutDownToolStripMenuItem
            // 
            this.shutDownToolStripMenuItem.Font = new System.Drawing.Font("Kristen ITC", 9F);
            this.shutDownToolStripMenuItem.Name = "shutDownToolStripMenuItem";
            this.shutDownToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.shutDownToolStripMenuItem.Text = "ShutDown";
            this.shutDownToolStripMenuItem.Click += new System.EventHandler(this.shutDownToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Font = new System.Drawing.Font("Kristen ITC", 9F);
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(65, 21);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // alarmToolStripMenuItem
            // 
            this.alarmToolStripMenuItem.Font = new System.Drawing.Font("Kristen ITC", 9F);
            this.alarmToolStripMenuItem.Name = "alarmToolStripMenuItem";
            this.alarmToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.alarmToolStripMenuItem.Text = "Alarm";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Kristen ITC", 9F);
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.label1.Location = new System.Drawing.Point(335, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.label2.Location = new System.Drawing.Point(383, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.label3.Location = new System.Drawing.Point(401, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.label9.Location = new System.Drawing.Point(353, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.label10.Location = new System.Drawing.Point(305, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 18);
            this.label10.TabIndex = 15;
            this.label10.Text = "00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(210, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Remaining time";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(12, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Hide";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "DogAlarm";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 198);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Kristen ITC", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "DogAlarm 0.3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem shutDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alarmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

