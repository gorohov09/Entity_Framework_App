
namespace Environmental_monitoring_DateBase_ADO5.Net.Forms
{
    partial class AverageEmission
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
            this.dataGridViewAverageEmission = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAverageEmission = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAverageEmission)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAverageEmission
            // 
            this.dataGridViewAverageEmission.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridViewAverageEmission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAverageEmission.Location = new System.Drawing.Point(49, 71);
            this.dataGridViewAverageEmission.Name = "dataGridViewAverageEmission";
            this.dataGridViewAverageEmission.RowHeadersWidth = 51;
            this.dataGridViewAverageEmission.RowTemplate.Height = 24;
            this.dataGridViewAverageEmission.Size = new System.Drawing.Size(662, 280);
            this.dataGridViewAverageEmission.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(46, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Средние выбросы";
            // 
            // buttonAverageEmission
            // 
            this.buttonAverageEmission.BackColor = System.Drawing.SystemColors.Info;
            this.buttonAverageEmission.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAverageEmission.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.buttonAverageEmission.Location = new System.Drawing.Point(280, 379);
            this.buttonAverageEmission.Name = "buttonAverageEmission";
            this.buttonAverageEmission.Size = new System.Drawing.Size(182, 40);
            this.buttonAverageEmission.TabIndex = 5;
            this.buttonAverageEmission.Text = "ОК";
            this.buttonAverageEmission.UseVisualStyleBackColor = false;
            // 
            // AverageEmission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAverageEmission);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewAverageEmission);
            this.Name = "AverageEmission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Средние выбросы";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAverageEmission)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewAverageEmission;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAverageEmission;
    }
}