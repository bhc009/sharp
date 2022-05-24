namespace ch4_type
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
            this.btn_set = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nud_start = new System.Windows.Forms.NumericUpDown();
            this.nud_end = new System.Windows.Forms.NumericUpDown();
            this.label_own = new System.Windows.Forms.Label();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_lloyd = new System.Windows.Forms.Button();
            this.btn_lucinda = new System.Windows.Forms.Button();
            this.btn_swap = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label_menu_1 = new System.Windows.Forms.Label();
            this.label_menu_2 = new System.Windows.Forms.Label();
            this.label_menu_3 = new System.Windows.Forms.Label();
            this.label_menu_4 = new System.Windows.Forms.Label();
            this.label_menu_5 = new System.Windows.Forms.Label();
            this.label_menu_6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_end)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_set
            // 
            this.btn_set.Location = new System.Drawing.Point(46, 34);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(112, 40);
            this.btn_set.TabIndex = 0;
            this.btn_set.Text = "set";
            this.btn_set.UseVisualStyleBackColor = true;
            this.btn_set.Click += new System.EventHandler(this.btn_set_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(19, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mileage calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "starting mileage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ending mileage";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "Amount owned :";
            // 
            // nud_start
            // 
            this.nud_start.Location = new System.Drawing.Point(141, 125);
            this.nud_start.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nud_start.Name = "nud_start";
            this.nud_start.Size = new System.Drawing.Size(189, 21);
            this.nud_start.TabIndex = 3;
            // 
            // nud_end
            // 
            this.nud_end.Location = new System.Drawing.Point(141, 156);
            this.nud_end.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nud_end.Name = "nud_end";
            this.nud_end.Size = new System.Drawing.Size(189, 21);
            this.nud_end.TabIndex = 3;
            // 
            // label_own
            // 
            this.label_own.AutoSize = true;
            this.label_own.Location = new System.Drawing.Point(139, 191);
            this.label_own.Name = "label_own";
            this.label_own.Size = new System.Drawing.Size(38, 12);
            this.label_own.TabIndex = 2;
            this.label_own.Text = "label2";
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(23, 227);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(307, 23);
            this.btn_calculate.TabIndex = 4;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(23, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 14);
            this.label5.TabIndex = 1;
            this.label5.Text = "Swap";
            // 
            // btn_lloyd
            // 
            this.btn_lloyd.Location = new System.Drawing.Point(25, 338);
            this.btn_lloyd.Name = "btn_lloyd";
            this.btn_lloyd.Size = new System.Drawing.Size(73, 26);
            this.btn_lloyd.TabIndex = 5;
            this.btn_lloyd.Text = "Lloyd";
            this.btn_lloyd.UseVisualStyleBackColor = true;
            this.btn_lloyd.Click += new System.EventHandler(this.btn_lloyd_Click);
            // 
            // btn_lucinda
            // 
            this.btn_lucinda.Location = new System.Drawing.Point(25, 370);
            this.btn_lucinda.Name = "btn_lucinda";
            this.btn_lucinda.Size = new System.Drawing.Size(73, 26);
            this.btn_lucinda.TabIndex = 5;
            this.btn_lucinda.Text = "Lucinda";
            this.btn_lucinda.UseVisualStyleBackColor = true;
            this.btn_lucinda.Click += new System.EventHandler(this.btn_lucinda_Click);
            // 
            // btn_swap
            // 
            this.btn_swap.Location = new System.Drawing.Point(25, 402);
            this.btn_swap.Name = "btn_swap";
            this.btn_swap.Size = new System.Drawing.Size(73, 26);
            this.btn_swap.TabIndex = 5;
            this.btn_swap.Text = "Swap!";
            this.btn_swap.UseVisualStyleBackColor = true;
            this.btn_swap.Click += new System.EventHandler(this.btn_swap_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(397, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 14);
            this.label6.TabIndex = 1;
            this.label6.Text = "Sloppy Joe\'s menu";
            // 
            // label_menu_1
            // 
            this.label_menu_1.AutoSize = true;
            this.label_menu_1.Location = new System.Drawing.Point(398, 61);
            this.label_menu_1.Name = "label_menu_1";
            this.label_menu_1.Size = new System.Drawing.Size(38, 12);
            this.label_menu_1.TabIndex = 6;
            this.label_menu_1.Text = "label7";
            // 
            // label_menu_2
            // 
            this.label_menu_2.AutoSize = true;
            this.label_menu_2.Location = new System.Drawing.Point(398, 87);
            this.label_menu_2.Name = "label_menu_2";
            this.label_menu_2.Size = new System.Drawing.Size(38, 12);
            this.label_menu_2.TabIndex = 6;
            this.label_menu_2.Text = "label7";
            // 
            // label_menu_3
            // 
            this.label_menu_3.AutoSize = true;
            this.label_menu_3.Location = new System.Drawing.Point(398, 113);
            this.label_menu_3.Name = "label_menu_3";
            this.label_menu_3.Size = new System.Drawing.Size(38, 12);
            this.label_menu_3.TabIndex = 6;
            this.label_menu_3.Text = "label7";
            // 
            // label_menu_4
            // 
            this.label_menu_4.AutoSize = true;
            this.label_menu_4.Location = new System.Drawing.Point(398, 139);
            this.label_menu_4.Name = "label_menu_4";
            this.label_menu_4.Size = new System.Drawing.Size(38, 12);
            this.label_menu_4.TabIndex = 6;
            this.label_menu_4.Text = "label7";
            // 
            // label_menu_5
            // 
            this.label_menu_5.AutoSize = true;
            this.label_menu_5.Location = new System.Drawing.Point(398, 165);
            this.label_menu_5.Name = "label_menu_5";
            this.label_menu_5.Size = new System.Drawing.Size(38, 12);
            this.label_menu_5.TabIndex = 6;
            this.label_menu_5.Text = "label7";
            // 
            // label_menu_6
            // 
            this.label_menu_6.AutoSize = true;
            this.label_menu_6.Location = new System.Drawing.Point(398, 191);
            this.label_menu_6.Name = "label_menu_6";
            this.label_menu_6.Size = new System.Drawing.Size(38, 12);
            this.label_menu_6.TabIndex = 6;
            this.label_menu_6.Text = "label7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 496);
            this.Controls.Add(this.label_menu_6);
            this.Controls.Add(this.label_menu_5);
            this.Controls.Add(this.label_menu_4);
            this.Controls.Add(this.label_menu_3);
            this.Controls.Add(this.label_menu_2);
            this.Controls.Add(this.label_menu_1);
            this.Controls.Add(this.btn_swap);
            this.Controls.Add(this.btn_lucinda);
            this.Controls.Add(this.btn_lloyd);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.nud_end);
            this.Controls.Add(this.nud_start);
            this.Controls.Add(this.label_own);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_set);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nud_start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_end)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_set;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nud_start;
        private System.Windows.Forms.NumericUpDown nud_end;
        private System.Windows.Forms.Label label_own;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_lloyd;
        private System.Windows.Forms.Button btn_lucinda;
        private System.Windows.Forms.Button btn_swap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_menu_1;
        private System.Windows.Forms.Label label_menu_2;
        private System.Windows.Forms.Label label_menu_3;
        private System.Windows.Forms.Label label_menu_4;
        private System.Windows.Forms.Label label_menu_5;
        private System.Windows.Forms.Label label_menu_6;
    }
}

