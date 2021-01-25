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
            this.b_saveDeck = new System.Windows.Forms.Button();
            this.b_readDeck = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.b_saveCard = new System.Windows.Forms.Button();
            this.cb_card = new System.Windows.Forms.ComboBox();
            this.b_readCard = new System.Windows.Forms.Button();
            this.cb_firstCardToCompare = new System.Windows.Forms.ComboBox();
            this.cb_secondCardToCompare = new System.Windows.Forms.ComboBox();
            this.b_compareBytesInCardsFiles = new System.Windows.Forms.Button();
            this.cb_cardToChange = new System.Windows.Forms.ComboBox();
            this.cb_cardToObtain = new System.Windows.Forms.ComboBox();
            this.b_changeCardInBytesFile = new System.Windows.Forms.Button();
            this.b_createHexFile = new System.Windows.Forms.Button();
            this.cb_BinaryfileName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // b_saveDeck
            // 
            this.b_saveDeck.Location = new System.Drawing.Point(49, 41);
            this.b_saveDeck.Name = "b_saveDeck";
            this.b_saveDeck.Size = new System.Drawing.Size(196, 94);
            this.b_saveDeck.TabIndex = 0;
            this.b_saveDeck.Text = "Zapisz zestaw kart";
            this.b_saveDeck.UseVisualStyleBackColor = true;
            this.b_saveDeck.Click += new System.EventHandler(this.b_saveDeck_Click);
            // 
            // b_readDeck
            // 
            this.b_readDeck.Location = new System.Drawing.Point(251, 41);
            this.b_readDeck.Name = "b_readDeck";
            this.b_readDeck.Size = new System.Drawing.Size(196, 94);
            this.b_readDeck.TabIndex = 1;
            this.b_readDeck.Text = "Wczytaj zestaw kart";
            this.b_readDeck.UseVisualStyleBackColor = true;
            this.b_readDeck.Click += new System.EventHandler(this.b_readDeck_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(251, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 111);
            this.button1.TabIndex = 3;
            this.button1.Text = "Wczytaj wiele zestawów";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(49, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 111);
            this.button2.TabIndex = 2;
            this.button2.Text = "Zapisz wiele zestawów";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // b_saveCard
            // 
            this.b_saveCard.Location = new System.Drawing.Point(49, 292);
            this.b_saveCard.Name = "b_saveCard";
            this.b_saveCard.Size = new System.Drawing.Size(196, 154);
            this.b_saveCard.TabIndex = 4;
            this.b_saveCard.Text = "Zapisz kartę";
            this.b_saveCard.UseVisualStyleBackColor = true;
            this.b_saveCard.Click += new System.EventHandler(this.b_saveCard_Click);
            // 
            // cb_card
            // 
            this.cb_card.FormattingEnabled = true;
            this.cb_card.Items.AddRange(new object[] {
            "Trójka trefl",
            "Szóstka kier",
            "Dwójka pik",
            "Ósemka kier",
            "Walet karo",
            "Czwórka karo",
            "As kier",
            "Dama pik",
            "As karo",
            "Szóstka pik"});
            this.cb_card.Location = new System.Drawing.Point(183, 262);
            this.cb_card.Name = "cb_card";
            this.cb_card.Size = new System.Drawing.Size(121, 24);
            this.cb_card.TabIndex = 5;
            // 
            // b_readCard
            // 
            this.b_readCard.Location = new System.Drawing.Point(251, 292);
            this.b_readCard.Name = "b_readCard";
            this.b_readCard.Size = new System.Drawing.Size(196, 154);
            this.b_readCard.TabIndex = 6;
            this.b_readCard.Text = "Wczytaj kartę";
            this.b_readCard.UseVisualStyleBackColor = true;
            this.b_readCard.Click += new System.EventHandler(this.b_readCard_Click);
            // 
            // cb_firstCardToCompare
            // 
            this.cb_firstCardToCompare.FormattingEnabled = true;
            this.cb_firstCardToCompare.Items.AddRange(new object[] {
            "Trójka trefl",
            "Szóstka kier",
            "Dwójka pik",
            "Ósemka kier",
            "Walet karo",
            "Czwórka karo",
            "As kier",
            "Dama pik",
            "As karo",
            "Szóstka pik"});
            this.cb_firstCardToCompare.Location = new System.Drawing.Point(49, 465);
            this.cb_firstCardToCompare.Name = "cb_firstCardToCompare";
            this.cb_firstCardToCompare.Size = new System.Drawing.Size(121, 24);
            this.cb_firstCardToCompare.TabIndex = 7;
            // 
            // cb_secondCardToCompare
            // 
            this.cb_secondCardToCompare.FormattingEnabled = true;
            this.cb_secondCardToCompare.Items.AddRange(new object[] {
            "Trójka trefl",
            "Szóstka kier",
            "Dwójka pik",
            "Ósemka kier",
            "Walet karo",
            "Czwórka karo",
            "As kier",
            "Dama pik",
            "As karo",
            "Szóstka pik"});
            this.cb_secondCardToCompare.Location = new System.Drawing.Point(49, 495);
            this.cb_secondCardToCompare.Name = "cb_secondCardToCompare";
            this.cb_secondCardToCompare.Size = new System.Drawing.Size(121, 24);
            this.cb_secondCardToCompare.TabIndex = 8;
            // 
            // b_compareBytesInCardsFiles
            // 
            this.b_compareBytesInCardsFiles.Location = new System.Drawing.Point(192, 465);
            this.b_compareBytesInCardsFiles.Name = "b_compareBytesInCardsFiles";
            this.b_compareBytesInCardsFiles.Size = new System.Drawing.Size(255, 54);
            this.b_compareBytesInCardsFiles.TabIndex = 9;
            this.b_compareBytesInCardsFiles.Text = "Porównaj pliki bajtów należące do kart";
            this.b_compareBytesInCardsFiles.UseVisualStyleBackColor = true;
            this.b_compareBytesInCardsFiles.Click += new System.EventHandler(this.b_compareBytesInCardsFiles_Click);
            // 
            // cb_cardToChange
            // 
            this.cb_cardToChange.FormattingEnabled = true;
            this.cb_cardToChange.Items.AddRange(new object[] {
            "Trójka trefl",
            "Szóstka kier",
            "Dwójka pik",
            "Ósemka kier",
            "Walet karo",
            "Czwórka karo",
            "As kier",
            "Dama pik",
            "As karo",
            "Szóstka pik"});
            this.cb_cardToChange.Location = new System.Drawing.Point(49, 599);
            this.cb_cardToChange.Name = "cb_cardToChange";
            this.cb_cardToChange.Size = new System.Drawing.Size(121, 24);
            this.cb_cardToChange.TabIndex = 10;
            this.cb_cardToChange.SelectedIndexChanged += new System.EventHandler(this.cb_cardToChange_SelectedIndexChanged);
            // 
            // cb_cardToObtain
            // 
            this.cb_cardToObtain.FormattingEnabled = true;
            this.cb_cardToObtain.Items.AddRange(new object[] {
            "Dziesiątka kier",
            "Dziesiątka pik",
            "Dziesiątka karo"});
            this.cb_cardToObtain.Location = new System.Drawing.Point(326, 599);
            this.cb_cardToObtain.Name = "cb_cardToObtain";
            this.cb_cardToObtain.Size = new System.Drawing.Size(121, 24);
            this.cb_cardToObtain.TabIndex = 11;
            this.cb_cardToObtain.SelectedIndexChanged += new System.EventHandler(this.cb_cardToObtain_SelectedIndexChanged);
            // 
            // b_changeCardInBytesFile
            // 
            this.b_changeCardInBytesFile.Location = new System.Drawing.Point(49, 549);
            this.b_changeCardInBytesFile.Name = "b_changeCardInBytesFile";
            this.b_changeCardInBytesFile.Size = new System.Drawing.Size(398, 44);
            this.b_changeCardInBytesFile.TabIndex = 12;
            this.b_changeCardInBytesFile.Text = "Zmień karę Z Na za pomocą zmian w pliku bajtów";
            this.b_changeCardInBytesFile.UseVisualStyleBackColor = true;
            this.b_changeCardInBytesFile.Click += new System.EventHandler(this.b_changeCardInBytesFile_Click);
            // 
            // b_createHexFile
            // 
            this.b_createHexFile.Location = new System.Drawing.Point(470, 76);
            this.b_createHexFile.Name = "b_createHexFile";
            this.b_createHexFile.Size = new System.Drawing.Size(135, 176);
            this.b_createHexFile.TabIndex = 13;
            this.b_createHexFile.Text = "Zmień dane binarne na postać szesnastkową";
            this.b_createHexFile.UseVisualStyleBackColor = true;
            this.b_createHexFile.Click += new System.EventHandler(this.b_createHexFile_Click);
            // 
            // cb_BinaryfileName
            // 
            this.cb_BinaryfileName.FormattingEnabled = true;
            this.cb_BinaryfileName.Items.AddRange(new object[] {
            "Trójka trefl",
            "Szóstka kier",
            "Dwójka pik",
            "Ósemka kier",
            "Walet karo",
            "Czwórka karo",
            "As kier",
            "Dama pik",
            "As karo",
            "Szóstka pik"});
            this.cb_BinaryfileName.Location = new System.Drawing.Point(470, 41);
            this.cb_BinaryfileName.Name = "cb_BinaryfileName";
            this.cb_BinaryfileName.Size = new System.Drawing.Size(135, 24);
            this.cb_BinaryfileName.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 667);
            this.Controls.Add(this.cb_BinaryfileName);
            this.Controls.Add(this.b_createHexFile);
            this.Controls.Add(this.b_changeCardInBytesFile);
            this.Controls.Add(this.cb_cardToObtain);
            this.Controls.Add(this.cb_cardToChange);
            this.Controls.Add(this.b_compareBytesInCardsFiles);
            this.Controls.Add(this.cb_secondCardToCompare);
            this.Controls.Add(this.cb_firstCardToCompare);
            this.Controls.Add(this.b_readCard);
            this.Controls.Add(this.cb_card);
            this.Controls.Add(this.b_saveCard);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.b_readDeck);
            this.Controls.Add(this.b_saveDeck);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_saveDeck;
        private System.Windows.Forms.Button b_readDeck;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button b_saveCard;
        private System.Windows.Forms.ComboBox cb_card;
        private System.Windows.Forms.Button b_readCard;
        private System.Windows.Forms.ComboBox cb_firstCardToCompare;
        private System.Windows.Forms.ComboBox cb_secondCardToCompare;
        private System.Windows.Forms.Button b_compareBytesInCardsFiles;
        private System.Windows.Forms.ComboBox cb_cardToChange;
        private System.Windows.Forms.ComboBox cb_cardToObtain;
        private System.Windows.Forms.Button b_changeCardInBytesFile;
        private System.Windows.Forms.Button b_createHexFile;
        private System.Windows.Forms.ComboBox cb_BinaryfileName;
    }
}

