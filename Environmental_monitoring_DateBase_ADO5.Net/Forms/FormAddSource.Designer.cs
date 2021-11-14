
namespace Environmental_monitoring_DateBase_ADO5.Net
{
    partial class FormAddSource
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAddSource_NameSource = new System.Windows.Forms.TextBox();
            this.textBoxAddSource_AdresSource = new System.Windows.Forms.TextBox();
            this.buttonFormAddSource_Add = new System.Windows.Forms.Button();
            this.buttonFormAddSource_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название источника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(21, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Адрес";
            // 
            // textBoxAddSource_NameSource
            // 
            this.textBoxAddSource_NameSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAddSource_NameSource.Location = new System.Drawing.Point(24, 59);
            this.textBoxAddSource_NameSource.Name = "textBoxAddSource_NameSource";
            this.textBoxAddSource_NameSource.Size = new System.Drawing.Size(188, 24);
            this.textBoxAddSource_NameSource.TabIndex = 2;
            // 
            // textBoxAddSource_AdresSource
            // 
            this.textBoxAddSource_AdresSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAddSource_AdresSource.Location = new System.Drawing.Point(24, 138);
            this.textBoxAddSource_AdresSource.Name = "textBoxAddSource_AdresSource";
            this.textBoxAddSource_AdresSource.Size = new System.Drawing.Size(188, 24);
            this.textBoxAddSource_AdresSource.TabIndex = 3;
            // 
            // buttonFormAddSource_Add
            // 
            this.buttonFormAddSource_Add.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonFormAddSource_Add.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonFormAddSource_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFormAddSource_Add.Location = new System.Drawing.Point(65, 200);
            this.buttonFormAddSource_Add.Name = "buttonFormAddSource_Add";
            this.buttonFormAddSource_Add.Size = new System.Drawing.Size(137, 35);
            this.buttonFormAddSource_Add.TabIndex = 4;
            this.buttonFormAddSource_Add.Text = "Добавить";
            this.buttonFormAddSource_Add.UseVisualStyleBackColor = false;
            // 
            // buttonFormAddSource_Cancel
            // 
            this.buttonFormAddSource_Cancel.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonFormAddSource_Cancel.DialogResult = System.Windows.Forms.DialogResult.No;
            this.buttonFormAddSource_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFormAddSource_Cancel.Location = new System.Drawing.Point(245, 200);
            this.buttonFormAddSource_Cancel.Name = "buttonFormAddSource_Cancel";
            this.buttonFormAddSource_Cancel.Size = new System.Drawing.Size(137, 35);
            this.buttonFormAddSource_Cancel.TabIndex = 5;
            this.buttonFormAddSource_Cancel.Text = "Отменить";
            this.buttonFormAddSource_Cancel.UseVisualStyleBackColor = false;
            // 
            // FormAddSource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 292);
            this.Controls.Add(this.buttonFormAddSource_Cancel);
            this.Controls.Add(this.buttonFormAddSource_Add);
            this.Controls.Add(this.textBoxAddSource_AdresSource);
            this.Controls.Add(this.textBoxAddSource_NameSource);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAddSource";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить источник";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonFormAddSource_Add;
        private System.Windows.Forms.Button buttonFormAddSource_Cancel;
        public System.Windows.Forms.TextBox textBoxAddSource_NameSource;
        public System.Windows.Forms.TextBox textBoxAddSource_AdresSource;
    }
}