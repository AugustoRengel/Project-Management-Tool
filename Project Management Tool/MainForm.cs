using Project_Management_Tool.UserControlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management_Tool
{
    public partial class MainForm : Form
    {
        private Button activeButton;
        private UserControl activeUserControl;
        private Size formSize;
        private int borderSize = 0;
        private string theme;

        public MainForm()
        {
            InitializeComponent();
            //Properties.Settings.Default.Reset();
            ApplyUiTheme();
            this.Padding = new Padding(borderSize);
            if(Properties.Settings.Default.UserName == "")
            {
                btnConfigurations_Click(btnConfigurations, new EventArgs());
            }
        }

        public void ApplyUiTheme()
        {
            if (Properties.Settings.Default.DarkMode)
            {
                this.BackColor = Properties.Settings.Default.BackgroundDark;
                MenuPanel.BackColor = Properties.Settings.Default.SurfaceContainerDark;
                MainPanel.BackColor = Properties.Settings.Default.SurfaceContainerDark;
            }
            else
            {
                this.BackColor = Properties.Settings.Default.BackgroundLight;
                MenuPanel.BackColor = Properties.Settings.Default.SurfaceContainerLight;
                MainPanel.BackColor = Properties.Settings.Default.SurfaceContainerLight;
            }
            foreach (Button menuBtn in this.Controls.OfType<Button>())
            {
                ConfigButtonsTheme(menuBtn);
            }
            foreach (Button menuBtn in MenuPanel.Controls.OfType<Button>())
            {
                ConfigButtonsTheme(menuBtn);
            }

            ApplyIcons();
        }

        private void ConfigButtonsTheme(Button button)
        {
            button.FlatAppearance.MouseOverBackColor = Properties.Settings.Default.PrimaryColor;
            button.FlatAppearance.MouseDownBackColor = Properties.Settings.Default.SecondaryColor;
            if (Properties.Settings.Default.DarkMode)
                button.ForeColor= Properties.Settings.Default.OnSurfaceDark;
            else
                button.ForeColor = Properties.Settings.Default.OnSurfaceLight;
        }
        private void ApplyIcons()
        {
            if (Properties.Settings.Default.DarkMode)
                theme = "dark";
            else
                theme = "light";
            btnClose.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("close_wnd_" + theme);
            btnMaximize.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("maximize_wnd_" + theme);
            btnMinimize.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("minimize_wnd_" + theme);
            btnMenu.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("menu_" + theme);
            btnAllProjects.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("search_folder_" + theme);
            btnMyProjects.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("document_" + theme);
            btnIdeas.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("light_on_" + theme);
            btnNewProject.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("add_project_" + theme);
            btnConfigurations.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("gear_" + theme);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (activeButton != (Button)btnSender)
                {
                    DisableButton();
                    activeButton = (Button)btnSender;
                    activeButton.BackColor = Properties.Settings.Default.PrimaryColor;
                }
            }
        }
        private void DisableButton()
        {
            if (activeButton != null)
            {
                activeButton.BackColor = Color.Transparent;
            }
        }

        private void closeUserControl()
        {
            if (activeUserControl != null)
            {
                MainPanel.Controls.Remove(activeUserControl);
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            ColapseMenu();
        }

        private void ColapseMenu()
        {
            if (MenuPanel.Width >= 200)
            {
                MenuPanel.Width = 64;
                MainPanel.Location = new Point(
                    MainPanel.Location.X - 136,
                    MainPanel.Location.Y
                );
                MainPanel.Width += 136;
                foreach (Button menuBtn in MenuPanel.Controls.OfType<Button>())
                {
                    menuBtn.Text = "";
                    menuBtn.ImageAlign = ContentAlignment.MiddleCenter;
                    menuBtn.Padding = new Padding(0);

                }
            }
            else
            {
                MenuPanel.Width = 200;
                MainPanel.Location = new Point(
                    MainPanel.Location.X + 136,
                    MainPanel.Location.Y
                );
                MainPanel.Width -= 136;
                foreach (Button menuBtn in MenuPanel.Controls.OfType<Button>())
                {
                    menuBtn.Text = " " + menuBtn.Tag.ToString();
                    menuBtn.ImageAlign = ContentAlignment.MiddleLeft;
                    menuBtn.Padding = new Padding(12, 0, 0, 0);

                }
            }
        }

        private void btnAllProjects_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            closeUserControl();
            ProjectsListUC control = new ProjectsListUC();
            activeUserControl = control;
            control.Width = MainPanel.Width;
            control.Height = MainPanel.Height;
            MainPanel.Controls.Add(control);
        }

        private void btnMyProjects_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            closeUserControl();
        }

        private void btnIdeas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            closeUserControl();
        }

        private void btnConfigurations_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            closeUserControl();
            ConfigsUC control = new ConfigsUC();
            activeUserControl = control;
            control.Width = MainPanel.Width;
            control.Height = MainPanel.Height;
            control.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(control);
        }

        #region Window basic functions 
        //Drag Form
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                borderSize = 8;
                btnMaximize.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("restore_wnd_" + theme);
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                borderSize = 0;
                btnMaximize.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("maximize_wnd_" + theme);
            }
            this.Padding = new Padding(borderSize);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0x09; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;
            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right
            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>
            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          
                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion
            //Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
            if (m.Msg == WM_SYSCOMMAND)
            {
                /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
                /// Quote:
                /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
                /// are used internally by the system.To obtain the correct result when testing 
                /// the value of wParam, an application must combine the value 0xFFF0 with the 
                /// wParam value by using the bitwise AND operator.
                int wParam = (m.WParam.ToInt32() & 0xFFF0);
                if (wParam == SC_MINIMIZE)  //Before
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = formSize;
            }
            base.WndProc(ref m);
        }
        #endregion

        private void btnNewProject_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            closeUserControl();
            NewProjectUC control = new NewProjectUC();
            activeUserControl = control;
            control.Width = MainPanel.Width;
            control.Height = MainPanel.Height;
            MainPanel.Controls.Add(control);
        }
    }
}
