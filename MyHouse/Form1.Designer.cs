namespace MyHouse
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
            this.tb_LocationDescription = new System.Windows.Forms.TextBox();
            this.b_GoToNextLocation = new System.Windows.Forms.Button();
            this.cb_Locations = new System.Windows.Forms.ComboBox();
            this.b_GoThroughTheDoor = new System.Windows.Forms.Button();
            this.b_Hide = new System.Windows.Forms.Button();
            this.b_checkThatHidingPlace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_LocationDescription
            // 
            this.tb_LocationDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_LocationDescription.Location = new System.Drawing.Point(32, 27);
            this.tb_LocationDescription.Multiline = true;
            this.tb_LocationDescription.Name = "tb_LocationDescription";
            this.tb_LocationDescription.Size = new System.Drawing.Size(474, 188);
            this.tb_LocationDescription.TabIndex = 0;
            this.tb_LocationDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // b_GoToNextLocation
            // 
            this.b_GoToNextLocation.Location = new System.Drawing.Point(32, 230);
            this.b_GoToNextLocation.Name = "b_GoToNextLocation";
            this.b_GoToNextLocation.Size = new System.Drawing.Size(128, 37);
            this.b_GoToNextLocation.TabIndex = 1;
            this.b_GoToNextLocation.Text = "Idź tutaj";
            this.b_GoToNextLocation.UseVisualStyleBackColor = true;
            this.b_GoToNextLocation.Visible = false;
            this.b_GoToNextLocation.Click += new System.EventHandler(this.b_GoToNextLocation_Click);
            // 
            // cb_Locations
            // 
            this.cb_Locations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Locations.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb_Locations.FormattingEnabled = true;
            this.cb_Locations.Location = new System.Drawing.Point(177, 230);
            this.cb_Locations.Name = "cb_Locations";
            this.cb_Locations.Size = new System.Drawing.Size(329, 37);
            this.cb_Locations.TabIndex = 2;
            this.cb_Locations.Visible = false;
            // 
            // b_GoThroughTheDoor
            // 
            this.b_GoThroughTheDoor.Location = new System.Drawing.Point(32, 273);
            this.b_GoThroughTheDoor.Name = "b_GoThroughTheDoor";
            this.b_GoThroughTheDoor.Size = new System.Drawing.Size(474, 37);
            this.b_GoThroughTheDoor.TabIndex = 3;
            this.b_GoThroughTheDoor.Text = "Przejdź przez drzwi";
            this.b_GoThroughTheDoor.UseVisualStyleBackColor = true;
            this.b_GoThroughTheDoor.Visible = false;
            this.b_GoThroughTheDoor.Click += new System.EventHandler(this.b_GoThroughTheDoor_Click);
            // 
            // b_Hide
            // 
            this.b_Hide.Location = new System.Drawing.Point(32, 359);
            this.b_Hide.Name = "b_Hide";
            this.b_Hide.Size = new System.Drawing.Size(474, 37);
            this.b_Hide.TabIndex = 4;
            this.b_Hide.Text = "Kryj się!";
            this.b_Hide.UseVisualStyleBackColor = true;
            this.b_Hide.Click += new System.EventHandler(this.b_Hide_Click);
            // 
            // b_checkThatHidingPlace
            // 
            this.b_checkThatHidingPlace.Location = new System.Drawing.Point(32, 316);
            this.b_checkThatHidingPlace.Name = "b_checkThatHidingPlace";
            this.b_checkThatHidingPlace.Size = new System.Drawing.Size(474, 37);
            this.b_checkThatHidingPlace.TabIndex = 5;
            this.b_checkThatHidingPlace.UseVisualStyleBackColor = true;
            this.b_checkThatHidingPlace.Visible = false;
            this.b_checkThatHidingPlace.Click += new System.EventHandler(this.b_checkThatHidingPlace_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 405);
            this.Controls.Add(this.b_checkThatHidingPlace);
            this.Controls.Add(this.b_Hide);
            this.Controls.Add(this.b_GoThroughTheDoor);
            this.Controls.Add(this.cb_Locations);
            this.Controls.Add(this.b_GoToNextLocation);
            this.Controls.Add(this.tb_LocationDescription);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_LocationDescription;
        private System.Windows.Forms.Button b_GoToNextLocation;
        private System.Windows.Forms.ComboBox cb_Locations;
        private System.Windows.Forms.Button b_GoThroughTheDoor;
        private System.Windows.Forms.Button b_Hide;
        private System.Windows.Forms.Button b_checkThatHidingPlace;
    }
}

