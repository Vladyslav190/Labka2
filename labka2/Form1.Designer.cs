
namespace Lab02_kyrs_3
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
            this.components = new System.ComponentModel.Container();
            this.button_XOR = new System.Windows.Forms.Button();
            this.button_clean = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_P = new System.Windows.Forms.TextBox();
            this.textBox_Key = new System.Windows.Forms.TextBox();
            this.textBox_C = new System.Windows.Forms.TextBox();
            this.textBox_P3 = new System.Windows.Forms.TextBox();
            this.textBox_Key3 = new System.Windows.Forms.TextBox();
            this.textBox_C3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // button_XOR
            // 
            this.button_XOR.Location = new System.Drawing.Point(204, 59);
            this.button_XOR.Name = "button_XOR";
            this.button_XOR.Size = new System.Drawing.Size(75, 35);
            this.button_XOR.TabIndex = 0;
            this.button_XOR.Text = "XOR";
            this.button_XOR.UseVisualStyleBackColor = true;
            this.button_XOR.Click += new System.EventHandler(this.button_XOR_Click);
            // 
            // button_clean
            // 
            this.button_clean.Location = new System.Drawing.Point(84, 139);
            this.button_clean.Name = "button_clean";
            this.button_clean.Size = new System.Drawing.Size(101, 39);
            this.button_clean.TabIndex = 1;
            this.button_clean.Text = "Прибрати";
            this.button_clean.UseVisualStyleBackColor = true;
            this.button_clean.Click += new System.EventHandler(this.button_clean_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "P =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Key =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "C =";
            // 
            // textBox_P
            // 
            this.textBox_P.Location = new System.Drawing.Point(85, 31);
            this.textBox_P.Name = "textBox_P";
            this.textBox_P.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_P.Size = new System.Drawing.Size(100, 22);
            this.textBox_P.TabIndex = 5;
            // 
            // textBox_Key
            // 
            this.textBox_Key.Location = new System.Drawing.Point(85, 65);
            this.textBox_Key.Name = "textBox_Key";
            this.textBox_Key.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_Key.Size = new System.Drawing.Size(100, 22);
            this.textBox_Key.TabIndex = 6;
            // 
            // textBox_C
            // 
            this.textBox_C.Location = new System.Drawing.Point(85, 95);
            this.textBox_C.Name = "textBox_C";
            this.textBox_C.ReadOnly = true;
            this.textBox_C.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_C.Size = new System.Drawing.Size(100, 22);
            this.textBox_C.TabIndex = 7;
            this.toolTip1.SetToolTip(this.textBox_C, "Підсказка");
            // 
            // textBox_P3
            // 
            this.textBox_P3.Location = new System.Drawing.Point(302, 95);
            this.textBox_P3.Name = "textBox_P3";
            this.textBox_P3.ReadOnly = true;
            this.textBox_P3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_P3.Size = new System.Drawing.Size(100, 22);
            this.textBox_P3.TabIndex = 29;
            // 
            // textBox_Key3
            // 
            this.textBox_Key3.Location = new System.Drawing.Point(302, 65);
            this.textBox_Key3.Name = "textBox_Key3";
            this.textBox_Key3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_Key3.Size = new System.Drawing.Size(100, 22);
            this.textBox_Key3.TabIndex = 28;
            // 
            // textBox_C3
            // 
            this.textBox_C3.Location = new System.Drawing.Point(302, 31);
            this.textBox_C3.Name = "textBox_C3";
            this.textBox_C3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_C3.Size = new System.Drawing.Size(100, 22);
            this.textBox_C3.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(418, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 17);
            this.label10.TabIndex = 26;
            this.label10.Text = "= C";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(418, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "= Key";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(418, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 17);
            this.label12.TabIndex = 24;
            this.label12.Text = "= P";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 191);
            this.Controls.Add(this.textBox_P3);
            this.Controls.Add(this.textBox_Key3);
            this.Controls.Add(this.textBox_C3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox_C);
            this.Controls.Add(this.textBox_Key);
            this.Controls.Add(this.textBox_P);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_clean);
            this.Controls.Add(this.button_XOR);
            this.Name = "Form1";
            this.Text = "XOR шифратор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_XOR;
        private System.Windows.Forms.Button button_clean;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_P;
        private System.Windows.Forms.TextBox textBox_Key;
        private System.Windows.Forms.TextBox textBox_C;
        private System.Windows.Forms.TextBox textBox_P3;
        private System.Windows.Forms.TextBox textBox_Key3;
        private System.Windows.Forms.TextBox textBox_C3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

