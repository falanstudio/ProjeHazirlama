namespace Proje
{
    partial class MainForm
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
            panelMain = new Panel();
            panelNav = new Panel();
            buttonSettings = new Button();
            buttonApps = new Button();
            buttonMacros = new Button();
            buttonSongs = new Button();
            panel3 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            panelNav.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(18, 26, 54);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(132, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(746, 582);
            panelMain.TabIndex = 5;
            // 
            // panelNav
            // 
            panelNav.BackColor = Color.FromArgb(20, 6, 62);
            panelNav.Controls.Add(buttonSettings);
            panelNav.Controls.Add(buttonApps);
            panelNav.Controls.Add(buttonMacros);
            panelNav.Controls.Add(buttonSongs);
            panelNav.Controls.Add(panel3);
            panelNav.Controls.Add(panel2);
            panelNav.Dock = DockStyle.Left;
            panelNav.Location = new Point(0, 0);
            panelNav.Margin = new Padding(4);
            panelNav.Name = "panelNav";
            panelNav.Size = new Size(132, 582);
            panelNav.TabIndex = 3;
            // 
            // buttonSettings
            // 
            buttonSettings.Dock = DockStyle.Top;
            buttonSettings.FlatAppearance.BorderSize = 0;
            buttonSettings.FlatStyle = FlatStyle.Flat;
            buttonSettings.Font = new Font("Calibri", 12F, FontStyle.Bold);
            buttonSettings.ForeColor = Color.Transparent;
            buttonSettings.Location = new Point(0, 278);
            buttonSettings.Margin = new Padding(4);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(132, 46);
            buttonSettings.TabIndex = 10;
            buttonSettings.Tag = "panelButton";
            buttonSettings.Text = "Ayarlar";
            buttonSettings.UseVisualStyleBackColor = true;
            // 
            // buttonApps
            // 
            buttonApps.Dock = DockStyle.Top;
            buttonApps.FlatAppearance.BorderSize = 0;
            buttonApps.FlatStyle = FlatStyle.Flat;
            buttonApps.Font = new Font("Calibri", 12F, FontStyle.Bold);
            buttonApps.ForeColor = Color.Transparent;
            buttonApps.Location = new Point(0, 232);
            buttonApps.Margin = new Padding(4);
            buttonApps.Name = "buttonApps";
            buttonApps.Size = new Size(132, 46);
            buttonApps.TabIndex = 7;
            buttonApps.Tag = "panelButton";
            buttonApps.Text = "Uygulamalar";
            buttonApps.UseVisualStyleBackColor = true;
            // 
            // buttonMacros
            // 
            buttonMacros.Dock = DockStyle.Top;
            buttonMacros.FlatAppearance.BorderSize = 0;
            buttonMacros.FlatStyle = FlatStyle.Flat;
            buttonMacros.Font = new Font("Calibri", 12F, FontStyle.Bold);
            buttonMacros.ForeColor = Color.Transparent;
            buttonMacros.Location = new Point(0, 186);
            buttonMacros.Margin = new Padding(4);
            buttonMacros.Name = "buttonMacros";
            buttonMacros.Size = new Size(132, 46);
            buttonMacros.TabIndex = 8;
            buttonMacros.Tag = "panelButton";
            buttonMacros.Text = "Makrolar";
            buttonMacros.UseVisualStyleBackColor = true;
            // 
            // buttonSongs
            // 
            buttonSongs.Dock = DockStyle.Top;
            buttonSongs.FlatAppearance.BorderSize = 0;
            buttonSongs.FlatStyle = FlatStyle.Flat;
            buttonSongs.Font = new Font("Calibri", 12F, FontStyle.Bold);
            buttonSongs.ForeColor = Color.Transparent;
            buttonSongs.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSongs.Location = new Point(0, 140);
            buttonSongs.Margin = new Padding(4);
            buttonSongs.Name = "buttonSongs";
            buttonSongs.Size = new Size(132, 46);
            buttonSongs.TabIndex = 9;
            buttonSongs.Tag = "panelButton";
            buttonSongs.Text = "Sesler";
            buttonSongs.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 470);
            panel3.Name = "panel3";
            panel3.Size = new Size(132, 112);
            panel3.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(132, 140);
            panel2.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(132, 0);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(6, 582);
            panel4.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(878, 582);
            Controls.Add(panel4);
            Controls.Add(panelMain);
            Controls.Add(panelNav);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            panelNav.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelMain;
        private Panel panelNav;
        private Button buttonSettings;
        private Button buttonApps;
        private Button buttonMacros;
        private Button buttonSongs;
        private Panel panel3;
        private Panel panel2;
        private Panel panel4;
        private Button button1;
    }
}
