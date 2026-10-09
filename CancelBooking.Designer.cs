using Guna.UI2.WinForms;
using System;

namespace PhumlaKamnandiHotel_Project
{
    partial class CancelBooking
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
            this.btnClose = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnCancelBooking = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblRef = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtRef = new Guna.UI2.WinForms.Guna2TextBox();
            this.header.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundImage)).BeginInit();
            this.card.SuspendLayout();
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
            this.header.Size = new System.Drawing.Size(1141, 89);
            this.header.TabIndex = 2;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.Cyan;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(266, 1);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(875, 88);
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
            this.logoBox.Location = new System.Drawing.Point(0, -52);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(268, 208);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
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
            this.backgroundImage.Size = new System.Drawing.Size(1141, 535);
            this.backgroundImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backgroundImage.TabIndex = 1;
            this.backgroundImage.TabStop = false;
            // 
            // card
            // 
            this.card.BackColor = System.Drawing.Color.Transparent;
            this.card.BorderRadius = 12;
            this.card.Controls.Add(this.btnClose);
            this.card.Controls.Add(this.btnCancelBooking);
            this.card.Controls.Add(this.lblRef);
            this.card.Controls.Add(this.txtRef);
            this.card.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.card.Location = new System.Drawing.Point(220, 212);
            this.card.Name = "card";
            this.card.Size = new System.Drawing.Size(745, 287);
            this.card.TabIndex = 0;
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
            this.btnClose.Location = new System.Drawing.Point(384, 100);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(121, 47);
            this.btnClose.TabIndex = 39;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCancelBooking
            // 
            this.btnCancelBooking.AutoRoundedCorners = true;
            this.btnCancelBooking.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelBooking.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelBooking.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelBooking.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelBooking.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelBooking.FillColor2 = System.Drawing.Color.Cyan;
            this.btnCancelBooking.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelBooking.ForeColor = System.Drawing.Color.White;
            this.btnCancelBooking.Location = new System.Drawing.Point(164, 100);
            this.btnCancelBooking.Name = "btnCancelBooking";
            this.btnCancelBooking.Size = new System.Drawing.Size(170, 47);
            this.btnCancelBooking.TabIndex = 38;
            this.btnCancelBooking.Text = "Cancel Booking";
            this.btnCancelBooking.Click += new System.EventHandler(this.btnCancelBooking_Click);
            // 
            // lblRef
            // 
            this.lblRef.BackColor = System.Drawing.Color.Transparent;
            this.lblRef.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRef.Location = new System.Drawing.Point(27, 35);
            this.lblRef.Name = "lblRef";
            this.lblRef.Size = new System.Drawing.Size(134, 22);
            this.lblRef.TabIndex = 0;
            this.lblRef.Text = "Reservation Ref No";
            // 
            // txtRef
            // 
            this.txtRef.BorderRadius = 6;
            this.txtRef.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRef.DefaultText = "";
            this.txtRef.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRef.ForeColor = System.Drawing.Color.Black;
            this.txtRef.Location = new System.Drawing.Point(200, 18);
            this.txtRef.Name = "txtRef";
            this.txtRef.PlaceholderText = "Enter reservation number";
            this.txtRef.SelectedText = "";
            this.txtRef.Size = new System.Drawing.Size(220, 36);
            this.txtRef.TabIndex = 1;
            // 
            // CancelBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 624);
            this.Controls.Add(this.card);
            this.Controls.Add(this.backgroundImage);
            this.Controls.Add(this.header);
            this.Name = "CancelBooking";
            this.Text = "Cancel Booking";
            this.header.ResumeLayout(false);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundImage)).EndInit();
            this.card.ResumeLayout(false);
            this.card.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private Guna2Panel header;
        private Guna2PictureBox logoBox;
        private Guna2PictureBox backgroundImage;
        private Guna2Panel card;
        private Guna2HtmlLabel lblRef;
        private Guna2TextBox txtRef;
        private Guna2GradientPanel guna2GradientPanel1;
        private Guna2HtmlLabel label1;
        private Guna2GradientButton btnClose;
        private Guna2GradientButton btnCancelBooking;
    }
}