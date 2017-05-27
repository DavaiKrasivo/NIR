namespace Inter
{
    partial class Form1
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
            this.CreateMat = new System.Windows.Forms.Button();
            this.Number = new System.Windows.Forms.TextBox();
            this.Tabl = new System.Windows.Forms.DataGridView();
            this.ReshBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Tabl)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateMat
            // 
            this.CreateMat.Location = new System.Drawing.Point(13, 51);
            this.CreateMat.Name = "CreateMat";
            this.CreateMat.Size = new System.Drawing.Size(75, 23);
            this.CreateMat.TabIndex = 0;
            this.CreateMat.Text = "Go";
            this.CreateMat.UseVisualStyleBackColor = true;
            this.CreateMat.Click += new System.EventHandler(this.button1_Click);
            // 
            // Number
            // 
            this.Number.Location = new System.Drawing.Point(13, 13);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(75, 20);
            this.Number.TabIndex = 1;
            // 
            // Tabl
            // 
            this.Tabl.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Tabl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tabl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabl.Location = new System.Drawing.Point(426, 12);
            this.Tabl.Name = "Tabl";
            this.Tabl.Size = new System.Drawing.Size(352, 238);
            this.Tabl.TabIndex = 2;
            this.Tabl.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tabl_CellValueChanged);
            // 
            // ReshBut
            // 
            this.ReshBut.Location = new System.Drawing.Point(294, 51);
            this.ReshBut.Name = "ReshBut";
            this.ReshBut.Size = new System.Drawing.Size(75, 23);
            this.ReshBut.TabIndex = 3;
            this.ReshBut.Text = "решить";
            this.ReshBut.UseVisualStyleBackColor = true;
            this.ReshBut.Click += new System.EventHandler(this.ReshBut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "- Кол-во городов";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 262);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReshBut);
            this.Controls.Add(this.Tabl);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.CreateMat);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Tabl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateMat;
        private System.Windows.Forms.TextBox Number;
        private System.Windows.Forms.DataGridView Tabl;
        private System.Windows.Forms.Button ReshBut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

