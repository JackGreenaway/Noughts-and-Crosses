namespace TicTacToe
{
    partial class Window
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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button3 = new Button();
            button2 = new Button();
            button5 = new Button();
            button6 = new Button();
            button4 = new Button();
            button8 = new Button();
            button9 = new Button();
            button7 = new Button();
            button10 = new Button();
            AI_timer = new System.Windows.Forms.Timer(components);
            button11 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.GreenYellow;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(192, 46);
            label1.TabIndex = 0;
            label1.Tag = "";
            label1.Text = "Player Wins";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Salmon;
            label2.Location = new Point(465, 9);
            label2.Name = "label2";
            label2.Size = new Size(133, 46);
            label2.TabIndex = 1;
            label2.Text = "AI Wins";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(65, 111);
            button1.Name = "button1";
            button1.Size = new Size(170, 170);
            button1.TabIndex = 3;
            button1.Tag = "play";
            button1.Text = "?";
            button1.UseVisualStyleBackColor = true;
            button1.Click += PlayerMove;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(417, 111);
            button3.Name = "button3";
            button3.Size = new Size(170, 170);
            button3.TabIndex = 4;
            button3.Tag = "play";
            button3.Text = "?";
            button3.UseVisualStyleBackColor = true;
            button3.Click += PlayerMove;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(241, 111);
            button2.Name = "button2";
            button2.Size = new Size(170, 170);
            button2.TabIndex = 5;
            button2.Tag = "play";
            button2.Text = "?";
            button2.UseVisualStyleBackColor = true;
            button2.Click += PlayerMove;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(241, 287);
            button5.Name = "button5";
            button5.Size = new Size(170, 170);
            button5.TabIndex = 8;
            button5.Tag = "play";
            button5.Text = "?";
            button5.UseVisualStyleBackColor = true;
            button5.Click += PlayerMove;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(417, 287);
            button6.Name = "button6";
            button6.Size = new Size(170, 170);
            button6.TabIndex = 7;
            button6.Tag = "play";
            button6.Text = "?";
            button6.UseVisualStyleBackColor = true;
            button6.Click += PlayerMove;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(65, 287);
            button4.Name = "button4";
            button4.Size = new Size(170, 170);
            button4.TabIndex = 6;
            button4.Tag = "play";
            button4.Text = "?";
            button4.UseVisualStyleBackColor = true;
            button4.Click += PlayerMove;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(241, 463);
            button8.Name = "button8";
            button8.Size = new Size(170, 170);
            button8.TabIndex = 11;
            button8.Tag = "play";
            button8.Text = "?";
            button8.UseVisualStyleBackColor = true;
            button8.Click += PlayerMove;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location = new Point(417, 463);
            button9.Name = "button9";
            button9.Size = new Size(170, 170);
            button9.TabIndex = 10;
            button9.Tag = "play";
            button9.Text = "?";
            button9.UseVisualStyleBackColor = true;
            button9.Click += PlayerMove;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(65, 463);
            button7.Name = "button7";
            button7.Size = new Size(170, 170);
            button7.TabIndex = 9;
            button7.Tag = "play";
            button7.Text = "?";
            button7.UseVisualStyleBackColor = true;
            button7.Click += PlayerMove;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button10.Location = new Point(228, 639);
            button10.Name = "button10";
            button10.Size = new Size(194, 57);
            button10.TabIndex = 12;
            button10.Tag = "Restart";
            button10.Text = "Restart Game";
            button10.UseVisualStyleBackColor = true;
            button10.Click += RestartGame;
            // 
            // AI_timer
            // 
            AI_timer.Tag = "ai_move";
            AI_timer.Tick += AImove;
            // 
            // button11
            // 
            button11.BackColor = Color.Red;
            button11.Location = new Point(607, 662);
            button11.Name = "button11";
            button11.Size = new Size(33, 29);
            button11.TabIndex = 13;
            button11.Tag = "HardReset";
            button11.UseVisualStyleBackColor = false;
            button11.Click += Hard_Reset;
            // 
            // Window
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 703);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button7);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            ImeMode = ImeMode.On;
            Name = "Window";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Noughts & Crossses";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button3;
        private Button button2;
        private Button button5;
        private Button button6;
        private Button button4;
        private Button button8;
        private Button button9;
        private Button button7;
        private Button button10;
        private System.Windows.Forms.Timer AI_timer;
        private Button button11;
    }
}