namespace MSSSAstroClient
{
    partial class ClientForm
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
            this.textBoxDisplay = new System.Windows.Forms.TextBox();
            this.textBoxObserved = new System.Windows.Forms.TextBox();
            this.textBoxRest = new System.Windows.Forms.TextBox();
            this.buttonStarDistance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxDisplay
            // 
            this.textBoxDisplay.Location = new System.Drawing.Point(315, 100);
            this.textBoxDisplay.Name = "textBoxDisplay";
            this.textBoxDisplay.Size = new System.Drawing.Size(158, 20);
            this.textBoxDisplay.TabIndex = 0;
            // 
            // textBoxObserved
            // 
            this.textBoxObserved.Location = new System.Drawing.Point(55, 100);
            this.textBoxObserved.Name = "textBoxObserved";
            this.textBoxObserved.Size = new System.Drawing.Size(100, 20);
            this.textBoxObserved.TabIndex = 1;
            // 
            // textBoxRest
            // 
            this.textBoxRest.Location = new System.Drawing.Point(183, 100);
            this.textBoxRest.Name = "textBoxRest";
            this.textBoxRest.Size = new System.Drawing.Size(100, 20);
            this.textBoxRest.TabIndex = 2;
            // 
            // buttonStarDistance
            // 
            this.buttonStarDistance.Location = new System.Drawing.Point(55, 66);
            this.buttonStarDistance.Name = "buttonStarDistance";
            this.buttonStarDistance.Size = new System.Drawing.Size(208, 23);
            this.buttonStarDistance.TabIndex = 3;
            this.buttonStarDistance.Text = "Calculate Star Distance";
            this.buttonStarDistance.UseVisualStyleBackColor = true;
            this.buttonStarDistance.Click += new System.EventHandler(this.buttonStarDistance_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonStarDistance);
            this.Controls.Add(this.textBoxRest);
            this.Controls.Add(this.textBoxObserved);
            this.Controls.Add(this.textBoxDisplay);
            this.Name = "ClientForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDisplay;
        private System.Windows.Forms.TextBox textBoxObserved;
        private System.Windows.Forms.TextBox textBoxRest;
        private System.Windows.Forms.Button buttonStarDistance;
    }
}

