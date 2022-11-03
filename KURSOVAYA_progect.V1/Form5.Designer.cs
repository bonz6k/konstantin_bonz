
namespace KURSOVAYA_progect.V1
{
    partial class Form5
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
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(9, 37);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(428, 257);
            this.dataGridView3.TabIndex = 5;
            this.dataGridView3.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView3_CellMouseClick);
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "Услуги",
            "Должность",
            "Персонал",
            "Комнаты"});
            this.comboBox5.Location = new System.Drawing.Point(133, 9);
            this.comboBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(167, 21);
            this.comboBox5.TabIndex = 6;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // bt1
            // 
            this.bt1.BackColor = System.Drawing.SystemColors.Highlight;
            this.bt1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt1.Location = new System.Drawing.Point(10, 325);
            this.bt1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(104, 46);
            this.bt1.TabIndex = 8;
            this.bt1.Text = "Добавить";
            this.bt1.UseVisualStyleBackColor = false;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt2
            // 
            this.bt2.BackColor = System.Drawing.SystemColors.Highlight;
            this.bt2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt2.Location = new System.Drawing.Point(118, 325);
            this.bt2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(104, 46);
            this.bt2.TabIndex = 9;
            this.bt2.Text = "Редактировать";
            this.bt2.UseVisualStyleBackColor = false;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt3
            // 
            this.bt3.BackColor = System.Drawing.SystemColors.Highlight;
            this.bt3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt3.Location = new System.Drawing.Point(334, 325);
            this.bt3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(104, 46);
            this.bt3.TabIndex = 10;
            this.bt3.Text = "Удалить";
            this.bt3.UseVisualStyleBackColor = false;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // bt4
            // 
            this.bt4.BackColor = System.Drawing.SystemColors.Highlight;
            this.bt4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt4.Location = new System.Drawing.Point(226, 325);
            this.bt4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(104, 46);
            this.bt4.TabIndex = 11;
            this.bt4.Text = "Обновить";
            this.bt4.UseVisualStyleBackColor = false;
            this.bt4.Click += new System.EventHandler(this.bt4_Click);
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(226, 301);
            this.tb3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(104, 20);
            this.tb3.TabIndex = 12;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(118, 301);
            this.tb2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(104, 20);
            this.tb2.TabIndex = 13;
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(10, 301);
            this.tb1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(104, 20);
            this.tb1.TabIndex = 14;
            // 
            // tb4
            // 
            this.tb4.Location = new System.Drawing.Point(334, 301);
            this.tb4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb4.Name = "tb4";
            this.tb4.Size = new System.Drawing.Size(104, 20);
            this.tb4.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(323, 7);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 26);
            this.button1.TabIndex = 16;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Справочники";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(441, 375);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb4);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form5";
            this.Text = "Spravochniki";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}