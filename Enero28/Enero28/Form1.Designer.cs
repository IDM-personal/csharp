
namespace Enero28
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
            this.Box1 = new System.Windows.Forms.CheckBox();
            this.Box2 = new System.Windows.Forms.CheckBox();
            this.Box3 = new System.Windows.Forms.CheckBox();
            this.towrite = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Box1
            // 
            this.Box1.AutoSize = true;
            this.Box1.Location = new System.Drawing.Point(13, 13);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(103, 17);
            this.Box1.TabIndex = 0;
            this.Box1.Text = "Ordenador 500€";
            this.Box1.UseVisualStyleBackColor = true;
            // 
            // Box2
            // 
            this.Box2.AutoSize = true;
            this.Box2.Location = new System.Drawing.Point(13, 36);
            this.Box2.Name = "Box2";
            this.Box2.Size = new System.Drawing.Size(86, 17);
            this.Box2.TabIndex = 1;
            this.Box2.Text = "Teclado 35€";
            this.Box2.UseVisualStyleBackColor = true;
            // 
            // Box3
            // 
            this.Box3.AutoSize = true;
            this.Box3.Location = new System.Drawing.Point(13, 59);
            this.Box3.Name = "Box3";
            this.Box3.Size = new System.Drawing.Size(76, 17);
            this.Box3.TabIndex = 2;
            this.Box3.Text = "Raton 15€";
            this.Box3.UseVisualStyleBackColor = true;
            // 
            // towrite
            // 
            this.towrite.AutoSize = true;
            this.towrite.Location = new System.Drawing.Point(156, 17);
            this.towrite.Name = "towrite";
            this.towrite.Size = new System.Drawing.Size(0, 13);
            this.towrite.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Clicka";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.click_Clicka);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 144);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.towrite);
            this.Controls.Add(this.Box3);
            this.Controls.Add(this.Box2);
            this.Controls.Add(this.Box1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Box1;
        private System.Windows.Forms.CheckBox Box2;
        private System.Windows.Forms.CheckBox Box3;
        private System.Windows.Forms.Label towrite;
        private System.Windows.Forms.Button button1;
    }
}

