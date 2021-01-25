namespace DogRace
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.gb_BetPlaceArea = new System.Windows.Forms.GroupBox();
            this.nud_DogsNumber = new System.Windows.Forms.NumericUpDown();
            this.nud_BetMoney = new System.Windows.Forms.NumericUpDown();
            this.b_StartRace = new System.Windows.Forms.Button();
            this.b_PaceTheBet = new System.Windows.Forms.Button();
            this.l_ArekInfo = new System.Windows.Forms.Label();
            this.l_BartekInfo = new System.Windows.Forms.Label();
            this.l_JanekInfo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.l_BettorName = new System.Windows.Forms.Label();
            this.rb_Arek = new System.Windows.Forms.RadioButton();
            this.rb_Bartek = new System.Windows.Forms.RadioButton();
            this.rb_Janek = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pb_DogNo1 = new System.Windows.Forms.PictureBox();
            this.pb_RaceTrack = new System.Windows.Forms.PictureBox();
            this.pb_DogNo2 = new System.Windows.Forms.PictureBox();
            this.pb_DogNo3 = new System.Windows.Forms.PictureBox();
            this.pb_DogNo4 = new System.Windows.Forms.PictureBox();
            this.b_savePlayerResult = new System.Windows.Forms.Button();
            this.b_loadPlayeerResult = new System.Windows.Forms.Button();
            this.gb_BetPlaceArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_DogsNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_BetMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_DogNo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_RaceTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_DogNo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_DogNo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_DogNo4)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_BetPlaceArea
            // 
            this.gb_BetPlaceArea.Controls.Add(this.nud_DogsNumber);
            this.gb_BetPlaceArea.Controls.Add(this.nud_BetMoney);
            this.gb_BetPlaceArea.Controls.Add(this.b_StartRace);
            this.gb_BetPlaceArea.Controls.Add(this.b_PaceTheBet);
            this.gb_BetPlaceArea.Controls.Add(this.l_ArekInfo);
            this.gb_BetPlaceArea.Controls.Add(this.l_BartekInfo);
            this.gb_BetPlaceArea.Controls.Add(this.l_JanekInfo);
            this.gb_BetPlaceArea.Controls.Add(this.label4);
            this.gb_BetPlaceArea.Controls.Add(this.label3);
            this.gb_BetPlaceArea.Controls.Add(this.l_BettorName);
            this.gb_BetPlaceArea.Controls.Add(this.rb_Arek);
            this.gb_BetPlaceArea.Controls.Add(this.rb_Bartek);
            this.gb_BetPlaceArea.Controls.Add(this.rb_Janek);
            this.gb_BetPlaceArea.Controls.Add(this.label1);
            this.gb_BetPlaceArea.Location = new System.Drawing.Point(12, 302);
            this.gb_BetPlaceArea.Name = "gb_BetPlaceArea";
            this.gb_BetPlaceArea.Size = new System.Drawing.Size(763, 249);
            this.gb_BetPlaceArea.TabIndex = 2;
            this.gb_BetPlaceArea.TabStop = false;
            this.gb_BetPlaceArea.Text = "Dom bukmacherski";
            // 
            // nud_DogsNumber
            // 
            this.nud_DogsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nud_DogsNumber.Location = new System.Drawing.Point(385, 201);
            this.nud_DogsNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nud_DogsNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_DogsNumber.Name = "nud_DogsNumber";
            this.nud_DogsNumber.Size = new System.Drawing.Size(60, 27);
            this.nud_DogsNumber.TabIndex = 13;
            this.nud_DogsNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nud_BetMoney
            // 
            this.nud_BetMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nud_BetMoney.Location = new System.Drawing.Point(194, 204);
            this.nud_BetMoney.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nud_BetMoney.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_BetMoney.Name = "nud_BetMoney";
            this.nud_BetMoney.Size = new System.Drawing.Size(70, 27);
            this.nud_BetMoney.TabIndex = 12;
            this.nud_BetMoney.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // b_StartRace
            // 
            this.b_StartRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_StartRace.Location = new System.Drawing.Point(666, 200);
            this.b_StartRace.Name = "b_StartRace";
            this.b_StartRace.Size = new System.Drawing.Size(91, 34);
            this.b_StartRace.TabIndex = 11;
            this.b_StartRace.Text = "Start!";
            this.b_StartRace.UseVisualStyleBackColor = true;
            this.b_StartRace.Click += new System.EventHandler(this.b_StartRace_Click);
            // 
            // b_PaceTheBet
            // 
            this.b_PaceTheBet.Location = new System.Drawing.Point(99, 200);
            this.b_PaceTheBet.Name = "b_PaceTheBet";
            this.b_PaceTheBet.Size = new System.Drawing.Size(89, 34);
            this.b_PaceTheBet.TabIndex = 10;
            this.b_PaceTheBet.Text = "Stawia";
            this.b_PaceTheBet.UseVisualStyleBackColor = true;
            this.b_PaceTheBet.Click += new System.EventHandler(this.b_PaceTheBet_Click);
            // 
            // l_ArekInfo
            // 
            this.l_ArekInfo.AutoSize = true;
            this.l_ArekInfo.Location = new System.Drawing.Point(367, 152);
            this.l_ArekInfo.Name = "l_ArekInfo";
            this.l_ArekInfo.Size = new System.Drawing.Size(0, 17);
            this.l_ArekInfo.TabIndex = 9;
            // 
            // l_BartekInfo
            // 
            this.l_BartekInfo.AutoSize = true;
            this.l_BartekInfo.Location = new System.Drawing.Point(367, 113);
            this.l_BartekInfo.Name = "l_BartekInfo";
            this.l_BartekInfo.Size = new System.Drawing.Size(0, 17);
            this.l_BartekInfo.TabIndex = 8;
            // 
            // l_JanekInfo
            // 
            this.l_JanekInfo.AutoSize = true;
            this.l_JanekInfo.Location = new System.Drawing.Point(367, 70);
            this.l_JanekInfo.Name = "l_JanekInfo";
            this.l_JanekInfo.Size = new System.Drawing.Size(0, 17);
            this.l_JanekInfo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(367, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Zakłady";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "zł na psa numer";
            // 
            // l_BettorName
            // 
            this.l_BettorName.AutoSize = true;
            this.l_BettorName.Location = new System.Drawing.Point(36, 209);
            this.l_BettorName.Name = "l_BettorName";
            this.l_BettorName.Size = new System.Drawing.Size(46, 17);
            this.l_BettorName.TabIndex = 4;
            this.l_BettorName.Text = "label2";
            // 
            // rb_Arek
            // 
            this.rb_Arek.AutoSize = true;
            this.rb_Arek.Location = new System.Drawing.Point(10, 152);
            this.rb_Arek.Name = "rb_Arek";
            this.rb_Arek.Size = new System.Drawing.Size(17, 16);
            this.rb_Arek.TabIndex = 3;
            this.rb_Arek.TabStop = true;
            this.rb_Arek.UseVisualStyleBackColor = true;
            this.rb_Arek.CheckedChanged += new System.EventHandler(this.rb_Arek_CheckedChanged);
            this.rb_Arek.Click += new System.EventHandler(this.rb_Arek_Click);
            // 
            // rb_Bartek
            // 
            this.rb_Bartek.AutoSize = true;
            this.rb_Bartek.Location = new System.Drawing.Point(10, 113);
            this.rb_Bartek.Name = "rb_Bartek";
            this.rb_Bartek.Size = new System.Drawing.Size(17, 16);
            this.rb_Bartek.TabIndex = 2;
            this.rb_Bartek.UseVisualStyleBackColor = true;
            this.rb_Bartek.CheckedChanged += new System.EventHandler(this.rb_Bartek_CheckedChanged);
            this.rb_Bartek.Click += new System.EventHandler(this.rb_Bartek_Click);
            // 
            // rb_Janek
            // 
            this.rb_Janek.AutoSize = true;
            this.rb_Janek.Checked = true;
            this.rb_Janek.Location = new System.Drawing.Point(10, 70);
            this.rb_Janek.Name = "rb_Janek";
            this.rb_Janek.Size = new System.Drawing.Size(17, 16);
            this.rb_Janek.TabIndex = 1;
            this.rb_Janek.TabStop = true;
            this.rb_Janek.UseVisualStyleBackColor = true;
            this.rb_Janek.CheckedChanged += new System.EventHandler(this.rb_Janek_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(17, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minimalny zakad: 5zł";
            // 
            // pb_DogNo1
            // 
            this.pb_DogNo1.Image = global::DogRace.Properties.Resources.dog;
            this.pb_DogNo1.Location = new System.Drawing.Point(12, 27);
            this.pb_DogNo1.Name = "pb_DogNo1";
            this.pb_DogNo1.Size = new System.Drawing.Size(110, 30);
            this.pb_DogNo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_DogNo1.TabIndex = 3;
            this.pb_DogNo1.TabStop = false;
            // 
            // pb_RaceTrack
            // 
            this.pb_RaceTrack.Image = global::DogRace.Properties.Resources.racetrack;
            this.pb_RaceTrack.Location = new System.Drawing.Point(11, 12);
            this.pb_RaceTrack.Name = "pb_RaceTrack";
            this.pb_RaceTrack.Size = new System.Drawing.Size(763, 272);
            this.pb_RaceTrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_RaceTrack.TabIndex = 1;
            this.pb_RaceTrack.TabStop = false;
            // 
            // pb_DogNo2
            // 
            this.pb_DogNo2.Image = global::DogRace.Properties.Resources.dog;
            this.pb_DogNo2.Location = new System.Drawing.Point(11, 93);
            this.pb_DogNo2.Name = "pb_DogNo2";
            this.pb_DogNo2.Size = new System.Drawing.Size(110, 30);
            this.pb_DogNo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_DogNo2.TabIndex = 4;
            this.pb_DogNo2.TabStop = false;
            // 
            // pb_DogNo3
            // 
            this.pb_DogNo3.Image = global::DogRace.Properties.Resources.dog;
            this.pb_DogNo3.Location = new System.Drawing.Point(11, 165);
            this.pb_DogNo3.Name = "pb_DogNo3";
            this.pb_DogNo3.Size = new System.Drawing.Size(110, 30);
            this.pb_DogNo3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_DogNo3.TabIndex = 5;
            this.pb_DogNo3.TabStop = false;
            // 
            // pb_DogNo4
            // 
            this.pb_DogNo4.Image = global::DogRace.Properties.Resources.dog;
            this.pb_DogNo4.Location = new System.Drawing.Point(12, 231);
            this.pb_DogNo4.Name = "pb_DogNo4";
            this.pb_DogNo4.Size = new System.Drawing.Size(110, 30);
            this.pb_DogNo4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_DogNo4.TabIndex = 6;
            this.pb_DogNo4.TabStop = false;
            // 
            // b_savePlayerResult
            // 
            this.b_savePlayerResult.Location = new System.Drawing.Point(12, 557);
            this.b_savePlayerResult.Name = "b_savePlayerResult";
            this.b_savePlayerResult.Size = new System.Drawing.Size(379, 51);
            this.b_savePlayerResult.TabIndex = 15;
            this.b_savePlayerResult.Text = "Zapisz wynik gracza";
            this.b_savePlayerResult.UseVisualStyleBackColor = true;
            this.b_savePlayerResult.Click += new System.EventHandler(this.b_savePlayerResult_Click);
            // 
            // b_loadPlayeerResult
            // 
            this.b_loadPlayeerResult.Location = new System.Drawing.Point(397, 557);
            this.b_loadPlayeerResult.Name = "b_loadPlayeerResult";
            this.b_loadPlayeerResult.Size = new System.Drawing.Size(377, 51);
            this.b_loadPlayeerResult.TabIndex = 16;
            this.b_loadPlayeerResult.Text = "Wczytaj wynik gracza";
            this.b_loadPlayeerResult.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 611);
            this.Controls.Add(this.b_loadPlayeerResult);
            this.Controls.Add(this.b_savePlayerResult);
            this.Controls.Add(this.pb_DogNo4);
            this.Controls.Add(this.pb_DogNo3);
            this.Controls.Add(this.pb_DogNo2);
            this.Controls.Add(this.pb_DogNo1);
            this.Controls.Add(this.gb_BetPlaceArea);
            this.Controls.Add(this.pb_RaceTrack);
            this.Name = "Form1";
            this.Text = "Postaw się a odstaw się!";
            this.gb_BetPlaceArea.ResumeLayout(false);
            this.gb_BetPlaceArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_DogsNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_BetMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_DogNo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_RaceTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_DogNo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_DogNo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_DogNo4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_RaceTrack;
        private System.Windows.Forms.GroupBox gb_BetPlaceArea;
        private System.Windows.Forms.NumericUpDown nud_DogsNumber;
        private System.Windows.Forms.NumericUpDown nud_BetMoney;
        private System.Windows.Forms.Button b_StartRace;
        private System.Windows.Forms.Button b_PaceTheBet;
        private System.Windows.Forms.Label l_ArekInfo;
        private System.Windows.Forms.Label l_BartekInfo;
        private System.Windows.Forms.Label l_JanekInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label l_BettorName;
        private System.Windows.Forms.RadioButton rb_Arek;
        private System.Windows.Forms.RadioButton rb_Bartek;
        private System.Windows.Forms.RadioButton rb_Janek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_DogNo1;
        private System.Windows.Forms.PictureBox pb_DogNo2;
        private System.Windows.Forms.PictureBox pb_DogNo3;
        private System.Windows.Forms.PictureBox pb_DogNo4;
        private System.Windows.Forms.Button b_savePlayerResult;
        private System.Windows.Forms.Button b_loadPlayeerResult;
    }
}

