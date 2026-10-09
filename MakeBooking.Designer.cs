using System;
using System.ComponentModel;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace PhumlaKamnandiHotel_Project
{
    partial class MakeBooking
    {
        private IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.header = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.card = new Guna.UI2.WinForms.Guna2Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnConfirm = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnCancel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtDeposit = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRate = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDeposit = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblRate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtGuestName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblContact = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtContact = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCheckIn = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtCheckIn = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblCheckOut = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtCheckOut = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblGuests = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.numGuestsUpDown = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lblRoom = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbRoomType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnCheckGuest = new Guna.UI2.WinForms.Guna2GradientButton();
            this.header.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.card.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGuestsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.Controls.Add(this.guna2GradientPanel1);
            this.header.Controls.Add(this.pictureBox1);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1180, 89);
            this.header.TabIndex = 2;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.Cyan;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(239, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(940, 88);
            this.guna2GradientPanel1.TabIndex = 2;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PhumlaKamnandiHotel_Project.Properties.Resources.Gemini_Generated_Image_xktbx8xktbx8xktb;
            this.pictureBox1.Location = new System.Drawing.Point(0, -71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 228);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // card
            // 
            this.card.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.card.BorderThickness = 1;
            this.card.Controls.Add(this.btnCheckGuest);
            this.card.Controls.Add(this.btnClose);
            this.card.Controls.Add(this.guna2HtmlLabel1);
            this.card.Controls.Add(this.btnConfirm);
            this.card.Controls.Add(this.btnCancel);
            this.card.Controls.Add(this.txtDeposit);
            this.card.Controls.Add(this.txtRate);
            this.card.Controls.Add(this.lblDeposit);
            this.card.Controls.Add(this.lblRate);
            this.card.Controls.Add(this.lblName);
            this.card.Controls.Add(this.txtGuestName);
            this.card.Controls.Add(this.lblContact);
            this.card.Controls.Add(this.txtContact);
            this.card.Controls.Add(this.lblCheckIn);
            this.card.Controls.Add(this.dtCheckIn);
            this.card.Controls.Add(this.lblCheckOut);
            this.card.Controls.Add(this.dtCheckOut);
            this.card.Controls.Add(this.lblGuests);
            this.card.Controls.Add(this.numGuestsUpDown);
            this.card.Controls.Add(this.lblRoom);
            this.card.Controls.Add(this.cmbRoomType);
            this.card.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.card.Location = new System.Drawing.Point(189, 121);
            this.card.Name = "card";
            this.card.Size = new System.Drawing.Size(756, 480);
            this.card.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.AutoRoundedCorners = true;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor2 = System.Drawing.Color.Cyan;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(499, 332);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(121, 47);
            this.btnClose.TabIndex = 40;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(499, 238);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(3, 2);
            this.guna2HtmlLabel1.TabIndex = 36;
            this.guna2HtmlLabel1.Text = null;
            // 
            // btnConfirm
            // 
            this.btnConfirm.AutoRoundedCorners = true;
            this.btnConfirm.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConfirm.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConfirm.FillColor2 = System.Drawing.Color.Cyan;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(160, 332);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(120, 46);
            this.btnConfirm.TabIndex = 35;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoRoundedCorners = true;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor2 = System.Drawing.Color.Cyan;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(322, 332);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 46);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtDeposit
            // 
            this.txtDeposit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDeposit.DefaultText = "";
            this.txtDeposit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDeposit.ForeColor = System.Drawing.Color.Black;
            this.txtDeposit.Location = new System.Drawing.Point(160, 256);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.PlaceholderText = "";
            this.txtDeposit.ReadOnly = true;
            this.txtDeposit.SelectedText = "";
            this.txtDeposit.Size = new System.Drawing.Size(126, 36);
            this.txtDeposit.TabIndex = 17;
            // 
            // txtRate
            // 
            this.txtRate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRate.DefaultText = "";
            this.txtRate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRate.ForeColor = System.Drawing.Color.Black;
            this.txtRate.Location = new System.Drawing.Point(160, 201);
            this.txtRate.Name = "txtRate";
            this.txtRate.PlaceholderText = "";
            this.txtRate.ReadOnly = true;
            this.txtRate.SelectedText = "";
            this.txtRate.Size = new System.Drawing.Size(126, 36);
            this.txtRate.TabIndex = 16;
            // 
            // lblDeposit
            // 
            this.lblDeposit.BackColor = System.Drawing.Color.Transparent;
            this.lblDeposit.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeposit.ForeColor = System.Drawing.Color.Black;
            this.lblDeposit.Location = new System.Drawing.Point(20, 273);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(62, 22);
            this.lblDeposit.TabIndex = 18;
            this.lblDeposit.Text = "Deposit";
            // 
            // lblRate
            // 
            this.lblRate.BackColor = System.Drawing.Color.Transparent;
            this.lblRate.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.ForeColor = System.Drawing.Color.Black;
            this.lblRate.Location = new System.Drawing.Point(20, 218);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(37, 22);
            this.lblRate.TabIndex = 19;
            this.lblRate.Text = "Rate";
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(20, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(94, 22);
            this.lblName.TabIndex = 20;
            this.lblName.Text = "Guest Name";
            // 
            // txtGuestName
            // 
            this.txtGuestName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGuestName.DefaultText = "";
            this.txtGuestName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGuestName.ForeColor = System.Drawing.Color.Black;
            this.txtGuestName.Location = new System.Drawing.Point(160, 20);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.PlaceholderText = "";
            this.txtGuestName.SelectedText = "";
            this.txtGuestName.Size = new System.Drawing.Size(240, 41);
            this.txtGuestName.TabIndex = 21;
            // 
            // lblContact
            // 
            this.lblContact.BackColor = System.Drawing.Color.Transparent;
            this.lblContact.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.ForeColor = System.Drawing.Color.Black;
            this.lblContact.Location = new System.Drawing.Point(20, 88);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(61, 22);
            this.lblContact.TabIndex = 22;
            this.lblContact.Text = "Contact ";
            // 
            // txtContact
            // 
            this.txtContact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContact.DefaultText = "";
            this.txtContact.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtContact.ForeColor = System.Drawing.Color.Black;
            this.txtContact.Location = new System.Drawing.Point(160, 66);
            this.txtContact.Name = "txtContact";
            this.txtContact.PlaceholderText = "";
            this.txtContact.SelectedText = "";
            this.txtContact.Size = new System.Drawing.Size(240, 41);
            this.txtContact.TabIndex = 23;
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.BackColor = System.Drawing.Color.Transparent;
            this.lblCheckIn.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckIn.Location = new System.Drawing.Point(420, 20);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(80, 22);
            this.lblCheckIn.TabIndex = 24;
            this.lblCheckIn.Text = "Check-in *";
            // 
            // dtCheckIn
            // 
            this.dtCheckIn.Checked = true;
            this.dtCheckIn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtCheckIn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtCheckIn.Location = new System.Drawing.Point(528, 18);
            this.dtCheckIn.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtCheckIn.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtCheckIn.Name = "dtCheckIn";
            this.dtCheckIn.Size = new System.Drawing.Size(200, 36);
            this.dtCheckIn.TabIndex = 25;
            this.dtCheckIn.Value = new System.DateTime(2025, 10, 9, 10, 15, 15, 68);
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.BackColor = System.Drawing.Color.Transparent;
            this.lblCheckOut.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckOut.Location = new System.Drawing.Point(420, 60);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(91, 22);
            this.lblCheckOut.TabIndex = 26;
            this.lblCheckOut.Text = "Check-out *";
            // 
            // dtCheckOut
            // 
            this.dtCheckOut.Checked = true;
            this.dtCheckOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtCheckOut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtCheckOut.Location = new System.Drawing.Point(528, 58);
            this.dtCheckOut.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtCheckOut.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtCheckOut.Name = "dtCheckOut";
            this.dtCheckOut.Size = new System.Drawing.Size(200, 36);
            this.dtCheckOut.TabIndex = 27;
            this.dtCheckOut.Value = new System.DateTime(2025, 10, 9, 10, 15, 15, 165);
            // 
            // lblGuests
            // 
            this.lblGuests.BackColor = System.Drawing.Color.Transparent;
            this.lblGuests.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuests.ForeColor = System.Drawing.Color.Black;
            this.lblGuests.Location = new System.Drawing.Point(20, 130);
            this.lblGuests.Name = "lblGuests";
            this.lblGuests.Size = new System.Drawing.Size(104, 22);
            this.lblGuests.TabIndex = 28;
            this.lblGuests.Text = "No. of Guests ";
            // 
            // numGuestsUpDown
            // 
            this.numGuestsUpDown.BackColor = System.Drawing.Color.Transparent;
            this.numGuestsUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numGuestsUpDown.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numGuestsUpDown.Location = new System.Drawing.Point(160, 113);
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
            this.numGuestsUpDown.Size = new System.Drawing.Size(80, 36);
            this.numGuestsUpDown.TabIndex = 29;
            this.numGuestsUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblRoom
            // 
            this.lblRoom.BackColor = System.Drawing.Color.Transparent;
            this.lblRoom.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.ForeColor = System.Drawing.Color.Black;
            this.lblRoom.Location = new System.Drawing.Point(20, 174);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(88, 22);
            this.lblRoom.TabIndex = 30;
            this.lblRoom.Text = "Room Type";
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.BackColor = System.Drawing.Color.Transparent;
            this.cmbRoomType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbRoomType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbRoomType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbRoomType.ForeColor = System.Drawing.Color.Black;
            this.cmbRoomType.ItemHeight = 30;
            this.cmbRoomType.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Family",
            "Deluxe",
            "Suite"});
            this.cmbRoomType.Location = new System.Drawing.Point(160, 157);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(200, 36);
            this.cmbRoomType.TabIndex = 31;
            this.cmbRoomType.SelectedIndexChanged += new System.EventHandler(this.cmbRoomType_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PhumlaKamnandiHotel_Project.Properties.Resources._444300;
            this.pictureBox2.Location = new System.Drawing.Point(-11, 86);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1191, 549);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnCheckGuest
            // 
            this.btnCheckGuest.AutoRoundedCorners = true;
            this.btnCheckGuest.BackColor = System.Drawing.Color.Transparent;
            this.btnCheckGuest.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckGuest.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckGuest.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheckGuest.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheckGuest.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheckGuest.FillColor2 = System.Drawing.Color.Cyan;
            this.btnCheckGuest.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckGuest.ForeColor = System.Drawing.Color.White;
            this.btnCheckGuest.Location = new System.Drawing.Point(314, 405);
            this.btnCheckGuest.Name = "btnCheckGuest";
            this.btnCheckGuest.Size = new System.Drawing.Size(121, 47);
            this.btnCheckGuest.TabIndex = 41;
            this.btnCheckGuest.Text = "Check Guest";
            this.btnCheckGuest.Click += new System.EventHandler(this.btnCheckGuest_Click);
            // 
            // MakeBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 622);
            this.Controls.Add(this.card);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.header);
            this.Name = "MakeBooking";
            this.Text = "Make Booking";
            this.header.ResumeLayout(false);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.card.ResumeLayout(false);
            this.card.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGuestsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Guna2Panel header;
        private PictureBox pictureBox2;
        private Guna2Panel card;
        private Guna2HtmlLabel lblName;
        private Guna2TextBox txtGuestName;
        private Guna2HtmlLabel lblContact;
        private Guna2TextBox txtContact;
        private Guna2HtmlLabel lblCheckIn;
        private Guna2DateTimePicker dtCheckIn;
        private Guna2HtmlLabel lblCheckOut;
        private Guna2DateTimePicker dtCheckOut;
        private Guna2HtmlLabel lblGuests;
        private Guna2NumericUpDown numGuestsUpDown;
        private Guna2HtmlLabel lblRoom;
        private Guna2ComboBox cmbRoomType;
        private Guna2HtmlLabel lblRate;
        private Guna2TextBox txtDeposit;
        private Guna2TextBox txtRate;
        private Guna2HtmlLabel lblDeposit;
        private Guna2HtmlLabel label1;
        private Guna2GradientButton btnConfirm;
        private Guna2GradientButton btnCancel;
        private Guna2GradientPanel guna2GradientPanel1;
        private Guna2HtmlLabel guna2HtmlLabel1;
        private Guna2GradientButton btnClose;
        private Guna2GradientButton btnCheckGuest;
    }
}