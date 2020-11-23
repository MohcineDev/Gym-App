namespace app
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.help = new FontAwesome.Sharp.IconButton();
            this.renewRegistrationBtn = new FontAwesome.Sharp.IconButton();
            this.updateMemberBtn = new FontAwesome.Sharp.IconButton();
            this.deleteMemberBtn = new FontAwesome.Sharp.IconButton();
            this.searchMemberBtn = new FontAwesome.Sharp.IconButton();
            this.addMemberBtn = new FontAwesome.Sharp.IconButton();
            this.homeBtn = new FontAwesome.Sharp.IconButton();
            this.back = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 24);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.LightYellow;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(55, 1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(20, 20);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(5, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PowderBlue;
            this.panel2.Controls.Add(this.help);
            this.panel2.Controls.Add(this.renewRegistrationBtn);
            this.panel2.Controls.Add(this.updateMemberBtn);
            this.panel2.Controls.Add(this.deleteMemberBtn);
            this.panel2.Controls.Add(this.searchMemberBtn);
            this.panel2.Controls.Add(this.addMemberBtn);
            this.panel2.Controls.Add(this.homeBtn);
            this.panel2.Controls.Add(this.back);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(780, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 556);
            this.panel2.TabIndex = 1;
            // 
            // help
            // 
            this.help.BackColor = System.Drawing.Color.DodgerBlue;
            this.help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.help.Dock = System.Windows.Forms.DockStyle.Top;
            this.help.FlatAppearance.BorderSize = 0;
            this.help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.help.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.help.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.help.ForeColor = System.Drawing.Color.White;
            this.help.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.help.IconColor = System.Drawing.Color.WhiteSmoke;
            this.help.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.help.IconSize = 35;
            this.help.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.help.Location = new System.Drawing.Point(0, 360);
            this.help.Name = "help";
            this.help.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.help.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.help.Rotation = 0D;
            this.help.Size = new System.Drawing.Size(170, 60);
            this.help.TabIndex = 16;
            this.help.Text = "مساعدة";
            this.help.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.help.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.help.UseVisualStyleBackColor = false;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // renewRegistrationBtn
            // 
            this.renewRegistrationBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.renewRegistrationBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.renewRegistrationBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.renewRegistrationBtn.FlatAppearance.BorderSize = 0;
            this.renewRegistrationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.renewRegistrationBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.renewRegistrationBtn.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold);
            this.renewRegistrationBtn.ForeColor = System.Drawing.Color.White;
            this.renewRegistrationBtn.IconChar = FontAwesome.Sharp.IconChar.Grin;
            this.renewRegistrationBtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.renewRegistrationBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.renewRegistrationBtn.IconSize = 35;
            this.renewRegistrationBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.renewRegistrationBtn.Location = new System.Drawing.Point(0, 300);
            this.renewRegistrationBtn.Name = "renewRegistrationBtn";
            this.renewRegistrationBtn.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.renewRegistrationBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.renewRegistrationBtn.Rotation = 0D;
            this.renewRegistrationBtn.Size = new System.Drawing.Size(170, 60);
            this.renewRegistrationBtn.TabIndex = 15;
            this.renewRegistrationBtn.Text = "تجديد الانخراط";
            this.renewRegistrationBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.renewRegistrationBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.renewRegistrationBtn.UseVisualStyleBackColor = false;
            this.renewRegistrationBtn.Click += new System.EventHandler(this.renewRegistrationBtn_Click);
            // 
            // updateMemberBtn
            // 
            this.updateMemberBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.updateMemberBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateMemberBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.updateMemberBtn.FlatAppearance.BorderSize = 0;
            this.updateMemberBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateMemberBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.updateMemberBtn.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.updateMemberBtn.ForeColor = System.Drawing.Color.White;
            this.updateMemberBtn.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.updateMemberBtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.updateMemberBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.updateMemberBtn.IconSize = 35;
            this.updateMemberBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.updateMemberBtn.Location = new System.Drawing.Point(0, 240);
            this.updateMemberBtn.Name = "updateMemberBtn";
            this.updateMemberBtn.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.updateMemberBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.updateMemberBtn.Rotation = 0D;
            this.updateMemberBtn.Size = new System.Drawing.Size(170, 60);
            this.updateMemberBtn.TabIndex = 14;
            this.updateMemberBtn.Text = "تحديث";
            this.updateMemberBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.updateMemberBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.updateMemberBtn.UseVisualStyleBackColor = false;
            this.updateMemberBtn.Click += new System.EventHandler(this.updateMemberBtn_Click);
            // 
            // deleteMemberBtn
            // 
            this.deleteMemberBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.deleteMemberBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteMemberBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.deleteMemberBtn.FlatAppearance.BorderSize = 0;
            this.deleteMemberBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteMemberBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.deleteMemberBtn.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.deleteMemberBtn.ForeColor = System.Drawing.Color.White;
            this.deleteMemberBtn.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.deleteMemberBtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.deleteMemberBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.deleteMemberBtn.IconSize = 35;
            this.deleteMemberBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteMemberBtn.Location = new System.Drawing.Point(0, 180);
            this.deleteMemberBtn.Name = "deleteMemberBtn";
            this.deleteMemberBtn.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.deleteMemberBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.deleteMemberBtn.Rotation = 0D;
            this.deleteMemberBtn.Size = new System.Drawing.Size(170, 60);
            this.deleteMemberBtn.TabIndex = 13;
            this.deleteMemberBtn.Text = "مسح";
            this.deleteMemberBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteMemberBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.deleteMemberBtn.UseVisualStyleBackColor = false;
            this.deleteMemberBtn.Click += new System.EventHandler(this.deleteMemberBtn_Click);
            // 
            // searchMemberBtn
            // 
            this.searchMemberBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.searchMemberBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchMemberBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchMemberBtn.FlatAppearance.BorderSize = 0;
            this.searchMemberBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchMemberBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.searchMemberBtn.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.searchMemberBtn.ForeColor = System.Drawing.Color.White;
            this.searchMemberBtn.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.searchMemberBtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.searchMemberBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.searchMemberBtn.IconSize = 35;
            this.searchMemberBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchMemberBtn.Location = new System.Drawing.Point(0, 120);
            this.searchMemberBtn.Name = "searchMemberBtn";
            this.searchMemberBtn.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.searchMemberBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.searchMemberBtn.Rotation = 0D;
            this.searchMemberBtn.Size = new System.Drawing.Size(170, 60);
            this.searchMemberBtn.TabIndex = 12;
            this.searchMemberBtn.Text = "بحث";
            this.searchMemberBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchMemberBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.searchMemberBtn.UseVisualStyleBackColor = false;
            this.searchMemberBtn.Click += new System.EventHandler(this.searchMemberBtn_Click);
            // 
            // addMemberBtn
            // 
            this.addMemberBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.addMemberBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addMemberBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.addMemberBtn.FlatAppearance.BorderSize = 0;
            this.addMemberBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMemberBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.addMemberBtn.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.addMemberBtn.ForeColor = System.Drawing.Color.White;
            this.addMemberBtn.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.addMemberBtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.addMemberBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addMemberBtn.IconSize = 35;
            this.addMemberBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addMemberBtn.Location = new System.Drawing.Point(0, 60);
            this.addMemberBtn.Name = "addMemberBtn";
            this.addMemberBtn.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.addMemberBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addMemberBtn.Rotation = 0D;
            this.addMemberBtn.Size = new System.Drawing.Size(170, 60);
            this.addMemberBtn.TabIndex = 11;
            this.addMemberBtn.Text = "اضافة";
            this.addMemberBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addMemberBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.addMemberBtn.UseVisualStyleBackColor = false;
            this.addMemberBtn.Click += new System.EventHandler(this.addMemberBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.homeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.homeBtn.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.homeBtn.ForeColor = System.Drawing.Color.White;
            this.homeBtn.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.homeBtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.homeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.homeBtn.IconSize = 35;
            this.homeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.homeBtn.Location = new System.Drawing.Point(0, 0);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.homeBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.homeBtn.Rotation = 0D;
            this.homeBtn.Size = new System.Drawing.Size(170, 60);
            this.homeBtn.TabIndex = 10;
            this.homeBtn.Text = "الرئيسية";
            this.homeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.homeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.homeBtn.UseVisualStyleBackColor = false;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // back
            // 
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.back.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.back.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.back.IconColor = System.Drawing.Color.Crimson;
            this.back.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.back.IconSize = 48;
            this.back.Location = new System.Drawing.Point(0, 496);
            this.back.Name = "back";
            this.back.Rotation = 0D;
            this.back.Size = new System.Drawing.Size(170, 60);
            this.back.TabIndex = 6;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Location = new System.Drawing.Point(30, 1);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(20, 20);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // date
            // 
            this.date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.date.BackColor = System.Drawing.Color.Transparent;
            this.date.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(256, 219);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(291, 21);
            this.date.TabIndex = 4;
            this.date.Text = "Date";
            this.date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.LightBlue;
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.date);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 24);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(780, 556);
            this.mainPanel.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 16F);
            this.label1.Location = new System.Drawing.Point(179, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 118);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 580);
            this.ControlBox = false;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.btnMaximize);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(880, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label date;
        public System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton back;
        private FontAwesome.Sharp.IconButton homeBtn;
        private FontAwesome.Sharp.IconButton addMemberBtn;
        private FontAwesome.Sharp.IconButton searchMemberBtn;
        private FontAwesome.Sharp.IconButton deleteMemberBtn;
        private FontAwesome.Sharp.IconButton updateMemberBtn;
        private FontAwesome.Sharp.IconButton renewRegistrationBtn;
        private FontAwesome.Sharp.IconButton help;
    }
}

