using System;
using System.Drawing;
using System.Windows.Forms;

namespace RandomNumber
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void ApplySettings()
        {
            BackColor = Settings.BackgroundColor;
            labelNumber.ForeColor = Settings.TextColor;
            timer1.Interval = Settings.Interval;
        }

        private void UpdateNumber() => labelNumber.Text = random.Next(1, 101).ToString();

        private void SetSelectedIntervalItem()
        {
            updateNumberOnClickToolStripMenuItem.Checked = Settings.UpdateNumberOnClick;

            foreach (ToolStripMenuItem menuItem in setUpdateIntervalToolStripMenuItem.DropDownItems)
                menuItem.Checked = Convert.ToInt32(menuItem.Tag) == Settings.Interval;
        }

        private Color SelectColor(Color currentColor)
        {
            using (var colorDialog = new ColorDialog())
            {
                colorDialog.AllowFullOpen = true;
                colorDialog.Color = currentColor;

                if (colorDialog.ShowDialog() == DialogResult.OK)
                    currentColor = colorDialog.Color;

                return currentColor;
            }
        }

        #region ContextMenu events

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SetSelectedIntervalItem();
        }

        private void secondToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var menuItem = (ToolStripMenuItem)sender;
            int interval = Convert.ToInt32(menuItem.Tag);
            Settings.Interval = interval;

            ApplySettings();
        }

        private void selectBackgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.BackgroundColor = SelectColor(Settings.BackgroundColor);

            ApplySettings();
        }

        private void selectTextColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.TextColor = SelectColor(Settings.TextColor);

            ApplySettings();
        }

        private void updateNumberOnClickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.UpdateNumberOnClick = !Settings.UpdateNumberOnClick;
        }

        #endregion

        #region Other events

        private void Form1_Load(object sender, EventArgs e)
        {
            ApplySettings();
            UpdateNumber();

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateNumber();
        }

        private void labelNumber_Click(object sender, EventArgs e)
        {
            if (Settings.UpdateNumberOnClick)
            {
                UpdateNumber();

                // Restart timer to reset interval
                timer1.Stop();
                timer1.Start();
            }
        }

        #endregion
    }
}
