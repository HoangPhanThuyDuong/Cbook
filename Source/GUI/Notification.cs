using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace index
{
    public partial class frm_notify : Form
    {
        public frm_notify()
        {
            InitializeComponent();
        }

        public enum eAction
        {
            wait,
            start,
            close
        }

        public enum eType
        {
            Success,
            Warning,
            Error,
            Info
        }

        private frm_notify.eAction action;
        private int x, y;

        private void timer_run_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case eAction.wait:
                    timer_run.Interval = 2000;
                    action = eAction.close;
                    break;

                case frm_notify.eAction.start:
                    this.timer_run.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = frm_notify.eAction.wait;
                        }
                    }
                    break;

                case eAction.close:
                    timer_run.Interval = 1;
                    this.Opacity -= 0.1;
                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }

        public void Show(string msg, eType type)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 1; i < 5; i++)
            {
                fname = "alert" + i.ToString();
                frm_notify frm = (frm_notify)Application.OpenForms[fname];

                if (frm == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width - 5;
                    //this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.y = this.Height * (i - 1) + 5;
                    this.Location = new Point(this.x, this.y);
                    break;
                }
            }

            switch (type)
            {
                case eType.Success:
                    this.iconshow.Image = Image.FromFile(Application.StartupPath + "\\Resources\\ok.png");
                    this.BackColor = Color.SeaGreen;
                    break;
                case eType.Error:
                    this.iconshow.Image = Image.FromFile(Application.StartupPath + "\\Resources\\error.png");
                    this.BackColor = Color.DarkRed;
                    break;
                case eType.Info:
                    this.iconshow.Image = Image.FromFile(Application.StartupPath + "\\Resources\\info.png");
                    this.BackColor = Color.RoyalBlue;
                    break;
                case eType.Warning:
                    this.iconshow.Image = Image.FromFile(Application.StartupPath + "\\Resources\\warning.png");
                    this.BackColor = Color.DarkOrange;
                    break;
            }

            this.lbl_notify.Text = msg;
            this.Show();
            this.action = eAction.start;
            this.timer_run.Interval = 1;    
            this.timer_run.Start();
        }
    }
}
