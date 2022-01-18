
namespace DocGen_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.шаблонToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveShablToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveShablAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openShablToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.шаблонToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(513, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // шаблонToolStripMenuItem
            // 
            this.шаблонToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateToolStripMenuItem,
            this.OpenToolStripMenuItem,
            this.saveShablToolStripMenuItem,
            this.saveShablAsToolStripMenuItem,
            this.openShablToolStripMenuItem,
            this.saveDocToolStripMenuItem});
            this.шаблонToolStripMenuItem.Name = "шаблонToolStripMenuItem";
            this.шаблонToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.шаблонToolStripMenuItem.Text = "Файл";
            // 
            // CreateToolStripMenuItem
            // 
            this.CreateToolStripMenuItem.Name = "CreateToolStripMenuItem";
            this.CreateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.CreateToolStripMenuItem.Size = new System.Drawing.Size(370, 22);
            this.CreateToolStripMenuItem.Text = "Задать шаблон для заполнения";
            this.CreateToolStripMenuItem.Click += new System.EventHandler(this.CreateToolStripMenuItem_Click);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(370, 22);
            this.OpenToolStripMenuItem.Text = "Открыть шаблон документа";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // saveShablToolStripMenuItem
            // 
            this.saveShablToolStripMenuItem.Name = "saveShablToolStripMenuItem";
            this.saveShablToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveShablToolStripMenuItem.Size = new System.Drawing.Size(370, 22);
            this.saveShablToolStripMenuItem.Text = "Сохранить шаблон для заполнения";
            this.saveShablToolStripMenuItem.Click += new System.EventHandler(this.saveShablToolStripMenuItem_Click);
            // 
            // saveShablAsToolStripMenuItem
            // 
            this.saveShablAsToolStripMenuItem.Name = "saveShablAsToolStripMenuItem";
            this.saveShablAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveShablAsToolStripMenuItem.Size = new System.Drawing.Size(370, 22);
            this.saveShablAsToolStripMenuItem.Text = "Сохранить шаблон для заполнения как";
            this.saveShablAsToolStripMenuItem.Click += new System.EventHandler(this.saveShablAsToolStripMenuItem_Click);
            // 
            // openShablToolStripMenuItem
            // 
            this.openShablToolStripMenuItem.Name = "openShablToolStripMenuItem";
            this.openShablToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.openShablToolStripMenuItem.Size = new System.Drawing.Size(370, 22);
            this.openShablToolStripMenuItem.Text = "Открыть шаблон для заполнения";
            this.openShablToolStripMenuItem.Click += new System.EventHandler(this.openShablToolStripMenuItem_Click);
            // 
            // saveDocToolStripMenuItem
            // 
            this.saveDocToolStripMenuItem.Name = "saveDocToolStripMenuItem";
            this.saveDocToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.saveDocToolStripMenuItem.Size = new System.Drawing.Size(370, 22);
            this.saveDocToolStripMenuItem.Text = "Сохранить документ";
            this.saveDocToolStripMenuItem.Click += new System.EventHandler(this.saveDocToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instrToolStripMenuItem,
            this.aboutProgramToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // instrToolStripMenuItem
            // 
            this.instrToolStripMenuItem.Name = "instrToolStripMenuItem";
            this.instrToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.instrToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.instrToolStripMenuItem.Text = "Инструкция";
            this.instrToolStripMenuItem.Click += new System.EventHandler(this.instrToolStripMenuItem_Click);
            // 
            // aboutProgramToolStripMenuItem
            // 
            this.aboutProgramToolStripMenuItem.Name = "aboutProgramToolStripMenuItem";
            this.aboutProgramToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.aboutProgramToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.aboutProgramToolStripMenuItem.Text = "О программе";
            this.aboutProgramToolStripMenuItem.Click += new System.EventHandler(this.aboutProgramToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(513, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сохранить документ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Size = new System.Drawing.Size(513, 404);
            this.splitContainer1.SplitterDistance = 375;
            this.splitContainer1.TabIndex = 3;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.AutoScroll = true;
            this.splitContainer2.Panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitContainer2.Panel1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.splitContainer2_Panel1_Scroll);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.AutoScroll = true;
            this.splitContainer2.Panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitContainer2.Panel2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.splitContainer2_Panel2_Scroll);
            this.splitContainer2.Panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.splitContainer2_Panel2_MouseMove);
            this.splitContainer2.Size = new System.Drawing.Size(513, 375);
            this.splitContainer2.SplitterDistance = 170;
            this.splitContainer2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(513, 428);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "DocGen";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem шаблонToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveShablToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveShablAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem openShablToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ToolStripMenuItem saveDocToolStripMenuItem;
    }
}

