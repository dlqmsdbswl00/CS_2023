namespace _002_BMI_WF
{
    partial class BMI_form
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
            this.lbl_cm = new System.Windows.Forms.Label();
            this.lbl_kg = new System.Windows.Forms.Label();
            this.txt_cm = new System.Windows.Forms.TextBox();
            this.txt_kg = new System.Windows.Forms.TextBox();
            this.btn_BMI = new System.Windows.Forms.Button();
            this.lbl_bmi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_cm
            // 
            this.lbl_cm.AutoSize = true;
            this.lbl_cm.Location = new System.Drawing.Point(12, 56);
            this.lbl_cm.Name = "lbl_cm";
            this.lbl_cm.Size = new System.Drawing.Size(29, 12);
            this.lbl_cm.TabIndex = 0;
            this.lbl_cm.Text = "키 : ";
            // 
            // lbl_kg
            // 
            this.lbl_kg.AutoSize = true;
            this.lbl_kg.Location = new System.Drawing.Point(12, 92);
            this.lbl_kg.Name = "lbl_kg";
            this.lbl_kg.Size = new System.Drawing.Size(41, 12);
            this.lbl_kg.TabIndex = 1;
            this.lbl_kg.Text = "체중 : ";
            // 
            // txt_cm
            // 
            this.txt_cm.Location = new System.Drawing.Point(56, 47);
            this.txt_cm.Name = "txt_cm";
            this.txt_cm.Size = new System.Drawing.Size(100, 21);
            this.txt_cm.TabIndex = 2;
            this.txt_cm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_kg
            // 
            this.txt_kg.Location = new System.Drawing.Point(56, 83);
            this.txt_kg.Name = "txt_kg";
            this.txt_kg.Size = new System.Drawing.Size(100, 21);
            this.txt_kg.TabIndex = 3;
            this.txt_kg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_BMI
            // 
            this.btn_BMI.Location = new System.Drawing.Point(81, 119);
            this.btn_BMI.Name = "btn_BMI";
            this.btn_BMI.Size = new System.Drawing.Size(75, 23);
            this.btn_BMI.TabIndex = 4;
            this.btn_BMI.Text = "BMI";
            this.btn_BMI.UseVisualStyleBackColor = true;
            this.btn_BMI.Click += new System.EventHandler(this.btn_BMI_Click);
            // 
            // lbl_bmi
            // 
            this.lbl_bmi.AutoSize = true;
            this.lbl_bmi.Location = new System.Drawing.Point(12, 124);
            this.lbl_bmi.Name = "lbl_bmi";
            this.lbl_bmi.Size = new System.Drawing.Size(0, 12);
            this.lbl_bmi.TabIndex = 5;
            // 
            // BMI_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 185);
            this.Controls.Add(this.lbl_bmi);
            this.Controls.Add(this.btn_BMI);
            this.Controls.Add(this.txt_kg);
            this.Controls.Add(this.txt_cm);
            this.Controls.Add(this.lbl_kg);
            this.Controls.Add(this.lbl_cm);
            this.Name = "BMI_form";
            this.Text = "BMI계산기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_cm;
        private System.Windows.Forms.Label lbl_kg;
        private System.Windows.Forms.TextBox txt_cm;
        private System.Windows.Forms.TextBox txt_kg;
        private System.Windows.Forms.Button btn_BMI;
        private System.Windows.Forms.Label lbl_bmi;
    }
}

