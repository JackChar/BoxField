namespace BoxField
{
    partial class HighscoreScreen
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
            this.top10Output = new System.Windows.Forms.Label();
            this.scoreTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // top10Output
            // 
            this.top10Output.BackColor = System.Drawing.Color.Transparent;
            this.top10Output.Font = new System.Drawing.Font("Courier New", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top10Output.ForeColor = System.Drawing.Color.White;
            this.top10Output.Location = new System.Drawing.Point(163, 89);
            this.top10Output.Name = "top10Output";
            this.top10Output.Size = new System.Drawing.Size(582, 365);
            this.top10Output.TabIndex = 2;
            // 
            // scoreTitle
            // 
            this.scoreTitle.BackColor = System.Drawing.Color.Transparent;
            this.scoreTitle.Font = new System.Drawing.Font("OCR A Std", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreTitle.ForeColor = System.Drawing.Color.Red;
            this.scoreTitle.Location = new System.Drawing.Point(158, 6);
            this.scoreTitle.Name = "scoreTitle";
            this.scoreTitle.Size = new System.Drawing.Size(587, 74);
            this.scoreTitle.TabIndex = 3;
            this.scoreTitle.Text = "High Scores";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("OCR A Std", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(208, 457);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 43);
            this.label1.TabIndex = 4;
            this.label1.Text = "Escape to Return";
            // 
            // HighscoreScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scoreTitle);
            this.Controls.Add(this.top10Output);
            this.Name = "HighscoreScreen";
            this.Size = new System.Drawing.Size(900, 500);
            this.Load += new System.EventHandler(this.HighscoreScreen_Load);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.HighscoreScreen_PreviewKeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label top10Output;
        private System.Windows.Forms.Label scoreTitle;
        private System.Windows.Forms.Label label1;
    }
}
