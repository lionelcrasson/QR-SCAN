namespace QR_SCAN
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.img_qr = new System.Windows.Forms.PictureBox();
            this.label_URL = new System.Windows.Forms.Label();
            this.textBox_URL = new System.Windows.Forms.TextBox();
            this.bt_create_qr = new System.Windows.Forms.Button();
            this.bt_save_qr = new System.Windows.Forms.Button();
            this.bt_load_qr = new System.Windows.Forms.Button();
            this.bt_extract_qr = new System.Windows.Forms.Button();
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.tb_prenom = new System.Windows.Forms.TextBox();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_new = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img_qr)).BeginInit();
            this.SuspendLayout();
            // 
            // img_qr
            // 
            this.img_qr.Location = new System.Drawing.Point(15, 13);
            this.img_qr.Name = "img_qr";
            this.img_qr.Size = new System.Drawing.Size(414, 269);
            this.img_qr.TabIndex = 0;
            this.img_qr.TabStop = false;
            // 
            // label_URL
            // 
            this.label_URL.AutoSize = true;
            this.label_URL.Location = new System.Drawing.Point(12, 299);
            this.label_URL.Name = "label_URL";
            this.label_URL.Size = new System.Drawing.Size(29, 13);
            this.label_URL.TabIndex = 1;
            this.label_URL.Text = "URL";
            // 
            // textBox_URL
            // 
            this.textBox_URL.Location = new System.Drawing.Point(48, 295);
            this.textBox_URL.Name = "textBox_URL";
            this.textBox_URL.Size = new System.Drawing.Size(381, 20);
            this.textBox_URL.TabIndex = 2;
            // 
            // bt_create_qr
            // 
            this.bt_create_qr.Location = new System.Drawing.Point(15, 330);
            this.bt_create_qr.Name = "bt_create_qr";
            this.bt_create_qr.Size = new System.Drawing.Size(414, 23);
            this.bt_create_qr.TabIndex = 3;
            this.bt_create_qr.Text = "Create";
            this.bt_create_qr.UseVisualStyleBackColor = true;
            this.bt_create_qr.Click += new System.EventHandler(this.bt_create_qr_Click);
            // 
            // bt_save_qr
            // 
            this.bt_save_qr.Location = new System.Drawing.Point(15, 360);
            this.bt_save_qr.Name = "bt_save_qr";
            this.bt_save_qr.Size = new System.Drawing.Size(414, 23);
            this.bt_save_qr.TabIndex = 4;
            this.bt_save_qr.Text = "Save QR";
            this.bt_save_qr.UseVisualStyleBackColor = true;
            this.bt_save_qr.Click += new System.EventHandler(this.bt_save_qr_Click);
            // 
            // bt_load_qr
            // 
            this.bt_load_qr.Location = new System.Drawing.Point(15, 390);
            this.bt_load_qr.Name = "bt_load_qr";
            this.bt_load_qr.Size = new System.Drawing.Size(198, 23);
            this.bt_load_qr.TabIndex = 5;
            this.bt_load_qr.Text = "Load QR";
            this.bt_load_qr.UseVisualStyleBackColor = true;
            this.bt_load_qr.Click += new System.EventHandler(this.bt_load_qr_Click);
            // 
            // bt_extract_qr
            // 
            this.bt_extract_qr.Location = new System.Drawing.Point(220, 390);
            this.bt_extract_qr.Name = "bt_extract_qr";
            this.bt_extract_qr.Size = new System.Drawing.Size(209, 23);
            this.bt_extract_qr.TabIndex = 6;
            this.bt_extract_qr.Text = "Extract QR";
            this.bt_extract_qr.UseVisualStyleBackColor = true;
            this.bt_extract_qr.Click += new System.EventHandler(this.bt_extract_qr_Click);
            // 
            // tb_nom
            // 
            this.tb_nom.Location = new System.Drawing.Point(13, 472);
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.Size = new System.Drawing.Size(198, 20);
            this.tb_nom.TabIndex = 7;
            // 
            // tb_prenom
            // 
            this.tb_prenom.Location = new System.Drawing.Point(217, 472);
            this.tb_prenom.Name = "tb_prenom";
            this.tb_prenom.Size = new System.Drawing.Size(210, 20);
            this.tb_prenom.TabIndex = 8;
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(48, 419);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(381, 20);
            this.tb_ID.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 452);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 452);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Prenom";
            // 
            // bt_new
            // 
            this.bt_new.Location = new System.Drawing.Point(12, 498);
            this.bt_new.Name = "bt_new";
            this.bt_new.Size = new System.Drawing.Size(417, 23);
            this.bt_new.TabIndex = 14;
            this.bt_new.Text = "nouveau client";
            this.bt_new.UseVisualStyleBackColor = true;
            this.bt_new.Click += new System.EventHandler(this.bt_new_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 537);
            this.Controls.Add(this.bt_new);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.tb_prenom);
            this.Controls.Add(this.tb_nom);
            this.Controls.Add(this.bt_extract_qr);
            this.Controls.Add(this.bt_load_qr);
            this.Controls.Add(this.bt_save_qr);
            this.Controls.Add(this.bt_create_qr);
            this.Controls.Add(this.textBox_URL);
            this.Controls.Add(this.label_URL);
            this.Controls.Add(this.img_qr);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.img_qr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img_qr;
        private System.Windows.Forms.Label label_URL;
        private System.Windows.Forms.TextBox textBox_URL;
        private System.Windows.Forms.Button bt_create_qr;
        private System.Windows.Forms.Button bt_save_qr;
        private System.Windows.Forms.Button bt_load_qr;
        private System.Windows.Forms.Button bt_extract_qr;
        private System.Windows.Forms.TextBox tb_nom;
        private System.Windows.Forms.TextBox tb_prenom;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_new;
    }
}

