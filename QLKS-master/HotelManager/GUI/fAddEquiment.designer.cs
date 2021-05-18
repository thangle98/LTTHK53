namespace HotelManager
{
    partial class fAddEquipment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAddEquipment));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.groupRoom = new System.Windows.Forms.GroupBox();
            this.txtIDThietbi = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNhaSX = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtNametb = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTenPhong = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose_ = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAddEquipment = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.groupRoom.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(595, 6);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(21, 20);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 53;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupRoom
            // 
            this.groupRoom.Controls.Add(this.label3);
            this.groupRoom.Controls.Add(this.txtIDThietbi);
            this.groupRoom.Controls.Add(this.label4);
            this.groupRoom.Controls.Add(this.label15);
            this.groupRoom.Controls.Add(this.txtNhaSX);
            this.groupRoom.Controls.Add(this.txtNametb);
            this.groupRoom.Controls.Add(this.label1);
            this.groupRoom.Controls.Add(this.txbTenPhong);
            this.groupRoom.Controls.Add(this.label16);
            this.groupRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupRoom.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupRoom.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupRoom.Location = new System.Drawing.Point(15, 67);
            this.groupRoom.Margin = new System.Windows.Forms.Padding(4);
            this.groupRoom.Name = "groupRoom";
            this.groupRoom.Padding = new System.Windows.Forms.Padding(4);
            this.groupRoom.Size = new System.Drawing.Size(593, 239);
            this.groupRoom.TabIndex = 57;
            this.groupRoom.TabStop = false;
            this.groupRoom.Text = "Thông tin trang thiết bị";
            this.groupRoom.Enter += new System.EventHandler(this.groupRoom_Enter);
            // 
            // txtIDThietbi
            // 
            this.txtIDThietbi.BorderColorFocused = System.Drawing.Color.RoyalBlue;
            this.txtIDThietbi.BorderColorIdle = System.Drawing.Color.RoyalBlue;
            this.txtIDThietbi.BorderColorMouseHover = System.Drawing.Color.RoyalBlue;
            this.txtIDThietbi.BorderThickness = 1;
            this.txtIDThietbi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDThietbi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDThietbi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIDThietbi.isPassword = false;
            this.txtIDThietbi.Location = new System.Drawing.Point(30, 55);
            this.txtIDThietbi.Margin = new System.Windows.Forms.Padding(0);
            this.txtIDThietbi.Name = "txtIDThietbi";
            this.txtIDThietbi.Size = new System.Drawing.Size(189, 29);
            this.txtIDThietbi.TabIndex = 80;
            this.txtIDThietbi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(24, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 79;
            this.label4.Text = "Mã thiết bị";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label15.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label15.Location = new System.Drawing.Point(310, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 25);
            this.label15.TabIndex = 78;
            this.label15.Text = "Số lượng:";
            // 
            // txtNhaSX
            // 
            this.txtNhaSX.BorderColorFocused = System.Drawing.Color.RoyalBlue;
            this.txtNhaSX.BorderColorIdle = System.Drawing.Color.RoyalBlue;
            this.txtNhaSX.BorderColorMouseHover = System.Drawing.Color.RoyalBlue;
            this.txtNhaSX.BorderThickness = 1;
            this.txtNhaSX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNhaSX.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhaSX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNhaSX.isPassword = false;
            this.txtNhaSX.Location = new System.Drawing.Point(315, 55);
            this.txtNhaSX.Margin = new System.Windows.Forms.Padding(0);
            this.txtNhaSX.Name = "txtNhaSX";
            this.txtNhaSX.Size = new System.Drawing.Size(190, 29);
            this.txtNhaSX.TabIndex = 77;
            this.txtNhaSX.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtNametb
            // 
            this.txtNametb.BorderColorFocused = System.Drawing.Color.RoyalBlue;
            this.txtNametb.BorderColorIdle = System.Drawing.Color.RoyalBlue;
            this.txtNametb.BorderColorMouseHover = System.Drawing.Color.RoyalBlue;
            this.txtNametb.BorderThickness = 1;
            this.txtNametb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNametb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNametb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNametb.isPassword = false;
            this.txtNametb.Location = new System.Drawing.Point(28, 126);
            this.txtNametb.Margin = new System.Windows.Forms.Padding(0);
            this.txtNametb.Name = "txtNametb";
            this.txtNametb.Size = new System.Drawing.Size(189, 29);
            this.txtNametb.TabIndex = 76;
            this.txtNametb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(22, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 74;
            this.label1.Text = "Tên thiết bị";
            // 
            // txbTenPhong
            // 
            this.txbTenPhong.BorderColorFocused = System.Drawing.Color.RoyalBlue;
            this.txbTenPhong.BorderColorIdle = System.Drawing.Color.RoyalBlue;
            this.txbTenPhong.BorderColorMouseHover = System.Drawing.Color.RoyalBlue;
            this.txbTenPhong.BorderThickness = 1;
            this.txbTenPhong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbTenPhong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTenPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbTenPhong.isPassword = false;
            this.txbTenPhong.Location = new System.Drawing.Point(314, 126);
            this.txbTenPhong.Margin = new System.Windows.Forms.Padding(0);
            this.txbTenPhong.Name = "txbTenPhong";
            this.txbTenPhong.Size = new System.Drawing.Size(189, 29);
            this.txbTenPhong.TabIndex = 72;
            this.txbTenPhong.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label16.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label16.Location = new System.Drawing.Point(24, 171);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(99, 25);
            this.label16.TabIndex = 73;
            this.label16.Text = "Mã phòng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClose_);
            this.groupBox1.Controls.Add(this.btnAddEquipment);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox1.Location = new System.Drawing.Point(15, 301);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(591, 129);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btnClose_
            // 
            this.btnClose_.ActiveBorderThickness = 1;
            this.btnClose_.ActiveCornerRadius = 20;
            this.btnClose_.ActiveFillColor = System.Drawing.Color.RoyalBlue;
            this.btnClose_.ActiveForecolor = System.Drawing.Color.White;
            this.btnClose_.ActiveLineColor = System.Drawing.Color.RoyalBlue;
            this.btnClose_.BackColor = System.Drawing.Color.White;
            this.btnClose_.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose_.BackgroundImage")));
            this.btnClose_.ButtonText = "Đóng";
            this.btnClose_.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose_.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose_.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnClose_.IdleBorderThickness = 1;
            this.btnClose_.IdleCornerRadius = 20;
            this.btnClose_.IdleFillColor = System.Drawing.Color.White;
            this.btnClose_.IdleForecolor = System.Drawing.Color.RoyalBlue;
            this.btnClose_.IdleLineColor = System.Drawing.Color.RoyalBlue;
            this.btnClose_.Location = new System.Drawing.Point(314, 54);
            this.btnClose_.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnClose_.Name = "btnClose_";
            this.btnClose_.Size = new System.Drawing.Size(233, 49);
            this.btnClose_.TabIndex = 51;
            this.btnClose_.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddEquipment
            // 
            this.btnAddEquipment.ActiveBorderThickness = 1;
            this.btnAddEquipment.ActiveCornerRadius = 20;
            this.btnAddEquipment.ActiveFillColor = System.Drawing.Color.RoyalBlue;
            this.btnAddEquipment.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddEquipment.ActiveLineColor = System.Drawing.Color.RoyalBlue;
            this.btnAddEquipment.BackColor = System.Drawing.Color.White;
            this.btnAddEquipment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddEquipment.BackgroundImage")));
            this.btnAddEquipment.ButtonText = "Thêm Thiết Bị";
            this.btnAddEquipment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddEquipment.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEquipment.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnAddEquipment.IdleBorderThickness = 1;
            this.btnAddEquipment.IdleCornerRadius = 20;
            this.btnAddEquipment.IdleFillColor = System.Drawing.Color.White;
            this.btnAddEquipment.IdleForecolor = System.Drawing.Color.RoyalBlue;
            this.btnAddEquipment.IdleLineColor = System.Drawing.Color.RoyalBlue;
            this.btnAddEquipment.Location = new System.Drawing.Point(27, 54);
            this.btnAddEquipment.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnAddEquipment.Name = "btnAddEquipment";
            this.btnAddEquipment.Size = new System.Drawing.Size(233, 49);
            this.btnAddEquipment.TabIndex = 48;
            this.btnAddEquipment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddEquipment.Click += new System.EventHandler(this.btnAddEquipment_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(17, 56);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(591, 12);
            this.bunifuSeparator1.TabIndex = 55;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 46);
            this.label2.TabIndex = 54;
            this.label2.Text = "Thêm Trang Thiết Bị";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(310, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 81;
            this.label3.Text = "Mô tả:";
            // 
            // fAddEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(623, 443);
            this.Controls.Add(this.groupRoom);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fAddEquipment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fAbout";
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.groupRoom.ResumeLayout(false);
            this.groupRoom.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.GroupBox groupRoom;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnClose_;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddEquipment;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtIDThietbi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label15;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtNhaSX;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtNametb;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbTenPhong;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label3;
    }
}