namespace DBMainApp
{
    partial class RegForm
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
            this.components = new System.ComponentModel.Container();
            this.status_timer = new System.Windows.Forms.Timer(this.components);
            this.eng_label = new System.Windows.Forms.Label();
            this.caps_label = new System.Windows.Forms.Label();
            this.rus_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.password_t = new System.Windows.Forms.TextBox();
            this.login_t = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.password_t2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.registration_b = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // status_timer
            // 
            this.status_timer.Interval = 200;
            this.status_timer.Tick += new System.EventHandler(this.status_timer_Tick);
            // 
            // eng_label
            // 
            this.eng_label.AutoSize = true;
            this.eng_label.Location = new System.Drawing.Point(307, 364);
            this.eng_label.Name = "eng_label";
            this.eng_label.Size = new System.Drawing.Size(124, 16);
            this.eng_label.TabIndex = 11;
            this.eng_label.Text = "Язык: Английский";
            // 
            // caps_label
            // 
            this.caps_label.AutoSize = true;
            this.caps_label.ForeColor = System.Drawing.Color.Red;
            this.caps_label.Location = new System.Drawing.Point(12, 364);
            this.caps_label.Name = "caps_label";
            this.caps_label.Size = new System.Drawing.Size(195, 16);
            this.caps_label.TabIndex = 10;
            this.caps_label.Text = "Нажата клавиша CAPS LOCK!";
            // 
            // rus_label
            // 
            this.rus_label.AutoSize = true;
            this.rus_label.Location = new System.Drawing.Point(330, 364);
            this.rus_label.Name = "rus_label";
            this.rus_label.Size = new System.Drawing.Size(101, 16);
            this.rus_label.TabIndex = 12;
            this.rus_label.Text = "Язык: Русский";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(188, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(190, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Логин";
            // 
            // password_t
            // 
            this.password_t.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_t.Location = new System.Drawing.Point(104, 160);
            this.password_t.Name = "password_t";
            this.password_t.PasswordChar = '*';
            this.password_t.Size = new System.Drawing.Size(239, 27);
            this.password_t.TabIndex = 14;
            // 
            // login_t
            // 
            this.login_t.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_t.Location = new System.Drawing.Point(104, 100);
            this.login_t.Name = "login_t";
            this.login_t.Size = new System.Drawing.Size(239, 27);
            this.login_t.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(140, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Повторите пароль";
            // 
            // password_t2
            // 
            this.password_t2.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_t2.Location = new System.Drawing.Point(104, 219);
            this.password_t2.Name = "password_t2";
            this.password_t2.PasswordChar = '*';
            this.password_t2.Size = new System.Drawing.Size(239, 27);
            this.password_t2.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(11, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(420, 28);
            this.label4.TabIndex = 19;
            this.label4.Text = "Заполните следующие поля";
            // 
            // registration_b
            // 
            this.registration_b.Font = new System.Drawing.Font("Lucida Console", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registration_b.Location = new System.Drawing.Point(104, 261);
            this.registration_b.Name = "registration_b";
            this.registration_b.Size = new System.Drawing.Size(239, 82);
            this.registration_b.TabIndex = 20;
            this.registration_b.Text = "Зарегистрироваться";
            this.registration_b.UseVisualStyleBackColor = true;
            this.registration_b.Click += new System.EventHandler(this.registration_b_Click);
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(443, 389);
            this.Controls.Add(this.registration_b);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password_t2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.password_t);
            this.Controls.Add(this.login_t);
            this.Controls.Add(this.rus_label);
            this.Controls.Add(this.eng_label);
            this.Controls.Add(this.caps_label);
            this.MaximumSize = new System.Drawing.Size(461, 436);
            this.MinimumSize = new System.Drawing.Size(461, 436);
            this.Name = "RegForm";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer status_timer;
        private System.Windows.Forms.Label eng_label;
        private System.Windows.Forms.Label caps_label;
        private System.Windows.Forms.Label rus_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password_t;
        private System.Windows.Forms.TextBox login_t;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password_t2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button registration_b;
    }
}