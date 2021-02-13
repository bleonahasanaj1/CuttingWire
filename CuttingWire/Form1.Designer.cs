
namespace CuttingWire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtCmimi = new System.Windows.Forms.TextBox();
            this.lblShkruajCmimin = new System.Windows.Forms.Label();
            this.lblShkruajGjatesine = new System.Windows.Forms.Label();
            this.txtGjatesia = new System.Windows.Forms.TextBox();
            this.lblGjatesite = new System.Windows.Forms.Label();
            this.lblCmimet = new System.Windows.Forms.Label();
            this.lblRezultati = new System.Windows.Forms.Label();
            this.btnShtoCmimin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGjejPrerjenOptimale = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCmimi
            // 
            this.txtCmimi.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCmimi.Location = new System.Drawing.Point(19, 233);
            this.txtCmimi.Name = "txtCmimi";
            this.txtCmimi.Size = new System.Drawing.Size(59, 28);
            this.txtCmimi.TabIndex = 1;
            this.txtCmimi.TextChanged += new System.EventHandler(this.txtCmimi_TextChanged);
            this.txtCmimi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCmimi_KeyPress);
            // 
            // lblShkruajCmimin
            // 
            this.lblShkruajCmimin.AutoSize = true;
            this.lblShkruajCmimin.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShkruajCmimin.Location = new System.Drawing.Point(17, 210);
            this.lblShkruajCmimin.Name = "lblShkruajCmimin";
            this.lblShkruajCmimin.Size = new System.Drawing.Size(194, 20);
            this.lblShkruajCmimin.TabIndex = 2;
            this.lblShkruajCmimin.Text = "Shkruaj çmimin për gjatësi";
            // 
            // lblShkruajGjatesine
            // 
            this.lblShkruajGjatesine.AutoSize = true;
            this.lblShkruajGjatesine.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShkruajGjatesine.Location = new System.Drawing.Point(17, 363);
            this.lblShkruajGjatesine.Name = "lblShkruajGjatesine";
            this.lblShkruajGjatesine.Size = new System.Drawing.Size(179, 20);
            this.lblShkruajGjatesine.TabIndex = 3;
            this.lblShkruajGjatesine.Text = "Shkruaj gjatësinë e telit";
            this.lblShkruajGjatesine.Click += new System.EventHandler(this.lblGjatesia_Click);
            // 
            // txtGjatesia
            // 
            this.txtGjatesia.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGjatesia.Location = new System.Drawing.Point(19, 386);
            this.txtGjatesia.Name = "txtGjatesia";
            this.txtGjatesia.Size = new System.Drawing.Size(59, 28);
            this.txtGjatesia.TabIndex = 4;
            this.txtGjatesia.TextChanged += new System.EventHandler(this.txtGjatesia_TextChanged);
            this.txtGjatesia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGjatesia_KeyPress);
            // 
            // lblGjatesite
            // 
            this.lblGjatesite.AutoSize = true;
            this.lblGjatesite.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGjatesite.Location = new System.Drawing.Point(225, 241);
            this.lblGjatesite.Name = "lblGjatesite";
            this.lblGjatesite.Size = new System.Drawing.Size(82, 20);
            this.lblGjatesite.TabIndex = 5;
            this.lblGjatesite.Text = "Gjatësitë: ";
            // 
            // lblCmimet
            // 
            this.lblCmimet.AutoSize = true;
            this.lblCmimet.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCmimet.Location = new System.Drawing.Point(225, 277);
            this.lblCmimet.Name = "lblCmimet";
            this.lblCmimet.Size = new System.Drawing.Size(83, 20);
            this.lblCmimet.TabIndex = 6;
            this.lblCmimet.Text = "Çmimet:     ";
            // 
            // lblRezultati
            // 
            this.lblRezultati.AutoSize = true;
            this.lblRezultati.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRezultati.Location = new System.Drawing.Point(17, 484);
            this.lblRezultati.MaximumSize = new System.Drawing.Size(500, 0);
            this.lblRezultati.Name = "lblRezultati";
            this.lblRezultati.Size = new System.Drawing.Size(156, 23);
            this.lblRezultati.TabIndex = 7;
            this.lblRezultati.Text = "Zgjidhja më e mirë: ";
            // 
            // btnShtoCmimin
            // 
            this.btnShtoCmimin.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShtoCmimin.Location = new System.Drawing.Point(19, 277);
            this.btnShtoCmimin.Name = "btnShtoCmimin";
            this.btnShtoCmimin.Size = new System.Drawing.Size(107, 31);
            this.btnShtoCmimin.TabIndex = 8;
            this.btnShtoCmimin.Text = "Shto çmimin";
            this.btnShtoCmimin.UseVisualStyleBackColor = true;
            this.btnShtoCmimin.Click += new System.EventHandler(this.btnShtoCmimin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(100, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 177);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnGjejPrerjenOptimale
            // 
            this.btnGjejPrerjenOptimale.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGjejPrerjenOptimale.Location = new System.Drawing.Point(19, 437);
            this.btnGjejPrerjenOptimale.Name = "btnGjejPrerjenOptimale";
            this.btnGjejPrerjenOptimale.Size = new System.Drawing.Size(173, 30);
            this.btnGjejPrerjenOptimale.TabIndex = 12;
            this.btnGjejPrerjenOptimale.Text = "Gjej prerjen optimale";
            this.btnGjejPrerjenOptimale.UseVisualStyleBackColor = true;
            this.btnGjejPrerjenOptimale.Click += new System.EventHandler(this.btnGjejPrerjenOptimale_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 545);
            this.Controls.Add(this.btnGjejPrerjenOptimale);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnShtoCmimin);
            this.Controls.Add(this.lblRezultati);
            this.Controls.Add(this.lblCmimet);
            this.Controls.Add(this.lblGjatesite);
            this.Controls.Add(this.txtGjatesia);
            this.Controls.Add(this.lblShkruajGjatesine);
            this.Controls.Add(this.lblShkruajCmimin);
            this.Controls.Add(this.txtCmimi);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCmimi;
        private System.Windows.Forms.Label lblShkruajCmimin;
        private System.Windows.Forms.Label lblShkruajGjatesine;
        private System.Windows.Forms.TextBox txtGjatesia;
        private System.Windows.Forms.Label lblGjatesite;
        private System.Windows.Forms.Label lblCmimet;
        private System.Windows.Forms.Label lblRezultati;
        private System.Windows.Forms.Button btnShtoCmimin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGjejPrerjenOptimale;
    }
}

