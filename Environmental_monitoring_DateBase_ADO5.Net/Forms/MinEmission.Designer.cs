
namespace Environmental_monitoring_DateBase_ADO5.Net.Forms
{
    partial class MinEmission
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
            this.dataGridViewMinEmission = new System.Windows.Forms.DataGridView();
            this.buttonMinEmission = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMinEmission)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(46, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Минимальные выбросы";
            // 
            // dataGridViewMinEmission
            // 
            this.dataGridViewMinEmission.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridViewMinEmission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMinEmission.Location = new System.Drawing.Point(49, 71);
            this.dataGridViewMinEmission.Name = "dataGridViewMinEmission";
            this.dataGridViewMinEmission.RowHeadersWidth = 51;
            this.dataGridViewMinEmission.RowTemplate.Height = 24;
            this.dataGridViewMinEmission.Size = new System.Drawing.Size(662, 280);
            this.dataGridViewMinEmission.TabIndex = 1;
            // 
            // buttonMinEmission
            // 
            this.buttonMinEmission.BackColor = System.Drawing.SystemColors.Info;
            this.buttonMinEmission.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonMinEmission.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.buttonMinEmission.Location = new System.Drawing.Point(280, 379);
            this.buttonMinEmission.Name = "buttonMinEmission";
            this.buttonMinEmission.Size = new System.Drawing.Size(182, 40);
            this.buttonMinEmission.TabIndex = 2;
            this.buttonMinEmission.Text = "ОК";
            this.buttonMinEmission.UseVisualStyleBackColor = false;
            // 
            // MinEmission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonMinEmission);
            this.Controls.Add(this.dataGridViewMinEmission);
            this.Controls.Add(this.label1);
            this.Name = "MinEmission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MinEmission";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMinEmission)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMinEmission;
        public System.Windows.Forms.DataGridView dataGridViewMinEmission;
    }
}