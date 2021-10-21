
namespace numeroMayor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnResult = new System.Windows.Forms.Button();
            this.n1 = new System.Windows.Forms.Label();
            this.n2 = new System.Windows.Forms.Label();
            this.n3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.txtN3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(168, 259);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(75, 23);
            this.btnResult.TabIndex = 0;
            this.btnResult.Text = "enviar";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // n1
            // 
            this.n1.AutoSize = true;
            this.n1.Location = new System.Drawing.Point(123, 109);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(58, 15);
            this.n1.TabIndex = 1;
            this.n1.Text = "numero 1";
            // 
            // n2
            // 
            this.n2.AutoSize = true;
            this.n2.Location = new System.Drawing.Point(123, 154);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(58, 15);
            this.n2.TabIndex = 2;
            this.n2.Text = "numero 2";
            // 
            // n3
            // 
            this.n3.AutoSize = true;
            this.n3.Location = new System.Drawing.Point(123, 202);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(58, 15);
            this.n3.TabIndex = 3;
            this.n3.Text = "numero 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Numero Mayor";
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(224, 101);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(100, 23);
            this.txtN1.TabIndex = 5;
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(224, 146);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(100, 23);
            this.txtN2.TabIndex = 6;
            // 
            // txtN3
            // 
            this.txtN3.Location = new System.Drawing.Point(224, 194);
            this.txtN3.Name = "txtN3";
            this.txtN3.Size = new System.Drawing.Size(100, 23);
            this.txtN3.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 333);
            this.Controls.Add(this.txtN3);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.btnResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Label n1;
        private System.Windows.Forms.Label n2;
        private System.Windows.Forms.Label n3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.TextBox txtN3;
    }
}

