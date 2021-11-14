
namespace Environmental_monitoring_DateBase_ADO5.Net.Forms
{
    partial class FormRedactSource
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
            this.textBoxRedactSource_AdresSource = new System.Windows.Forms.TextBox();
            this.textBoxRedactSource_NameSource = new System.Windows.Forms.TextBox();
            this.buttonFormRedactSource_Cancel = new System.Windows.Forms.Button();
            this.buttonFormRedactSource_Redact = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название источника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(21, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Адрес";
            // 
            // textBoxRedactSource_AdresSource
            // 
            this.textBoxRedactSource_AdresSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRedactSource_AdresSource.Location = new System.Drawing.Point(24, 138);
            this.textBoxRedactSource_AdresSource.Name = "textBoxRedactSource_AdresSource";
            this.textBoxRedactSource_AdresSource.Size = new System.Drawing.Size(188, 24);
            this.textBoxRedactSource_AdresSource.TabIndex = 3;
            // 
            // textBoxRedactSource_NameSource
            // 
            this.textBoxRedactSource_NameSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRedactSource_NameSource.Location = new System.Drawing.Point(24, 59);
            this.textBoxRedactSource_NameSource.Name = "textBoxRedactSource_NameSource";
            this.textBoxRedactSource_NameSource.Size = new System.Drawing.Size(188, 24);
            this.textBoxRedactSource_NameSource.TabIndex = 4;
            // 
            // buttonFormRedactSource_Cancel
            // 
            this.buttonFormRedactSource_Cancel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonFormRedactSource_Cancel.DialogResult = System.Windows.Forms.DialogResult.No;
            this.buttonFormRedactSource_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFormRedactSource_Cancel.Location = new System.Drawing.Point(245, 200);
            this.buttonFormRedactSource_Cancel.Name = "buttonFormRedactSource_Cancel";
            this.buttonFormRedactSource_Cancel.Size = new System.Drawing.Size(137, 35);
            this.buttonFormRedactSource_Cancel.TabIndex = 5;
            this.buttonFormRedactSource_Cancel.Text = "Отменить";
            this.buttonFormRedactSource_Cancel.UseVisualStyleBackColor = false;
            // 
            // buttonFormRedactSource_Redact
            // 
            this.buttonFormRedactSource_Redact.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonFormRedactSource_Redact.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonFormRedactSource_Redact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFormRedactSource_Redact.Location = new System.Drawing.Point(65, 200);
            this.buttonFormRedactSource_Redact.Name = "buttonFormRedactSource_Redact";
            this.buttonFormRedactSource_Redact.Size = new System.Drawing.Size(137, 35);
            this.buttonFormRedactSource_Redact.TabIndex = 6;
            this.buttonFormRedactSource_Redact.Text = "Изменить";
            this.buttonFormRedactSource_Redact.UseVisualStyleBackColor = false;
            // 
            // FormRedactSource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 292);
            this.Controls.Add(this.buttonFormRedactSource_Redact);
            this.Controls.Add(this.buttonFormRedactSource_Cancel);
            this.Controls.Add(this.textBoxRedactSource_NameSource);
            this.Controls.Add(this.textBoxRedactSource_AdresSource);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormRedactSource";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRedactSource";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBoxRedactSource_AdresSource;
        public System.Windows.Forms.TextBox textBoxRedactSource_NameSource;
        public System.Windows.Forms.Button buttonFormRedactSource_Cancel;
        public System.Windows.Forms.Button buttonFormRedactSource_Redact;
    }
}