namespace Dinner397
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tb_lumberjackName = new System.Windows.Forms.TextBox();
            this.b_addLuberjack = new System.Windows.Forms.Button();
            this.b_getNextLumberjack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_queueOfLuberjacks = new System.Windows.Forms.ListBox();
            this.gb_feedLuberjeck = new System.Windows.Forms.GroupBox();
            this.rb_banana = new System.Windows.Forms.RadioButton();
            this.rb_browned = new System.Windows.Forms.RadioButton();
            this.rb_soggy = new System.Windows.Forms.RadioButton();
            this.rb_crispy = new System.Windows.Forms.RadioButton();
            this.nud_howMany = new System.Windows.Forms.NumericUpDown();
            this.b_addFlapjacks = new System.Windows.Forms.Button();
            this.tb_currentLumberjack = new System.Windows.Forms.TextBox();
            this.gb_feedLuberjeck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_howMany)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imię drwala";
            // 
            // tb_lumberjackName
            // 
            this.tb_lumberjackName.Location = new System.Drawing.Point(97, 29);
            this.tb_lumberjackName.Name = "tb_lumberjackName";
            this.tb_lumberjackName.Size = new System.Drawing.Size(145, 22);
            this.tb_lumberjackName.TabIndex = 1;
            // 
            // b_addLuberjack
            // 
            this.b_addLuberjack.Location = new System.Drawing.Point(16, 76);
            this.b_addLuberjack.Name = "b_addLuberjack";
            this.b_addLuberjack.Size = new System.Drawing.Size(150, 40);
            this.b_addLuberjack.TabIndex = 2;
            this.b_addLuberjack.Text = "Dodaj drwala";
            this.b_addLuberjack.UseVisualStyleBackColor = true;
            this.b_addLuberjack.Click += new System.EventHandler(this.b_addLuberjack_Click);
            // 
            // b_getNextLumberjack
            // 
            this.b_getNextLumberjack.Location = new System.Drawing.Point(16, 307);
            this.b_getNextLumberjack.Name = "b_getNextLumberjack";
            this.b_getNextLumberjack.Size = new System.Drawing.Size(196, 40);
            this.b_getNextLumberjack.TabIndex = 3;
            this.b_getNextLumberjack.Text = "Następny drwal!";
            this.b_getNextLumberjack.UseVisualStyleBackColor = true;
            this.b_getNextLumberjack.Click += new System.EventHandler(this.b_getNextLumberjack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kolejka do śniadania";
            // 
            // lb_queueOfLuberjacks
            // 
            this.lb_queueOfLuberjacks.FormattingEnabled = true;
            this.lb_queueOfLuberjacks.ItemHeight = 16;
            this.lb_queueOfLuberjacks.Location = new System.Drawing.Point(16, 162);
            this.lb_queueOfLuberjacks.Name = "lb_queueOfLuberjacks";
            this.lb_queueOfLuberjacks.Size = new System.Drawing.Size(150, 276);
            this.lb_queueOfLuberjacks.TabIndex = 5;
            // 
            // gb_feedLuberjeck
            // 
            this.gb_feedLuberjeck.Controls.Add(this.rb_banana);
            this.gb_feedLuberjeck.Controls.Add(this.rb_browned);
            this.gb_feedLuberjeck.Controls.Add(this.rb_soggy);
            this.gb_feedLuberjeck.Controls.Add(this.rb_crispy);
            this.gb_feedLuberjeck.Controls.Add(this.nud_howMany);
            this.gb_feedLuberjeck.Controls.Add(this.b_addFlapjacks);
            this.gb_feedLuberjeck.Controls.Add(this.tb_currentLumberjack);
            this.gb_feedLuberjeck.Controls.Add(this.b_getNextLumberjack);
            this.gb_feedLuberjeck.Location = new System.Drawing.Point(186, 76);
            this.gb_feedLuberjeck.Name = "gb_feedLuberjeck";
            this.gb_feedLuberjeck.Size = new System.Drawing.Size(236, 362);
            this.gb_feedLuberjeck.TabIndex = 6;
            this.gb_feedLuberjeck.TabStop = false;
            this.gb_feedLuberjeck.Text = "Nakarm drwala";
            // 
            // rb_banana
            // 
            this.rb_banana.AutoSize = true;
            this.rb_banana.Location = new System.Drawing.Point(16, 139);
            this.rb_banana.Name = "rb_banana";
            this.rb_banana.Size = new System.Drawing.Size(94, 21);
            this.rb_banana.TabIndex = 10;
            this.rb_banana.TabStop = true;
            this.rb_banana.Text = "Bananowy";
            this.rb_banana.UseVisualStyleBackColor = true;
            // 
            // rb_browned
            // 
            this.rb_browned.AutoSize = true;
            this.rb_browned.Location = new System.Drawing.Point(16, 113);
            this.rb_browned.Name = "rb_browned";
            this.rb_browned.Size = new System.Drawing.Size(84, 21);
            this.rb_browned.TabIndex = 9;
            this.rb_browned.TabStop = true;
            this.rb_browned.Text = "Rumiany";
            this.rb_browned.UseVisualStyleBackColor = true;
            // 
            // rb_soggy
            // 
            this.rb_soggy.AutoSize = true;
            this.rb_soggy.Location = new System.Drawing.Point(16, 86);
            this.rb_soggy.Name = "rb_soggy";
            this.rb_soggy.Size = new System.Drawing.Size(83, 21);
            this.rb_soggy.TabIndex = 8;
            this.rb_soggy.TabStop = true;
            this.rb_soggy.Text = "Wilgotny";
            this.rb_soggy.UseVisualStyleBackColor = true;
            // 
            // rb_crispy
            // 
            this.rb_crispy.AutoSize = true;
            this.rb_crispy.Location = new System.Drawing.Point(16, 59);
            this.rb_crispy.Name = "rb_crispy";
            this.rb_crispy.Size = new System.Drawing.Size(77, 21);
            this.rb_crispy.TabIndex = 7;
            this.rb_crispy.TabStop = true;
            this.rb_crispy.Text = "Chrupki";
            this.rb_crispy.UseVisualStyleBackColor = true;
            // 
            // nud_howMany
            // 
            this.nud_howMany.Location = new System.Drawing.Point(16, 30);
            this.nud_howMany.Name = "nud_howMany";
            this.nud_howMany.Size = new System.Drawing.Size(196, 22);
            this.nud_howMany.TabIndex = 6;
            // 
            // b_addFlapjacks
            // 
            this.b_addFlapjacks.Location = new System.Drawing.Point(16, 177);
            this.b_addFlapjacks.Name = "b_addFlapjacks";
            this.b_addFlapjacks.Size = new System.Drawing.Size(196, 40);
            this.b_addFlapjacks.TabIndex = 5;
            this.b_addFlapjacks.Text = "Dodaj naleśniki";
            this.b_addFlapjacks.UseVisualStyleBackColor = true;
            this.b_addFlapjacks.Click += new System.EventHandler(this.b_addFlapjacks_Click);
            // 
            // tb_currentLumberjack
            // 
            this.tb_currentLumberjack.Location = new System.Drawing.Point(16, 223);
            this.tb_currentLumberjack.Multiline = true;
            this.tb_currentLumberjack.Name = "tb_currentLumberjack";
            this.tb_currentLumberjack.Size = new System.Drawing.Size(196, 67);
            this.tb_currentLumberjack.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 450);
            this.Controls.Add(this.gb_feedLuberjeck);
            this.Controls.Add(this.lb_queueOfLuberjacks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.b_addLuberjack);
            this.Controls.Add(this.tb_lumberjackName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb_feedLuberjeck.ResumeLayout(false);
            this.gb_feedLuberjeck.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_howMany)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_lumberjackName;
        private System.Windows.Forms.Button b_addLuberjack;
        private System.Windows.Forms.Button b_getNextLumberjack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lb_queueOfLuberjacks;
        private System.Windows.Forms.GroupBox gb_feedLuberjeck;
        private System.Windows.Forms.RadioButton rb_banana;
        private System.Windows.Forms.RadioButton rb_browned;
        private System.Windows.Forms.RadioButton rb_soggy;
        private System.Windows.Forms.RadioButton rb_crispy;
        private System.Windows.Forms.NumericUpDown nud_howMany;
        private System.Windows.Forms.Button b_addFlapjacks;
        private System.Windows.Forms.TextBox tb_currentLumberjack;
    }
}

