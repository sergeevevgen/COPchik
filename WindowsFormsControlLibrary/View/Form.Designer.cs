﻿namespace View
{
    partial class Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ControlsStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ActionsToolStripMenuItem = new
            System.Windows.Forms.ToolStripMenuItem();
            this.DocsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SimpleDocToolStripMenuItem = new
            System.Windows.Forms.ToolStripMenuItem();
            this.TableDocToolStripMenuItem = new
            System.Windows.Forms.ToolStripMenuItem();
            this.ChartDocToolStripMenuItem = new
            System.Windows.Forms.ToolStripMenuItem();
            this.panelControl = new System.Windows.Forms.Panel();
            this.AddElementToolStripMenuItem = new
            System.Windows.Forms.ToolStripMenuItem();
            this.UpdElementToolStripMenuItem = new
            System.Windows.Forms.ToolStripMenuItem();
            this.DelElementToolStripMenuItem = new
            System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            //
            // menuStrip
            //
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ControlsStripMenuItem,
            this.ActionsToolStripMenuItem,
            this.DocsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "Меню";
            //
            // ControlsStripMenuItem
            //
            this.ControlsStripMenuItem.Name = "ControlsStripMenuItem";
            this.ControlsStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.ControlsStripMenuItem.Text = "Справочники";
            //
            // ActionsToolStripMenuItem
            //
            this.ActionsToolStripMenuItem.DropDownItems.AddRange(new
            System.Windows.Forms.ToolStripItem[] {
            this.AddElementToolStripMenuItem,
            this.UpdElementToolStripMenuItem,
            this.DelElementToolStripMenuItem});
            this.ActionsToolStripMenuItem.Name = "ActionsToolStripMenuItem";
            this.ActionsToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.ActionsToolStripMenuItem.Text = "Действия";
            //
            // DocsToolStripMenuItem
            //
            this.DocsToolStripMenuItem.DropDownItems.AddRange(new
            System.Windows.Forms.ToolStripItem[] {
            this.SimpleDocToolStripMenuItem,
            this.TableDocToolStripMenuItem,
            this.ChartDocToolStripMenuItem});
            this.DocsToolStripMenuItem.Name = "DocsToolStripMenuItem";
            this.DocsToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.DocsToolStripMenuItem.Text = "Документы";
            //
            // SimpleDocToolStripMenuItem
            //
            this.SimpleDocToolStripMenuItem.Name = "SimpleDocToolStripMenuItem";
            this.SimpleDocToolStripMenuItem.ShortcutKeys =
            ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control |
            System.Windows.Forms.Keys.S)));
            this.SimpleDocToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.SimpleDocToolStripMenuItem.Text = "Простой документ";
            this.SimpleDocToolStripMenuItem.Click += new
            System.EventHandler(this.SimpleDocToolStripMenuItem_Click);
            //
            // TableDocToolStripMenuItem
            //
            this.TableDocToolStripMenuItem.Name = "TableDocToolStripMenuItem";
            this.TableDocToolStripMenuItem.ShortcutKeys =
            ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control |
            System.Windows.Forms.Keys.T)));
            this.TableDocToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.TableDocToolStripMenuItem.Text = "Документ с таблицой";
            this.TableDocToolStripMenuItem.Click += new
            System.EventHandler(this.TableDocToolStripMenuItem_Click);
            //
            // ChartDocToolStripMenuItem
            //
            this.ChartDocToolStripMenuItem.Name = "ChartDocToolStripMenuItem";
            this.ChartDocToolStripMenuItem.ShortcutKeys =
            ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control |
            System.Windows.Forms.Keys.C)));
            this.ChartDocToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.ChartDocToolStripMenuItem.Text = "Диаграмма";
            this.ChartDocToolStripMenuItem.Click += new
            System.EventHandler(this.ChartDocToolStripMenuItem_Click);
            //
            // panelControl
            //
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(0, 24);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(800, 426);
            this.panelControl.TabIndex = 1;
            //
            // AddElementToolStripMenuItem
            //
            this.AddElementToolStripMenuItem.Name = "AddElementToolStripMenuItem";
            this.AddElementToolStripMenuItem.ShortcutKeys =
            ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control |
            System.Windows.Forms.Keys.A)));
            this.AddElementToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AddElementToolStripMenuItem.Text = "Добавить";
            this.AddElementToolStripMenuItem.Click += new
            System.EventHandler(this.AddElementToolStripMenuItem_Click);
            //
            // UpdElementToolStripMenuItem
            //
            this.UpdElementToolStripMenuItem.Name = "UpdElementToolStripMenuItem";
            this.UpdElementToolStripMenuItem.ShortcutKeys =
            ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control |
            System.Windows.Forms.Keys.U)));
            this.UpdElementToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.UpdElementToolStripMenuItem.Text = "Изменить";
            this.UpdElementToolStripMenuItem.Click += new
            System.EventHandler(this.UpdElementToolStripMenuItem_Click);
            //
            // DelElementToolStripMenuItem
            //
            this.DelElementToolStripMenuItem.Name = "DelElementToolStripMenuItem";
            this.DelElementToolStripMenuItem.ShortcutKeys =
            ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control |
            System.Windows.Forms.Keys.D)));
            this.DelElementToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DelElementToolStripMenuItem.Text = "Удалить";
            this.DelElementToolStripMenuItem.Click += new
            System.EventHandler(this.DelElementToolStripMenuItem_Click);
            //
            // FormMain
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная форма";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new
            System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem ControlsStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DocsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SimpleDocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TableDocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChartDocToolStripMenuItem;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.ToolStripMenuItem ActionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddElementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpdElementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DelElementToolStripMenuItem;
    }
}

