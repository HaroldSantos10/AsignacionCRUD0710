﻿
namespace AsignacionCRUD0710
{
    partial class frMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.televisorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarRegistrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capturarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.televisorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.testToolStripMenuItem.Text = "Test";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // televisorToolStripMenuItem
            // 
            this.televisorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarRegistrosToolStripMenuItem,
            this.capturarDatosToolStripMenuItem});
            this.televisorToolStripMenuItem.Name = "televisorToolStripMenuItem";
            this.televisorToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.televisorToolStripMenuItem.Text = "Televisor";
            // 
            // mostrarRegistrosToolStripMenuItem
            // 
            this.mostrarRegistrosToolStripMenuItem.Name = "mostrarRegistrosToolStripMenuItem";
            this.mostrarRegistrosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mostrarRegistrosToolStripMenuItem.Text = "Mostrar Registros";
            this.mostrarRegistrosToolStripMenuItem.Click += new System.EventHandler(this.mostrarRegistrosToolStripMenuItem_Click);
            // 
            // capturarDatosToolStripMenuItem
            // 
            this.capturarDatosToolStripMenuItem.Name = "capturarDatosToolStripMenuItem";
            this.capturarDatosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.capturarDatosToolStripMenuItem.Text = "Capturar Datos";
            this.capturarDatosToolStripMenuItem.Click += new System.EventHandler(this.capturarDatosToolStripMenuItem_Click);
            // 
            // frMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frMenu";
            this.Text = "frMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem televisorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarRegistrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capturarDatosToolStripMenuItem;
    }
}