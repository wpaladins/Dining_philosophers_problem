namespace Dining_philosophers_problem
{
    partial class Dining_philosophers_problem
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dining_philosophers_problem));
            this.start = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.pause_pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chopstick2 = new System.Windows.Forms.PictureBox();
            this.chopstick1 = new System.Windows.Forms.PictureBox();
            this.chopstick0 = new System.Windows.Forms.PictureBox();
            this.chopstick4 = new System.Windows.Forms.PictureBox();
            this.chopstick3 = new System.Windows.Forms.PictureBox();
            this.philosopher0 = new System.Windows.Forms.PictureBox();
            this.philosopher4 = new System.Windows.Forms.PictureBox();
            this.philosopher3 = new System.Windows.Forms.PictureBox();
            this.philosopher2 = new System.Windows.Forms.PictureBox();
            this.philosopher1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pause_pictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chopstick2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chopstick1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chopstick0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chopstick4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chopstick3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.philosopher0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.philosopher4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.philosopher3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.philosopher2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.philosopher1)).BeginInit();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(169, 479);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(107, 50);
            this.start.TabIndex = 1;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // pause
            // 
            this.pause.Location = new System.Drawing.Point(301, 479);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(107, 50);
            this.pause.TabIndex = 2;
            this.pause.Text = "Pause";
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // pause_pictureBox
            // 
            this.pause_pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pause_pictureBox.Name = "pause_pictureBox";
            this.pause_pictureBox.Size = new System.Drawing.Size(558, 423);
            this.pause_pictureBox.TabIndex = 3;
            this.pause_pictureBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.BackgroundImage = global::Dining_philosophers_problem.Resource1.desk1;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chopstick2);
            this.groupBox1.Controls.Add(this.chopstick1);
            this.groupBox1.Controls.Add(this.chopstick0);
            this.groupBox1.Controls.Add(this.chopstick4);
            this.groupBox1.Controls.Add(this.chopstick3);
            this.groupBox1.Controls.Add(this.philosopher0);
            this.groupBox1.Controls.Add(this.philosopher4);
            this.groupBox1.Controls.Add(this.philosopher3);
            this.groupBox1.Controls.Add(this.philosopher2);
            this.groupBox1.Controls.Add(this.philosopher1);
            this.groupBox1.Location = new System.Drawing.Point(33, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 393);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Desk";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "philosopher0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "philosopher4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "philosopher3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "philosopher2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "philosopher1";
            // 
            // chopstick2
            // 
            this.chopstick2.Location = new System.Drawing.Point(201, 61);
            this.chopstick2.Name = "chopstick2";
            this.chopstick2.Size = new System.Drawing.Size(100, 50);
            this.chopstick2.TabIndex = 9;
            this.chopstick2.TabStop = false;
            // 
            // chopstick1
            // 
            this.chopstick1.Location = new System.Drawing.Point(106, 129);
            this.chopstick1.Name = "chopstick1";
            this.chopstick1.Size = new System.Drawing.Size(100, 50);
            this.chopstick1.TabIndex = 8;
            this.chopstick1.TabStop = false;
            // 
            // chopstick0
            // 
            this.chopstick0.Location = new System.Drawing.Point(151, 190);
            this.chopstick0.Name = "chopstick0";
            this.chopstick0.Size = new System.Drawing.Size(100, 50);
            this.chopstick0.TabIndex = 7;
            this.chopstick0.TabStop = false;
            // 
            // chopstick4
            // 
            this.chopstick4.Location = new System.Drawing.Point(257, 192);
            this.chopstick4.Name = "chopstick4";
            this.chopstick4.Size = new System.Drawing.Size(100, 50);
            this.chopstick4.TabIndex = 6;
            this.chopstick4.TabStop = false;
            // 
            // chopstick3
            // 
            this.chopstick3.Location = new System.Drawing.Point(307, 130);
            this.chopstick3.Name = "chopstick3";
            this.chopstick3.Size = new System.Drawing.Size(100, 50);
            this.chopstick3.TabIndex = 5;
            this.chopstick3.TabStop = false;
            // 
            // philosopher0
            // 
            this.philosopher0.Location = new System.Drawing.Point(24, 251);
            this.philosopher0.Name = "philosopher0";
            this.philosopher0.Size = new System.Drawing.Size(40, 40);
            this.philosopher0.TabIndex = 4;
            this.philosopher0.TabStop = false;
            // 
            // philosopher4
            // 
            this.philosopher4.Location = new System.Drawing.Point(239, 319);
            this.philosopher4.Name = "philosopher4";
            this.philosopher4.Size = new System.Drawing.Size(40, 40);
            this.philosopher4.TabIndex = 3;
            this.philosopher4.TabStop = false;
            // 
            // philosopher3
            // 
            this.philosopher3.Location = new System.Drawing.Point(445, 237);
            this.philosopher3.Name = "philosopher3";
            this.philosopher3.Size = new System.Drawing.Size(40, 40);
            this.philosopher3.TabIndex = 2;
            this.philosopher3.TabStop = false;
            // 
            // philosopher2
            // 
            this.philosopher2.Location = new System.Drawing.Point(423, 52);
            this.philosopher2.Name = "philosopher2";
            this.philosopher2.Size = new System.Drawing.Size(40, 40);
            this.philosopher2.TabIndex = 1;
            this.philosopher2.TabStop = false;
            // 
            // philosopher1
            // 
            this.philosopher1.Location = new System.Drawing.Point(78, 38);
            this.philosopher1.Name = "philosopher1";
            this.philosopher1.Size = new System.Drawing.Size(40, 40);
            this.philosopher1.TabIndex = 0;
            this.philosopher1.TabStop = false;
            // 
            // Dining_philosophers_problem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(578, 560);
            this.Controls.Add(this.pause_pictureBox);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.start);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Dining_philosophers_problem";
            this.Text = "Dining philosophers problem by CS1504 WangXuSheng";
            this.Load += new System.EventHandler(this.Dining_philosophers_problem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pause_pictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chopstick2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chopstick1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chopstick0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chopstick4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chopstick3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.philosopher0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.philosopher4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.philosopher3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.philosopher2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.philosopher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.PictureBox chopstick2;
        private System.Windows.Forms.PictureBox chopstick1;
        private System.Windows.Forms.PictureBox chopstick0;
        private System.Windows.Forms.PictureBox chopstick4;
        private System.Windows.Forms.PictureBox chopstick3;
        private System.Windows.Forms.PictureBox philosopher0;
        private System.Windows.Forms.PictureBox philosopher4;
        private System.Windows.Forms.PictureBox philosopher3;
        private System.Windows.Forms.PictureBox philosopher2;
        private System.Windows.Forms.PictureBox philosopher1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pause_pictureBox;
    }
}

