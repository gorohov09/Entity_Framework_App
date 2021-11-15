
namespace Environmental_monitoring_DateBase_ADO5.Net.Forms
{
    partial class FormDeleteSource
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
            this.label4 = new System.Windows.Forms.Label();
            this.FormDeleteSourcelabel2 = new System.Windows.Forms.Label();
            this.buttonFormDeleteSourceNo = new System.Windows.Forms.Button();
            this.buttonFormDeleteSourceYes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(26, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 18);
            this.label4.TabIndex = 5;
            // 
            // FormDeleteSourcelabel2
            // 
            this.FormDeleteSourcelabel2.AutoSize = true;
            this.FormDeleteSourcelabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormDeleteSourcelabel2.Location = new System.Drawing.Point(26, 64);
            this.FormDeleteSourcelabel2.Name = "FormDeleteSourcelabel2";
            this.FormDeleteSourcelabel2.Size = new System.Drawing.Size(52, 18);
            this.FormDeleteSourcelabel2.TabIndex = 7;
            this.FormDeleteSourcelabel2.Text = "label2";
            // 
            // buttonFormDeleteSourceNo
            // 
            this.buttonFormDeleteSourceNo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonFormDeleteSourceNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.buttonFormDeleteSourceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFormDeleteSourceNo.Location = new System.Drawing.Point(214, 127);
            this.buttonFormDeleteSourceNo.Name = "buttonFormDeleteSourceNo";
            this.buttonFormDeleteSourceNo.Size = new System.Drawing.Size(137, 35);
            this.buttonFormDeleteSourceNo.TabIndex = 9;
            this.buttonFormDeleteSourceNo.Text = "Нет";
            this.buttonFormDeleteSourceNo.UseVisualStyleBackColor = false;
            // 
            // buttonFormDeleteSourceYes
            // 
            this.buttonFormDeleteSourceYes.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonFormDeleteSourceYes.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonFormDeleteSourceYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFormDeleteSourceYes.Location = new System.Drawing.Point(44, 127);
            this.buttonFormDeleteSourceYes.Name = "buttonFormDeleteSourceYes";
            this.buttonFormDeleteSourceYes.Size = new System.Drawing.Size(137, 35);
            this.buttonFormDeleteSourceYes.TabIndex = 10;
            this.buttonFormDeleteSourceYes.Text = "Да";
            this.buttonFormDeleteSourceYes.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Вы действительно хотите удалить источник?";
            // 
            // FormDeleteSource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 197);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonFormDeleteSourceYes);
            this.Controls.Add(this.buttonFormDeleteSourceNo);
            this.Controls.Add(this.FormDeleteSourcelabel2);
            this.Controls.Add(this.label4);
            this.Name = "FormDeleteSource";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удалить источник";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label FormDeleteSourcelabel2;
        private System.Windows.Forms.Button buttonFormDeleteSourceNo;
        private System.Windows.Forms.Button buttonFormDeleteSourceYes;
        private System.Windows.Forms.Label label1;
    }
}