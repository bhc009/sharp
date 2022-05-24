namespace ch3_moneyTrading
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
            this.label_moneyOfJoe = new System.Windows.Forms.Label();
            this.label_moneyOfBob = new System.Windows.Forms.Label();
            this.label_moneyOfBank = new System.Windows.Forms.Label();
            this.button_giveMoneyToJoe = new System.Windows.Forms.Button();
            this.button_getMoneyFromBob = new System.Windows.Forms.Button();
            this.btn_joeGiveToBob = new System.Windows.Forms.Button();
            this.btn_bobGiveToJoe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_moneyOfJoe
            // 
            this.label_moneyOfJoe.AutoSize = true;
            this.label_moneyOfJoe.Location = new System.Drawing.Point(22, 20);
            this.label_moneyOfJoe.Name = "label_moneyOfJoe";
            this.label_moneyOfJoe.Size = new System.Drawing.Size(38, 12);
            this.label_moneyOfJoe.TabIndex = 0;
            this.label_moneyOfJoe.Text = "label1";
            // 
            // label_moneyOfBob
            // 
            this.label_moneyOfBob.AutoSize = true;
            this.label_moneyOfBob.Location = new System.Drawing.Point(22, 47);
            this.label_moneyOfBob.Name = "label_moneyOfBob";
            this.label_moneyOfBob.Size = new System.Drawing.Size(38, 12);
            this.label_moneyOfBob.TabIndex = 0;
            this.label_moneyOfBob.Text = "label1";
            // 
            // label_moneyOfBank
            // 
            this.label_moneyOfBank.AutoSize = true;
            this.label_moneyOfBank.Location = new System.Drawing.Point(22, 79);
            this.label_moneyOfBank.Name = "label_moneyOfBank";
            this.label_moneyOfBank.Size = new System.Drawing.Size(38, 12);
            this.label_moneyOfBank.TabIndex = 0;
            this.label_moneyOfBank.Text = "label1";
            // 
            // button_giveMoneyToJoe
            // 
            this.button_giveMoneyToJoe.Location = new System.Drawing.Point(24, 110);
            this.button_giveMoneyToJoe.Name = "button_giveMoneyToJoe";
            this.button_giveMoneyToJoe.Size = new System.Drawing.Size(106, 33);
            this.button_giveMoneyToJoe.TabIndex = 1;
            this.button_giveMoneyToJoe.Text = "Give 10$ to Joe";
            this.button_giveMoneyToJoe.UseVisualStyleBackColor = true;
            this.button_giveMoneyToJoe.Click += new System.EventHandler(this.button_giveMoneyToJoe_Click);
            // 
            // button_getMoneyFromBob
            // 
            this.button_getMoneyFromBob.Location = new System.Drawing.Point(148, 110);
            this.button_getMoneyFromBob.Name = "button_getMoneyFromBob";
            this.button_getMoneyFromBob.Size = new System.Drawing.Size(106, 33);
            this.button_getMoneyFromBob.TabIndex = 1;
            this.button_getMoneyFromBob.Text = "Get 5$ from Bob";
            this.button_getMoneyFromBob.UseVisualStyleBackColor = true;
            this.button_getMoneyFromBob.Click += new System.EventHandler(this.button_getMoneyToBob_Click);
            // 
            // btn_joeGiveToBob
            // 
            this.btn_joeGiveToBob.Location = new System.Drawing.Point(24, 150);
            this.btn_joeGiveToBob.Name = "btn_joeGiveToBob";
            this.btn_joeGiveToBob.Size = new System.Drawing.Size(105, 44);
            this.btn_joeGiveToBob.TabIndex = 2;
            this.btn_joeGiveToBob.Text = "Joe gives 10$ to bob";
            this.btn_joeGiveToBob.UseVisualStyleBackColor = true;
            this.btn_joeGiveToBob.Click += new System.EventHandler(this.btn_joeGiveToBob_Click);
            // 
            // btn_bobGiveToJoe
            // 
            this.btn_bobGiveToJoe.Location = new System.Drawing.Point(148, 150);
            this.btn_bobGiveToJoe.Name = "btn_bobGiveToJoe";
            this.btn_bobGiveToJoe.Size = new System.Drawing.Size(105, 43);
            this.btn_bobGiveToJoe.TabIndex = 3;
            this.btn_bobGiveToJoe.Text = "bob gives 5$ to Joe";
            this.btn_bobGiveToJoe.UseVisualStyleBackColor = true;
            this.btn_bobGiveToJoe.Click += new System.EventHandler(this.btn_bobGiveToJoe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 209);
            this.Controls.Add(this.btn_bobGiveToJoe);
            this.Controls.Add(this.btn_joeGiveToBob);
            this.Controls.Add(this.button_getMoneyFromBob);
            this.Controls.Add(this.button_giveMoneyToJoe);
            this.Controls.Add(this.label_moneyOfBank);
            this.Controls.Add(this.label_moneyOfBob);
            this.Controls.Add(this.label_moneyOfJoe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_moneyOfJoe;
        private System.Windows.Forms.Label label_moneyOfBob;
        private System.Windows.Forms.Label label_moneyOfBank;
        private System.Windows.Forms.Button button_giveMoneyToJoe;
        private System.Windows.Forms.Button button_getMoneyFromBob;
        private System.Windows.Forms.Button btn_joeGiveToBob;
        private System.Windows.Forms.Button btn_bobGiveToJoe;
    }
}

