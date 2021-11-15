
namespace Environmental_monitoring_DateBase_ADO5.Net.Forms
{
    partial class MaxEmission
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
            this.dataGridViewMaxEmission = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMaxEmission = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaxEmission)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMaxEmission
            // 
            this.dataGridViewMaxEmission.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridViewMaxEmission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMaxEmission.Location = new System.Drawing.Point(49, 71);
            this.dataGridViewMaxEmission.Name = "dataGridViewMaxEmission";
            this.dataGridViewMaxEmission.RowHeadersWidth = 51;
            this.dataGridViewMaxEmission.RowTemplate.Height = 24;
            this.dataGridViewMaxEmission.Size = new System.Drawing.Size(662, 280);
            this.dataGridViewMaxEmission.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(46, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Максимальные выбросы";
            // 
            // buttonMaxEmission
            // 
            this.buttonMaxEmission.BackColor = System.Drawing.SystemColors.Info;
            this.buttonMaxEmission.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonMaxEmission.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.buttonMaxEmission.Location = new System.Drawing.Point(280, 379);
            this.buttonMaxEmission.Name = "buttonMaxEmission";
            this.buttonMaxEmission.Size = new System.Drawing.Size(182, 40);
            this.buttonMaxEmission.TabIndex = 4;
            this.buttonMaxEmission.Text = "ОК";
            this.buttonMaxEmission.UseVisualStyleBackColor = false;
            // 
            // MaxEmission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonMaxEmission);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewMaxEmission);
            this.Name = "MaxEmission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Максимальные выбросы";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaxEmission)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewMaxEmission;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMaxEmission;
    }
}