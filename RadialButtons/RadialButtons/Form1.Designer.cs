
namespace RadialButtons
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mas = new System.Windows.Forms.RadioButton();
            this.menos = new System.Windows.Forms.RadioButton();
            this.mult = new System.Windows.Forms.RadioButton();
            this.nbr1 = new System.Windows.Forms.TextBox();
            this.nbr2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.div = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mas
            // 
            this.mas.AutoSize = true;
            this.mas.Checked = true;
            this.mas.Location = new System.Drawing.Point(17, 19);
            this.mas.Name = "mas";
            this.mas.Size = new System.Drawing.Size(45, 17);
            this.mas.TabIndex = 0;
            this.mas.TabStop = true;
            this.mas.Text = "Mas";
            this.mas.UseVisualStyleBackColor = true;
            // 
            // menos
            // 
            this.menos.AutoSize = true;
            this.menos.Location = new System.Drawing.Point(17, 41);
            this.menos.Name = "menos";
            this.menos.Size = new System.Drawing.Size(57, 17);
            this.menos.TabIndex = 1;
            this.menos.TabStop = true;
            this.menos.Text = "Menos";
            this.menos.UseVisualStyleBackColor = true;
            // 
            // mult
            // 
            this.mult.AutoSize = true;
            this.mult.Location = new System.Drawing.Point(17, 64);
            this.mult.Name = "mult";
            this.mult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mult.Size = new System.Drawing.Size(89, 17);
            this.mult.TabIndex = 2;
            this.mult.TabStop = true;
            this.mult.Text = "Multiplicacion";
            this.mult.UseVisualStyleBackColor = true;
            // 
            // nbr1
            // 
            this.nbr1.Location = new System.Drawing.Point(213, 12);
            this.nbr1.Name = "nbr1";
            this.nbr1.Size = new System.Drawing.Size(100, 20);
            this.nbr1.TabIndex = 3;
            // 
            // nbr2
            // 
            this.nbr2.Location = new System.Drawing.Point(213, 38);
            this.nbr2.Name = "nbr2";
            this.nbr2.Size = new System.Drawing.Size(100, 20);
            this.nbr2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Resultado : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.div);
            this.groupBox1.Controls.Add(this.mas);
            this.groupBox1.Controls.Add(this.menos);
            this.groupBox1.Controls.Add(this.mult);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 123);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculator";
            // 
            // div
            // 
            this.div.AutoSize = true;
            this.div.Location = new System.Drawing.Point(17, 87);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(62, 17);
            this.div.TabIndex = 3;
            this.div.TabStop = true;
            this.div.Text = "Division";
            this.div.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "B";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(231, 99);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(0, 13);
            this.Result.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "Calcule";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 144);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nbr2);
            this.Controls.Add(this.nbr1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton mas;
        private System.Windows.Forms.RadioButton menos;
        private System.Windows.Forms.RadioButton mult;
        private System.Windows.Forms.TextBox nbr1;
        private System.Windows.Forms.TextBox nbr2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton div;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button button1;
    }
}

