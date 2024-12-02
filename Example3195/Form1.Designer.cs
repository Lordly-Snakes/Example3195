namespace Example3195
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            colorDialog1 = new ColorDialog();
            timer1 = new System.Windows.Forms.Timer(components);
            openFileDialog1 = new OpenFileDialog();
            dataGridView1 = new DataGridView();
            imageBox = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            currentSel = new Label();
            physLabel = new Label();
            actionButton = new Button();
            debugBox = new GroupBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            labelV0 = new Label();
            labelph = new Label();
            labelTime = new Label();
            labelA = new Label();
            checkBox1 = new CheckBox();
            menuStrip1 = new MenuStrip();
            настройкиToolStripMenuItem = new ToolStripMenuItem();
            настройкаЦветовToolStripMenuItem = new ToolStripMenuItem();
            настройкаСкоростиToolStripMenuItem = new ToolStripMenuItem();
            показатьубратьОтладкуToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imageBox).BeginInit();
            debugBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Location = new Point(12, 138);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 35;
            dataGridView1.Size = new Size(568, 35);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // imageBox
            // 
            imageBox.Image = Properties.Resources.baraban_finel;
            imageBox.Location = new Point(586, 41);
            imageBox.Name = "imageBox";
            imageBox.Size = new Size(447, 436);
            imageBox.SizeMode = PictureBoxSizeMode.Zoom;
            imageBox.TabIndex = 3;
            imageBox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(500, 221);
            label1.Name = "label1";
            label1.Size = new Size(80, 65);
            label1.TabIndex = 5;
            label1.Text = "->";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 41);
            label2.Name = "label2";
            label2.Size = new Size(33, 40);
            label2.TabIndex = 6;
            label2.Text = "0";
            // 
            // currentSel
            // 
            currentSel.AutoSize = true;
            currentSel.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            currentSel.Location = new Point(6, 254);
            currentSel.Name = "currentSel";
            currentSel.Size = new Size(33, 40);
            currentSel.TabIndex = 8;
            currentSel.Text = "0";
            // 
            // physLabel
            // 
            physLabel.AutoSize = true;
            physLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            physLabel.Location = new Point(79, 18);
            physLabel.Name = "physLabel";
            physLabel.Size = new Size(105, 45);
            physLabel.TabIndex = 12;
            physLabel.Text = "label6";
            // 
            // actionButton
            // 
            actionButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            actionButton.Location = new Point(371, 41);
            actionButton.Name = "actionButton";
            actionButton.Size = new Size(209, 90);
            actionButton.TabIndex = 13;
            actionButton.UseVisualStyleBackColor = true;
            actionButton.Click += actionButton_Click;
            // 
            // debugBox
            // 
            debugBox.Controls.Add(pictureBox5);
            debugBox.Controls.Add(pictureBox4);
            debugBox.Controls.Add(pictureBox3);
            debugBox.Controls.Add(pictureBox2);
            debugBox.Controls.Add(pictureBox1);
            debugBox.Controls.Add(labelV0);
            debugBox.Controls.Add(labelph);
            debugBox.Controls.Add(labelTime);
            debugBox.Controls.Add(labelA);
            debugBox.Controls.Add(currentSel);
            debugBox.Controls.Add(physLabel);
            debugBox.Location = new Point(12, 179);
            debugBox.Name = "debugBox";
            debugBox.Size = new Size(187, 298);
            debugBox.TabIndex = 14;
            debugBox.TabStop = false;
            debugBox.Text = "Отладочные данные";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Снимок_экрана_2024_11_29_185137;
            pictureBox5.Location = new Point(6, 201);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(67, 38);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 20;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Снимок_экрана_2024_11_29_184234;
            pictureBox4.Location = new Point(6, 157);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(67, 38);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 19;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Снимок_экрана_2024_11_29_184510;
            pictureBox3.Location = new Point(6, 113);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(67, 38);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Снимок_экрана_2024_11_29_184249;
            pictureBox2.Location = new Point(6, 69);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(67, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources.Снимок_экрана_2024_11_29_184244;
            pictureBox1.Image = Properties.Resources.Снимок_экрана_2024_11_29_184244;
            pictureBox1.InitialImage = Properties.Resources.Снимок_экрана_2024_11_29_184244;
            pictureBox1.Location = new Point(6, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // labelV0
            // 
            labelV0.AutoSize = true;
            labelV0.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelV0.Location = new Point(79, 198);
            labelV0.Name = "labelV0";
            labelV0.Size = new Size(105, 45);
            labelV0.TabIndex = 16;
            labelV0.Text = "label6";
            // 
            // labelph
            // 
            labelph.AutoSize = true;
            labelph.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelph.Location = new Point(79, 63);
            labelph.Name = "labelph";
            labelph.Size = new Size(105, 45);
            labelph.TabIndex = 15;
            labelph.Text = "label6";
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTime.Location = new Point(79, 108);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(105, 45);
            labelTime.TabIndex = 14;
            labelTime.Text = "label6";
            // 
            // labelA
            // 
            labelA.AutoSize = true;
            labelA.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelA.Location = new Point(79, 153);
            labelA.Name = "labelA";
            labelA.Size = new Size(105, 45);
            labelA.TabIndex = 13;
            labelA.Text = "label6";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 112);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(91, 19);
            checkBox1.TabIndex = 15;
            checkBox1.Text = "Режим авто";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { настройкиToolStripMenuItem, выходToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1072, 24);
            menuStrip1.TabIndex = 16;
            menuStrip1.Text = "menuStrip1";
            // 
            // настройкиToolStripMenuItem
            // 
            настройкиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { настройкаЦветовToolStripMenuItem, настройкаСкоростиToolStripMenuItem, показатьубратьОтладкуToolStripMenuItem });
            настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            настройкиToolStripMenuItem.Size = new Size(79, 20);
            настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // настройкаЦветовToolStripMenuItem
            // 
            настройкаЦветовToolStripMenuItem.Name = "настройкаЦветовToolStripMenuItem";
            настройкаЦветовToolStripMenuItem.Size = new Size(212, 22);
            настройкаЦветовToolStripMenuItem.Text = "Настройка цветов";
            настройкаЦветовToolStripMenuItem.Click += настройкаЦветовToolStripMenuItem_Click;
            // 
            // настройкаСкоростиToolStripMenuItem
            // 
            настройкаСкоростиToolStripMenuItem.Name = "настройкаСкоростиToolStripMenuItem";
            настройкаСкоростиToolStripMenuItem.Size = new Size(212, 22);
            настройкаСкоростиToolStripMenuItem.Text = "Настройка скорости";
            настройкаСкоростиToolStripMenuItem.Click += настройкаСкоростиToolStripMenuItem_Click;
            // 
            // показатьубратьОтладкуToolStripMenuItem
            // 
            показатьубратьОтладкуToolStripMenuItem.Name = "показатьубратьОтладкуToolStripMenuItem";
            показатьубратьОтладкуToolStripMenuItem.Size = new Size(212, 22);
            показатьубратьОтладкуToolStripMenuItem.Text = "Показать/убрать отладку";
            показатьубратьОтладкуToolStripMenuItem.Click += показатьубратьОтладкуToolStripMenuItem_Click;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(53, 20);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 528);
            Controls.Add(checkBox1);
            Controls.Add(debugBox);
            Controls.Add(actionButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(imageBox);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "ПОЛЕ ЧУДЕС";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)imageBox).EndInit();
            debugBox.ResumeLayout(false);
            debugBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ColorDialog colorDialog1;
        private System.Windows.Forms.Timer timer1;
        private OpenFileDialog openFileDialog1;
        public DataGridView dataGridView1;
        private PictureBox imageBox;
        private Label label1;
        private Label label2;
        private Label currentSel;
        private Label physLabel;
        private Button actionButton;
        private GroupBox debugBox;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label labelV0;
        private Label labelph;
        private Label labelTime;
        private Label labelA;
        private CheckBox checkBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem настройкиToolStripMenuItem;
        private ToolStripMenuItem настройкаЦветовToolStripMenuItem;
        private ToolStripMenuItem настройкаСкоростиToolStripMenuItem;
        private ToolStripMenuItem показатьубратьОтладкуToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
    }
}
