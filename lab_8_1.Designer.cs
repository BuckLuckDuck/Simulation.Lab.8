namespace Simulation.Lab._8
{
    partial class lab_8_1
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
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_quest_inf = new System.Windows.Forms.Label();
            this.lbl_answer_inf = new System.Windows.Forms.Label();
            this.lbl_answer = new System.Windows.Forms.Label();
            this.btn_answer_get = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.IndianRed;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_close.Location = new System.Drawing.Point(495, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(40, 40);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "Х";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_back
            // 
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_back.Location = new System.Drawing.Point(429, 385);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(106, 39);
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "Назад";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(106, 140);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(320, 26);
            this.textBox1.TabIndex = 6;
            // 
            // lbl_quest_inf
            // 
            this.lbl_quest_inf.AutoSize = true;
            this.lbl_quest_inf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_quest_inf.Location = new System.Drawing.Point(103, 105);
            this.lbl_quest_inf.Name = "lbl_quest_inf";
            this.lbl_quest_inf.Size = new System.Drawing.Size(137, 20);
            this.lbl_quest_inf.TabIndex = 7;
            this.lbl_quest_inf.Text = "Задайте вопрос:";
            // 
            // lbl_answer_inf
            // 
            this.lbl_answer_inf.AutoSize = true;
            this.lbl_answer_inf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_answer_inf.Location = new System.Drawing.Point(103, 179);
            this.lbl_answer_inf.Name = "lbl_answer_inf";
            this.lbl_answer_inf.Size = new System.Drawing.Size(61, 20);
            this.lbl_answer_inf.TabIndex = 8;
            this.lbl_answer_inf.Text = "Ответ:";
            // 
            // lbl_answer
            // 
            this.lbl_answer.AutoSize = true;
            this.lbl_answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_answer.Location = new System.Drawing.Point(103, 221);
            this.lbl_answer.Name = "lbl_answer";
            this.lbl_answer.Size = new System.Drawing.Size(0, 20);
            this.lbl_answer.TabIndex = 9;
            // 
            // btn_answer_get
            // 
            this.btn_answer_get.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_answer_get.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_answer_get.Location = new System.Drawing.Point(160, 300);
            this.btn_answer_get.Name = "btn_answer_get";
            this.btn_answer_get.Size = new System.Drawing.Size(222, 34);
            this.btn_answer_get.TabIndex = 10;
            this.btn_answer_get.Text = "Получить ответ";
            this.btn_answer_get.UseVisualStyleBackColor = true;
            this.btn_answer_get.Click += new System.EventHandler(this.btn_answer_get_Click);
            // 
            // lab_8_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 436);
            this.Controls.Add(this.btn_answer_get);
            this.Controls.Add(this.lbl_answer);
            this.Controls.Add(this.lbl_answer_inf);
            this.Controls.Add(this.lbl_quest_inf);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "lab_8_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "lab_8_1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_quest_inf;
        private System.Windows.Forms.Label lbl_answer_inf;
        private System.Windows.Forms.Label lbl_answer;
        private System.Windows.Forms.Button btn_answer_get;
    }
}