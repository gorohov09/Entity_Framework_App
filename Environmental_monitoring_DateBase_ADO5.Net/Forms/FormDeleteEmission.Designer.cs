
namespace Environmental_monitoring_DateBase_ADO5.Net.Forms
{
    partial class FormDeleteEmission
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
            this.FormDeleteEmissionlabel3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonFormDeleteEmissionNo = new System.Windows.Forms.Button();
            this.buttonFormDeleteEmissionYes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FormDeleteEmissionlabel3
            // 
            this.FormDeleteEmissionlabel3.AutoSize = true;
            this.FormDeleteEmissionlabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormDeleteEmissionlabel3.Location = new System.Drawing.Point(19, 68);
            this.FormDeleteEmissionlabel3.Name = "FormDeleteEmissionlabel3";
            this.FormDeleteEmissionlabel3.Size = new System.Drawing.Size(52, 18);
            this.FormDeleteEmissionlabel3.TabIndex = 8;
            this.FormDeleteEmissionlabel3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(19, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(364, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Вы действительно хотите удалить выбросы?";
            // 
            // buttonFormDeleteEmissionNo
            // 
            this.buttonFormDeleteEmissionNo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonFormDeleteEmissionNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.buttonFormDeleteEmissionNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFormDeleteEmissionNo.Location = new System.Drawing.Point(206, 122);
            this.buttonFormDeleteEmissionNo.Name = "buttonFormDeleteEmissionNo";
            this.buttonFormDeleteEmissionNo.Size = new System.Drawing.Size(137, 35);
            this.buttonFormDeleteEmissionNo.TabIndex = 11;
            this.buttonFormDeleteEmissionNo.Text = "Нет";
            this.buttonFormDeleteEmissionNo.UseVisualStyleBackColor = false;
            // 
            // buttonFormDeleteEmissionYes
            // 
            this.buttonFormDeleteEmissionYes.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonFormDeleteEmissionYes.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonFormDeleteEmissionYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFormDeleteEmissionYes.Location = new System.Drawing.Point(35, 122);
            this.buttonFormDeleteEmissionYes.Name = "buttonFormDeleteEmissionYes";
            this.buttonFormDeleteEmissionYes.Size = new System.Drawing.Size(137, 35);
            this.buttonFormDeleteEmissionYes.TabIndex = 12;
            this.buttonFormDeleteEmissionYes.Text = "Да";
            this.buttonFormDeleteEmissionYes.UseVisualStyleBackColor = false;
            // 
            // FormDeleteEmission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 197);
            this.Controls.Add(this.buttonFormDeleteEmissionYes);
            this.Controls.Add(this.buttonFormDeleteEmissionNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FormDeleteEmissionlabel3);
            this.Name = "FormDeleteEmission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDeleteEmission";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonFormDeleteEmissionNo;
        private System.Windows.Forms.Button buttonFormDeleteEmissionYes;
        public System.Windows.Forms.Label FormDeleteEmissionlabel3;
    }
}