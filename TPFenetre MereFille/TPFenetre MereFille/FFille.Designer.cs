namespace TPFenetre_MereFille
{
    partial class FFille
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
            this.btnChanger = new System.Windows.Forms.Button();
            this.btnMaMere = new System.Windows.Forms.Button();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChanger
            // 
            this.btnChanger.Location = new System.Drawing.Point(411, 113);
            this.btnChanger.Name = "btnChanger";
            this.btnChanger.Size = new System.Drawing.Size(75, 23);
            this.btnChanger.TabIndex = 0;
            this.btnChanger.Text = "Changer";
            this.btnChanger.UseVisualStyleBackColor = true;
            this.btnChanger.Click += new System.EventHandler(this.btnChanger_Click);
            // 
            // btnMaMere
            // 
            this.btnMaMere.Location = new System.Drawing.Point(240, 188);
            this.btnMaMere.Name = "btnMaMere";
            this.btnMaMere.Size = new System.Drawing.Size(75, 23);
            this.btnMaMere.TabIndex = 1;
            this.btnMaMere.Text = "Ma Mere";
            this.btnMaMere.UseVisualStyleBackColor = true;
            this.btnMaMere.Click += new System.EventHandler(this.btnMaMere_Click);
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(195, 115);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(182, 20);
            this.tbNom.TabIndex = 2;
            this.tbNom.TextChanged += new System.EventHandler(this.tbNom_TextChanged);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(52, 118);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(98, 13);
            this.lblNom.TabIndex = 3;
            this.lblNom.Text = "je change de nom :";
            this.lblNom.Click += new System.EventHandler(this.lblNom_Click);
            // 
            // FFille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 262);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.btnMaMere);
            this.Controls.Add(this.btnChanger);
            this.Name = "FFille";
            this.Text = "Fille";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChanger;
        private System.Windows.Forms.Button btnMaMere;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label lblNom;
    }
}