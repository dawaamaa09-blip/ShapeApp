namespace ShapeApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
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
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            shapeMenu = new System.Windows.Forms.ToolStripMenuItem();
            lineMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            clearMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            гурвалжинtriangleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            тэгшӨнцөгтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            дугуйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            олонӨнцөгтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            canvasHost = new System.Windows.Forms.Panel();
            canvas = new System.Windows.Forms.PictureBox();
            муруйШугамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            canvasHost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)canvas).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { shapeMenu });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            menuStrip1.Size = new System.Drawing.Size(1063, 42);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // shapeMenu
            // 
            shapeMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { lineMenuItem, toolStripSeparator1, clearMenuItem, гурвалжинtriangleMenuItem, тэгшӨнцөгтToolStripMenuItem, дугуйToolStripMenuItem, pieToolStripMenuItem, олонӨнцөгтToolStripMenuItem, муруйШугамToolStripMenuItem });
            shapeMenu.Name = "shapeMenu";
            shapeMenu.Size = new System.Drawing.Size(78, 34);
            shapeMenu.Text = "Дүрс";
            // 
            // lineMenuItem
            // 
            lineMenuItem.Name = "lineMenuItem";
            lineMenuItem.Size = new System.Drawing.Size(315, 40);
            lineMenuItem.Text = "Шулуун";
            lineMenuItem.Click += lineMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(312, 6);
            // 
            // clearMenuItem
            // 
            clearMenuItem.Name = "clearMenuItem";
            clearMenuItem.Size = new System.Drawing.Size(315, 40);
            clearMenuItem.Text = "Цэвэрлэх";
            clearMenuItem.Click += clearMenuItem_Click;
            // 
            // гурвалжинtriangleMenuItem
            // 
            гурвалжинtriangleMenuItem.Name = "гурвалжинtriangleMenuItem";
            гурвалжинtriangleMenuItem.Size = new System.Drawing.Size(315, 40);
            гурвалжинtriangleMenuItem.Text = "Гурвалжин";
            гурвалжинtriangleMenuItem.Click += triangleMenuItem_Click;
            // 
            // тэгшӨнцөгтToolStripMenuItem
            // 
            тэгшӨнцөгтToolStripMenuItem.Name = "тэгшӨнцөгтToolStripMenuItem";
            тэгшӨнцөгтToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            тэгшӨнцөгтToolStripMenuItem.Text = "Тэгш өнцөгт";
            тэгшӨнцөгтToolStripMenuItem.Click += тэгшӨнцөгтToolStripMenuItem_Click;
            // 
            // дугуйToolStripMenuItem
            // 
            дугуйToolStripMenuItem.Name = "дугуйToolStripMenuItem";
            дугуйToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            дугуйToolStripMenuItem.Text = "Дугуй";
            дугуйToolStripMenuItem.Click += дугуйToolStripMenuItem_Click;
            // 
            // pieToolStripMenuItem
            // 
            pieToolStripMenuItem.Name = "pieToolStripMenuItem";
            pieToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            pieToolStripMenuItem.Text = "Pie";
            pieToolStripMenuItem.Click += pieToolStripMenuItem_Click;
            // 
            // олонӨнцөгтToolStripMenuItem
            // 
            олонӨнцөгтToolStripMenuItem.Name = "олонӨнцөгтToolStripMenuItem";
            олонӨнцөгтToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            олонӨнцөгтToolStripMenuItem.Text = "Олон Өнцөгт";
            олонӨнцөгтToolStripMenuItem.Click += олонӨнцөгтToolStripMenuItem_Click;
            // 
            // canvasHost
            // 
            canvasHost.Controls.Add(canvas);
            canvasHost.Dock = System.Windows.Forms.DockStyle.Fill;
            canvasHost.Location = new System.Drawing.Point(0, 42);
            canvasHost.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            canvasHost.Name = "canvasHost";
            canvasHost.Padding = new System.Windows.Forms.Padding(21, 24, 21, 24);
            canvasHost.Size = new System.Drawing.Size(1063, 838);
            canvasHost.TabIndex = 1;
            // 
            // canvas
            // 
            canvas.BackColor = System.Drawing.Color.White;
            canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            canvas.Location = new System.Drawing.Point(21, 24);
            canvas.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            canvas.Name = "canvas";
            canvas.Size = new System.Drawing.Size(1021, 790);
            canvas.TabIndex = 0;
            canvas.TabStop = false;
            canvas.Paint += canvas_Paint;
            canvas.Resize += canvas_Resize;
            // 
            // муруйШугамToolStripMenuItem
            // 
            муруйШугамToolStripMenuItem.Name = "муруйШугамToolStripMenuItem";
            муруйШугамToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            муруйШугамToolStripMenuItem.Text = "Муруй шугам";
            муруйШугамToolStripMenuItem.Click += муруйШугамToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1063, 880);
            Controls.Add(canvasHost);
            Controls.Add(menuStrip1);
            Font = new System.Drawing.Font("Segoe UI", 9F);
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            MinimumSize = new System.Drawing.Size(669, 576);
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Дасгал№2. Энгийн дүрсүүд зурах";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            canvasHost.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)canvas).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem shapeMenu;
        private System.Windows.Forms.ToolStripMenuItem lineMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem clearMenuItem;
        private System.Windows.Forms.Panel canvasHost;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.ToolStripMenuItem гурвалжинtriangleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тэгшӨнцөгтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дугуйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem олонӨнцөгтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem муруйШугамToolStripMenuItem;
    }
}
