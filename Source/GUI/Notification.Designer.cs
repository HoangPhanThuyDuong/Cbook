namespace index
{
    partial class frm_notify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_notify));
            this.lbl_notify = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.iconshow = new System.Windows.Forms.PictureBox();
            this.timer_run = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.iconshow)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_notify
            // 
            this.lbl_notify.AutoSize = true;
            this.lbl_notify.ForeColor = System.Drawing.Color.White;
            this.lbl_notify.Location = new System.Drawing.Point(110, 40);
            this.lbl_notify.Name = "lbl_notify";
            this.lbl_notify.Size = new System.Drawing.Size(174, 30);
            this.lbl_notify.TabIndex = 0;
            this.lbl_notify.Text = "Message Text";
            // 
            // btn_close
            // 
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(430, 30);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(50, 50);
            this.btn_close.TabIndex = 1;
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // iconshow
            // 
            this.iconshow.Image = ((System.Drawing.Image)(resources.GetObject("iconshow.Image")));
            this.iconshow.Location = new System.Drawing.Point(25, 25);
            this.iconshow.Name = "iconshow";
            this.iconshow.Size = new System.Drawing.Size(60, 60);
            this.iconshow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconshow.TabIndex = 2;
            this.iconshow.TabStop = false;
            // 
            // timer_run
            // 
            this.timer_run.Tick += new System.EventHandler(this.timer_run_Tick);
            // 
            // frm_notify
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(500, 110);
            this.ControlBox = false;
            this.Controls.Add(this.iconshow);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lbl_notify);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_notify";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Notification";
            ((System.ComponentModel.ISupportInitialize)(this.iconshow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_notify;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.PictureBox iconshow;
        private System.Windows.Forms.Timer timer_run;
    }
}