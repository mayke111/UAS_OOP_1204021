﻿namespace UAS_OOP_1204021
{
    partial class FormViewDaftarUlang
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
            this.dgDU = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgDU)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDU
            // 
            this.dgDU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDU.Location = new System.Drawing.Point(73, 44);
            this.dgDU.Name = "dgDU";
            this.dgDU.Size = new System.Drawing.Size(551, 396);
            this.dgDU.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Form View Data Daftar Ulang";
            // 
            // FormViewDaftarUlang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 438);
            this.Controls.Add(this.dgDU);
            this.Controls.Add(this.label1);
            this.Name = "FormViewDaftarUlang";
            this.Text = "FormViewDaftarUlang";
            this.Load += new System.EventHandler(this.FormViewDaftarUlang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDU;
        private System.Windows.Forms.Label label1;
    }
}