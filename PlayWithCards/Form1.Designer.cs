namespace SerializeCarts
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
            this.b_moveToFirstDeck = new System.Windows.Forms.Button();
            this.b_moveToSecondDeck = new System.Windows.Forms.Button();
            this.b_shuffleSecondDeck = new System.Windows.Forms.Button();
            this.b_shuffleFirstDeck = new System.Windows.Forms.Button();
            this.b_resetSecondDeck = new System.Windows.Forms.Button();
            this.b_resetFirstDeck = new System.Windows.Forms.Button();
            this.l_FirstDeck = new System.Windows.Forms.Label();
            this.l_secondDeck = new System.Windows.Forms.Label();
            this.lb_SecondDeck = new System.Windows.Forms.ListBox();
            this.lb_FirstDeck = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // b_moveToFirstDeck
            // 
            this.b_moveToFirstDeck.Location = new System.Drawing.Point(259, 212);
            this.b_moveToFirstDeck.Name = "b_moveToFirstDeck";
            this.b_moveToFirstDeck.Size = new System.Drawing.Size(52, 35);
            this.b_moveToFirstDeck.TabIndex = 19;
            this.b_moveToFirstDeck.Text = "<<";
            this.b_moveToFirstDeck.UseVisualStyleBackColor = true;
            this.b_moveToFirstDeck.Click += new System.EventHandler(this.b_moveToFirstDeck_Click);
            // 
            // b_moveToSecondDeck
            // 
            this.b_moveToSecondDeck.Location = new System.Drawing.Point(259, 159);
            this.b_moveToSecondDeck.Name = "b_moveToSecondDeck";
            this.b_moveToSecondDeck.Size = new System.Drawing.Size(52, 35);
            this.b_moveToSecondDeck.TabIndex = 18;
            this.b_moveToSecondDeck.Text = ">>";
            this.b_moveToSecondDeck.UseVisualStyleBackColor = true;
            this.b_moveToSecondDeck.Click += new System.EventHandler(this.b_moveToSecondDeck_Click);
            // 
            // b_shuffleSecondDeck
            // 
            this.b_shuffleSecondDeck.Location = new System.Drawing.Point(327, 400);
            this.b_shuffleSecondDeck.Name = "b_shuffleSecondDeck";
            this.b_shuffleSecondDeck.Size = new System.Drawing.Size(214, 35);
            this.b_shuffleSecondDeck.TabIndex = 17;
            this.b_shuffleSecondDeck.Text = "Wymieszaj Zestaw 2";
            this.b_shuffleSecondDeck.UseVisualStyleBackColor = true;
            this.b_shuffleSecondDeck.Click += new System.EventHandler(this.b_shuffleSecondDeck_Click);
            // 
            // b_shuffleFirstDeck
            // 
            this.b_shuffleFirstDeck.Location = new System.Drawing.Point(28, 400);
            this.b_shuffleFirstDeck.Name = "b_shuffleFirstDeck";
            this.b_shuffleFirstDeck.Size = new System.Drawing.Size(214, 35);
            this.b_shuffleFirstDeck.TabIndex = 16;
            this.b_shuffleFirstDeck.Text = "Wymieszaj Zestaw 1";
            this.b_shuffleFirstDeck.UseVisualStyleBackColor = true;
            this.b_shuffleFirstDeck.Click += new System.EventHandler(this.b_shuffleFirstDeck_Click);
            // 
            // b_resetSecondDeck
            // 
            this.b_resetSecondDeck.Location = new System.Drawing.Point(327, 359);
            this.b_resetSecondDeck.Name = "b_resetSecondDeck";
            this.b_resetSecondDeck.Size = new System.Drawing.Size(214, 35);
            this.b_resetSecondDeck.TabIndex = 15;
            this.b_resetSecondDeck.Text = "Przywróć Zestaw 2";
            this.b_resetSecondDeck.UseVisualStyleBackColor = true;
            this.b_resetSecondDeck.Click += new System.EventHandler(this.b_resetSecondDeck_Click);
            // 
            // b_resetFirstDeck
            // 
            this.b_resetFirstDeck.Location = new System.Drawing.Point(28, 359);
            this.b_resetFirstDeck.Name = "b_resetFirstDeck";
            this.b_resetFirstDeck.Size = new System.Drawing.Size(214, 35);
            this.b_resetFirstDeck.TabIndex = 14;
            this.b_resetFirstDeck.Text = "Przywróć Zestaw 1";
            this.b_resetFirstDeck.UseVisualStyleBackColor = true;
            this.b_resetFirstDeck.Click += new System.EventHandler(this.b_resetFirstDeck_Click);
            // 
            // l_FirstDeck
            // 
            this.l_FirstDeck.AutoSize = true;
            this.l_FirstDeck.Location = new System.Drawing.Point(25, 8);
            this.l_FirstDeck.Name = "l_FirstDeck";
            this.l_FirstDeck.Size = new System.Drawing.Size(65, 17);
            this.l_FirstDeck.TabIndex = 13;
            this.l_FirstDeck.Text = "Zestaw 1";
            // 
            // l_secondDeck
            // 
            this.l_secondDeck.AutoSize = true;
            this.l_secondDeck.Location = new System.Drawing.Point(327, 8);
            this.l_secondDeck.Name = "l_secondDeck";
            this.l_secondDeck.Size = new System.Drawing.Size(65, 17);
            this.l_secondDeck.TabIndex = 12;
            this.l_secondDeck.Text = "Zestaw 2";
            // 
            // lb_SecondDeck
            // 
            this.lb_SecondDeck.FormattingEnabled = true;
            this.lb_SecondDeck.ItemHeight = 16;
            this.lb_SecondDeck.Location = new System.Drawing.Point(327, 48);
            this.lb_SecondDeck.Name = "lb_SecondDeck";
            this.lb_SecondDeck.Size = new System.Drawing.Size(214, 292);
            this.lb_SecondDeck.TabIndex = 11;
            // 
            // lb_FirstDeck
            // 
            this.lb_FirstDeck.FormattingEnabled = true;
            this.lb_FirstDeck.ItemHeight = 16;
            this.lb_FirstDeck.Location = new System.Drawing.Point(28, 48);
            this.lb_FirstDeck.Name = "lb_FirstDeck";
            this.lb_FirstDeck.Size = new System.Drawing.Size(214, 292);
            this.lb_FirstDeck.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 450);
            this.Controls.Add(this.b_moveToFirstDeck);
            this.Controls.Add(this.b_moveToSecondDeck);
            this.Controls.Add(this.b_shuffleSecondDeck);
            this.Controls.Add(this.b_shuffleFirstDeck);
            this.Controls.Add(this.b_resetSecondDeck);
            this.Controls.Add(this.b_resetFirstDeck);
            this.Controls.Add(this.l_FirstDeck);
            this.Controls.Add(this.l_secondDeck);
            this.Controls.Add(this.lb_SecondDeck);
            this.Controls.Add(this.lb_FirstDeck);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_moveToFirstDeck;
        private System.Windows.Forms.Button b_moveToSecondDeck;
        private System.Windows.Forms.Button b_shuffleSecondDeck;
        private System.Windows.Forms.Button b_shuffleFirstDeck;
        private System.Windows.Forms.Button b_resetSecondDeck;
        private System.Windows.Forms.Button b_resetFirstDeck;
        private System.Windows.Forms.Label l_FirstDeck;
        private System.Windows.Forms.Label l_secondDeck;
        private System.Windows.Forms.ListBox lb_SecondDeck;
        private System.Windows.Forms.ListBox lb_FirstDeck;
    }
}

