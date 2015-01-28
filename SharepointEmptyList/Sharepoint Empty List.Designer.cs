namespace SharepointEmptyList
{
    partial class SharepointForm
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
        private void InitializeComponent( )
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SharepointForm));
            this.labelURL = new System.Windows.Forms.Label();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.labelListName = new System.Windows.Forms.Label();
            this.textBoxListName = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.labelSharepointItemsCount = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonGetCount = new System.Windows.Forms.Button();
            this.buttonURLLocalhost = new System.Windows.Forms.Button();
            this.labelDaysToDelete = new System.Windows.Forms.Label();
            this.numericUpDownDaysToDelete = new System.Windows.Forms.NumericUpDown();
            this.statusStrip1.SuspendLayout();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDaysToDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // labelURL
            // 
            this.labelURL.AutoSize = true;
            this.labelURL.Location = new System.Drawing.Point(12, 15);
            this.labelURL.Name = "labelURL";
            this.labelURL.Size = new System.Drawing.Size(32, 13);
            this.labelURL.TabIndex = 0;
            this.labelURL.Text = "URL:";
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(75, 12);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(300, 20);
            this.textBoxURL.TabIndex = 1;
            // 
            // labelListName
            // 
            this.labelListName.AutoSize = true;
            this.labelListName.Location = new System.Drawing.Point(12, 41);
            this.labelListName.Name = "labelListName";
            this.labelListName.Size = new System.Drawing.Size(57, 13);
            this.labelListName.TabIndex = 3;
            this.labelListName.Text = "List Name:";
            // 
            // textBoxListName
            // 
            this.textBoxListName.Location = new System.Drawing.Point(75, 38);
            this.textBoxListName.Name = "textBoxListName";
            this.textBoxListName.Size = new System.Drawing.Size(300, 20);
            this.textBoxListName.TabIndex = 4;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 150);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(381, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(112, 17);
            this.toolStripStatusLabel.Text = "toolStripStatusLabel";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.labelSharepointItemsCount);
            this.groupBox.Location = new System.Drawing.Point(96, 90);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(119, 52);
            this.groupBox.TabIndex = 6;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Number of Items";
            // 
            // labelSharepointItemsCount
            // 
            this.labelSharepointItemsCount.AutoSize = true;
            this.labelSharepointItemsCount.Location = new System.Drawing.Point(6, 29);
            this.labelSharepointItemsCount.Name = "labelSharepointItemsCount";
            this.labelSharepointItemsCount.Size = new System.Drawing.Size(84, 13);
            this.labelSharepointItemsCount.TabIndex = 7;
            this.labelSharepointItemsCount.Text = "Number of Items";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(221, 119);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(154, 23);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonGetCount
            // 
            this.buttonGetCount.Location = new System.Drawing.Point(221, 90);
            this.buttonGetCount.Name = "buttonGetCount";
            this.buttonGetCount.Size = new System.Drawing.Size(154, 23);
            this.buttonGetCount.TabIndex = 8;
            this.buttonGetCount.Text = "Get Count";
            this.buttonGetCount.UseVisualStyleBackColor = true;
            this.buttonGetCount.Click += new System.EventHandler(this.buttonGetCount_Click);
            // 
            // buttonURLLocalhost
            // 
            this.buttonURLLocalhost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonURLLocalhost.Location = new System.Drawing.Point(12, 96);
            this.buttonURLLocalhost.Name = "buttonURLLocalhost";
            this.buttonURLLocalhost.Size = new System.Drawing.Size(78, 44);
            this.buttonURLLocalhost.TabIndex = 9;
            this.buttonURLLocalhost.Text = "Localhost URL";
            this.buttonURLLocalhost.UseVisualStyleBackColor = true;
            this.buttonURLLocalhost.Click += new System.EventHandler(this.buttonURLLocalhost_Click);
            // 
            // labelDaysToDelete
            // 
            this.labelDaysToDelete.AutoSize = true;
            this.labelDaysToDelete.Location = new System.Drawing.Point(12, 66);
            this.labelDaysToDelete.Name = "labelDaysToDelete";
            this.labelDaysToDelete.Size = new System.Drawing.Size(302, 13);
            this.labelDaysToDelete.TabIndex = 10;
            this.labelDaysToDelete.Text = "Days to keep (any case older than this value, will be removed):";
            // 
            // numericUpDownDaysToDelete
            // 
            this.numericUpDownDaysToDelete.Location = new System.Drawing.Point(320, 64);
            this.numericUpDownDaysToDelete.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownDaysToDelete.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDaysToDelete.Name = "numericUpDownDaysToDelete";
            this.numericUpDownDaysToDelete.Size = new System.Drawing.Size(55, 20);
            this.numericUpDownDaysToDelete.TabIndex = 11;
            this.numericUpDownDaysToDelete.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // SharepointForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 172);
            this.Controls.Add(this.numericUpDownDaysToDelete);
            this.Controls.Add(this.labelDaysToDelete);
            this.Controls.Add(this.buttonURLLocalhost);
            this.Controls.Add(this.buttonGetCount);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textBoxListName);
            this.Controls.Add(this.labelListName);
            this.Controls.Add(this.textBoxURL);
            this.Controls.Add(this.labelURL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SharepointForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Sharepoint Delete List Items";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDaysToDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelURL;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.Label labelListName;
        private System.Windows.Forms.TextBox textBoxListName;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label labelSharepointItemsCount;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonGetCount;
        private System.Windows.Forms.Button buttonURLLocalhost;
        private System.Windows.Forms.Label labelDaysToDelete;
        private System.Windows.Forms.NumericUpDown numericUpDownDaysToDelete;

    }
}

