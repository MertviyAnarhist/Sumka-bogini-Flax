namespace Сумка_богини_Флакс
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_main = new System.Windows.Forms.TextBox();
            this.btn_raschet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(34, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите число от 1 до 100 :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_main
            // 
            this.textBox_main.Location = new System.Drawing.Point(364, 18);
            this.textBox_main.Name = "textBox_main";
            this.textBox_main.Size = new System.Drawing.Size(76, 22);
            this.textBox_main.TabIndex = 1;
            this.textBox_main.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_raschet
            // 
            this.btn_raschet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(138)))));
            this.btn_raschet.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_raschet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_raschet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(187)))));
            this.btn_raschet.Location = new System.Drawing.Point(29, 71);
            this.btn_raschet.Name = "btn_raschet";
            this.btn_raschet.Size = new System.Drawing.Size(273, 87);
            this.btn_raschet.TabIndex = 2;
            this.btn_raschet.Text = "Открыть сумку!";
            this.btn_raschet.UseVisualStyleBackColor = false;
            this.btn_raschet.Click += new System.EventHandler(this.btn_raschet_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(55)))), ((int)(((byte)(0)))));
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 84F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(240)))), ((int)(((byte)(48)))));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(28, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(731, 199);
            this.label2.TabIndex = 3;
            this.label2.Text = "?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 450);
            this.Controls.Add(this.btn_raschet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_main);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Сумка Богини Флакс";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_main;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_raschet;
        private System.Windows.Forms.Label label2;
    }
}

