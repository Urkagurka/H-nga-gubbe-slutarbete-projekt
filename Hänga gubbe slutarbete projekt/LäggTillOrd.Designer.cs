namespace Hänga_gubbe_slutarbete_projekt
{
    partial class LäggTillOrd
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
            buttonLägtillord = new Button();
            textBoxNyttOrd = new TextBox();
            SuspendLayout();
            // 
            // buttonLägtillord
            // 
            buttonLägtillord.Location = new Point(12, 41);
            buttonLägtillord.Name = "buttonLägtillord";
            buttonLägtillord.Size = new Size(488, 81);
            buttonLägtillord.TabIndex = 0;
            buttonLägtillord.Text = "Lägg Till Ordet";
            buttonLägtillord.UseVisualStyleBackColor = true;
            buttonLägtillord.Click += buttonLägtillord_Click;
            // 
            // textBoxNyttOrd
            // 
            textBoxNyttOrd.Location = new Point(12, 12);
            textBoxNyttOrd.Name = "textBoxNyttOrd";
            textBoxNyttOrd.Size = new Size(488, 23);
            textBoxNyttOrd.TabIndex = 1;
            // 
            // LäggTillOrd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 139);
            Controls.Add(textBoxNyttOrd);
            Controls.Add(buttonLägtillord);
            Name = "LäggTillOrd";
            Text = "LäggTillOrd";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLägtillord;
        private TextBox textBoxNyttOrd;
    }
}