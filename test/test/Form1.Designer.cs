namespace test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_ChangeText = new System.Windows.Forms.Button();
            this.cb_enableChange = new System.Windows.Forms.CheckBox();
            this.label_toChange = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ChangeText
            // 
            this.btn_ChangeText.Location = new System.Drawing.Point(25, 21);
            this.btn_ChangeText.Name = "btn_ChangeText";
            this.btn_ChangeText.Size = new System.Drawing.Size(150, 26);
            this.btn_ChangeText.TabIndex = 0;
            this.btn_ChangeText.Text = "Change label if checked";
            this.btn_ChangeText.UseVisualStyleBackColor = true;
            this.btn_ChangeText.Click += new System.EventHandler(this.btn_ChangeText_Click);
            // 
            // cb_enableChange
            // 
            this.cb_enableChange.AutoSize = true;
            this.cb_enableChange.Checked = true;
            this.cb_enableChange.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_enableChange.Location = new System.Drawing.Point(205, 27);
            this.cb_enableChange.Name = "cb_enableChange";
            this.cb_enableChange.Size = new System.Drawing.Size(150, 16);
            this.cb_enableChange.TabIndex = 1;
            this.cb_enableChange.Text = "Enable label changing";
            this.cb_enableChange.UseVisualStyleBackColor = true;
            // 
            // label_toChange
            // 
            this.label_toChange.Location = new System.Drawing.Point(30, 84);
            this.label_toChange.Name = "label_toChange";
            this.label_toChange.Size = new System.Drawing.Size(325, 22);
            this.label_toChange.TabIndex = 2;
            this.label_toChange.Text = "Press button to change my text";
            this.label_toChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(384, 19);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(495, 323);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 354);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label_toChange);
            this.Controls.Add(this.cb_enableChange);
            this.Controls.Add(this.btn_ChangeText);
            this.Name = "Form1";
            this.Text = "My Desktop App";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ChangeText;
        private System.Windows.Forms.CheckBox cb_enableChange;
        private System.Windows.Forms.Label label_toChange;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

