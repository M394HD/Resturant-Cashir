namespace DesktopApplication.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnReporting = new System.Windows.Forms.Button();
            this.btnSetup = new System.Windows.Forms.Button();
            this.btnPOS = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Gray;
            this.pnlMenu.Controls.Add(this.btnOptions);
            this.pnlMenu.Controls.Add(this.btnReporting);
            this.pnlMenu.Controls.Add(this.btnSetup);
            this.pnlMenu.Controls.Add(this.btnPOS);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 531);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnOptions
            // 
            this.btnOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOptions.FlatAppearance.BorderSize = 0;
            this.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptions.ForeColor = System.Drawing.Color.White;
            this.btnOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOptions.Image")));
            this.btnOptions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOptions.Location = new System.Drawing.Point(0, 236);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnOptions.Size = new System.Drawing.Size(200, 52);
            this.btnOptions.TabIndex = 4;
            this.btnOptions.Text = "Options";
            this.btnOptions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOptions.UseVisualStyleBackColor = true;
            // 
            // btnReporting
            // 
            this.btnReporting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReporting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReporting.FlatAppearance.BorderSize = 0;
            this.btnReporting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporting.ForeColor = System.Drawing.Color.White;
            this.btnReporting.Image = ((System.Drawing.Image)(resources.GetObject("btnReporting.Image")));
            this.btnReporting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporting.Location = new System.Drawing.Point(0, 184);
            this.btnReporting.Name = "btnReporting";
            this.btnReporting.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReporting.Size = new System.Drawing.Size(200, 52);
            this.btnReporting.TabIndex = 3;
            this.btnReporting.Text = "Reporting";
            this.btnReporting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReporting.UseVisualStyleBackColor = true;
            // 
            // btnSetup
            // 
            this.btnSetup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSetup.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetup.FlatAppearance.BorderSize = 0;
            this.btnSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetup.ForeColor = System.Drawing.Color.White;
            this.btnSetup.Image = ((System.Drawing.Image)(resources.GetObject("btnSetup.Image")));
            this.btnSetup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetup.Location = new System.Drawing.Point(0, 132);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSetup.Size = new System.Drawing.Size(200, 52);
            this.btnSetup.TabIndex = 2;
            this.btnSetup.Text = "Setup";
            this.btnSetup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetup.UseVisualStyleBackColor = true;
            // 
            // btnPOS
            // 
            this.btnPOS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPOS.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPOS.FlatAppearance.BorderSize = 0;
            this.btnPOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPOS.ForeColor = System.Drawing.Color.White;
            this.btnPOS.Image = ((System.Drawing.Image)(resources.GetObject("btnPOS.Image")));
            this.btnPOS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPOS.Location = new System.Drawing.Point(0, 80);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPOS.Size = new System.Drawing.Size(200, 52);
            this.btnPOS.TabIndex = 1;
            this.btnPOS.Text = "Point Of Sale";
            this.btnPOS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPOS.UseVisualStyleBackColor = true;
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(200, 80);
            this.pnlLogo.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.pnlMenu);
            this.Name = "MainForm";
            this.Text = "Main Smart POS";
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnPOS;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnReporting;
        private System.Windows.Forms.Button btnSetup;
    }
}