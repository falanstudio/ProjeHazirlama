namespace Proje
{
    partial class Sesler
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
            panel1 = new Panel();
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ses1 = new Ses();
            ses2 = new Ses();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(746, 123);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(503, 123);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(243, 459);
            panel2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(ses1);
            flowLayoutPanel1.Controls.Add(ses2);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 123);
            flowLayoutPanel1.Margin = new Padding(4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(503, 459);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // ses1
            // 
            ses1.BorderStyle = BorderStyle.FixedSingle;
            ses1.Button = null;
            ses1.Font = new Font("Segoe UI", 12F);
            ses1.Icon = null;
            ses1.Location = new Point(4, 4);
            ses1.Margin = new Padding(4);
            ses1.Name = "ses1";
            ses1.Size = new Size(85, 117);
            ses1.TabIndex = 0;
            // 
            // ses2
            // 
            ses2.BorderStyle = BorderStyle.FixedSingle;
            ses2.Button = null;
            ses2.Font = new Font("Segoe UI", 12F);
            ses2.Icon = null;
            ses2.Location = new Point(97, 4);
            ses2.Margin = new Padding(4);
            ses2.Name = "ses2";
            ses2.Size = new Size(85, 117);
            ses2.TabIndex = 1;
            // 
            // Sesler
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 582);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            MaximumSize = new Size(746, 582);
            MinimumSize = new Size(746, 582);
            Name = "Sesler";
            Text = "Sesler";
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Ses ses1;
        private Ses ses2;
    }
}