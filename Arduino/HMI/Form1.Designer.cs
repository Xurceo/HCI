namespace HMI
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
            this.port = new System.Windows.Forms.Label();
            this.port_connect = new System.Windows.Forms.Button();
            this.port_name = new System.Windows.Forms.TextBox();
            this.state = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // port
            // 
            this.port.AutoSize = true;
            this.port.Location = new System.Drawing.Point(332, 9);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(141, 16);
            this.port.TabIndex = 0;
            this.port.Text = "Порт: не підключено";
            // 
            // port_connect
            // 
            this.port_connect.Location = new System.Drawing.Point(358, 56);
            this.port_connect.Name = "port_connect";
            this.port_connect.Size = new System.Drawing.Size(93, 84);
            this.port_connect.TabIndex = 2;
            this.port_connect.Text = "Підключити";
            this.port_connect.UseVisualStyleBackColor = true;
            this.port_connect.Click += new System.EventHandler(this.port_connect_click);
            // 
            // port_name
            // 
            this.port_name.Location = new System.Drawing.Point(358, 28);
            this.port_name.Name = "port_name";
            this.port_name.Size = new System.Drawing.Size(93, 22);
            this.port_name.TabIndex = 3;
            // 
            // state
            // 
            this.state.AutoSize = true;
            this.state.Location = new System.Drawing.Point(41, 25);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(33, 16);
            this.state.TabIndex = 5;
            this.state.Text = "ВКЛ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Статус кнопки:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 153);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.state);
            this.Controls.Add(this.port_name);
            this.Controls.Add(this.port_connect);
            this.Controls.Add(this.port);
            this.Name = "Form1";
            this.Text = "Ардуіно кнопка";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label port;
        private System.Windows.Forms.Button port_connect;
        private System.Windows.Forms.TextBox port_name;
        private System.Windows.Forms.Label state;
        private System.Windows.Forms.Label label1;
    }
}

