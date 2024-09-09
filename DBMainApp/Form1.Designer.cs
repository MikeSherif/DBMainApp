namespace DBMainApp
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
            this.login_t = new System.Windows.Forms.TextBox();
            this.password_t = new System.Windows.Forms.TextBox();
            this.enter_b = new System.Windows.Forms.Button();
            this.registration_b = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.caps_label = new System.Windows.Forms.Label();
            this.rus_label = new System.Windows.Forms.Label();
            this.eng_label = new System.Windows.Forms.Label();
            this.status_timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // login_t
            // 
            this.login_t.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_t.Location = new System.Drawing.Point(74, 88);
            this.login_t.Name = "login_t";
            this.login_t.Size = new System.Drawing.Size(239, 27);
            this.login_t.TabIndex = 0;
            // 
            // password_t
            // 
            this.password_t.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_t.Location = new System.Drawing.Point(74, 148);
            this.password_t.Name = "password_t";
            this.password_t.PasswordChar = '*';
            this.password_t.Size = new System.Drawing.Size(239, 27);
            this.password_t.TabIndex = 1;
            // 
            // enter_b
            // 
            this.enter_b.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enter_b.Location = new System.Drawing.Point(74, 191);
            this.enter_b.Name = "enter_b";
            this.enter_b.Size = new System.Drawing.Size(239, 69);
            this.enter_b.TabIndex = 2;
            this.enter_b.Text = "Войти";
            this.enter_b.UseVisualStyleBackColor = true;
            this.enter_b.Click += new System.EventHandler(this.enter_b_Click);
            // 
            // registration_b
            // 
            this.registration_b.Font = new System.Drawing.Font("Lucida Console", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registration_b.Location = new System.Drawing.Point(74, 266);
            this.registration_b.Name = "registration_b";
            this.registration_b.Size = new System.Drawing.Size(239, 48);
            this.registration_b.TabIndex = 3;
            this.registration_b.Text = "Зарегистрироваться";
            this.registration_b.UseVisualStyleBackColor = true;
            this.registration_b.Click += new System.EventHandler(this.registration_b_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(47, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Добро пожаловать!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(160, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(158, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Пароль";
            // 
            // caps_label
            // 
            this.caps_label.AutoSize = true;
            this.caps_label.ForeColor = System.Drawing.Color.Red;
            this.caps_label.Location = new System.Drawing.Point(12, 332);
            this.caps_label.Name = "caps_label";
            this.caps_label.Size = new System.Drawing.Size(195, 16);
            this.caps_label.TabIndex = 7;
            this.caps_label.Text = "Нажата клавиша CAPS LOCK!";
            // 
            // rus_label
            // 
            this.rus_label.AutoSize = true;
            this.rus_label.Location = new System.Drawing.Point(269, 332);
            this.rus_label.Name = "rus_label";
            this.rus_label.Size = new System.Drawing.Size(101, 16);
            this.rus_label.TabIndex = 8;
            this.rus_label.Text = "Язык: Русский";
            // 
            // eng_label
            // 
            this.eng_label.AutoSize = true;
            this.eng_label.Location = new System.Drawing.Point(246, 332);
            this.eng_label.Name = "eng_label";
            this.eng_label.Size = new System.Drawing.Size(124, 16);
            this.eng_label.TabIndex = 9;
            this.eng_label.Text = "Язык: Английский";
            // 
            // status_timer
            // 
            this.status_timer.Interval = 200;
            this.status_timer.Tick += new System.EventHandler(this.status_timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(382, 357);
            this.Controls.Add(this.eng_label);
            this.Controls.Add(this.rus_label);
            this.Controls.Add(this.caps_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registration_b);
            this.Controls.Add(this.enter_b);
            this.Controls.Add(this.password_t);
            this.Controls.Add(this.login_t);
            this.MaximumSize = new System.Drawing.Size(400, 404);
            this.MinimumSize = new System.Drawing.Size(400, 404);
            this.Name = "Form1";
            this.Text = "Вход";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox login_t;
        private System.Windows.Forms.TextBox password_t;
        private System.Windows.Forms.Button enter_b;
        private System.Windows.Forms.Button registration_b;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label caps_label;
        private System.Windows.Forms.Label rus_label;
        private System.Windows.Forms.Label eng_label;
        private System.Windows.Forms.Timer status_timer;
    }
}

