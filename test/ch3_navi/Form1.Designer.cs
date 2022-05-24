namespace ch3_navi
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_saying = new System.Windows.Forms.TextBox();
            this.btn_speak = new System.Windows.Forms.Button();
            this.nud_iteration = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nud_iteration)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Say this :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Number of times :";
            // 
            // tb_saying
            // 
            this.tb_saying.Location = new System.Drawing.Point(163, 22);
            this.tb_saying.Name = "tb_saying";
            this.tb_saying.Size = new System.Drawing.Size(193, 21);
            this.tb_saying.TabIndex = 1;
            this.tb_saying.Text = "Hello!";
            // 
            // btn_speak
            // 
            this.btn_speak.Location = new System.Drawing.Point(34, 104);
            this.btn_speak.Name = "btn_speak";
            this.btn_speak.Size = new System.Drawing.Size(322, 26);
            this.btn_speak.TabIndex = 3;
            this.btn_speak.Text = "Speak to me!";
            this.btn_speak.UseVisualStyleBackColor = true;
            this.btn_speak.Click += new System.EventHandler(this.btn_speak_Click);
            // 
            // nud_iteration
            // 
            this.nud_iteration.Location = new System.Drawing.Point(163, 55);
            this.nud_iteration.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_iteration.Name = "nud_iteration";
            this.nud_iteration.Size = new System.Drawing.Size(193, 21);
            this.nud_iteration.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 151);
            this.Controls.Add(this.nud_iteration);
            this.Controls.Add(this.btn_speak);
            this.Controls.Add(this.tb_saying);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nud_iteration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_saying;
        private System.Windows.Forms.Button btn_speak;
        private System.Windows.Forms.NumericUpDown nud_iteration;
    }
}

