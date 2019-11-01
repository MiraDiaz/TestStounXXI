namespace TestStounXXI
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
            this.dataGridViewDC = new System.Windows.Forms.DataGridView();
            this.dataGridViewER = new System.Windows.Forms.DataGridView();
            this.labelDate = new System.Windows.Forms.Label();
            this.buttonDowload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewER)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDC
            // 
            this.dataGridViewDC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDC.Location = new System.Drawing.Point(12, 103);
            this.dataGridViewDC.Name = "dataGridViewDC";
            this.dataGridViewDC.RowTemplate.Height = 28;
            this.dataGridViewDC.Size = new System.Drawing.Size(548, 411);
            this.dataGridViewDC.TabIndex = 0;
            // 
            // dataGridViewER
            // 
            this.dataGridViewER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewER.Location = new System.Drawing.Point(566, 103);
            this.dataGridViewER.Name = "dataGridViewER";
            this.dataGridViewER.RowTemplate.Height = 28;
            this.dataGridViewER.Size = new System.Drawing.Size(550, 411);
            this.dataGridViewER.TabIndex = 1;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(425, 74);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(0, 20);
            this.labelDate.TabIndex = 2;
            // 
            // buttonDowload
            // 
            this.buttonDowload.Location = new System.Drawing.Point(12, 2);
            this.buttonDowload.Name = "buttonDowload";
            this.buttonDowload.Size = new System.Drawing.Size(391, 33);
            this.buttonDowload.TabIndex = 3;
            this.buttonDowload.Text = "Загрузить данные";
            this.buttonDowload.UseVisualStyleBackColor = true;
            this.buttonDowload.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(409, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Справочник валют";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(570, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Курс валют";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 561);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDowload);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.dataGridViewER);
            this.Controls.Add(this.dataGridViewDC);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewER)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDC;
        private System.Windows.Forms.DataGridView dataGridViewER;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Button buttonDowload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

