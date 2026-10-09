using Guna.UI2.WinForms;
using System;

namespace PhumlaKamnandiHotel_Project
{
    partial class ChangeBooking
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.header = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.logoBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.backgroundImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.card = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSave = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnCancel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnLoad = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblRef = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtResID = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtGuestName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCheckIn = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtCheckIn = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblCheckOut = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtCheckOut = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblGuests = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.numGuestsUpDown = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lblRoom = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbRoomType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblRate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtRate = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDeposit = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtDeposit = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2GradientButton();
            this.header.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundImage)).BeginInit();
            this.card.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGuestsUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.WhiteSmoke;
            this.header.Controls.Add(this.guna2GradientPanel1);
            this.header.Controls.Add(this.logoBox);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.FillColor = System.Drawing.Color.WhiteSmoke;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1144, 89);
            this.header.TabIndex = 0;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.Cyan;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(230, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(914, 88);
            this.guna2GradientPanel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bell MT", 24F);
            this.label1.Location = new System.Drawing.Point(170, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(527, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Peaceful Home Away From Home";
            // 
            // logoBox
            // 
            this.logoBox.Image = global::PhumlaKamnandiHotel_Project.Properties.Resources.Gemini_Generated_Image_xktbx8xktbx8xktb;
            this.logoBox.ImageRotate = 0F;
            this.logoBox.Location = new System.Drawing.Point(0, -40);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(226, 184);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoBox.TabIndex = 1;
            this.logoBox.TabStop = false;
            // 
            // backgroundImage
            // 
            this.backgroundImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundImage.Image = global::PhumlaKamnandiHotel_Project.Properties.Resources._444300;
            this.backgroundImage.ImageRotate = 0F;
            this.backgroundImage.Location = new System.Drawing.Point(0, 89);
            this.backgroundImage.Name = "backgroundImage";
            this.backgroundImage.Size = new System.Drawing.Size(1144, 532);
            this.backgroundImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backgroundImage.TabIndex = 1;
            this.backgroundImage.TabStop = false;
            // 
            // card
            // 
            this.card.BackColor = System.Drawing.Color.Transparent;
            this.card.BorderRadius = 12;
            this.card.Controls.Add(this.btnClose);
            this.card.Controls.Add(this.btnSave);
            this.card.Controls.Add(this.btnCancel);
            this.card.Controls.Add(this.btnLoad);
            this.card.Controls.Add(this.lblRef);
            this.card.Controls.Add(this.txtResID);
            this.card.Controls.Add(this.lblName);
            this.card.Controls.Add(this.txtGuestName);
            this.card.Controls.Add(this.lblCheckIn);
            this.card.Controls.Add(this.dtCheckIn);
            this.card.Controls.Add(this.lblCheckOut);
            this.card.Controls.Add(this.dtCheckOut);
            this.card.Controls.Add(this.lblGuests);
            this.card.Controls.Add(this.numGuestsUpDown);
            this.card.Controls.Add(this.lblRoom);
            this.card.Controls.Add(this.cmbRoomType);
            this.card.Controls.Add(this.lblRate);
            this.card.Controls.Add(this.txtRate);
            this.card.Controls.Add(this.lblDeposit);
            this.card.Controls.Add(this.txtDeposit);
            this.card.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.card.Location = new System.Drawing.Point(210, 131);
            this.card.Name = "card";
            this.card.Size = new System.Drawing.Size(786, 435);
            this.card.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.AutoRoundedCorners = true;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor2 = System.Drawing.Color.Cyan;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(160, 326);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(165, 43);
            this.btnSave.TabIndex = 42;
            this.btnSave.Text = "Save Changes";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoRoundedCorners = true;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor2 = System.Drawing.Color.Cyan;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(371, 327);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(133, 42);
            this.btnCancel.TabIndex = 41;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.AutoRoundedCorners = true;
            this.btnLoad.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLoad.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLoad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLoad.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLoad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLoad.FillColor2 = System.Drawing.Color.Cyan;
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(434, 7);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(113, 41);
            this.btnLoad.TabIndex = 40;
            this.btnLoad.Text = "Load";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblRef
            // 
            this.lblRef.BackColor = System.Drawing.Color.Transparent;
            this.lblRef.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRef.ForeColor = System.Drawing.Color.Black;
            this.lblRef.Location = new System.Drawing.Point(20, 20);
            this.lblRef.Name = "lblRef";
            this.lblRef.Size = new System.Drawing.Size(134, 22);
            this.lblRef.TabIndex = 0;
            this.lblRef.Text = "Reservation Ref No";
            // 
            // txtResID
            // 
            this.txtResID.BorderRadius = 6;
            this.txtResID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtResID.DefaultText = "";
            this.txtResID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtResID.ForeColor = System.Drawing.Color.Black;
            this.txtResID.Location = new System.Drawing.Point(160, 18);
            this.txtResID.Name = "txtResID";
            this.txtResID.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtResID.PlaceholderText = "";
            this.txtResID.SelectedText = "";
            this.txtResID.Size = new System.Drawing.Size(220, 30);
            this.txtResID.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(20, 70);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(97, 22);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Guest Name *";
            // 
            // txtGuestName
            // 
            this.txtGuestName.BorderRadius = 6;
            this.txtGuestName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGuestName.DefaultText = "";
            this.txtGuestName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGuestName.ForeColor = System.Drawing.Color.Black;
            this.txtGuestName.Location = new System.Drawing.Point(160, 70);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.PlaceholderText = "";
            this.txtGuestName.ReadOnly = true;
            this.txtGuestName.SelectedText = "";
            this.txtGuestName.Size = new System.Drawing.Size(240, 30);
            this.txtGuestName.TabIndex = 4;
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.BackColor = System.Drawing.Color.Transparent;
            this.lblCheckIn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckIn.ForeColor = System.Drawing.Color.Black;
            this.lblCheckIn.Location = new System.Drawing.Point(420, 72);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(74, 22);
            this.lblCheckIn.TabIndex = 5;
            this.lblCheckIn.Text = "Check-in *";
            // 
            // dtCheckIn
            // 
            this.dtCheckIn.BorderRadius = 6;
            this.dtCheckIn.Checked = true;
            this.dtCheckIn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtCheckIn.Location = new System.Drawing.Point(505, 70);
            this.dtCheckIn.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtCheckIn.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtCheckIn.Name = "dtCheckIn";
            this.dtCheckIn.Size = new System.Drawing.Size(200, 30);
            this.dtCheckIn.TabIndex = 6;
            this.dtCheckIn.Value = new System.DateTime(2025, 10, 9, 10, 35, 0, 80);
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.BackColor = System.Drawing.Color.Transparent;
            this.lblCheckOut.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckOut.ForeColor = System.Drawing.Color.Black;
            this.lblCheckOut.Location = new System.Drawing.Point(420, 112);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(84, 22);
            this.lblCheckOut.TabIndex = 7;
            this.lblCheckOut.Text = "Check-out *";
            // 
            // dtCheckOut
            // 
            this.dtCheckOut.BorderRadius = 6;
            this.dtCheckOut.Checked = true;
            this.dtCheckOut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtCheckOut.Location = new System.Drawing.Point(505, 110);
            this.dtCheckOut.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtCheckOut.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtCheckOut.Name = "dtCheckOut";
            this.dtCheckOut.Size = new System.Drawing.Size(200, 30);
            this.dtCheckOut.TabIndex = 8;
            this.dtCheckOut.Value = new System.DateTime(2025, 10, 9, 10, 35, 0, 182);
            // 
            // lblGuests
            // 
            this.lblGuests.BackColor = System.Drawing.Color.Transparent;
            this.lblGuests.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuests.ForeColor = System.Drawing.Color.Black;
            this.lblGuests.Location = new System.Drawing.Point(20, 113);
            this.lblGuests.Name = "lblGuests";
            this.lblGuests.Size = new System.Drawing.Size(105, 22);
            this.lblGuests.TabIndex = 9;
            this.lblGuests.Text = "No. of Guests *";
            // 
            // numGuestsUpDown
            // 
            this.numGuestsUpDown.BackColor = System.Drawing.Color.Transparent;
            this.numGuestsUpDown.BorderRadius = 6;
            this.numGuestsUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numGuestsUpDown.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numGuestsUpDown.Location = new System.Drawing.Point(160, 110);
            this.numGuestsUpDown.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numGuestsUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numGuestsUpDown.Name = "numGuestsUpDown";
            this.numGuestsUpDown.Size = new System.Drawing.Size(60, 30);
            this.numGuestsUpDown.TabIndex = 10;
            this.numGuestsUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblRoom
            // 
            this.lblRoom.BackColor = System.Drawing.Color.Transparent;
            this.lblRoom.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.ForeColor = System.Drawing.Color.Black;
            this.lblRoom.Location = new System.Drawing.Point(20, 153);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(91, 22);
            this.lblRoom.TabIndex = 11;
            this.lblRoom.Text = "Room Type *";
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.BackColor = System.Drawing.Color.Transparent;
            this.cmbRoomType.BorderRadius = 6;
            this.cmbRoomType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomType.FocusedColor = System.Drawing.Color.Empty;
            this.cmbRoomType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbRoomType.ForeColor = System.Drawing.Color.Black;
            this.cmbRoomType.ItemHeight = 30;
            this.cmbRoomType.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Family",
            "Deluxe",
            "Suite"});
            this.cmbRoomType.Location = new System.Drawing.Point(160, 150);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(200, 36);
            this.cmbRoomType.TabIndex = 12;
            this.cmbRoomType.SelectedIndexChanged += new System.EventHandler(this.cmbRoomType_SelectedIndexChanged);
            // 
            // lblRate
            // 
            this.lblRate.BackColor = System.Drawing.Color.Transparent;
            this.lblRate.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.ForeColor = System.Drawing.Color.Black;
            this.lblRate.Location = new System.Drawing.Point(21, 199);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(33, 22);
            this.lblRate.TabIndex = 13;
            this.lblRate.Text = "Rate";
            // 
            // txtRate
            // 
            this.txtRate.BorderRadius = 6;
            this.txtRate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRate.DefaultText = "";
            this.txtRate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRate.ForeColor = System.Drawing.Color.Black;
            this.txtRate.Location = new System.Drawing.Point(160, 195);
            this.txtRate.Name = "txtRate";
            this.txtRate.PlaceholderText = "";
            this.txtRate.ReadOnly = true;
            this.txtRate.SelectedText = "";
            this.txtRate.Size = new System.Drawing.Size(126, 30);
            this.txtRate.TabIndex = 14;
            // 
            // lblDeposit
            // 
            this.lblDeposit.BackColor = System.Drawing.Color.Transparent;
            this.lblDeposit.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeposit.ForeColor = System.Drawing.Color.Black;
            this.lblDeposit.Location = new System.Drawing.Point(21, 242);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(55, 22);
            this.lblDeposit.TabIndex = 15;
            this.lblDeposit.Text = "Deposit";
            // 
            // txtDeposit
            // 
            this.txtDeposit.BorderRadius = 6;
            this.txtDeposit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDeposit.DefaultText = "";
            this.txtDeposit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDeposit.ForeColor = System.Drawing.Color.Black;
            this.txtDeposit.Location = new System.Drawing.Point(160, 240);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.PlaceholderText = "";
            this.txtDeposit.ReadOnly = true;
            this.txtDeposit.SelectedText = "";
            this.txtDeposit.Size = new System.Drawing.Size(126, 30);
            this.txtDeposit.TabIndex = 16;
            // 
            // btnClose
            // 
            this.btnClose.AutoRoundedCorners = true;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor2 = System.Drawing.Color.Cyan;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(564, 326);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(121, 43);
            this.btnClose.TabIndex = 43;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ChangeBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 621);
            this.Controls.Add(this.card);
            this.Controls.Add(this.backgroundImage);
            this.Controls.Add(this.header);
            this.Name = "ChangeBooking";
            this.Text = "Change Booking";
            this.header.ResumeLayout(false);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundImage)).EndInit();
            this.card.ResumeLayout(false);
            this.card.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGuestsUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna2Panel header;
        private Guna2PictureBox logoBox;
        private Guna2PictureBox backgroundImage;
        private Guna2Panel card;
        private Guna2HtmlLabel lblRef;
        private Guna2TextBox txtResID;
        private Guna2HtmlLabel lblName;
        private Guna2TextBox txtGuestName;
        private Guna2HtmlLabel lblCheckIn;
        private Guna2DateTimePicker dtCheckIn;
        private Guna2HtmlLabel lblCheckOut;
        private Guna2DateTimePicker dtCheckOut;
        private Guna2HtmlLabel lblGuests;
        private Guna2NumericUpDown numGuestsUpDown;
        private Guna2HtmlLabel lblRoom;
        private Guna2ComboBox cmbRoomType;
        private Guna2TextBox txtDeposit;
        private Guna2TextBox txtRate;
        private Guna2HtmlLabel lblDeposit;
        private Guna2HtmlLabel lblRate;
        private Guna2GradientPanel guna2GradientPanel1;
        private Guna2HtmlLabel label1;
        private Guna2GradientButton btnSave;
        private Guna2GradientButton btnCancel;
        private Guna2GradientButton btnLoad;
        private Guna2GradientButton btnClose;
    }
}