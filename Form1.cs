using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeagueSidemap
{
    public partial class MainForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public int ResX = 1920;
        public int ResY = 1080;


        public int CameraXPosition = 0;
        public int CameraYPosition = 0;
        public int CameraXSize = 350;
        public int CameraYSize = 350;

        public int DisplayXSize = 350;
        public int DisplayYSize = 350;

        public bool IsSettingsShown = false;


        public int CaptureRate = 10;
        Bitmap bmpm;
        Graphics g;
        Rectangle rect;
        public MainForm()
        {
            InitializeComponent();
        }

        private void CameraTimer_Tick(object sender, EventArgs e)
        {
            
            SliderPosY.Maximum = ResY - CameraYSize;
            SliderPosX.Maximum = ResX - CameraXSize;
            rect = new Rectangle(SliderPosX.Value, SliderPosY.Value, CameraXSize, CameraYSize);
            bmpm = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppArgb);
            g = Graphics.FromImage(bmpm);
            g.CopyFromScreen(rect.Left, rect.Top, 0, 0, bmpm.Size, CopyPixelOperation.SourceCopy);
            if (MapBmp.Image != null)
            {
                MapBmp.Image.Dispose();
            }
            MapBmp.Image = bmpm;
            g.Dispose();




            

        }


        public void UpdateFormSize(int x, int y) 
        {
            this.Size = new Size(x, y);
            MapBmp.Size = this.Size;
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            SettingsPannel.SendToBack();
            UpdateFormSize(DisplayXSize, DisplayYSize);
            SliderWindowSize.Minimum = 350;
            SliderWindowSize.Maximum = 1000;
            SliderCaptureSize.Minimum = 200;
            SliderCaptureSize.Maximum = 1000;
            SliderPosX.Minimum = 0;
            SliderPosX.Maximum = ResX- CameraXSize;
            SliderPosY.Minimum = 0;
            SliderPosY.Maximum = ResY - CameraYSize;

            frameBox.SelectedIndex = 1;
            CameraTimer.Enabled= true;
        }

        private void MapBmp_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void MapBmp_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (IsSettingsShown)
                {
                    SettingsPannel.SendToBack();
                    IsSettingsShown= false;
                }
                else
                {
                    SettingsPannel.BringToFront();
                    IsSettingsShown= true;
                }
            }
        }

        private void SettingsPannel_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (IsSettingsShown)
                {
                    SettingsPannel.SendToBack();
                    IsSettingsShown = false;
                }
                else
                {
                    SettingsPannel.BringToFront();
                    IsSettingsShown = true;
                }
            }
        }

        private void SliderWindowSize_MouseCaptureChanged(object sender, EventArgs e)
        {
            DisplayXSize = SliderWindowSize.Value;
            DisplayYSize = SliderWindowSize.Value;
            UpdateFormSize(DisplayXSize, DisplayYSize);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void trackBar2_MouseCaptureChanged(object sender, EventArgs e)
        {
            CameraXSize = SliderCaptureSize.Value;
            CameraYSize = SliderCaptureSize.Value;
    }

        private void button2_Click(object sender, EventArgs e)
        {
            ResX = int.Parse(txtbResX.Text);
            ResY = int.Parse(txtbResY.Text);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            CameraTimer.Enabled= false;
            CameraTimer.Interval = 1000 / int.Parse(frameBox.SelectedItem.ToString());
            CameraTimer.Enabled= true;
            
        }
    }
}
