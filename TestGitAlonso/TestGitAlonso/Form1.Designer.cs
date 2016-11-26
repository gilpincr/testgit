namespace TestGitAlonso
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
            this.btnFunc = new System.Windows.Forms.Button();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblRes = new System.Windows.Forms.Label();
            this.lblOpe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFunc
            // 
            this.btnFunc.Location = new System.Drawing.Point(464, 91);
            this.btnFunc.Name = "btnFunc";
            this.btnFunc.Size = new System.Drawing.Size(75, 24);
            this.btnFunc.TabIndex = 0;
            this.btnFunc.Text = "Funcion";
            this.btnFunc.UseVisualStyleBackColor = true;
            this.btnFunc.Click += new System.EventHandler(this.btnFunc_Click);
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(108, 93);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(100, 22);
            this.txtnum1.TabIndex = 1;
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(309, 91);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(100, 22);
            this.txtnum2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(245, 219);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRes.Location = new System.Drawing.Point(71, 219);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(137, 31);
            this.lblRes.TabIndex = 4;
            this.lblRes.Text = "Resultado";
            // 
            // lblOpe
            // 
            this.lblOpe.AutoSize = true;
            this.lblOpe.Location = new System.Drawing.Point(242, 93);
            this.lblOpe.Name = "lblOpe";
            this.lblOpe.Size = new System.Drawing.Size(12, 17);
            this.lblOpe.TabIndex = 5;
            this.lblOpe.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 412);
            this.Controls.Add(this.lblOpe);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.btnFunc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFunc;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Label lblOpe;
    }
}

