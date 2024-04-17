namespace Task1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            type = new DataGridViewTextBoxColumn();
            input1 = new DataGridViewTextBoxColumn();
            input2 = new DataGridViewTextBoxColumn();
            input3 = new DataGridViewTextBoxColumn();
            output1 = new DataGridViewTextBoxColumn();
            output2 = new DataGridViewTextBoxColumn();
            buttonAddTrigger = new Button();
            groupBox1 = new GroupBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox2 = new GroupBox();
            checkBox6 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            button2 = new Button();
            listBox1 = new ListBox();
            buttonReset = new Button();
            buttonVivod = new Button();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { type, input1, input2, input3, output1, output2 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(694, 329);
            dataGridView1.TabIndex = 0;
            // 
            // type
            // 
            type.HeaderText = "Вид триггера";
            type.MinimumWidth = 6;
            type.Name = "type";
            type.ReadOnly = true;
            // 
            // input1
            // 
            input1.HeaderText = "R(RS)/J(JK)";
            input1.MinimumWidth = 6;
            input1.Name = "input1";
            input1.ReadOnly = true;
            // 
            // input2
            // 
            input2.HeaderText = "S(RS)/K(JK)";
            input2.MinimumWidth = 6;
            input2.Name = "input2";
            input2.ReadOnly = true;
            // 
            // input3
            // 
            input3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            input3.HeaderText = "T";
            input3.MinimumWidth = 6;
            input3.Name = "input3";
            input3.ReadOnly = true;
            input3.Width = 46;
            // 
            // output1
            // 
            output1.HeaderText = "Выход №1";
            output1.MinimumWidth = 6;
            output1.Name = "output1";
            output1.ReadOnly = true;
            // 
            // output2
            // 
            output2.HeaderText = "Выход №2";
            output2.MinimumWidth = 6;
            output2.Name = "output2";
            output2.ReadOnly = true;
            // 
            // buttonAddTrigger
            // 
            buttonAddTrigger.Location = new Point(61, 173);
            buttonAddTrigger.Name = "buttonAddTrigger";
            buttonAddTrigger.Size = new Size(94, 29);
            buttonAddTrigger.TabIndex = 1;
            buttonAddTrigger.Text = "Добавить";
            buttonAddTrigger.UseVisualStyleBackColor = true;
            buttonAddTrigger.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(buttonAddTrigger);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(12, 373);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(225, 219);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Новый триггер";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(8, 130);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(39, 24);
            checkBox3.TabIndex = 4;
            checkBox3.Text = "T";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(8, 100);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(105, 24);
            checkBox2.TabIndex = 3;
            checkBox2.Text = "S(RS)/K(JK)";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(8, 70);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(102, 24);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "R(RS)/J(JK)";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(118, 31);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(103, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "JK-триггер";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 31);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(106, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "RS-триггер";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBox6);
            groupBox2.Controls.Add(checkBox5);
            groupBox2.Controls.Add(checkBox4);
            groupBox2.Controls.Add(button2);
            groupBox2.Location = new Point(243, 373);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(238, 219);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Установить все триггеры в это состояние:";
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(6, 130);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(39, 24);
            checkBox6.TabIndex = 3;
            checkBox6.Text = "T";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(6, 100);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(105, 24);
            checkBox5.TabIndex = 2;
            checkBox5.Text = "S(RS)/K(JK)";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(6, 70);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(102, 24);
            checkBox4.TabIndex = 1;
            checkBox4.Text = "R(RS)/J(JK)";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(69, 163);
            button2.Name = "button2";
            button2.Size = new Size(98, 39);
            button2.TabIndex = 0;
            button2.Text = "Установить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 17;
            listBox1.Location = new Point(8, 25);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(321, 310);
            listBox1.TabIndex = 4;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(500, 373);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(182, 31);
            buttonReset.TabIndex = 0;
            buttonReset.Text = "Reset всех  триггеров";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonVivod
            // 
            buttonVivod.Location = new Point(6, 350);
            buttonVivod.Name = "buttonVivod";
            buttonVivod.Size = new Size(328, 36);
            buttonVivod.TabIndex = 5;
            buttonVivod.Text = "Вывести информацию обо всех триггерах";
            buttonVivod.UseVisualStyleBackColor = true;
            buttonVivod.Click += buttonVivod_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(12, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(700, 355);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Триггеры";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(listBox1);
            groupBox4.Controls.Add(buttonVivod);
            groupBox4.Location = new Point(718, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(340, 392);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 596);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(buttonReset);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonAddTrigger;
        private GroupBox groupBox1;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox groupBox2;
        private ListBox listBox1;
        private Button buttonReset;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private Button button2;
        private Button buttonVivod;
        private DataGridViewTextBoxColumn type;
        private DataGridViewTextBoxColumn input1;
        private DataGridViewTextBoxColumn input2;
        private DataGridViewTextBoxColumn input3;
        private DataGridViewTextBoxColumn output1;
        private DataGridViewTextBoxColumn output2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
    }
}
