
namespace Lab7CSharp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Dupbutton = new System.Windows.Forms.Button();
            this.Exbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(423, -1);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lab 7.   C# ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 56);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(347, 243);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Dupbutton
            // 
            this.Dupbutton.Location = new System.Drawing.Point(94, 379);
            this.Dupbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Dupbutton.Name = "Dupbutton";
            this.Dupbutton.Size = new System.Drawing.Size(105, 40);
            this.Dupbutton.TabIndex = 2;
            this.Dupbutton.Text = "Duplicate";
            this.Dupbutton.UseVisualStyleBackColor = true;
            this.Dupbutton.Click += new System.EventHandler(this.Dupbutton_Click);
            // 
            // Exbutton
            // 
            this.Exbutton.Location = new System.Drawing.Point(262, 379);
            this.Exbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Exbutton.Name = "Exbutton";
            this.Exbutton.Size = new System.Drawing.Size(111, 40);
            this.Exbutton.TabIndex = 3;
            this.Exbutton.Text = "Exit";
            this.Exbutton.UseVisualStyleBackColor = true;
            this.Exbutton.Click += new System.EventHandler(this.Exbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 482);
            this.Controls.Add(this.Exbutton);
            this.Controls.Add(this.Dupbutton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Dupbutton;
        private System.Windows.Forms.Button Exbutton;
    }
}

