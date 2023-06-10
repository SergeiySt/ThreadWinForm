namespace Thread_WinForm
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_OneArray = new System.Windows.Forms.CheckBox();
            this.checkBox_TwoArray = new System.Windows.Forms.CheckBox();
            this.groupBox_OneArray = new System.Windows.Forms.GroupBox();
            this.textBox_A = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox_TwoArray = new System.Windows.Forms.GroupBox();
            this.textBox_B1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_A1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Start = new System.Windows.Forms.Button();
            this.richTextBox_Result = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_SortArray = new System.Windows.Forms.CheckBox();
            this.checkBox_Summ = new System.Windows.Forms.CheckBox();
            this.checkBox_MaxElement = new System.Windows.Forms.CheckBox();
            this.checkBox_MinElement = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label_ProcessorCount = new System.Windows.Forms.Label();
            this.groupBox_OneArray.SuspendLayout();
            this.groupBox_TwoArray.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(84, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(532, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Багатопоточна обробка великого масиву даних";
            // 
            // checkBox_OneArray
            // 
            this.checkBox_OneArray.AutoSize = true;
            this.checkBox_OneArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_OneArray.Location = new System.Drawing.Point(12, 62);
            this.checkBox_OneArray.Name = "checkBox_OneArray";
            this.checkBox_OneArray.Size = new System.Drawing.Size(187, 24);
            this.checkBox_OneArray.TabIndex = 2;
            this.checkBox_OneArray.Text = "Одновимірний масив";
            this.checkBox_OneArray.UseVisualStyleBackColor = true;
            this.checkBox_OneArray.CheckedChanged += new System.EventHandler(this.checkBox_OneArray_CheckedChanged);
            // 
            // checkBox_TwoArray
            // 
            this.checkBox_TwoArray.AutoSize = true;
            this.checkBox_TwoArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_TwoArray.Location = new System.Drawing.Point(12, 161);
            this.checkBox_TwoArray.Name = "checkBox_TwoArray";
            this.checkBox_TwoArray.Size = new System.Drawing.Size(176, 24);
            this.checkBox_TwoArray.TabIndex = 3;
            this.checkBox_TwoArray.Text = "Двовимірний масив";
            this.checkBox_TwoArray.UseVisualStyleBackColor = true;
            this.checkBox_TwoArray.CheckedChanged += new System.EventHandler(this.checkBox_TwoArray_CheckedChanged);
            // 
            // groupBox_OneArray
            // 
            this.groupBox_OneArray.Controls.Add(this.textBox_A);
            this.groupBox_OneArray.Controls.Add(this.label2);
            this.groupBox_OneArray.Enabled = false;
            this.groupBox_OneArray.Location = new System.Drawing.Point(12, 92);
            this.groupBox_OneArray.Name = "groupBox_OneArray";
            this.groupBox_OneArray.Size = new System.Drawing.Size(273, 46);
            this.groupBox_OneArray.TabIndex = 4;
            this.groupBox_OneArray.TabStop = false;
            // 
            // textBox_A
            // 
            this.textBox_A.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_A.Location = new System.Drawing.Point(167, 15);
            this.textBox_A.Name = "textBox_A";
            this.textBox_A.Size = new System.Drawing.Size(100, 17);
            this.textBox_A.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Введіть розмір масиву:";
            // 
            // groupBox_TwoArray
            // 
            this.groupBox_TwoArray.Controls.Add(this.textBox_B1);
            this.groupBox_TwoArray.Controls.Add(this.label4);
            this.groupBox_TwoArray.Controls.Add(this.textBox_A1);
            this.groupBox_TwoArray.Controls.Add(this.label3);
            this.groupBox_TwoArray.Enabled = false;
            this.groupBox_TwoArray.Location = new System.Drawing.Point(12, 191);
            this.groupBox_TwoArray.Name = "groupBox_TwoArray";
            this.groupBox_TwoArray.Size = new System.Drawing.Size(273, 54);
            this.groupBox_TwoArray.TabIndex = 5;
            this.groupBox_TwoArray.TabStop = false;
            // 
            // textBox_B1
            // 
            this.textBox_B1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_B1.Location = new System.Drawing.Point(236, 20);
            this.textBox_B1.Name = "textBox_B1";
            this.textBox_B1.Size = new System.Drawing.Size(31, 17);
            this.textBox_B1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "X";
            // 
            // textBox_A1
            // 
            this.textBox_A1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_A1.Location = new System.Drawing.Point(172, 19);
            this.textBox_A1.Name = "textBox_A1";
            this.textBox_A1.Size = new System.Drawing.Size(32, 17);
            this.textBox_A1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Введіть розмір масиву:";
            // 
            // button_Start
            // 
            this.button_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Start.Location = new System.Drawing.Point(12, 422);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(273, 49);
            this.button_Start.TabIndex = 6;
            this.button_Start.Text = "Почати";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // richTextBox_Result
            // 
            this.richTextBox_Result.Location = new System.Drawing.Point(305, 92);
            this.richTextBox_Result.Name = "richTextBox_Result";
            this.richTextBox_Result.Size = new System.Drawing.Size(394, 379);
            this.richTextBox_Result.TabIndex = 7;
            this.richTextBox_Result.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_MinElement);
            this.groupBox1.Controls.Add(this.checkBox_MaxElement);
            this.groupBox1.Controls.Add(this.checkBox_Summ);
            this.groupBox1.Controls.Add(this.checkBox_SortArray);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 251);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 165);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Алгоритми";
            // 
            // checkBox_SortArray
            // 
            this.checkBox_SortArray.AutoSize = true;
            this.checkBox_SortArray.Location = new System.Drawing.Point(11, 34);
            this.checkBox_SortArray.Name = "checkBox_SortArray";
            this.checkBox_SortArray.Size = new System.Drawing.Size(148, 20);
            this.checkBox_SortArray.TabIndex = 0;
            this.checkBox_SortArray.Text = "Сортуваня масиву";
            this.checkBox_SortArray.UseVisualStyleBackColor = true;
            // 
            // checkBox_Summ
            // 
            this.checkBox_Summ.AutoSize = true;
            this.checkBox_Summ.Location = new System.Drawing.Point(11, 60);
            this.checkBox_Summ.Name = "checkBox_Summ";
            this.checkBox_Summ.Size = new System.Drawing.Size(60, 20);
            this.checkBox_Summ.TabIndex = 1;
            this.checkBox_Summ.Text = "Сума";
            this.checkBox_Summ.UseVisualStyleBackColor = true;
            // 
            // checkBox_MaxElement
            // 
            this.checkBox_MaxElement.AutoSize = true;
            this.checkBox_MaxElement.Location = new System.Drawing.Point(11, 86);
            this.checkBox_MaxElement.Name = "checkBox_MaxElement";
            this.checkBox_MaxElement.Size = new System.Drawing.Size(220, 20);
            this.checkBox_MaxElement.TabIndex = 2;
            this.checkBox_MaxElement.Text = "Пошук max елемента у масиві";
            this.checkBox_MaxElement.UseVisualStyleBackColor = true;
            // 
            // checkBox_MinElement
            // 
            this.checkBox_MinElement.AutoSize = true;
            this.checkBox_MinElement.Location = new System.Drawing.Point(11, 112);
            this.checkBox_MinElement.Name = "checkBox_MinElement";
            this.checkBox_MinElement.Size = new System.Drawing.Size(216, 20);
            this.checkBox_MinElement.TabIndex = 3;
            this.checkBox_MinElement.Text = "Пошук min елемента у масиві";
            this.checkBox_MinElement.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(302, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(307, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Кількість доступних потоків на комп\'ютері:";
            // 
            // label_ProcessorCount
            // 
            this.label_ProcessorCount.AutoSize = true;
            this.label_ProcessorCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ProcessorCount.Location = new System.Drawing.Point(609, 68);
            this.label_ProcessorCount.Name = "label_ProcessorCount";
            this.label_ProcessorCount.Size = new System.Drawing.Size(52, 18);
            this.label_ProcessorCount.TabIndex = 10;
            this.label_ProcessorCount.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 483);
            this.Controls.Add(this.label_ProcessorCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox_Result);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.groupBox_TwoArray);
            this.Controls.Add(this.groupBox_OneArray);
            this.Controls.Add(this.checkBox_TwoArray);
            this.Controls.Add(this.checkBox_OneArray);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор";
            this.groupBox_OneArray.ResumeLayout(false);
            this.groupBox_OneArray.PerformLayout();
            this.groupBox_TwoArray.ResumeLayout(false);
            this.groupBox_TwoArray.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_OneArray;
        private System.Windows.Forms.CheckBox checkBox_TwoArray;
        private System.Windows.Forms.GroupBox groupBox_OneArray;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_A;
        private System.Windows.Forms.GroupBox groupBox_TwoArray;
        private System.Windows.Forms.TextBox textBox_A1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_B1;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.RichTextBox richTextBox_Result;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox_SortArray;
        private System.Windows.Forms.CheckBox checkBox_Summ;
        private System.Windows.Forms.CheckBox checkBox_MinElement;
        private System.Windows.Forms.CheckBox checkBox_MaxElement;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_ProcessorCount;
    }
}

