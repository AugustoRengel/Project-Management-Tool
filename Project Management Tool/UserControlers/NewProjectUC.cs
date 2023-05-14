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
    public partial class NewProjectUC : UserControl
    {
        public NewProjectUC()
        {
            InitializeComponent();
            ApplyUiTheme();
        }

        public void ApplyUiTheme()
        {
            if (Properties.Settings.Default.DarkMode)
            {
                this.BackColor = Properties.Settings.Default.SurfaceContainerDark;

                lblTitle.ForeColor = Properties.Settings.Default.OnSurfaceDark;
                lblDescription.ForeColor = Properties.Settings.Default.OnSurfaceDark;

                txtBoxTitle.ForeColor = Properties.Settings.Default.OnSurfaceDark;
                txtBoxTitle.BackColor = Properties.Settings.Default.SurfaceContainerDark;
                txtBoxDescription.ForeColor = Properties.Settings.Default.OnSurfaceDark;
                txtBoxDescription.BackColor = Properties.Settings.Default.SurfaceContainerDark;
            }
            else
            {
                this.BackColor = Properties.Settings.Default.SurfaceContainerLight;

                lblTitle.ForeColor = Properties.Settings.Default.OnSurfaceLight;
                lblDescription.ForeColor = Properties.Settings.Default.OnSurfaceLight;

                txtBoxTitle.ForeColor = Properties.Settings.Default.OnSurfaceLight;
                txtBoxTitle.BackColor = Properties.Settings.Default.SurfaceContainerLight;
                txtBoxDescription.ForeColor = Properties.Settings.Default.OnSurfaceLight;
                txtBoxDescription.BackColor = Properties.Settings.Default.SurfaceContainerLight;
            }
            foreach (Button menuBtn in this.Controls.OfType<Button>())
            {
                ConfigButtonsTheme(menuBtn);
            }

            //ApplyIcons();
        }

        private void ConfigButtonsTheme(Button button)
        {
            button.FlatAppearance.MouseOverBackColor = Properties.Settings.Default.PrimaryColor;
            button.FlatAppearance.MouseDownBackColor = Properties.Settings.Default.SecondaryColor;
            if (Properties.Settings.Default.DarkMode)
            {
                button.ForeColor = Properties.Settings.Default.OnSurfaceDark;
            }
            else
            {
                button.ForeColor = Properties.Settings.Default.OnSurfaceLight;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
