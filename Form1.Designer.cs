namespace Tetris
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_NewGame = new System.Windows.Forms.Button();
            this.Btn_Stop = new System.Windows.Forms.Button();
            this.Btn_Continue = new System.Windows.Forms.Button();
            this.Btn_Quit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(401, 420);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(441, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(141, 140);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(441, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 86);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // Btn_NewGame
            // 
            this.Btn_NewGame.Location = new System.Drawing.Point(445, 318);
            this.Btn_NewGame.Name = "Btn_NewGame";
            this.Btn_NewGame.Size = new System.Drawing.Size(75, 23);
            this.Btn_NewGame.TabIndex = 4;
            this.Btn_NewGame.Text = "新局";
            this.Btn_NewGame.UseVisualStyleBackColor = true;
            this.Btn_NewGame.Click += new System.EventHandler(this.Btn_NewGame_Click);
            // 
            // Btn_Stop
            // 
            this.Btn_Stop.Location = new System.Drawing.Point(445, 348);
            this.Btn_Stop.Name = "Btn_Stop";
            this.Btn_Stop.Size = new System.Drawing.Size(75, 23);
            this.Btn_Stop.TabIndex = 5;
            this.Btn_Stop.Text = "暂停";
            this.Btn_Stop.UseVisualStyleBackColor = true;
            this.Btn_Stop.Click += new System.EventHandler(this.Btn_Stop_Click);
            // 
            // Btn_Continue
            // 
            this.Btn_Continue.Location = new System.Drawing.Point(445, 378);
            this.Btn_Continue.Name = "Btn_Continue";
            this.Btn_Continue.Size = new System.Drawing.Size(75, 23);
            this.Btn_Continue.TabIndex = 6;
            this.Btn_Continue.Text = "继续";
            this.Btn_Continue.UseVisualStyleBackColor = true;
            this.Btn_Continue.Click += new System.EventHandler(this.Btn_Continue_Click);
            // 
            // Btn_Quit
            // 
            this.Btn_Quit.Location = new System.Drawing.Point(445, 408);
            this.Btn_Quit.Name = "Btn_Quit";
            this.Btn_Quit.Size = new System.Drawing.Size(75, 23);
            this.Btn_Quit.TabIndex = 7;
            this.Btn_Quit.Text = "退出";
            this.Btn_Quit.UseVisualStyleBackColor = true;
            this.Btn_Quit.Click += new System.EventHandler(this.Btn_Quit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 444);
            this.Controls.Add(this.Btn_Quit);
            this.Controls.Add(this.Btn_Continue);
            this.Controls.Add(this.Btn_Stop);
            this.Controls.Add(this.Btn_NewGame);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_NewGame;
        private System.Windows.Forms.Button Btn_Stop;
        private System.Windows.Forms.Button Btn_Continue;
        private System.Windows.Forms.Button Btn_Quit;

    }
}

