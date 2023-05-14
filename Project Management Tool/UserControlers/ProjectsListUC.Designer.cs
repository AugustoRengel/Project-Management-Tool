namespace Project_Management_Tool.UserControlers
{
    partial class ProjectsListUC
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBoxPage = new System.Windows.Forms.TextBox();
            this.lblTotalPages = new System.Windows.Forms.Label();
            this.btnPreviusPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.FlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.TopBarPanel = new System.Windows.Forms.Panel();
            this.DividerBar = new System.Windows.Forms.Panel();
            this.TopBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxPage
            // 
            this.txtBoxPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.txtBoxPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxPage.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(222)))), ((int)(((byte)(225)))));
            this.txtBoxPage.Location = new System.Drawing.Point(464, 8);
            this.txtBoxPage.Name = "txtBoxPage";
            this.txtBoxPage.Size = new System.Drawing.Size(42, 26);
            this.txtBoxPage.TabIndex = 8;
            this.txtBoxPage.Text = "1";
            this.txtBoxPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotalPages
            // 
            this.lblTotalPages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalPages.AutoSize = true;
            this.lblTotalPages.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(222)))), ((int)(((byte)(225)))));
            this.lblTotalPages.Location = new System.Drawing.Point(512, 10);
            this.lblTotalPages.Name = "lblTotalPages";
            this.lblTotalPages.Size = new System.Drawing.Size(54, 19);
            this.lblTotalPages.TabIndex = 7;
            this.lblTotalPages.Text = "/ 100";
            // 
            // btnPreviusPage
            // 
            this.btnPreviusPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreviusPage.BackColor = System.Drawing.Color.Transparent;
            this.btnPreviusPage.BackgroundImage = global::Project_Management_Tool.Properties.Resources.previus_page_dark;
            this.btnPreviusPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPreviusPage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(222)))), ((int)(((byte)(225)))));
            this.btnPreviusPage.FlatAppearance.BorderSize = 0;
            this.btnPreviusPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(44)))), ((int)(((byte)(220)))));
            this.btnPreviusPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(5)))), ((int)(((byte)(123)))));
            this.btnPreviusPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreviusPage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPreviusPage.Location = new System.Drawing.Point(433, 8);
            this.btnPreviusPage.Name = "btnPreviusPage";
            this.btnPreviusPage.Size = new System.Drawing.Size(25, 25);
            this.btnPreviusPage.TabIndex = 6;
            this.btnPreviusPage.UseVisualStyleBackColor = false;
            // 
            // btnNextPage
            // 
            this.btnNextPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextPage.BackColor = System.Drawing.Color.Transparent;
            this.btnNextPage.BackgroundImage = global::Project_Management_Tool.Properties.Resources.next_page_dark;
            this.btnNextPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNextPage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(222)))), ((int)(((byte)(225)))));
            this.btnNextPage.FlatAppearance.BorderSize = 0;
            this.btnNextPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(44)))), ((int)(((byte)(220)))));
            this.btnNextPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(5)))), ((int)(((byte)(123)))));
            this.btnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextPage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNextPage.Location = new System.Drawing.Point(572, 8);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(25, 25);
            this.btnNextPage.TabIndex = 5;
            this.btnNextPage.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImage = global::Project_Management_Tool.Properties.Resources.search_dark;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(222)))), ((int)(((byte)(225)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(44)))), ((int)(((byte)(220)))));
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(5)))), ((int)(((byte)(123)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearch.Location = new System.Drawing.Point(334, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(25, 25);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.txtBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(222)))), ((int)(((byte)(225)))));
            this.txtBoxSearch.Location = new System.Drawing.Point(8, 8);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(320, 23);
            this.txtBoxSearch.TabIndex = 0;
            // 
            // FlowLayoutPanel
            // 
            this.FlowLayoutPanel.AutoScroll = true;
            this.FlowLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.FlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowLayoutPanel.Location = new System.Drawing.Point(0, 47);
            this.FlowLayoutPanel.Name = "FlowLayoutPanel";
            this.FlowLayoutPanel.Size = new System.Drawing.Size(600, 353);
            this.FlowLayoutPanel.TabIndex = 4;
            // 
            // TopBarPanel
            // 
            this.TopBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.TopBarPanel.Controls.Add(this.txtBoxPage);
            this.TopBarPanel.Controls.Add(this.lblTotalPages);
            this.TopBarPanel.Controls.Add(this.btnPreviusPage);
            this.TopBarPanel.Controls.Add(this.btnNextPage);
            this.TopBarPanel.Controls.Add(this.btnSearch);
            this.TopBarPanel.Controls.Add(this.txtBoxSearch);
            this.TopBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBarPanel.Location = new System.Drawing.Point(0, 0);
            this.TopBarPanel.Name = "TopBarPanel";
            this.TopBarPanel.Size = new System.Drawing.Size(600, 39);
            this.TopBarPanel.TabIndex = 3;
            // 
            // DividerBar
            // 
            this.DividerBar.BackColor = System.Drawing.Color.Black;
            this.DividerBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.DividerBar.Location = new System.Drawing.Point(0, 39);
            this.DividerBar.Name = "DividerBar";
            this.DividerBar.Size = new System.Drawing.Size(600, 8);
            this.DividerBar.TabIndex = 5;
            // 
            // ProjectsListUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FlowLayoutPanel);
            this.Controls.Add(this.DividerBar);
            this.Controls.Add(this.TopBarPanel);
            this.Name = "ProjectsListUC";
            this.Size = new System.Drawing.Size(600, 400);
            this.TopBarPanel.ResumeLayout(false);
            this.TopBarPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxPage;
        private System.Windows.Forms.Label lblTotalPages;
        private System.Windows.Forms.Button btnPreviusPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel;
        private System.Windows.Forms.Panel TopBarPanel;
        private System.Windows.Forms.Panel DividerBar;
    }
}
