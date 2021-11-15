
namespace Environmental_monitoring_DateBase_ADO5.Net.Forms
{
    partial class FormAddEmission
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
            this.label3 = new System.Windows.Forms.Label();
            this.FormAddEmissionlabel4 = new System.Windows.Forms.Label();
            this.textBoxAddEmission_DateEmission = new System.Windows.Forms.TextBox();
            this.textBoxAddEmission_TextEmission = new System.Windows.Forms.TextBox();
            this.textBoxAddEmission_CountEmission = new System.Windows.Forms.TextBox();
            this.buttonFormAddEmissionAdd = new System.Windows.Forms.Button();
            this.buttonFormAddEmissionCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Дата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(23, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Комментарий";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(23, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Кол-во выбросов";
            // 
            // FormAddEmissionlabel4
            // 
            this.FormAddEmissionlabel4.AutoSize = true;
            this.FormAddEmissionlabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormAddEmissionlabel4.Location = new System.Drawing.Point(23, 19);
            this.FormAddEmissionlabel4.Name = "FormAddEmissionlabel4";
            this.FormAddEmissionlabel4.Size = new System.Drawing.Size(88, 18);
            this.FormAddEmissionlabel4.TabIndex = 4;
            this.FormAddEmissionlabel4.Text = "Источник:";
            // 
            // textBoxAddEmission_DateEmission
            // 
            this.textBoxAddEmission_DateEmission.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAddEmission_DateEmission.Location = new System.Drawing.Point(26, 195);
            this.textBoxAddEmission_DateEmission.Name = "textBoxAddEmission_DateEmission";
            this.textBoxAddEmission_DateEmission.Size = new System.Drawing.Size(188, 24);
            this.textBoxAddEmission_DateEmission.TabIndex = 5;
            // 
            // textBoxAddEmission_TextEmission
            // 
            this.textBoxAddEmission_TextEmission.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAddEmission_TextEmission.Location = new System.Drawing.Point(26, 140);
            this.textBoxAddEmission_TextEmission.Name = "textBoxAddEmission_TextEmission";
            this.textBoxAddEmission_TextEmission.Size = new System.Drawing.Size(188, 24);
            this.textBoxAddEmission_TextEmission.TabIndex = 6;
            // 
            // textBoxAddEmission_CountEmission
            // 
            this.textBoxAddEmission_CountEmission.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAddEmission_CountEmission.Location = new System.Drawing.Point(26, 76);
            this.textBoxAddEmission_CountEmission.Name = "textBoxAddEmission_CountEmission";
            this.textBoxAddEmission_CountEmission.Size = new System.Drawing.Size(188, 24);
            this.textBoxAddEmission_CountEmission.TabIndex = 7;
            // 
            // buttonFormAddEmissionAdd
            // 
            this.buttonFormAddEmissionAdd.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonFormAddEmissionAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonFormAddEmissionAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFormAddEmissionAdd.Location = new System.Drawing.Point(49, 236);
            this.buttonFormAddEmissionAdd.Name = "buttonFormAddEmissionAdd";
            this.buttonFormAddEmissionAdd.Size = new System.Drawing.Size(137, 35);
            this.buttonFormAddEmissionAdd.TabIndex = 8;
            this.buttonFormAddEmissionAdd.Text = "Добавить";
            this.buttonFormAddEmissionAdd.UseVisualStyleBackColor = false;
            // 
            // buttonFormAddEmissionCancel
            // 
            this.buttonFormAddEmissionCancel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonFormAddEmissionCancel.DialogResult = System.Windows.Forms.DialogResult.No;
            this.buttonFormAddEmissionCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFormAddEmissionCancel.Location = new System.Drawing.Point(233, 236);
            this.buttonFormAddEmissionCancel.Name = "buttonFormAddEmissionCancel";
            this.buttonFormAddEmissionCancel.Size = new System.Drawing.Size(137, 35);
            this.buttonFormAddEmissionCancel.TabIndex = 9;
            this.buttonFormAddEmissionCancel.Text = "Отменить";
            this.buttonFormAddEmissionCancel.UseVisualStyleBackColor = false;
            // 
            // FormAddEmission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 292);
            this.Controls.Add(this.buttonFormAddEmissionCancel);
            this.Controls.Add(this.buttonFormAddEmissionAdd);
            this.Controls.Add(this.textBoxAddEmission_CountEmission);
            this.Controls.Add(this.textBoxAddEmission_TextEmission);
            this.Controls.Add(this.textBoxAddEmission_DateEmission);
            this.Controls.Add(this.FormAddEmissionlabel4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAddEmission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить выбросы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBoxAddEmission_DateEmission;
        public System.Windows.Forms.TextBox textBoxAddEmission_TextEmission;
        public System.Windows.Forms.TextBox textBoxAddEmission_CountEmission;
        private System.Windows.Forms.Button buttonFormAddEmissionAdd;
        private System.Windows.Forms.Button buttonFormAddEmissionCancel;
        public System.Windows.Forms.Label FormAddEmissionlabel4;
    }
}