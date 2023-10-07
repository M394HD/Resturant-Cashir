namespace DesktopApplication.Forms
{
    partial class FormPermissions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPermissions));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxOption = new System.Windows.Forms.CheckBox();
            this.checkBoxReporting = new System.Windows.Forms.CheckBox();
            this.checkBoxSetUp = new System.Windows.Forms.CheckBox();
            this.checkBoxPointOfSale = new System.Windows.Forms.CheckBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(46, 46);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.btnSave,
            this.toolStripSeparator2,
            this.btnExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(600, 68);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 68);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(50, 65);
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 68);
            // 
            // btnExit
            // 
            this.btnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 65);
            this.btnExit.Text = "Exit";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(123, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(284, 32);
            this.comboBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Users";
            // 
            // checkBoxOption
            // 
            this.checkBoxOption.AccessibleDescription = "Main";
            this.checkBoxOption.AccessibleName = "Options";
            this.checkBoxOption.AutoSize = true;
            this.checkBoxOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxOption.Location = new System.Drawing.Point(445, 166);
            this.checkBoxOption.Name = "checkBoxOption";
            this.checkBoxOption.Size = new System.Drawing.Size(90, 24);
            this.checkBoxOption.TabIndex = 3;
            this.checkBoxOption.Text = "Options";
            this.checkBoxOption.UseVisualStyleBackColor = true;
            // 
            // checkBoxReporting
            // 
            this.checkBoxReporting.AccessibleDescription = "Main";
            this.checkBoxReporting.AccessibleName = "Reporting";
            this.checkBoxReporting.AutoSize = true;
            this.checkBoxReporting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxReporting.Location = new System.Drawing.Point(309, 166);
            this.checkBoxReporting.Name = "checkBoxReporting";
            this.checkBoxReporting.Size = new System.Drawing.Size(107, 24);
            this.checkBoxReporting.TabIndex = 2;
            this.checkBoxReporting.Text = "Reporting";
            this.checkBoxReporting.UseVisualStyleBackColor = true;
            // 
            // checkBoxSetUp
            // 
            this.checkBoxSetUp.AccessibleDescription = "Main";
            this.checkBoxSetUp.AccessibleName = "SetUp";
            this.checkBoxSetUp.AutoSize = true;
            this.checkBoxSetUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSetUp.Location = new System.Drawing.Point(190, 166);
            this.checkBoxSetUp.Name = "checkBoxSetUp";
            this.checkBoxSetUp.Size = new System.Drawing.Size(84, 24);
            this.checkBoxSetUp.TabIndex = 1;
            this.checkBoxSetUp.Text = "Set Up";
            this.checkBoxSetUp.UseVisualStyleBackColor = true;
            // 
            // checkBoxPointOfSale
            // 
            this.checkBoxPointOfSale.AccessibleDescription = "Main";
            this.checkBoxPointOfSale.AccessibleName = "PointOfSale";
            this.checkBoxPointOfSale.AutoSize = true;
            this.checkBoxPointOfSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPointOfSale.Location = new System.Drawing.Point(31, 166);
            this.checkBoxPointOfSale.Name = "checkBoxPointOfSale";
            this.checkBoxPointOfSale.Size = new System.Drawing.Size(134, 24);
            this.checkBoxPointOfSale.TabIndex = 0;
            this.checkBoxPointOfSale.Text = "Point Of Sale";
            this.checkBoxPointOfSale.UseVisualStyleBackColor = true;
            // 
            // FormPermissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 228);
            this.Controls.Add(this.checkBoxOption);
            this.Controls.Add(this.checkBoxReporting);
            this.Controls.Add(this.checkBoxSetUp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxPointOfSale);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.toolStrip1);
            this.MinimizeBox = false;
            this.Name = "FormPermissions";
            this.Text = "FormPermissions";
            this.Load += new System.EventHandler(this.FormPermissions_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxOption;
        private System.Windows.Forms.CheckBox checkBoxReporting;
        private System.Windows.Forms.CheckBox checkBoxSetUp;
        private System.Windows.Forms.CheckBox checkBoxPointOfSale;
    }
}