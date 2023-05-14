namespace Project_Management_Tool
{
    partial class MainForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnConfigurations = new System.Windows.Forms.Button();
            this.btnIdeas = new System.Windows.Forms.Button();
            this.btnNewProject = new System.Windows.Forms.Button();
            this.btnMyProjects = new System.Windows.Forms.Button();
            this.btnAllProjects = new System.Windows.Forms.Button();
            this.MenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.MenuPanel.Controls.Add(this.btnConfigurations);
            this.MenuPanel.Controls.Add(this.btnIdeas);
            this.MenuPanel.Controls.Add(this.btnNewProject);
            this.MenuPanel.Controls.Add(this.btnMyProjects);
            this.MenuPanel.Controls.Add(this.btnAllProjects);
            this.MenuPanel.Location = new System.Drawing.Point(8, 48);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(200, 394);
            this.MenuPanel.TabIndex = 0;
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.MainPanel.Location = new System.Drawing.Point(214, 48);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(578, 394);
            this.MainPanel.TabIndex = 2;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BackgroundImage = global::Project_Management_Tool.Properties.Resources.minimize_wnd_dark;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(44)))), ((int)(((byte)(220)))));
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(5)))), ((int)(((byte)(123)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMinimize.Location = new System.Drawing.Point(720, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(24, 24);
            this.btnMinimize.TabIndex = 6;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.BackgroundImage = global::Project_Management_Tool.Properties.Resources.maximize_wnd_dark;
            this.btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(44)))), ((int)(((byte)(220)))));
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(5)))), ((int)(((byte)(123)))));
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMaximize.Location = new System.Drawing.Point(744, 4);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(24, 24);
            this.btnMaximize.TabIndex = 5;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(44)))), ((int)(((byte)(220)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(5)))), ((int)(((byte)(123)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.Location = new System.Drawing.Point(768, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 24);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(44)))), ((int)(((byte)(220)))));
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(5)))), ((int)(((byte)(123)))));
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(222)))), ((int)(((byte)(225)))));
            this.btnMenu.Image = global::Project_Management_Tool.Properties.Resources.menu_dark;
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(8, 4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnMenu.Size = new System.Drawing.Size(200, 36);
            this.btnMenu.TabIndex = 3;
            this.btnMenu.Tag = "Expected.Virgula";
            this.btnMenu.Text = " Expected.Virgula";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnConfigurations
            // 
            this.btnConfigurations.BackColor = System.Drawing.Color.Transparent;
            this.btnConfigurations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConfigurations.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnConfigurations.FlatAppearance.BorderSize = 0;
            this.btnConfigurations.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(44)))), ((int)(((byte)(220)))));
            this.btnConfigurations.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(5)))), ((int)(((byte)(123)))));
            this.btnConfigurations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfigurations.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigurations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(222)))), ((int)(((byte)(225)))));
            this.btnConfigurations.Image = global::Project_Management_Tool.Properties.Resources.gear_dark;
            this.btnConfigurations.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfigurations.Location = new System.Drawing.Point(0, 354);
            this.btnConfigurations.Name = "btnConfigurations";
            this.btnConfigurations.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnConfigurations.Size = new System.Drawing.Size(200, 40);
            this.btnConfigurations.TabIndex = 7;
            this.btnConfigurations.Tag = "Configuration";
            this.btnConfigurations.Text = " Configurations";
            this.btnConfigurations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfigurations.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfigurations.UseVisualStyleBackColor = false;
            this.btnConfigurations.Click += new System.EventHandler(this.btnConfigurations_Click);
            // 
            // btnIdeas
            // 
            this.btnIdeas.BackColor = System.Drawing.Color.Transparent;
            this.btnIdeas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIdeas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIdeas.FlatAppearance.BorderSize = 0;
            this.btnIdeas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(44)))), ((int)(((byte)(220)))));
            this.btnIdeas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(5)))), ((int)(((byte)(123)))));
            this.btnIdeas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIdeas.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIdeas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(222)))), ((int)(((byte)(225)))));
            this.btnIdeas.Image = global::Project_Management_Tool.Properties.Resources.light_on_dark;
            this.btnIdeas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIdeas.Location = new System.Drawing.Point(0, 120);
            this.btnIdeas.Name = "btnIdeas";
            this.btnIdeas.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnIdeas.Size = new System.Drawing.Size(200, 40);
            this.btnIdeas.TabIndex = 6;
            this.btnIdeas.Tag = "Ideas";
            this.btnIdeas.Text = " Ideas";
            this.btnIdeas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIdeas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIdeas.UseVisualStyleBackColor = false;
            this.btnIdeas.Click += new System.EventHandler(this.btnIdeas_Click);
            // 
            // btnNewProject
            // 
            this.btnNewProject.BackColor = System.Drawing.Color.Transparent;
            this.btnNewProject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNewProject.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewProject.FlatAppearance.BorderSize = 0;
            this.btnNewProject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(130)))), ((int)(((byte)(173)))));
            this.btnNewProject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(124)))));
            this.btnNewProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewProject.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewProject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(222)))), ((int)(((byte)(225)))));
            this.btnNewProject.Image = global::Project_Management_Tool.Properties.Resources.add_project_dark;
            this.btnNewProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewProject.Location = new System.Drawing.Point(0, 80);
            this.btnNewProject.Name = "btnNewProject";
            this.btnNewProject.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnNewProject.Size = new System.Drawing.Size(200, 40);
            this.btnNewProject.TabIndex = 8;
            this.btnNewProject.Tag = "New Project";
            this.btnNewProject.Text = " New Project";
            this.btnNewProject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewProject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewProject.UseVisualStyleBackColor = false;
            this.btnNewProject.Click += new System.EventHandler(this.btnNewProject_Click);
            // 
            // btnMyProjects
            // 
            this.btnMyProjects.BackColor = System.Drawing.Color.Transparent;
            this.btnMyProjects.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMyProjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMyProjects.FlatAppearance.BorderSize = 0;
            this.btnMyProjects.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(130)))), ((int)(((byte)(173)))));
            this.btnMyProjects.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(124)))));
            this.btnMyProjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyProjects.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyProjects.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(222)))), ((int)(((byte)(225)))));
            this.btnMyProjects.Image = global::Project_Management_Tool.Properties.Resources.document_dark;
            this.btnMyProjects.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyProjects.Location = new System.Drawing.Point(0, 40);
            this.btnMyProjects.Name = "btnMyProjects";
            this.btnMyProjects.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnMyProjects.Size = new System.Drawing.Size(200, 40);
            this.btnMyProjects.TabIndex = 5;
            this.btnMyProjects.Tag = "My Projects";
            this.btnMyProjects.Text = " My Projects";
            this.btnMyProjects.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyProjects.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMyProjects.UseVisualStyleBackColor = false;
            this.btnMyProjects.Click += new System.EventHandler(this.btnMyProjects_Click);
            // 
            // btnAllProjects
            // 
            this.btnAllProjects.BackColor = System.Drawing.Color.Transparent;
            this.btnAllProjects.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAllProjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAllProjects.FlatAppearance.BorderSize = 0;
            this.btnAllProjects.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(187)))), ((int)(((byte)(250)))));
            this.btnAllProjects.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAllProjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllProjects.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllProjects.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(222)))), ((int)(((byte)(225)))));
            this.btnAllProjects.Image = global::Project_Management_Tool.Properties.Resources.search_folder_dark;
            this.btnAllProjects.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllProjects.Location = new System.Drawing.Point(0, 0);
            this.btnAllProjects.Name = "btnAllProjects";
            this.btnAllProjects.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnAllProjects.Size = new System.Drawing.Size(200, 40);
            this.btnAllProjects.TabIndex = 4;
            this.btnAllProjects.Tag = "All Projects";
            this.btnAllProjects.Text = " All Projects";
            this.btnAllProjects.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllProjects.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAllProjects.UseVisualStyleBackColor = false;
            this.btnAllProjects.Click += new System.EventHandler(this.btnAllProjects_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnMaximize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.MenuPanel);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button btnAllProjects;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnMyProjects;
        private System.Windows.Forms.Button btnConfigurations;
        private System.Windows.Forms.Button btnIdeas;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNewProject;
    }
}

