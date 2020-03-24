namespace DinoModder
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.control_mod = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // control_mod
            // 
            this.control_mod.Location = new System.Drawing.Point(13, 13);
            this.control_mod.Name = "control_mod";
            this.control_mod.Size = new System.Drawing.Size(129, 77);
            this.control_mod.TabIndex = 0;
            this.control_mod.Text = "Мод на изменение характеристик";
            this.control_mod.UseVisualStyleBackColor = true;
            this.control_mod.Click += new System.EventHandler(this.control_mod_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 77);
            this.button1.TabIndex = 1;
            this.button1.Text = "AUTO-ANTIOBSTACLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(326, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 77);
            this.button2.TabIndex = 2;
            this.button2.Text = "Текстурпак (алм. кирка)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(504, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 77);
            this.button3.TabIndex = 3;
            this.button3.Text = "Текстурпак (кирка на динозаврике)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 96);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(663, 77);
            this.button4.TabIndex = 4;
            this.button4.Text = "Текстурпак (безымянный)";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(248, 43);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(72, 22);
            this.numericUpDown1.TabIndex = 5;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 274);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(663, 79);
            this.button6.TabIndex = 7;
            this.button6.Text = "Открыть Chrome Driver";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(13, 180);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(662, 79);
            this.button5.TabIndex = 8;
            this.button5.Text = "Остановить AUTO-ANTIOBSTACLE";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 376);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.control_mod);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "DINO MODS BY TWMICRO";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button control_mod;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
    }
}

