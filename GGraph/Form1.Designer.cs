namespace GGraph
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
            this.sheet = new System.Windows.Forms.PictureBox();
            this.Edgebutton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.Mapbutton = new System.Windows.Forms.Button();
            this.listBoxMatrix = new System.Windows.Forms.ListBox();
            this.Deikstrabutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Vertexbutton = new System.Windows.Forms.Button();
            this.startBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.finishBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.sheet)).BeginInit();
            this.SuspendLayout();
            // 
            // sheet
            // 
            this.sheet.BackColor = System.Drawing.Color.White;
            this.sheet.Location = new System.Drawing.Point(117, 12);
            this.sheet.Name = "sheet";
            this.sheet.Size = new System.Drawing.Size(795, 486);
            this.sheet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.sheet.TabIndex = 0;
            this.sheet.TabStop = false;
            this.sheet.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sheet_MouseClick);
            // 
            // Edgebutton
            // 
            this.Edgebutton.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Edgebutton.Location = new System.Drawing.Point(12, 83);
            this.Edgebutton.Name = "Edgebutton";
            this.Edgebutton.Size = new System.Drawing.Size(90, 53);
            this.Edgebutton.TabIndex = 2;
            this.Edgebutton.Text = "Ребро";
            this.Edgebutton.UseVisualStyleBackColor = true;
            this.Edgebutton.Click += new System.EventHandler(this.Edgebutton_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Deletebutton.Location = new System.Drawing.Point(12, 152);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(90, 53);
            this.Deletebutton.TabIndex = 3;
            this.Deletebutton.Text = "Очистить";
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // Mapbutton
            // 
            this.Mapbutton.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Mapbutton.Location = new System.Drawing.Point(12, 223);
            this.Mapbutton.Name = "Mapbutton";
            this.Mapbutton.Size = new System.Drawing.Size(90, 53);
            this.Mapbutton.TabIndex = 4;
            this.Mapbutton.Text = "Карта";
            this.Mapbutton.UseVisualStyleBackColor = true;
            this.Mapbutton.Click += new System.EventHandler(this.Mapbutton_Click);
            // 
            // listBoxMatrix
            // 
            this.listBoxMatrix.FormattingEnabled = true;
            this.listBoxMatrix.ItemHeight = 16;
            this.listBoxMatrix.Location = new System.Drawing.Point(12, 622);
            this.listBoxMatrix.Name = "listBoxMatrix";
            this.listBoxMatrix.Size = new System.Drawing.Size(379, 132);
            this.listBoxMatrix.TabIndex = 6;
            // 
            // Deikstrabutton
            // 
            this.Deikstrabutton.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Deikstrabutton.Location = new System.Drawing.Point(12, 295);
            this.Deikstrabutton.Name = "Deikstrabutton";
            this.Deikstrabutton.Size = new System.Drawing.Size(90, 53);
            this.Deikstrabutton.TabIndex = 7;
            this.Deikstrabutton.Text = "Путь";
            this.Deikstrabutton.UseVisualStyleBackColor = true;
            this.Deikstrabutton.Click += new System.EventHandler(this.Deikstrabutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(420, 664);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // Vertexbutton
            // 
            this.Vertexbutton.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Vertexbutton.Location = new System.Drawing.Point(12, 12);
            this.Vertexbutton.Name = "Vertexbutton";
            this.Vertexbutton.Size = new System.Drawing.Size(90, 53);
            this.Vertexbutton.TabIndex = 9;
            this.Vertexbutton.Text = "Вершина";
            this.Vertexbutton.UseVisualStyleBackColor = true;
            this.Vertexbutton.Click += new System.EventHandler(this.Vertexbutton_Click);
            // 
            // startBox
            // 
            this.startBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.startBox.FormattingEnabled = true;
            this.startBox.Location = new System.Drawing.Point(1096, 638);
            this.startBox.Name = "startBox";
            this.startBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.startBox.Size = new System.Drawing.Size(121, 24);
            this.startBox.TabIndex = 10;
            this.startBox.SelectedIndexChanged += new System.EventHandler(this.startBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(911, 634);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "Точка старта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(896, 704);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "Точка финиша";
            // 
            // finishBox
            // 
            this.finishBox.BackColor = System.Drawing.Color.White;
            this.finishBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.finishBox.FormattingEnabled = true;
            this.finishBox.Location = new System.Drawing.Point(1096, 704);
            this.finishBox.Name = "finishBox";
            this.finishBox.Size = new System.Drawing.Size(121, 24);
            this.finishBox.TabIndex = 12;
            this.finishBox.SelectedIndexChanged += new System.EventHandler(this.finishBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1229, 766);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.finishBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startBox);
            this.Controls.Add(this.Vertexbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Deikstrabutton);
            this.Controls.Add(this.listBoxMatrix);
            this.Controls.Add(this.Mapbutton);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.Edgebutton);
            this.Controls.Add(this.sheet);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GGraph";
            ((System.ComponentModel.ISupportInitialize)(this.sheet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Edgebutton;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Button Mapbutton;
        public System.Windows.Forms.PictureBox sheet;
        private System.Windows.Forms.ListBox listBoxMatrix;
        private System.Windows.Forms.Button Deikstrabutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Vertexbutton;
        private System.Windows.Forms.ComboBox startBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox finishBox;
    }
}

