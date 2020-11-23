namespace app
{
    partial class AddMember
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
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cin = new System.Windows.Forms.TextBox();
            this.tel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fullname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Upload = new FontAwesome.Sharp.IconButton();
            this.add = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.registrationDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14F);
            this.label5.ForeColor = System.Drawing.Color.Indigo;
            this.label5.Location = new System.Drawing.Point(682, 319);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(53, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = " صورة";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F);
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(611, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "رقم البطاقة الوطنية";
            // 
            // cin
            // 
            this.cin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cin.Location = new System.Drawing.Point(466, 161);
            this.cin.MaxLength = 20;
            this.cin.Name = "cin";
            this.cin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cin.Size = new System.Drawing.Size(131, 26);
            this.cin.TabIndex = 8;
            // 
            // tel
            // 
            this.tel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tel.Location = new System.Drawing.Point(466, 213);
            this.tel.MaxLength = 20;
            this.tel.Name = "tel";
            this.tel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tel.Size = new System.Drawing.Size(131, 26);
            this.tel.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14F);
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(661, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "رقم الهاتف";
            // 
            // fullname
            // 
            this.fullname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fullname.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullname.Location = new System.Drawing.Point(466, 109);
            this.fullname.MaxLength = 20;
            this.fullname.Name = "fullname";
            this.fullname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fullname.Size = new System.Drawing.Size(131, 26);
            this.fullname.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F);
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(654, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "الاسم الكامل";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(297, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 40);
            this.label1.TabIndex = 15;
            this.label1.Text = "إضافة عضو";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(68, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 374);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Upload
            // 
            this.Upload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Upload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Upload.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.Upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Upload.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Upload.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Upload.ForeColor = System.Drawing.Color.Indigo;
            this.Upload.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.Upload.IconColor = System.Drawing.Color.Indigo;
            this.Upload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Upload.IconSize = 27;
            this.Upload.Location = new System.Drawing.Point(466, 313);
            this.Upload.Name = "Upload";
            this.Upload.Rotation = 0D;
            this.Upload.Size = new System.Drawing.Size(131, 32);
            this.Upload.TabIndex = 22;
            this.Upload.Text = "Upload";
            this.Upload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Upload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Upload.UseVisualStyleBackColor = true;
            this.Upload.Click += new System.EventHandler(this.Upload_Click);
            // 
            // add
            // 
            this.add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.add.BackColor = System.Drawing.Color.Indigo;
            this.add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add.FlatAppearance.BorderSize = 0;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.add.Font = new System.Drawing.Font("Arial", 25F);
            this.add.ForeColor = System.Drawing.Color.White;
            this.add.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.add.IconColor = System.Drawing.Color.White;
            this.add.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.add.IconSize = 35;
            this.add.Location = new System.Drawing.Point(466, 385);
            this.add.Name = "add";
            this.add.Rotation = 0D;
            this.add.Size = new System.Drawing.Size(265, 53);
            this.add.TabIndex = 23;
            this.add.Text = "إضافة";
            this.add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14F);
            this.label6.ForeColor = System.Drawing.Color.Indigo;
            this.label6.Location = new System.Drawing.Point(634, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 22);
            this.label6.TabIndex = 24;
            this.label6.Text = "تاريخ الانخراط";
            // 
            // registrationDate
            // 
            this.registrationDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.registrationDate.Font = new System.Drawing.Font("Arial", 12F);
            this.registrationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.registrationDate.Location = new System.Drawing.Point(466, 265);
            this.registrationDate.Name = "registrationDate";
            this.registrationDate.Size = new System.Drawing.Size(131, 26);
            this.registrationDate.TabIndex = 25;
            // 
            // AddMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(780, 556);
            this.Controls.Add(this.registrationDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.add);
            this.Controls.Add(this.Upload);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cin);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fullname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddMember";
            this.Text = "AddMember";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cin;
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fullname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private FontAwesome.Sharp.IconButton Upload;
        private FontAwesome.Sharp.IconButton add;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker registrationDate;
    }
}