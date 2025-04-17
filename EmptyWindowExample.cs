using System;
using System.Drawing;
using System.Windows.Forms;

namespace BasicWindowApp
{
    public class BasicForm : Form
    {
        public BasicForm()
        {
            this.Text = "空窗口应用程序示例";
            this.Size = new Size(800, 600);
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.StartPosition = FormStartPosition.CenterScreen;

            string iconPath = "app.ico";
            if (System.IO.File.Exists(iconPath))
            {
                this.Icon = new Icon(iconPath);
            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new BasicForm());
        }
    }
}
