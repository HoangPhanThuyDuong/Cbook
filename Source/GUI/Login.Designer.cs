namespace index
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel_left = new System.Windows.Forms.Panel();
            this.picture_logo = new System.Windows.Forms.PictureBox();
            this.lbl_lorem = new System.Windows.Forms.Label();
            this.panel_right = new System.Windows.Forms.Panel();
            this.btn_log = new System.Windows.Forms.Button();
            this.panel_acc = new System.Windows.Forms.Panel();
            this.txt_account = new System.Windows.Forms.TextBox();
            this.picture_user = new System.Windows.Forms.PictureBox();
            this.panel_pass = new System.Windows.Forms.Panel();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.picture_lock = new System.Windows.Forms.PictureBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.panel_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_logo)).BeginInit();
            this.panel_right.SuspendLayout();
            this.panel_acc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_user)).BeginInit();
            this.panel_pass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_lock)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.Color.LightCyan;
            this.panel_left.Controls.Add(this.picture_logo);
            this.panel_left.Controls.Add(this.lbl_lorem);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 0);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(500, 600);
            this.panel_left.TabIndex = 1;
            // 
            // picture_logo
            // 
            this.picture_logo.Image = ((System.Drawing.Image)(resources.GetObject("picture_logo.Image")));
            this.picture_logo.Location = new System.Drawing.Point(75, 167);
            this.picture_logo.Name = "picture_logo";
            this.picture_logo.Size = new System.Drawing.Size(350, 155);
            this.picture_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_logo.TabIndex = 0;
            this.picture_logo.TabStop = false;
            // 
            // lbl_lorem
            // 
            this.lbl_lorem.AutoSize = true;
            this.lbl_lorem.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lorem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lbl_lorem.Location = new System.Drawing.Point(95, 367);
            this.lbl_lorem.Name = "lbl_lorem";
            this.lbl_lorem.Size = new System.Drawing.Size(323, 66);
            this.lbl_lorem.TabIndex = 0;
            this.lbl_lorem.Text = "Cbook Bookstore - Bạn \r\ncủa mọi nhà\r\n";
            this.lbl_lorem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_right
            // 
            this.panel_right.BackColor = System.Drawing.Color.AliceBlue;
            this.panel_right.Controls.Add(this.btn_log);
            this.panel_right.Controls.Add(this.panel_acc);
            this.panel_right.Controls.Add(this.panel_pass);
            this.panel_right.Controls.Add(this.btn_exit);
            this.panel_right.Controls.Add(this.lbl_title);
            this.panel_right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_right.Location = new System.Drawing.Point(500, 0);
            this.panel_right.Name = "panel_right";
            this.panel_right.Size = new System.Drawing.Size(500, 600);
            this.panel_right.TabIndex = 1;
            // 
            // btn_log
            // 
            this.btn_log.BackColor = System.Drawing.Color.Cyan;
            this.btn_log.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_log.FlatAppearance.BorderColor = System.Drawing.Color.LightCyan;
            this.btn_log.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btn_log.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_log.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_log.Location = new System.Drawing.Point(50, 450);
            this.btn_log.Name = "btn_log";
            this.btn_log.Size = new System.Drawing.Size(200, 60);
            this.btn_log.TabIndex = 3;
            this.btn_log.Text = "Đăng nhập";
            this.btn_log.UseVisualStyleBackColor = false;
            this.btn_log.Click += new System.EventHandler(this.btn_log_Click);
            // 
            // panel_acc
            // 
            this.panel_acc.BackColor = System.Drawing.Color.White;
            this.panel_acc.Controls.Add(this.txt_account);
            this.panel_acc.Controls.Add(this.picture_user);
            this.panel_acc.Location = new System.Drawing.Point(0, 200);
            this.panel_acc.Name = "panel_acc";
            this.panel_acc.Size = new System.Drawing.Size(500, 80);
            this.panel_acc.TabIndex = 2;
            // 
            // txt_account
            // 
            this.txt_account.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_account.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_account.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txt_account.Location = new System.Drawing.Point(100, 25);
            this.txt_account.Name = "txt_account";
            this.txt_account.Size = new System.Drawing.Size(380, 33);
            this.txt_account.TabIndex = 1;
            // 
            // picture_user
            // 
            this.picture_user.Image = ((System.Drawing.Image)(resources.GetObject("picture_user.Image")));
            this.picture_user.Location = new System.Drawing.Point(20, 15);
            this.picture_user.Name = "picture_user";
            this.picture_user.Size = new System.Drawing.Size(50, 50);
            this.picture_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_user.TabIndex = 0;
            this.picture_user.TabStop = false;
            // 
            // panel_pass
            // 
            this.panel_pass.BackColor = System.Drawing.Color.White;
            this.panel_pass.Controls.Add(this.txt_password);
            this.panel_pass.Controls.Add(this.picture_lock);
            this.panel_pass.Location = new System.Drawing.Point(0, 325);
            this.panel_pass.Name = "panel_pass";
            this.panel_pass.Size = new System.Drawing.Size(500, 80);
            this.panel_pass.TabIndex = 2;
            // 
            // txt_password
            // 
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txt_password.Location = new System.Drawing.Point(100, 25);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(380, 33);
            this.txt_password.TabIndex = 1;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // picture_lock
            // 
            this.picture_lock.Image = ((System.Drawing.Image)(resources.GetObject("picture_lock.Image")));
            this.picture_lock.Location = new System.Drawing.Point(20, 15);
            this.picture_lock.Name = "picture_lock";
            this.picture_lock.Size = new System.Drawing.Size(50, 50);
            this.picture_lock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_lock.TabIndex = 0;
            this.picture_lock.TabStop = false;
            // 
            // btn_exit
            // 
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.Location = new System.Drawing.Point(440, 10);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(50, 50);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lbl_title.Location = new System.Drawing.Point(50, 100);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(369, 37);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Đăng nhập vào hệ thống";
            // 
            // Login
            // 
            this.AcceptButton = this.btn_log;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panel_right);
            this.Controls.Add(this.panel_left);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel_left.ResumeLayout(false);
            this.panel_left.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_logo)).EndInit();
            this.panel_right.ResumeLayout(false);
            this.panel_right.PerformLayout();
            this.panel_acc.ResumeLayout(false);
            this.panel_acc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_user)).EndInit();
            this.panel_pass.ResumeLayout(false);
            this.panel_pass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_lock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Panel panel_right;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel panel_acc;
        private System.Windows.Forms.PictureBox picture_user;
        private System.Windows.Forms.Panel panel_pass;
        private System.Windows.Forms.PictureBox picture_lock;
        private System.Windows.Forms.TextBox txt_account;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.PictureBox picture_logo;
        private System.Windows.Forms.Button btn_log;
        private System.Windows.Forms.Label lbl_lorem;
    }
}