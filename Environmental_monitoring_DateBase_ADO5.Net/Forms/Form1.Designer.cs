
namespace Environmental_monitoring_DateBase_ADO5.Net
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewSource = new System.Windows.Forms.DataGridView();
            this.dataGridViewEmission = new System.Windows.Forms.DataGridView();
            this.buttonAddSource = new System.Windows.Forms.Button();
            this.buttonDelteEmission = new System.Windows.Forms.Button();
            this.buttonAddEmission = new System.Windows.Forms.Button();
            this.buttonRedactSource = new System.Windows.Forms.Button();
            this.buttonDeleteSource = new System.Windows.Forms.Button();
            this.buttonRedactEmission = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.источникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выбросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.минимальныеВыбросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.максимальныеВыбросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.средниеВыбросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmission)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(23, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Источник выбросов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(23, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Выбросы";
            // 
            // dataGridViewSource
            // 
            this.dataGridViewSource.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridViewSource.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewSource.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridViewSource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSource.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewSource.Location = new System.Drawing.Point(28, 78);
            this.dataGridViewSource.Name = "dataGridViewSource";
            this.dataGridViewSource.RowHeadersWidth = 51;
            this.dataGridViewSource.RowTemplate.Height = 24;
            this.dataGridViewSource.Size = new System.Drawing.Size(713, 259);
            this.dataGridViewSource.TabIndex = 2;
            // 
            // dataGridViewEmission
            // 
            this.dataGridViewEmission.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridViewEmission.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewEmission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmission.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewEmission.Location = new System.Drawing.Point(28, 389);
            this.dataGridViewEmission.Name = "dataGridViewEmission";
            this.dataGridViewEmission.RowHeadersWidth = 51;
            this.dataGridViewEmission.RowTemplate.Height = 24;
            this.dataGridViewEmission.Size = new System.Drawing.Size(713, 244);
            this.dataGridViewEmission.TabIndex = 3;
            // 
            // buttonAddSource
            // 
            this.buttonAddSource.BackColor = System.Drawing.SystemColors.Info;
            this.buttonAddSource.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddSource.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddSource.ForeColor = System.Drawing.SystemColors.MenuText;
            this.buttonAddSource.Location = new System.Drawing.Point(811, 88);
            this.buttonAddSource.Name = "buttonAddSource";
            this.buttonAddSource.Size = new System.Drawing.Size(259, 47);
            this.buttonAddSource.TabIndex = 4;
            this.buttonAddSource.Text = "Добавить источник";
            this.buttonAddSource.UseVisualStyleBackColor = false;
            // 
            // buttonDelteEmission
            // 
            this.buttonDelteEmission.BackColor = System.Drawing.SystemColors.Info;
            this.buttonDelteEmission.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelteEmission.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelteEmission.ForeColor = System.Drawing.SystemColors.MenuText;
            this.buttonDelteEmission.Location = new System.Drawing.Point(811, 491);
            this.buttonDelteEmission.Name = "buttonDelteEmission";
            this.buttonDelteEmission.Size = new System.Drawing.Size(259, 47);
            this.buttonDelteEmission.TabIndex = 5;
            this.buttonDelteEmission.Text = "Удалить выбросы";
            this.buttonDelteEmission.UseVisualStyleBackColor = false;
            // 
            // buttonAddEmission
            // 
            this.buttonAddEmission.BackColor = System.Drawing.SystemColors.Info;
            this.buttonAddEmission.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddEmission.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddEmission.ForeColor = System.Drawing.SystemColors.MenuText;
            this.buttonAddEmission.Location = new System.Drawing.Point(811, 417);
            this.buttonAddEmission.Name = "buttonAddEmission";
            this.buttonAddEmission.Size = new System.Drawing.Size(259, 47);
            this.buttonAddEmission.TabIndex = 6;
            this.buttonAddEmission.Text = "Добавить выбросы";
            this.buttonAddEmission.UseVisualStyleBackColor = false;
            // 
            // buttonRedactSource
            // 
            this.buttonRedactSource.BackColor = System.Drawing.SystemColors.Info;
            this.buttonRedactSource.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRedactSource.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRedactSource.ForeColor = System.Drawing.SystemColors.MenuText;
            this.buttonRedactSource.Location = new System.Drawing.Point(811, 238);
            this.buttonRedactSource.Name = "buttonRedactSource";
            this.buttonRedactSource.Size = new System.Drawing.Size(259, 47);
            this.buttonRedactSource.TabIndex = 7;
            this.buttonRedactSource.Text = "Редактировать источник";
            this.buttonRedactSource.UseVisualStyleBackColor = false;
            // 
            // buttonDeleteSource
            // 
            this.buttonDeleteSource.BackColor = System.Drawing.SystemColors.Info;
            this.buttonDeleteSource.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDeleteSource.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteSource.ForeColor = System.Drawing.SystemColors.MenuText;
            this.buttonDeleteSource.Location = new System.Drawing.Point(811, 165);
            this.buttonDeleteSource.Name = "buttonDeleteSource";
            this.buttonDeleteSource.Size = new System.Drawing.Size(259, 47);
            this.buttonDeleteSource.TabIndex = 8;
            this.buttonDeleteSource.Text = "Удалить источник";
            this.buttonDeleteSource.UseVisualStyleBackColor = false;
            // 
            // buttonRedactEmission
            // 
            this.buttonRedactEmission.BackColor = System.Drawing.SystemColors.Info;
            this.buttonRedactEmission.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRedactEmission.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRedactEmission.ForeColor = System.Drawing.SystemColors.MenuText;
            this.buttonRedactEmission.Location = new System.Drawing.Point(811, 562);
            this.buttonRedactEmission.Name = "buttonRedactEmission";
            this.buttonRedactEmission.Size = new System.Drawing.Size(259, 47);
            this.buttonRedactEmission.TabIndex = 9;
            this.buttonRedactEmission.Text = "Редактировать выбросы";
            this.buttonRedactEmission.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button1.Location = new System.Drawing.Point(583, 658);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 47);
            this.button1.TabIndex = 10;
            this.button1.Text = "Средние выбросы";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Info;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button2.Location = new System.Drawing.Point(303, 658);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(254, 47);
            this.button2.TabIndex = 11;
            this.button2.Text = "Максимальные выбросы";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Info;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button3.Location = new System.Drawing.Point(28, 658);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(242, 47);
            this.button3.TabIndex = 12;
            this.button3.Text = "Минимальные выбросы";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.источникToolStripMenuItem,
            this.выбросыToolStripMenuItem,
            this.расчетToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1158, 30);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // источникToolStripMenuItem
            // 
            this.источникToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.редактироватьToolStripMenuItem});
            this.источникToolStripMenuItem.Name = "источникToolStripMenuItem";
            this.источникToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.источникToolStripMenuItem.Text = "Источник";
            // 
            // выбросыToolStripMenuItem
            // 
            this.выбросыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem1,
            this.удалитьToolStripMenuItem1,
            this.редактироватьToolStripMenuItem1});
            this.выбросыToolStripMenuItem.Name = "выбросыToolStripMenuItem";
            this.выбросыToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.выбросыToolStripMenuItem.Text = "Выбросы";
            // 
            // расчетToolStripMenuItem
            // 
            this.расчетToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.минимальныеВыбросыToolStripMenuItem,
            this.максимальныеВыбросыToolStripMenuItem,
            this.средниеВыбросыToolStripMenuItem});
            this.расчетToolStripMenuItem.Name = "расчетToolStripMenuItem";
            this.расчетToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.расчетToolStripMenuItem.Text = "Расчет";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            // 
            // добавитьToolStripMenuItem1
            // 
            this.добавитьToolStripMenuItem1.Name = "добавитьToolStripMenuItem1";
            this.добавитьToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.добавитьToolStripMenuItem1.Text = "Добавить";
            // 
            // удалитьToolStripMenuItem1
            // 
            this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.удалитьToolStripMenuItem1.Text = "Удалить";
            // 
            // редактироватьToolStripMenuItem1
            // 
            this.редактироватьToolStripMenuItem1.Name = "редактироватьToolStripMenuItem1";
            this.редактироватьToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.редактироватьToolStripMenuItem1.Text = "Редактировать";
            // 
            // минимальныеВыбросыToolStripMenuItem
            // 
            this.минимальныеВыбросыToolStripMenuItem.Name = "минимальныеВыбросыToolStripMenuItem";
            this.минимальныеВыбросыToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.минимальныеВыбросыToolStripMenuItem.Text = "Минимальные выбросы";
            // 
            // максимальныеВыбросыToolStripMenuItem
            // 
            this.максимальныеВыбросыToolStripMenuItem.Name = "максимальныеВыбросыToolStripMenuItem";
            this.максимальныеВыбросыToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.максимальныеВыбросыToolStripMenuItem.Text = "Максимальные выбросы";
            // 
            // средниеВыбросыToolStripMenuItem
            // 
            this.средниеВыбросыToolStripMenuItem.Name = "средниеВыбросыToolStripMenuItem";
            this.средниеВыбросыToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.средниеВыбросыToolStripMenuItem.Text = "Средние выбросы";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1158, 733);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonRedactEmission);
            this.Controls.Add(this.buttonDeleteSource);
            this.Controls.Add(this.buttonRedactSource);
            this.Controls.Add(this.buttonAddEmission);
            this.Controls.Add(this.buttonDelteEmission);
            this.Controls.Add(this.buttonAddSource);
            this.Controls.Add(this.dataGridViewEmission);
            this.Controls.Add(this.dataGridViewSource);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Программа мониторинга окружающей среды";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmission)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewSource;
        private System.Windows.Forms.DataGridView dataGridViewEmission;
        private System.Windows.Forms.Button buttonAddSource;
        private System.Windows.Forms.Button buttonDelteEmission;
        private System.Windows.Forms.Button buttonAddEmission;
        private System.Windows.Forms.Button buttonRedactSource;
        private System.Windows.Forms.Button buttonDeleteSource;
        private System.Windows.Forms.Button buttonRedactEmission;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem источникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выбросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem расчетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem минимальныеВыбросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem максимальныеВыбросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem средниеВыбросыToolStripMenuItem;
    }
}

