
namespace Game_EX
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
            this.numBucks = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numDogs = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Race = new System.Windows.Forms.Button();
            this.btnBets = new System.Windows.Forms.Button();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Al = new System.Windows.Forms.Label();
            this.lbl_Bob = new System.Windows.Forms.Label();
            this.lbl_Joe = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdo_Al = new System.Windows.Forms.RadioButton();
            this.rdo_Bob = new System.Windows.Forms.RadioButton();
            this.rdo_Joe = new System.Windows.Forms.RadioButton();
            this.lbl_Bet = new System.Windows.Forms.Label();
            this.dog1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dog2 = new System.Windows.Forms.PictureBox();
            this.dog3 = new System.Windows.Forms.PictureBox();
            this.dog4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numBucks)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).BeginInit();
            this.SuspendLayout();
            // 
            // numBucks
            // 
            this.numBucks.Location = new System.Drawing.Point(705, 59);
            this.numBucks.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numBucks.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numBucks.Name = "numBucks";
            this.numBucks.Size = new System.Drawing.Size(66, 21);
            this.numBucks.TabIndex = 1;
            this.numBucks.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numDogs);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btn_Race);
            this.groupBox1.Controls.Add(this.btnBets);
            this.groupBox1.Controls.Add(this.lbl_Name);
            this.groupBox1.Controls.Add(this.lbl_Al);
            this.groupBox1.Controls.Add(this.lbl_Bob);
            this.groupBox1.Controls.Add(this.lbl_Joe);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rdo_Al);
            this.groupBox1.Controls.Add(this.rdo_Bob);
            this.groupBox1.Controls.Add(this.rdo_Joe);
            this.groupBox1.Controls.Add(this.lbl_Bet);
            this.groupBox1.Controls.Add(this.numBucks);
            this.groupBox1.Location = new System.Drawing.Point(12, 315);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1190, 146);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betting Parlor";
            // 
            // numDogs
            // 
            this.numDogs.Location = new System.Drawing.Point(927, 59);
            this.numDogs.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numDogs.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDogs.Name = "numDogs";
            this.numDogs.Size = new System.Drawing.Size(66, 21);
            this.numDogs.TabIndex = 14;
            this.numDogs.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(786, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "bucks on dog number";
            // 
            // btn_Race
            // 
            this.btn_Race.Location = new System.Drawing.Point(1007, 31);
            this.btn_Race.Name = "btn_Race";
            this.btn_Race.Size = new System.Drawing.Size(152, 100);
            this.btn_Race.TabIndex = 12;
            this.btn_Race.Text = "Race!";
            this.btn_Race.UseVisualStyleBackColor = true;
            this.btn_Race.Click += new System.EventHandler(this.btn_Race_Click);
            // 
            // btnBets
            // 
            this.btnBets.Location = new System.Drawing.Point(612, 57);
            this.btnBets.Name = "btnBets";
            this.btnBets.Size = new System.Drawing.Size(75, 23);
            this.btnBets.TabIndex = 11;
            this.btnBets.Text = "Bets";
            this.btnBets.UseVisualStyleBackColor = true;
            this.btnBets.Click += new System.EventHandler(this.btnBets_Click);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Name.Location = new System.Drawing.Point(567, 60);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(39, 15);
            this.lbl_Name.TabIndex = 10;
            this.lbl_Name.Text = "name";
            // 
            // lbl_Al
            // 
            this.lbl_Al.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Al.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Al.Location = new System.Drawing.Point(195, 108);
            this.lbl_Al.Name = "lbl_Al";
            this.lbl_Al.Size = new System.Drawing.Size(355, 23);
            this.lbl_Al.TabIndex = 9;
            this.lbl_Al.Text = "alBetLabel";
            // 
            // lbl_Bob
            // 
            this.lbl_Bob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Bob.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Bob.Location = new System.Drawing.Point(195, 75);
            this.lbl_Bob.Name = "lbl_Bob";
            this.lbl_Bob.Size = new System.Drawing.Size(355, 23);
            this.lbl_Bob.TabIndex = 8;
            this.lbl_Bob.Text = "bobBetLabel";
            // 
            // lbl_Joe
            // 
            this.lbl_Joe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Joe.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Joe.Location = new System.Drawing.Point(195, 39);
            this.lbl_Joe.Name = "lbl_Joe";
            this.lbl_Joe.Size = new System.Drawing.Size(355, 23);
            this.lbl_Joe.TabIndex = 7;
            this.lbl_Joe.Text = "joeBetLabel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(192, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bets";
            // 
            // rdo_Al
            // 
            this.rdo_Al.AutoSize = true;
            this.rdo_Al.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdo_Al.Location = new System.Drawing.Point(49, 106);
            this.rdo_Al.Name = "rdo_Al";
            this.rdo_Al.Size = new System.Drawing.Size(100, 19);
            this.rdo_Al.TabIndex = 5;
            this.rdo_Al.Text = "alRadioButton";
            this.rdo_Al.UseVisualStyleBackColor = true;
            this.rdo_Al.CheckedChanged += new System.EventHandler(this.rdo_Name_CheckedChanged);
            // 
            // rdo_Bob
            // 
            this.rdo_Bob.AutoSize = true;
            this.rdo_Bob.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdo_Bob.Location = new System.Drawing.Point(49, 75);
            this.rdo_Bob.Name = "rdo_Bob";
            this.rdo_Bob.Size = new System.Drawing.Size(112, 19);
            this.rdo_Bob.TabIndex = 4;
            this.rdo_Bob.Text = "bobRadioButton";
            this.rdo_Bob.UseVisualStyleBackColor = true;
            this.rdo_Bob.CheckedChanged += new System.EventHandler(this.rdo_Name_CheckedChanged);
            // 
            // rdo_Joe
            // 
            this.rdo_Joe.AutoSize = true;
            this.rdo_Joe.Checked = true;
            this.rdo_Joe.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdo_Joe.Location = new System.Drawing.Point(49, 43);
            this.rdo_Joe.Name = "rdo_Joe";
            this.rdo_Joe.Size = new System.Drawing.Size(107, 19);
            this.rdo_Joe.TabIndex = 3;
            this.rdo_Joe.TabStop = true;
            this.rdo_Joe.Text = "joeRadioButton";
            this.rdo_Joe.UseVisualStyleBackColor = true;
            this.rdo_Joe.CheckedChanged += new System.EventHandler(this.rdo_Name_CheckedChanged);
            // 
            // lbl_Bet
            // 
            this.lbl_Bet.AutoSize = true;
            this.lbl_Bet.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Bet.Location = new System.Drawing.Point(15, 17);
            this.lbl_Bet.Name = "lbl_Bet";
            this.lbl_Bet.Size = new System.Drawing.Size(96, 15);
            this.lbl_Bet.TabIndex = 2;
            this.lbl_Bet.Text = "최소 배팅값: 5 $";
            // 
            // dog1
            // 
            this.dog1.Image = global::Game_EX.Properties.Resources.dog;
            this.dog1.Location = new System.Drawing.Point(42, 21);
            this.dog1.Name = "dog1";
            this.dog1.Size = new System.Drawing.Size(131, 38);
            this.dog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dog1.TabIndex = 3;
            this.dog1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Game_EX.Properties.Resources.racetrack;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1190, 287);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dog2
            // 
            this.dog2.Image = global::Game_EX.Properties.Resources.dog;
            this.dog2.Location = new System.Drawing.Point(42, 91);
            this.dog2.Name = "dog2";
            this.dog2.Size = new System.Drawing.Size(131, 38);
            this.dog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dog2.TabIndex = 4;
            this.dog2.TabStop = false;
            // 
            // dog3
            // 
            this.dog3.Image = global::Game_EX.Properties.Resources.dog;
            this.dog3.Location = new System.Drawing.Point(42, 168);
            this.dog3.Name = "dog3";
            this.dog3.Size = new System.Drawing.Size(131, 38);
            this.dog3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dog3.TabIndex = 5;
            this.dog3.TabStop = false;
            // 
            // dog4
            // 
            this.dog4.Image = global::Game_EX.Properties.Resources.dog;
            this.dog4.Location = new System.Drawing.Point(42, 241);
            this.dog4.Name = "dog4";
            this.dog4.Size = new System.Drawing.Size(131, 38);
            this.dog4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dog4.TabIndex = 6;
            this.dog4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 471);
            this.Controls.Add(this.dog4);
            this.Controls.Add(this.dog3);
            this.Controls.Add(this.dog2);
            this.Controls.Add(this.dog1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "A Day at the Races";
            ((System.ComponentModel.ISupportInitialize)(this.numBucks)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown numBucks;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdo_Al;
        private System.Windows.Forms.RadioButton rdo_Bob;
        private System.Windows.Forms.RadioButton rdo_Joe;
        private System.Windows.Forms.Label lbl_Bet;
        private System.Windows.Forms.NumericUpDown numDogs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Race;
        private System.Windows.Forms.Button btnBets;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Al;
        private System.Windows.Forms.Label lbl_Bob;
        private System.Windows.Forms.Label lbl_Joe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox dog1;
        private System.Windows.Forms.PictureBox dog2;
        private System.Windows.Forms.PictureBox dog3;
        private System.Windows.Forms.PictureBox dog4;
    }
}

