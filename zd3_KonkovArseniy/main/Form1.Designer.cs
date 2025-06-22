namespace main
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
            this.tb_type = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_diam = new System.Windows.Forms.TextBox();
            this.tb_pr = new System.Windows.Forms.TextBox();
            this.tb_costForMeter = new System.Windows.Forms.TextBox();
            this.tb_color = new System.Windows.Forms.TextBox();
            this.nud_count = new System.Windows.Forms.NumericUpDown();
            this.cb_opl = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_count)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_type
            // 
            this.tb_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_type.Location = new System.Drawing.Point(502, 18);
            this.tb_type.Name = "tb_type";
            this.tb_type.Size = new System.Drawing.Size(186, 26);
            this.tb_type.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(306, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Количество жил";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(288, 444);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(306, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Тип кабеля";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(306, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Диаметр";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(306, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Производитель";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(306, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Цена за метр";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(306, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Наличие оплетки";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.Location = new System.Drawing.Point(306, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "Цвет";
            // 
            // tb_diam
            // 
            this.tb_diam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_diam.Location = new System.Drawing.Point(502, 118);
            this.tb_diam.Name = "tb_diam";
            this.tb_diam.Size = new System.Drawing.Size(186, 26);
            this.tb_diam.TabIndex = 12;
            // 
            // tb_pr
            // 
            this.tb_pr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_pr.Location = new System.Drawing.Point(502, 170);
            this.tb_pr.Name = "tb_pr";
            this.tb_pr.Size = new System.Drawing.Size(186, 26);
            this.tb_pr.TabIndex = 13;
            // 
            // tb_costForMeter
            // 
            this.tb_costForMeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_costForMeter.Location = new System.Drawing.Point(502, 222);
            this.tb_costForMeter.Name = "tb_costForMeter";
            this.tb_costForMeter.Size = new System.Drawing.Size(186, 26);
            this.tb_costForMeter.TabIndex = 14;
            // 
            // tb_color
            // 
            this.tb_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_color.Location = new System.Drawing.Point(502, 330);
            this.tb_color.Name = "tb_color";
            this.tb_color.Size = new System.Drawing.Size(186, 26);
            this.tb_color.TabIndex = 16;
            // 
            // nud_count
            // 
            this.nud_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nud_count.Location = new System.Drawing.Point(502, 70);
            this.nud_count.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_count.Name = "nud_count";
            this.nud_count.Size = new System.Drawing.Size(186, 26);
            this.nud_count.TabIndex = 17;
            this.nud_count.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cb_opl
            // 
            this.cb_opl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_opl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb_opl.FormattingEnabled = true;
            this.cb_opl.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.cb_opl.Location = new System.Drawing.Point(502, 274);
            this.cb_opl.Name = "cb_opl";
            this.cb_opl.Size = new System.Drawing.Size(186, 28);
            this.cb_opl.TabIndex = 18;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(127, 70);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_type);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.cb_opl);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nud_count);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_color);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tb_costForMeter);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tb_pr);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tb_diam);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1043, 470);
            this.panel1.TabIndex = 20;
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(724, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 24);
            this.label8.TabIndex = 19;
            this.label8.Text = "Информация: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 500);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Кабеля";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_count)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tb_type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_diam;
        private System.Windows.Forms.TextBox tb_pr;
        private System.Windows.Forms.TextBox tb_costForMeter;
        private System.Windows.Forms.TextBox tb_color;
        private System.Windows.Forms.NumericUpDown nud_count;
        private System.Windows.Forms.ComboBox cb_opl;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Label label8;
    }
}

