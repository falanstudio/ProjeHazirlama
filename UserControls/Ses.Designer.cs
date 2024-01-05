namespace Proje
{
    partial class Ses
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            roundButton1 = new Custom_Controls.RoundButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(33, 112);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // roundButton1
            // 
            roundButton1.FlatAppearance.BorderColor = Color.Lime;
            roundButton1.FlatAppearance.BorderSize = 2;
            roundButton1.FlatAppearance.MouseDownBackColor = Color.Lime;
            roundButton1.FlatAppearance.MouseOverBackColor = Color.Lime;
            roundButton1.FlatStyle = FlatStyle.System;
            roundButton1.HeightEllipse = 20;
            roundButton1.Location = new Point(7, 7);
            roundButton1.Name = "roundButton1";
            roundButton1.Size = new Size(98, 102);
            roundButton1.TabIndex = 2;
            roundButton1.UseVisualStyleBackColor = true;
            roundButton1.WidthEllipse = 20;
            // 
            // Ses
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 26, 54);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(roundButton1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Ses";
            Padding = new Padding(4);
            Size = new Size(112, 137);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Custom_Controls.RoundButton roundButton1;
    }
}
