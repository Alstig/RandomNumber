namespace RandomNumber
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
            this.labelNumber = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.setUpdateIntervalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secondToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secondsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secondsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.secondsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.secondsToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.secondsToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.secondsToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.secondsToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.secondsToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateNumberOnClickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectBackgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectTextColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNumber
            // 
            this.labelNumber.ContextMenuStrip = this.contextMenuStrip1;
            this.labelNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumber.ForeColor = System.Drawing.Color.White;
            this.labelNumber.Location = new System.Drawing.Point(0, 0);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(78, 49);
            this.labelNumber.TabIndex = 0;
            this.labelNumber.Text = "0";
            this.labelNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNumber.Click += new System.EventHandler(this.labelNumber_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setUpdateIntervalToolStripMenuItem,
            this.selectBackgroundColorToolStripMenuItem,
            this.selectTextColorToolStripMenuItem,
            this.updateNumberOnClickToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(203, 114);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // setUpdateIntervalToolStripMenuItem
            // 
            this.setUpdateIntervalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.secondToolStripMenuItem,
            this.secondsToolStripMenuItem,
            this.secondsToolStripMenuItem1,
            this.secondsToolStripMenuItem2,
            this.secondsToolStripMenuItem3,
            this.secondsToolStripMenuItem4,
            this.secondsToolStripMenuItem5,
            this.secondsToolStripMenuItem6,
            this.secondsToolStripMenuItem7});
            this.setUpdateIntervalToolStripMenuItem.Image = global::RandomNumber.Properties.Resources.clock_select;
            this.setUpdateIntervalToolStripMenuItem.Name = "setUpdateIntervalToolStripMenuItem";
            this.setUpdateIntervalToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.setUpdateIntervalToolStripMenuItem.Text = "Set update interval";
            // 
            // secondToolStripMenuItem
            // 
            this.secondToolStripMenuItem.Name = "secondToolStripMenuItem";
            this.secondToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.secondToolStripMenuItem.Tag = "1000";
            this.secondToolStripMenuItem.Text = "1 second";
            this.secondToolStripMenuItem.Click += new System.EventHandler(this.secondToolStripMenuItem_Click);
            // 
            // secondsToolStripMenuItem
            // 
            this.secondsToolStripMenuItem.Name = "secondsToolStripMenuItem";
            this.secondsToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.secondsToolStripMenuItem.Tag = "1500";
            this.secondsToolStripMenuItem.Text = "1.5 seconds";
            this.secondsToolStripMenuItem.Click += new System.EventHandler(this.secondToolStripMenuItem_Click);
            // 
            // secondsToolStripMenuItem1
            // 
            this.secondsToolStripMenuItem1.Name = "secondsToolStripMenuItem1";
            this.secondsToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.secondsToolStripMenuItem1.Tag = "2000";
            this.secondsToolStripMenuItem1.Text = "2 seconds";
            this.secondsToolStripMenuItem1.Click += new System.EventHandler(this.secondToolStripMenuItem_Click);
            // 
            // secondsToolStripMenuItem2
            // 
            this.secondsToolStripMenuItem2.Name = "secondsToolStripMenuItem2";
            this.secondsToolStripMenuItem2.Size = new System.Drawing.Size(135, 22);
            this.secondsToolStripMenuItem2.Tag = "2500";
            this.secondsToolStripMenuItem2.Text = "2.5 seconds";
            this.secondsToolStripMenuItem2.Click += new System.EventHandler(this.secondToolStripMenuItem_Click);
            // 
            // secondsToolStripMenuItem3
            // 
            this.secondsToolStripMenuItem3.Name = "secondsToolStripMenuItem3";
            this.secondsToolStripMenuItem3.Size = new System.Drawing.Size(135, 22);
            this.secondsToolStripMenuItem3.Tag = "3000";
            this.secondsToolStripMenuItem3.Text = "3 seconds";
            this.secondsToolStripMenuItem3.Click += new System.EventHandler(this.secondToolStripMenuItem_Click);
            // 
            // secondsToolStripMenuItem4
            // 
            this.secondsToolStripMenuItem4.Name = "secondsToolStripMenuItem4";
            this.secondsToolStripMenuItem4.Size = new System.Drawing.Size(135, 22);
            this.secondsToolStripMenuItem4.Tag = "3500";
            this.secondsToolStripMenuItem4.Text = "3.5 seconds";
            this.secondsToolStripMenuItem4.Click += new System.EventHandler(this.secondToolStripMenuItem_Click);
            // 
            // secondsToolStripMenuItem5
            // 
            this.secondsToolStripMenuItem5.Name = "secondsToolStripMenuItem5";
            this.secondsToolStripMenuItem5.Size = new System.Drawing.Size(135, 22);
            this.secondsToolStripMenuItem5.Tag = "4000";
            this.secondsToolStripMenuItem5.Text = "4 seconds";
            this.secondsToolStripMenuItem5.Click += new System.EventHandler(this.secondToolStripMenuItem_Click);
            // 
            // secondsToolStripMenuItem6
            // 
            this.secondsToolStripMenuItem6.Name = "secondsToolStripMenuItem6";
            this.secondsToolStripMenuItem6.Size = new System.Drawing.Size(135, 22);
            this.secondsToolStripMenuItem6.Tag = "4500";
            this.secondsToolStripMenuItem6.Text = "4.5 seconds";
            this.secondsToolStripMenuItem6.Click += new System.EventHandler(this.secondToolStripMenuItem_Click);
            // 
            // secondsToolStripMenuItem7
            // 
            this.secondsToolStripMenuItem7.Name = "secondsToolStripMenuItem7";
            this.secondsToolStripMenuItem7.Size = new System.Drawing.Size(135, 22);
            this.secondsToolStripMenuItem7.Tag = "5000";
            this.secondsToolStripMenuItem7.Text = "5 seconds";
            this.secondsToolStripMenuItem7.Click += new System.EventHandler(this.secondToolStripMenuItem_Click);
            // 
            // updateNumberOnClickToolStripMenuItem
            // 
            this.updateNumberOnClickToolStripMenuItem.Name = "updateNumberOnClickToolStripMenuItem";
            this.updateNumberOnClickToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.updateNumberOnClickToolStripMenuItem.Text = "Update number on click";
            this.updateNumberOnClickToolStripMenuItem.Click += new System.EventHandler(this.updateNumberOnClickToolStripMenuItem_Click);
            // 
            // selectBackgroundColorToolStripMenuItem
            // 
            this.selectBackgroundColorToolStripMenuItem.Image = global::RandomNumber.Properties.Resources.paint_can_color;
            this.selectBackgroundColorToolStripMenuItem.Name = "selectBackgroundColorToolStripMenuItem";
            this.selectBackgroundColorToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.selectBackgroundColorToolStripMenuItem.Text = "Select background color";
            this.selectBackgroundColorToolStripMenuItem.Click += new System.EventHandler(this.selectBackgroundColorToolStripMenuItem_Click);
            // 
            // selectTextColorToolStripMenuItem
            // 
            this.selectTextColorToolStripMenuItem.Image = global::RandomNumber.Properties.Resources.edit_color;
            this.selectTextColorToolStripMenuItem.Name = "selectTextColorToolStripMenuItem";
            this.selectTextColorToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.selectTextColorToolStripMenuItem.Text = "Select text color";
            this.selectTextColorToolStripMenuItem.Click += new System.EventHandler(this.selectTextColorToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(78, 49);
            this.Controls.Add(this.labelNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Random";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setUpdateIntervalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secondToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secondsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secondsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem secondsToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem secondsToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem secondsToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem secondsToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem secondsToolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem secondsToolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem updateNumberOnClickToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectBackgroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectTextColorToolStripMenuItem;
    }
}

