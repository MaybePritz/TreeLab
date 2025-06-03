namespace TreeLab
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menu_aboutBtn = new System.Windows.Forms.ToolStripButton();
            this.menu_taskBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.taskBtn_create = new System.Windows.Forms.ToolStripMenuItem();
            this.taskBtn_mainTask = new System.Windows.Forms.ToolStripMenuItem();
            this.taskBtn_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_exitBtn = new System.Windows.Forms.ToolStripButton();
            this.panel = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_aboutBtn,
            this.menu_taskBtn,
            this.menu_exitBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1600, 42);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menu_aboutBtn
            // 
            this.menu_aboutBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menu_aboutBtn.Image = ((System.Drawing.Image)(resources.GetObject("menu_aboutBtn.Image")));
            this.menu_aboutBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menu_aboutBtn.Name = "menu_aboutBtn";
            this.menu_aboutBtn.Size = new System.Drawing.Size(167, 36);
            this.menu_aboutBtn.Text = "О программе";
            this.menu_aboutBtn.Click += new System.EventHandler(this.menu_aboutBtn_Click);
            // 
            // menu_taskBtn
            // 
            this.menu_taskBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menu_taskBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taskBtn_create,
            this.taskBtn_mainTask,
            this.taskBtn_delete});
            this.menu_taskBtn.Image = ((System.Drawing.Image)(resources.GetObject("menu_taskBtn.Image")));
            this.menu_taskBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menu_taskBtn.Name = "menu_taskBtn";
            this.menu_taskBtn.Size = new System.Drawing.Size(126, 36);
            this.menu_taskBtn.Text = "Задания";
            this.menu_taskBtn.Click += new System.EventHandler(this.menu_taskBtn_Click);
            // 
            // taskBtn_create
            // 
            this.taskBtn_create.Name = "taskBtn_create";
            this.taskBtn_create.Size = new System.Drawing.Size(421, 44);
            this.taskBtn_create.Text = "Создание дерева";
            this.taskBtn_create.Click += new System.EventHandler(this.taskBtn_create_Click);
            // 
            // taskBtn_mainTask
            // 
            this.taskBtn_mainTask.Name = "taskBtn_mainTask";
            this.taskBtn_mainTask.Size = new System.Drawing.Size(421, 44);
            this.taskBtn_mainTask.Text = "Преобразование дерева";
            this.taskBtn_mainTask.Click += new System.EventHandler(this.taskBtn_mainTask_Click);
            // 
            // taskBtn_delete
            // 
            this.taskBtn_delete.Name = "taskBtn_delete";
            this.taskBtn_delete.Size = new System.Drawing.Size(421, 44);
            this.taskBtn_delete.Text = "Разрушение дерева";
            this.taskBtn_delete.Click += new System.EventHandler(this.taskBtn_delete_Click);
            // 
            // menu_exitBtn
            // 
            this.menu_exitBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menu_exitBtn.Image = ((System.Drawing.Image)(resources.GetObject("menu_exitBtn.Image")));
            this.menu_exitBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menu_exitBtn.Name = "menu_exitBtn";
            this.menu_exitBtn.Size = new System.Drawing.Size(87, 36);
            this.menu_exitBtn.Text = "Выход";
            this.menu_exitBtn.Click += new System.EventHandler(this.menu_exitBtn_Click);
            // 
            // panel
            // 
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 42);
            this.panel.Margin = new System.Windows.Forms.Padding(0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1600, 823);
            this.panel.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MinimumSize = new System.Drawing.Size(1606, 875);
            this.Name = "Main";
            this.Text = "TreeLab";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton menu_aboutBtn;
        private System.Windows.Forms.ToolStripButton menu_exitBtn;
        private System.Windows.Forms.ToolStripDropDownButton menu_taskBtn;
        private System.Windows.Forms.ToolStripMenuItem taskBtn_create;
        private System.Windows.Forms.ToolStripMenuItem taskBtn_mainTask;
        private System.Windows.Forms.ToolStripMenuItem taskBtn_delete;
        private System.Windows.Forms.Panel panel;
    }
}

