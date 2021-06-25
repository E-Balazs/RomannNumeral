namespace Rómaiváltó
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
            this.BT_Merre = new System.Windows.Forms.Button();
            this.BT_Vált = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_A = new System.Windows.Forms.TextBox();
            this.TB_R = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BT_Merre
            // 
            this.BT_Merre.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BT_Merre.Location = new System.Drawing.Point(220, 90);
            this.BT_Merre.Name = "BT_Merre";
            this.BT_Merre.Size = new System.Drawing.Size(75, 58);
            this.BT_Merre.TabIndex = 0;
            this.BT_Merre.Text = "→";
            this.BT_Merre.UseVisualStyleBackColor = true;
            this.BT_Merre.Click += new System.EventHandler(this.BT_Merre_Click);
            // 
            // BT_Vált
            // 
            this.BT_Vált.Location = new System.Drawing.Point(220, 180);
            this.BT_Vált.Name = "BT_Vált";
            this.BT_Vált.Size = new System.Drawing.Size(75, 38);
            this.BT_Vált.TabIndex = 1;
            this.BT_Vált.Text = "Vált";
            this.BT_Vált.UseVisualStyleBackColor = true;
            this.BT_Vált.Click += new System.EventHandler(this.BT_Vált_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(62, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Arab";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(405, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Római";
            // 
            // TB_A
            // 
            this.TB_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TB_A.Location = new System.Drawing.Point(16, 126);
            this.TB_A.Name = "TB_A";
            this.TB_A.Size = new System.Drawing.Size(198, 30);
            this.TB_A.TabIndex = 4;
            this.TB_A.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_A_KeyPress);
            // 
            // TB_R
            // 
            this.TB_R.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TB_R.Location = new System.Drawing.Point(301, 126);
            this.TB_R.Name = "TB_R";
            this.TB_R.Size = new System.Drawing.Size(198, 30);
            this.TB_R.TabIndex = 5;
            this.TB_R.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_R_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 312);
            this.Controls.Add(this.TB_R);
            this.Controls.Add(this.TB_A);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BT_Vált);
            this.Controls.Add(this.BT_Merre);
            this.Name = "Form1";
            this.Text = "Váltó";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_Merre;
        private System.Windows.Forms.Button BT_Vált;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_A;
        private System.Windows.Forms.TextBox TB_R;
    }
}

