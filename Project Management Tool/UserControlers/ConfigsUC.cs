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
    public partial class ConfigsUC : UserControl
    {
        public ConfigsUC()
        {
            InitializeComponent();
            ApplyUiTheme();
            txtBoxUserName.Text = Properties.Settings.Default.UserName;
        }

        public void ApplyUiTheme()
        {
            if (Properties.Settings.Default.DarkMode)
            {
                this.BackColor = Properties.Settings.Default.SurfaceContainerDark;

                foreach(Label label in this.Controls.OfType<Label>())
                {
                    label.ForeColor = Properties.Settings.Default.OnSurfaceDark;
                }
                foreach (TextBox textBox in this.Controls.OfType<TextBox>())
                {
                    textBox.ForeColor = Properties.Settings.Default.OnSurfaceDark;
                    textBox.BackColor = Properties.Settings.Default.SurfaceContainerDark;
                }
                checkBoxDarkMode.Image = Properties.Resources.moon_dark;
                checkBoxDarkMode.ForeColor = Properties.Settings.Default.OnSurfaceDark;
                checkBoxDarkMode.Text = " Dark Mode";
            }
            else
            {
                this.BackColor = Properties.Settings.Default.SurfaceContainerLight;

                foreach (Label label in this.Controls.OfType<Label>())
                {
                    label.ForeColor = Properties.Settings.Default.OnSurfaceLight;
                }
                foreach (TextBox textBox in this.Controls.OfType<TextBox>())
                {
                    textBox.ForeColor = Properties.Settings.Default.OnSurfaceLight;
                    textBox.BackColor = Properties.Settings.Default.SurfaceContainerLight;
                }
                checkBoxDarkMode.Image = Properties.Resources.sun_light;
                checkBoxDarkMode.ForeColor = Properties.Settings.Default.OnSurfaceLight;
                checkBoxDarkMode.Text = " Light Mode";
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
                button.ForeColor = Properties.Settings.Default.OnSurfaceDark;
            else
                button.ForeColor = Properties.Settings.Default.OnSurfaceLight;
        }

        private void checkBoxDarkMode_MouseDown(object sender, MouseEventArgs e)
        {
            Color auxColor = Properties.Settings.Default.PrimaryColor;
            Properties.Settings.Default.PrimaryColor = Properties.Settings.Default.SecondaryColor;
            Properties.Settings.Default.SecondaryColor = auxColor;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("Save all changes?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                Properties.Settings.Default.UserName = txtBoxUserName.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void checkBoxDarkMode_MouseUp(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.Save();
            ApplyUiTheme();
            MainForm mainForm = (MainForm)this.FindForm();
            mainForm.ApplyUiTheme();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("Are you sure? All configs will be set to default values", "Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(answer == DialogResult.Yes)
            {
                Properties.Settings.Default.Reset();
                txtBoxUserName.Text = Properties.Settings.Default.UserName;
            }
        }
    }
}
