namespace Simulation.Lab._8
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
            this.btn_8_1 = new System.Windows.Forms.Button();
            this.btn_8_2 = new System.Windows.Forms.Button();
            this.btn_8_3 = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_8_1
            // 
            this.btn_8_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_8_1.Location = new System.Drawing.Point(117, 41);
            this.btn_8_1.Name = "btn_8_1";
            this.btn_8_1.Size = new System.Drawing.Size(245, 61);
            this.btn_8_1.TabIndex = 0;
            this.btn_8_1.Text = "8.1";
            this.btn_8_1.UseVisualStyleBackColor = true;
            this.btn_8_1.Click += new System.EventHandler(this.btn_8_1_Click);
            // 
            // btn_8_2
            // 
            this.btn_8_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_8_2.Location = new System.Drawing.Point(117, 153);
            this.btn_8_2.Name = "btn_8_2";
            this.btn_8_2.Size = new System.Drawing.Size(245, 60);
            this.btn_8_2.TabIndex = 1;
            this.btn_8_2.Text = "8.2";
            this.btn_8_2.UseVisualStyleBackColor = true;
            this.btn_8_2.Click += new System.EventHandler(this.btn_8_2_Click);
            // 
            // btn_8_3
            // 
            this.btn_8_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_8_3.Location = new System.Drawing.Point(117, 261);
            this.btn_8_3.Name = "btn_8_3";
            this.btn_8_3.Size = new System.Drawing.Size(245, 60);
            this.btn_8_3.TabIndex = 2;
            this.btn_8_3.Text = "8.3";
            this.btn_8_3.UseVisualStyleBackColor = true;
            this.btn_8_3.Click += new System.EventHandler(this.btn_8_3_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.IndianRed;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_close.Location = new System.Drawing.Point(425, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(40, 40);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "Х";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 365);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_8_3);
            this.Controls.Add(this.btn_8_2);
            this.Controls.Add(this.btn_8_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_8_1;
        private System.Windows.Forms.Button btn_8_2;
        private System.Windows.Forms.Button btn_8_3;
        private System.Windows.Forms.Button btn_close;
    }
}

