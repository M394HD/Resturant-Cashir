namespace DesktopApplication.Forms
{
    partial class POSForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POSForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblToal = new System.Windows.Forms.Label();
            this.button14 = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.lblChange = new System.Windows.Forms.Label();
            this.txtPayed = new System.Windows.Forms.TextBox();
            this.lblPaied = new System.Windows.Forms.Label();
            this.cmbxPayment = new System.Windows.Forms.ComboBox();
            this.lblPayMethod = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelItems = new System.Windows.Forms.Panel();
            this.djvItems = new System.Windows.Forms.DataGridView();
            this.ColItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColQTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.txtItemQTY = new System.Windows.Forms.TextBox();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.djvItems)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(128, 12);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(152, 33);
            this.txtTotal.TabIndex = 1;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblToal
            // 
            this.lblToal.AutoSize = true;
            this.lblToal.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToal.Location = new System.Drawing.Point(21, 15);
            this.lblToal.Name = "lblToal";
            this.lblToal.Size = new System.Drawing.Size(66, 25);
            this.lblToal.TabIndex = 0;
            this.lblToal.Text = "Total";
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Image = ((System.Drawing.Image)(resources.GetObject("button14.Image")));
            this.button14.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button14.Location = new System.Drawing.Point(431, 72);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(145, 62);
            this.button14.TabIndex = 7;
            this.button14.Text = "Ptint";
            this.button14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.UseVisualStyleBackColor = true;
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Image = ((System.Drawing.Image)(resources.GetObject("btnPay.Image")));
            this.btnPay.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPay.Location = new System.Drawing.Point(431, 4);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(145, 62);
            this.btnPay.TabIndex = 6;
            this.btnPay.Text = "Pay";
            this.btnPay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Image = ((System.Drawing.Image)(resources.GetObject("button12.Image")));
            this.button12.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button12.Location = new System.Drawing.Point(582, 72);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(145, 62);
            this.button12.TabIndex = 5;
            this.button12.Text = "Clear";
            this.button12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Image = ((System.Drawing.Image)(resources.GetObject("button13.Image")));
            this.button13.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button13.Location = new System.Drawing.Point(582, 4);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(145, 62);
            this.button13.TabIndex = 4;
            this.button13.Text = "Remove";
            this.button13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button11.Location = new System.Drawing.Point(733, 72);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(145, 62);
            this.button11.TabIndex = 3;
            this.button11.Text = "Exit";
            this.button11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button10.Location = new System.Drawing.Point(733, 4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(145, 62);
            this.button10.TabIndex = 2;
            this.button10.Text = "Cancel";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // txtChange
            // 
            this.txtChange.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChange.Location = new System.Drawing.Point(173, 90);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(174, 33);
            this.txtChange.TabIndex = 1;
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.Location = new System.Drawing.Point(38, 93);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(90, 25);
            this.lblChange.TabIndex = 0;
            this.lblChange.Text = "Change";
            // 
            // txtPayed
            // 
            this.txtPayed.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayed.Location = new System.Drawing.Point(172, 51);
            this.txtPayed.Name = "txtPayed";
            this.txtPayed.Size = new System.Drawing.Size(174, 33);
            this.txtPayed.TabIndex = 1;
            // 
            // lblPaied
            // 
            this.lblPaied.AutoSize = true;
            this.lblPaied.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaied.Location = new System.Drawing.Point(37, 54);
            this.lblPaied.Name = "lblPaied";
            this.lblPaied.Size = new System.Drawing.Size(70, 25);
            this.lblPaied.TabIndex = 0;
            this.lblPaied.Text = "Paied";
            // 
            // cmbxPayment
            // 
            this.cmbxPayment.BackColor = System.Drawing.SystemColors.Control;
            this.cmbxPayment.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxPayment.FormattingEnabled = true;
            this.cmbxPayment.Location = new System.Drawing.Point(172, 12);
            this.cmbxPayment.Name = "cmbxPayment";
            this.cmbxPayment.Size = new System.Drawing.Size(173, 33);
            this.cmbxPayment.TabIndex = 1;
            // 
            // lblPayMethod
            // 
            this.lblPayMethod.AutoSize = true;
            this.lblPayMethod.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayMethod.Location = new System.Drawing.Point(37, 15);
            this.lblPayMethod.Name = "lblPayMethod";
            this.lblPayMethod.Size = new System.Drawing.Size(105, 25);
            this.lblPayMethod.TabIndex = 0;
            this.lblPayMethod.Text = "Payment";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.button14);
            this.panel4.Controls.Add(this.btnPay);
            this.panel4.Controls.Add(this.button12);
            this.panel4.Controls.Add(this.button13);
            this.panel4.Controls.Add(this.button11);
            this.panel4.Controls.Add(this.button10);
            this.panel4.Controls.Add(this.txtChange);
            this.panel4.Controls.Add(this.lblChange);
            this.panel4.Controls.Add(this.txtPayed);
            this.panel4.Controls.Add(this.lblPaied);
            this.panel4.Controls.Add(this.cmbxPayment);
            this.panel4.Controls.Add(this.lblPayMethod);
            this.panel4.Location = new System.Drawing.Point(314, 449);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(879, 157);
            this.panel4.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.txtTotal);
            this.panel3.Controls.Add(this.lblToal);
            this.panel3.Location = new System.Drawing.Point(9, 449);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(299, 157);
            this.panel3.TabIndex = 4;
            // 
            // panelItems
            // 
            this.panelItems.BackColor = System.Drawing.Color.White;
            this.panelItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelItems.Location = new System.Drawing.Point(314, 7);
            this.panelItems.Name = "panelItems";
            this.panelItems.Size = new System.Drawing.Size(650, 436);
            this.panelItems.TabIndex = 5;
            // 
            // djvItems
            // 
            this.djvItems.AllowUserToAddRows = false;
            this.djvItems.AllowUserToDeleteRows = false;
            this.djvItems.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.djvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.djvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.djvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColItemId,
            this.ColItemName,
            this.ColQTY,
            this.ColPrice,
            this.ColItemPrice});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.djvItems.DefaultCellStyle = dataGridViewCellStyle2;
            this.djvItems.Location = new System.Drawing.Point(9, 7);
            this.djvItems.Name = "djvItems";
            this.djvItems.ReadOnly = true;
            this.djvItems.Size = new System.Drawing.Size(299, 436);
            this.djvItems.TabIndex = 6;
            // 
            // ColItemId
            // 
            this.ColItemId.HeaderText = "Id";
            this.ColItemId.Name = "ColItemId";
            this.ColItemId.ReadOnly = true;
            this.ColItemId.Visible = false;
            // 
            // ColItemName
            // 
            this.ColItemName.FillWeight = 130F;
            this.ColItemName.HeaderText = "Item";
            this.ColItemName.Name = "ColItemName";
            this.ColItemName.ReadOnly = true;
            this.ColItemName.Width = 130;
            // 
            // ColQTY
            // 
            this.ColQTY.FillWeight = 50F;
            this.ColQTY.HeaderText = "QTY";
            this.ColQTY.Name = "ColQTY";
            this.ColQTY.ReadOnly = true;
            this.ColQTY.Width = 50;
            // 
            // ColPrice
            // 
            this.ColPrice.FillWeight = 70F;
            this.ColPrice.HeaderText = "Price";
            this.ColPrice.Name = "ColPrice";
            this.ColPrice.ReadOnly = true;
            this.ColPrice.Width = 70;
            // 
            // ColItemPrice
            // 
            this.ColItemPrice.HeaderText = "ItemPrice";
            this.ColItemPrice.Name = "ColItemPrice";
            this.ColItemPrice.ReadOnly = true;
            this.ColItemPrice.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnDot);
            this.panel1.Controls.Add(this.btn0);
            this.panel1.Controls.Add(this.btn3);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Controls.Add(this.txtItemQTY);
            this.panel1.Controls.Add(this.btn6);
            this.panel1.Controls.Add(this.btn5);
            this.panel1.Controls.Add(this.btn4);
            this.panel1.Controls.Add(this.btn9);
            this.panel1.Controls.Add(this.btn8);
            this.panel1.Controls.Add(this.btn7);
            this.panel1.Location = new System.Drawing.Point(970, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 436);
            this.panel1.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(163, 274);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 70);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "C";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnDot
            // 
            this.btnDot.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.Location = new System.Drawing.Point(87, 274);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(70, 70);
            this.btnDot.TabIndex = 10;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(11, 274);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(70, 70);
            this.btn0.TabIndex = 9;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(163, 198);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(70, 70);
            this.btn3.TabIndex = 8;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(87, 198);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(70, 70);
            this.btn2.TabIndex = 7;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(11, 198);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(70, 70);
            this.btn1.TabIndex = 6;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // txtItemQTY
            // 
            this.txtItemQTY.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemQTY.Location = new System.Drawing.Point(11, 7);
            this.txtItemQTY.Name = "txtItemQTY";
            this.txtItemQTY.Size = new System.Drawing.Size(222, 33);
            this.txtItemQTY.TabIndex = 1;
            this.txtItemQTY.Text = "0";
            this.txtItemQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(163, 122);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(70, 70);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(87, 122);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(70, 70);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(11, 122);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(70, 70);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(163, 46);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(70, 70);
            this.btn9.TabIndex = 2;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(87, 46);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(70, 70);
            this.btn8.TabIndex = 1;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(11, 46);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(70, 70);
            this.btn7.TabIndex = 0;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            // 
            // POSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 619);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelItems);
            this.Controls.Add(this.djvItems);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "POSForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "POSForm";
            this.Load += new System.EventHandler(this.POSForm_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.djvItems)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblToal;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.TextBox txtPayed;
        private System.Windows.Forms.Label lblPaied;
        private System.Windows.Forms.ComboBox cmbxPayment;
        private System.Windows.Forms.Label lblPayMethod;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelItems;
        private System.Windows.Forms.DataGridView djvItems;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txtItemQTY;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColQTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColItemPrice;
    }
}