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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.colorDialogBox = new System.Windows.Forms.ColorDialog();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonStyle = new System.Windows.Forms.Button();
            this.comboBoxLang = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numWheelHorizon = new System.Windows.Forms.NumericUpDown();
            this.textBoxHorizon = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBoxKelvin = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxObserved = new System.Windows.Forms.TextBox();
            this.textBoxRest = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxDistance = new System.Windows.Forms.TextBox();
            this.listViewDisplay = new System.Windows.Forms.ListView();
            this.recordID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStarVelocity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStarDistances = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnKelvin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEventHorizon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBoxInput.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWheelHorizon)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 196);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(654, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonStyle);
            this.groupBox2.Controls.Add(this.comboBoxLang);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(259, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 46);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GUI Preferences";
            // 
            // buttonStyle
            // 
            this.buttonStyle.Location = new System.Drawing.Point(57, 16);
            this.buttonStyle.Name = "buttonStyle";
            this.buttonStyle.Size = new System.Drawing.Size(100, 23);
            this.buttonStyle.TabIndex = 4;
            this.buttonStyle.Text = "Change Style";
            this.buttonStyle.UseVisualStyleBackColor = true;
            this.buttonStyle.Click += new System.EventHandler(this.buttonStyle_Click);
            // 
            // comboBoxLang
            // 
            this.comboBoxLang.FormattingEnabled = true;
            this.comboBoxLang.Location = new System.Drawing.Point(277, 16);
            this.comboBoxLang.Name = "comboBoxLang";
            this.comboBoxLang.Size = new System.Drawing.Size(100, 21);
            this.comboBoxLang.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Language: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Colours:";
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.groupBox6);
            this.groupBoxInput.Controls.Add(this.groupBox5);
            this.groupBoxInput.Controls.Add(this.groupBox3);
            this.groupBoxInput.Controls.Add(this.groupBox4);
            this.groupBoxInput.Location = new System.Drawing.Point(12, 7);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(241, 150);
            this.groupBoxInput.TabIndex = 11;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Calculation Input";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.numWheelHorizon);
            this.groupBox6.Controls.Add(this.textBoxHorizon);
            this.groupBox6.Location = new System.Drawing.Point(6, 70);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(110, 71);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Event Horizon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(39, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "* 10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(57, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "^";
            // 
            // numWheelHorizon
            // 
            this.numWheelHorizon.Location = new System.Drawing.Point(72, 19);
            this.numWheelHorizon.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numWheelHorizon.Name = "numWheelHorizon";
            this.numWheelHorizon.Size = new System.Drawing.Size(33, 20);
            this.numWheelHorizon.TabIndex = 6;
            this.numWheelHorizon.Value = new decimal(new int[] {
            36,
            0,
            0,
            0});
            // 
            // textBoxHorizon
            // 
            this.textBoxHorizon.Location = new System.Drawing.Point(5, 44);
            this.textBoxHorizon.Name = "textBoxHorizon";
            this.textBoxHorizon.Size = new System.Drawing.Size(34, 20);
            this.textBoxHorizon.TabIndex = 5;
            this.textBoxHorizon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxKelvin);
            this.groupBox5.Location = new System.Drawing.Point(123, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(110, 45);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Celcius to Kelvin";
            // 
            // textBoxKelvin
            // 
            this.textBoxKelvin.Location = new System.Drawing.Point(5, 18);
            this.textBoxKelvin.Name = "textBoxKelvin";
            this.textBoxKelvin.Size = new System.Drawing.Size(100, 20);
            this.textBoxKelvin.TabIndex = 5;
            this.textBoxKelvin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKelvin_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxObserved);
            this.groupBox3.Controls.Add(this.textBoxRest);
            this.groupBox3.Location = new System.Drawing.Point(123, 67);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(110, 74);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Star Velocity";
            // 
            // textBoxObserved
            // 
            this.textBoxObserved.Location = new System.Drawing.Point(5, 17);
            this.textBoxObserved.Name = "textBoxObserved";
            this.textBoxObserved.Size = new System.Drawing.Size(100, 20);
            this.textBoxObserved.TabIndex = 1;
            this.textBoxObserved.Text = "Observed:";
            this.textBoxObserved.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxRest
            // 
            this.textBoxRest.Location = new System.Drawing.Point(5, 45);
            this.textBoxRest.Name = "textBoxRest";
            this.textBoxRest.Size = new System.Drawing.Size(100, 20);
            this.textBoxRest.TabIndex = 4;
            this.textBoxRest.Text = "Rest:";
            this.textBoxRest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxDistance);
            this.groupBox4.Location = new System.Drawing.Point(7, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(110, 45);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Star Distance";
            // 
            // textBoxDistance
            // 
            this.textBoxDistance.Location = new System.Drawing.Point(5, 17);
            this.textBoxDistance.Name = "textBoxDistance";
            this.textBoxDistance.Size = new System.Drawing.Size(100, 20);
            this.textBoxDistance.TabIndex = 5;
            this.textBoxDistance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // listViewDisplay
            // 
            this.listViewDisplay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.recordID,
            this.columnStarVelocity,
            this.columnStarDistances,
            this.columnKelvin,
            this.columnEventHorizon});
            this.listViewDisplay.HideSelection = false;
            this.listViewDisplay.Location = new System.Drawing.Point(259, 12);
            this.listViewDisplay.Name = "listViewDisplay";
            this.listViewDisplay.Size = new System.Drawing.Size(383, 129);
            this.listViewDisplay.TabIndex = 12;
            this.listViewDisplay.UseCompatibleStateImageBehavior = false;
            this.listViewDisplay.View = System.Windows.Forms.View.Details;
            // 
            // recordID
            // 
            this.recordID.Text = "ID";
            this.recordID.Width = 28;
            // 
            // columnStarVelocity
            // 
            this.columnStarVelocity.Text = "Star Velocity";
            this.columnStarVelocity.Width = 85;
            // 
            // columnStarDistances
            // 
            this.columnStarDistances.Text = "Star Distance";
            this.columnStarDistances.Width = 94;
            // 
            // columnKelvin
            // 
            this.columnKelvin.Text = "Kelvin";
            this.columnKelvin.Width = 65;
            // 
            // columnEventHorizon
            // 
            this.columnEventHorizon.Text = "Event Horizon";
            this.columnEventHorizon.Width = 103;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(12, 161);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(241, 28);
            this.buttonCalculate.TabIndex = 10;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 218);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxInput);
            this.Controls.Add(this.listViewDisplay);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.statusStrip1);
            this.Name = "ClientForm";
            this.Text = "Malin Space Science Systems Astro Client";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxInput.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWheelHorizon)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ColorDialog colorDialogBox;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonStyle;
        private System.Windows.Forms.ComboBox comboBoxLang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numWheelHorizon;
        private System.Windows.Forms.TextBox textBoxHorizon;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBoxKelvin;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxObserved;
        private System.Windows.Forms.TextBox textBoxRest;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxDistance;
        private System.Windows.Forms.ListView listViewDisplay;
        private System.Windows.Forms.ColumnHeader recordID;
        private System.Windows.Forms.ColumnHeader columnStarVelocity;
        private System.Windows.Forms.ColumnHeader columnStarDistances;
        private System.Windows.Forms.ColumnHeader columnKelvin;
        private System.Windows.Forms.ColumnHeader columnEventHorizon;
        private System.Windows.Forms.Button buttonCalculate;
    }
}

