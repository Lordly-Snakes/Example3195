namespace Example3195
{
    partial class selColor
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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ControlDark;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(75, 59);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ControlDark;
            label2.Location = new Point(93, 9);
            label2.Name = "label2";
            label2.Size = new Size(81, 59);
            label2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(12, 72);
            button1.Name = "button1";
            button1.Size = new Size(75, 56);
            button1.TabIndex = 2;
            button1.Text = "цвет выбранной ячейки";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(93, 72);
            button2.Name = "button2";
            button2.Size = new Size(81, 56);
            button2.TabIndex = 3;
            button2.Text = "цвет фона ячеек";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // selColor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(186, 173);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "selColor";
            Text = "selColor";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}