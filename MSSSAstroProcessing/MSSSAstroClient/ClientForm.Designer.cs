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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.colorDialogBox = new System.Windows.Forms.ColorDialog();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.groupBoxPreferences = new System.Windows.Forms.GroupBox();
            this.buttonStyle = new System.Windows.Forms.Button();
            this.comboBoxLang = new System.Windows.Forms.ComboBox();
            this.labelLanguage = new System.Windows.Forms.Label();
            this.labelColours = new System.Windows.Forms.Label();
            this.groupBoxControls = new System.Windows.Forms.GroupBox();
            this.groupBoxHorizon = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numWheelHorizon = new System.Windows.Forms.NumericUpDown();
            this.textBoxHorizon = new System.Windows.Forms.TextBox();
            this.groupBoxKelvin = new System.Windows.Forms.GroupBox();
            this.textBoxKelvin = new System.Windows.Forms.TextBox();
            this.groupBoxStarVelocity = new System.Windows.Forms.GroupBox();
            this.textBoxObserved = new System.Windows.Forms.TextBox();
            this.textBoxRest = new System.Windows.Forms.TextBox();
            this.groupBoxStarDistance = new System.Windows.Forms.GroupBox();
            this.textBoxDistance = new System.Windows.Forms.TextBox();
            this.listViewDisplay = new System.Windows.Forms.ListView();
            this.recordID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStarVelocity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStarDistances = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnKelvin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEventHorizon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.groupBoxPreferences.SuspendLayout();
            this.groupBoxControls.SuspendLayout();
            this.groupBoxHorizon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWheelHorizon)).BeginInit();
            this.groupBoxKelvin.SuspendLayout();
            this.groupBoxStarVelocity.SuspendLayout();
            this.groupBoxStarDistance.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Name = "statusStrip1";
            this.toolTip1.SetToolTip(this.statusStrip1, resources.GetString("statusStrip1.ToolTip"));
            // 
            // statusLabel
            // 
            resources.ApplyResources(this.statusLabel, "statusLabel");
            this.statusLabel.Name = "statusLabel";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // groupBoxPreferences
            // 
            resources.ApplyResources(this.groupBoxPreferences, "groupBoxPreferences");
            this.groupBoxPreferences.Controls.Add(this.buttonStyle);
            this.groupBoxPreferences.Controls.Add(this.comboBoxLang);
            this.groupBoxPreferences.Controls.Add(this.labelLanguage);
            this.groupBoxPreferences.Controls.Add(this.labelColours);
            this.groupBoxPreferences.Name = "groupBoxPreferences";
            this.groupBoxPreferences.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBoxPreferences, resources.GetString("groupBoxPreferences.ToolTip"));
            // 
            // buttonStyle
            // 
            resources.ApplyResources(this.buttonStyle, "buttonStyle");
            this.buttonStyle.Name = "buttonStyle";
            this.toolTip1.SetToolTip(this.buttonStyle, resources.GetString("buttonStyle.ToolTip"));
            this.buttonStyle.UseVisualStyleBackColor = true;
            this.buttonStyle.Click += new System.EventHandler(this.buttonStyle_Click);
            // 
            // comboBoxLang
            // 
            resources.ApplyResources(this.comboBoxLang, "comboBoxLang");
            this.comboBoxLang.FormattingEnabled = true;
            this.comboBoxLang.Items.AddRange(new object[] {
            resources.GetString("comboBoxLang.Items"),
            resources.GetString("comboBoxLang.Items1"),
            resources.GetString("comboBoxLang.Items2")});
            this.comboBoxLang.Name = "comboBoxLang";
            this.toolTip1.SetToolTip(this.comboBoxLang, resources.GetString("comboBoxLang.ToolTip"));
            this.comboBoxLang.SelectedIndexChanged += new System.EventHandler(this.comboBoxLang_TextChanged);
            // 
            // labelLanguage
            // 
            resources.ApplyResources(this.labelLanguage, "labelLanguage");
            this.labelLanguage.Name = "labelLanguage";
            this.toolTip1.SetToolTip(this.labelLanguage, resources.GetString("labelLanguage.ToolTip"));
            // 
            // labelColours
            // 
            resources.ApplyResources(this.labelColours, "labelColours");
            this.labelColours.Name = "labelColours";
            this.toolTip1.SetToolTip(this.labelColours, resources.GetString("labelColours.ToolTip"));
            // 
            // groupBoxControls
            // 
            resources.ApplyResources(this.groupBoxControls, "groupBoxControls");
            this.groupBoxControls.Controls.Add(this.groupBoxHorizon);
            this.groupBoxControls.Controls.Add(this.groupBoxKelvin);
            this.groupBoxControls.Controls.Add(this.groupBoxStarVelocity);
            this.groupBoxControls.Controls.Add(this.groupBoxStarDistance);
            this.groupBoxControls.Name = "groupBoxControls";
            this.groupBoxControls.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBoxControls, resources.GetString("groupBoxControls.ToolTip"));
            // 
            // groupBoxHorizon
            // 
            resources.ApplyResources(this.groupBoxHorizon, "groupBoxHorizon");
            this.groupBoxHorizon.Controls.Add(this.label2);
            this.groupBoxHorizon.Controls.Add(this.label1);
            this.groupBoxHorizon.Controls.Add(this.numWheelHorizon);
            this.groupBoxHorizon.Controls.Add(this.textBoxHorizon);
            this.groupBoxHorizon.Name = "groupBoxHorizon";
            this.groupBoxHorizon.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBoxHorizon, resources.GetString("groupBoxHorizon.ToolTip"));
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.toolTip1.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // numWheelHorizon
            // 
            resources.ApplyResources(this.numWheelHorizon, "numWheelHorizon");
            this.numWheelHorizon.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numWheelHorizon.Minimum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.numWheelHorizon.Name = "numWheelHorizon";
            this.toolTip1.SetToolTip(this.numWheelHorizon, resources.GetString("numWheelHorizon.ToolTip"));
            this.numWheelHorizon.Value = new decimal(new int[] {
            36,
            0,
            0,
            0});
            // 
            // textBoxHorizon
            // 
            resources.ApplyResources(this.textBoxHorizon, "textBoxHorizon");
            this.textBoxHorizon.Name = "textBoxHorizon";
            this.toolTip1.SetToolTip(this.textBoxHorizon, resources.GetString("textBoxHorizon.ToolTip"));
            this.textBoxHorizon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // groupBoxKelvin
            // 
            resources.ApplyResources(this.groupBoxKelvin, "groupBoxKelvin");
            this.groupBoxKelvin.Controls.Add(this.textBoxKelvin);
            this.groupBoxKelvin.Name = "groupBoxKelvin";
            this.groupBoxKelvin.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBoxKelvin, resources.GetString("groupBoxKelvin.ToolTip"));
            // 
            // textBoxKelvin
            // 
            resources.ApplyResources(this.textBoxKelvin, "textBoxKelvin");
            this.textBoxKelvin.Name = "textBoxKelvin";
            this.toolTip1.SetToolTip(this.textBoxKelvin, resources.GetString("textBoxKelvin.ToolTip"));
            this.textBoxKelvin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKelvin_KeyPress);
            // 
            // groupBoxStarVelocity
            // 
            resources.ApplyResources(this.groupBoxStarVelocity, "groupBoxStarVelocity");
            this.groupBoxStarVelocity.Controls.Add(this.textBoxObserved);
            this.groupBoxStarVelocity.Controls.Add(this.textBoxRest);
            this.groupBoxStarVelocity.Name = "groupBoxStarVelocity";
            this.groupBoxStarVelocity.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBoxStarVelocity, resources.GetString("groupBoxStarVelocity.ToolTip"));
            // 
            // textBoxObserved
            // 
            resources.ApplyResources(this.textBoxObserved, "textBoxObserved");
            this.textBoxObserved.Name = "textBoxObserved";
            this.toolTip1.SetToolTip(this.textBoxObserved, resources.GetString("textBoxObserved.ToolTip"));
            this.textBoxObserved.Enter += new System.EventHandler(this.textBox_Enter);
            this.textBoxObserved.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxRest
            // 
            resources.ApplyResources(this.textBoxRest, "textBoxRest");
            this.textBoxRest.Name = "textBoxRest";
            this.toolTip1.SetToolTip(this.textBoxRest, resources.GetString("textBoxRest.ToolTip"));
            this.textBoxRest.Enter += new System.EventHandler(this.textBox_Enter);
            this.textBoxRest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // groupBoxStarDistance
            // 
            resources.ApplyResources(this.groupBoxStarDistance, "groupBoxStarDistance");
            this.groupBoxStarDistance.Controls.Add(this.textBoxDistance);
            this.groupBoxStarDistance.Name = "groupBoxStarDistance";
            this.groupBoxStarDistance.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBoxStarDistance, resources.GetString("groupBoxStarDistance.ToolTip"));
            // 
            // textBoxDistance
            // 
            resources.ApplyResources(this.textBoxDistance, "textBoxDistance");
            this.textBoxDistance.Name = "textBoxDistance";
            this.toolTip1.SetToolTip(this.textBoxDistance, resources.GetString("textBoxDistance.ToolTip"));
            this.textBoxDistance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // listViewDisplay
            // 
            resources.ApplyResources(this.listViewDisplay, "listViewDisplay");
            this.listViewDisplay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.recordID,
            this.columnStarVelocity,
            this.columnStarDistances,
            this.columnKelvin,
            this.columnEventHorizon});
            this.listViewDisplay.HideSelection = false;
            this.listViewDisplay.Name = "listViewDisplay";
            this.toolTip1.SetToolTip(this.listViewDisplay, resources.GetString("listViewDisplay.ToolTip"));
            this.listViewDisplay.UseCompatibleStateImageBehavior = false;
            this.listViewDisplay.View = System.Windows.Forms.View.Details;
            // 
            // recordID
            // 
            resources.ApplyResources(this.recordID, "recordID");
            // 
            // columnStarVelocity
            // 
            resources.ApplyResources(this.columnStarVelocity, "columnStarVelocity");
            // 
            // columnStarDistances
            // 
            resources.ApplyResources(this.columnStarDistances, "columnStarDistances");
            // 
            // columnKelvin
            // 
            resources.ApplyResources(this.columnKelvin, "columnKelvin");
            // 
            // columnEventHorizon
            // 
            resources.ApplyResources(this.columnEventHorizon, "columnEventHorizon");
            // 
            // buttonCalculate
            // 
            resources.ApplyResources(this.buttonCalculate, "buttonCalculate");
            this.buttonCalculate.Name = "buttonCalculate";
            this.toolTip1.SetToolTip(this.buttonCalculate, resources.GetString("buttonCalculate.ToolTip"));
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // ClientForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxPreferences);
            this.Controls.Add(this.groupBoxControls);
            this.Controls.Add(this.listViewDisplay);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.statusStrip1);
            this.Name = "ClientForm";
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.groupBoxPreferences.ResumeLayout(false);
            this.groupBoxPreferences.PerformLayout();
            this.groupBoxControls.ResumeLayout(false);
            this.groupBoxHorizon.ResumeLayout(false);
            this.groupBoxHorizon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWheelHorizon)).EndInit();
            this.groupBoxKelvin.ResumeLayout(false);
            this.groupBoxKelvin.PerformLayout();
            this.groupBoxStarVelocity.ResumeLayout(false);
            this.groupBoxStarVelocity.PerformLayout();
            this.groupBoxStarDistance.ResumeLayout(false);
            this.groupBoxStarDistance.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ColorDialog colorDialogBox;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.GroupBox groupBoxPreferences;
        private System.Windows.Forms.Button buttonStyle;
        private System.Windows.Forms.ComboBox comboBoxLang;
        private System.Windows.Forms.Label labelLanguage;
        private System.Windows.Forms.Label labelColours;
        private System.Windows.Forms.GroupBox groupBoxControls;
        private System.Windows.Forms.GroupBox groupBoxHorizon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numWheelHorizon;
        private System.Windows.Forms.TextBox textBoxHorizon;
        private System.Windows.Forms.GroupBox groupBoxKelvin;
        private System.Windows.Forms.TextBox textBoxKelvin;
        private System.Windows.Forms.GroupBox groupBoxStarVelocity;
        private System.Windows.Forms.TextBox textBoxObserved;
        private System.Windows.Forms.TextBox textBoxRest;
        private System.Windows.Forms.GroupBox groupBoxStarDistance;
        private System.Windows.Forms.TextBox textBoxDistance;
        private System.Windows.Forms.ListView listViewDisplay;
        private System.Windows.Forms.ColumnHeader recordID;
        private System.Windows.Forms.ColumnHeader columnStarVelocity;
        private System.Windows.Forms.ColumnHeader columnStarDistances;
        private System.Windows.Forms.ColumnHeader columnKelvin;
        private System.Windows.Forms.ColumnHeader columnEventHorizon;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

