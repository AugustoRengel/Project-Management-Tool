using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management_Tool.UserControlers
{
    public partial class ProjectsListUC : UserControl
    {
        private string theme;

        public ProjectsListUC()
        {
            InitializeComponent();
            ApplyUiTheme();
        }
        public void ApplyUiTheme()
        {
            if (Properties.Settings.Default.DarkMode)
            {
                this.BackColor = Properties.Settings.Default.BackgroundDark;
                TopBarPanel.BackColor = Properties.Settings.Default.SurfaceContainerDark;
                FlowLayoutPanel.BackColor = Properties.Settings.Default.SurfaceContainerDark;
                DividerBar.BackColor = Properties.Settings.Default.BackgroundDark;

                lblTotalPages.ForeColor = Properties.Settings.Default.OnSurfaceDark;
                txtBoxPage.ForeColor = Properties.Settings.Default.OnSurfaceDark;
                txtBoxPage.BackColor = Properties.Settings.Default.SurfaceContainerDark;
                txtBoxSearch.ForeColor = Properties.Settings.Default.OnSurfaceDark;
                txtBoxSearch.BackColor = Properties.Settings.Default.SurfaceContainerDark;
            }
            else
            {
                this.BackColor = Properties.Settings.Default.BackgroundLight;
                TopBarPanel.BackColor = Properties.Settings.Default.SurfaceContainerLight;
                FlowLayoutPanel.BackColor = Properties.Settings.Default.SurfaceContainerLight;
                DividerBar.BackColor = Properties.Settings.Default.BackgroundLight;

                lblTotalPages.ForeColor = Properties.Settings.Default.OnSurfaceLight;
                txtBoxPage.ForeColor = Properties.Settings.Default.OnSurfaceLight;
                txtBoxPage.BackColor = Properties.Settings.Default.SurfaceContainerLight;
                txtBoxSearch.ForeColor = Properties.Settings.Default.OnSurfaceLight;
                txtBoxSearch.BackColor = Properties.Settings.Default.SurfaceContainerLight;
            }
            foreach (Button menuBtn in TopBarPanel.Controls.OfType<Button>())
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
                button.ForeColor = Properties.Settings.Default.OnSurfaceDark;
            else
                button.ForeColor = Properties.Settings.Default.OnSurfaceLight;
        }
        private void ApplyIcons()
        {
            if (Properties.Settings.Default.DarkMode)
                theme = "dark";
            else
                theme = "light";
            btnPreviusPage.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("previus_page_" + theme);
            btnNextPage.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("next_page_" + theme);
            btnSearch.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("search_" + theme);
        }
    }
}
