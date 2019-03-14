namespace Calculator
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
            this.lblRez = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnInmultire = new System.Windows.Forms.Button();
            this.btnEgal = new System.Windows.Forms.Button();
            this.btnImpartire = new System.Windows.Forms.Button();
            this.txtValori = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnRadical = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRez
            // 
            this.lblRez.AutoSize = true;
            this.lblRez.BackColor = System.Drawing.Color.Transparent;
            this.lblRez.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRez.ForeColor = System.Drawing.Color.White;
            this.lblRez.Location = new System.Drawing.Point(290, 38);
            this.lblRez.Name = "lblRez";
            this.lblRez.Size = new System.Drawing.Size(0, 24);
            this.lblRez.TabIndex = 0;
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.Transparent;
            this.btnPlus.FlatAppearance.BorderSize = 0;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPlus.ForeColor = System.Drawing.Color.White;
            this.btnPlus.Location = new System.Drawing.Point(74, 83);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(51, 48);
            this.btnPlus.TabIndex = 1;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInmultire
            // 
            this.btnInmultire.BackColor = System.Drawing.Color.Transparent;
            this.btnInmultire.FlatAppearance.BorderSize = 0;
            this.btnInmultire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInmultire.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnInmultire.ForeColor = System.Drawing.Color.White;
            this.btnInmultire.Location = new System.Drawing.Point(74, 121);
            this.btnInmultire.Name = "btnInmultire";
            this.btnInmultire.Size = new System.Drawing.Size(51, 49);
            this.btnInmultire.TabIndex = 2;
            this.btnInmultire.Text = "x";
            this.btnInmultire.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInmultire.UseVisualStyleBackColor = false;
            this.btnInmultire.Click += new System.EventHandler(this.btnInmultire_Click);
            // 
            // btnEgal
            // 
            this.btnEgal.BackColor = System.Drawing.Color.Transparent;
            this.btnEgal.FlatAppearance.BorderSize = 0;
            this.btnEgal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEgal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEgal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEgal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEgal.ForeColor = System.Drawing.Color.White;
            this.btnEgal.Location = new System.Drawing.Point(146, 175);
            this.btnEgal.Name = "btnEgal";
            this.btnEgal.Size = new System.Drawing.Size(51, 49);
            this.btnEgal.TabIndex = 3;
            this.btnEgal.Text = "=";
            this.btnEgal.UseVisualStyleBackColor = false;
            this.btnEgal.Click += new System.EventHandler(this.btnEgal_Click);
            // 
            // btnImpartire
            // 
            this.btnImpartire.BackColor = System.Drawing.Color.Transparent;
            this.btnImpartire.FlatAppearance.BorderSize = 0;
            this.btnImpartire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImpartire.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnImpartire.ForeColor = System.Drawing.Color.White;
            this.btnImpartire.Location = new System.Drawing.Point(146, 121);
            this.btnImpartire.Name = "btnImpartire";
            this.btnImpartire.Size = new System.Drawing.Size(51, 48);
            this.btnImpartire.TabIndex = 4;
            this.btnImpartire.Text = "÷";
            this.btnImpartire.UseVisualStyleBackColor = false;
            this.btnImpartire.Click += new System.EventHandler(this.btnImpartire_Click);
            // 
            // txtValori
            // 
            this.txtValori.BackColor = System.Drawing.Color.White;
            this.txtValori.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValori.Location = new System.Drawing.Point(74, 44);
            this.txtValori.Name = "txtValori";
            this.txtValori.Size = new System.Drawing.Size(123, 20);
            this.txtValori.TabIndex = 6;
            this.txtValori.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.SeaShell;
            this.label2.Location = new System.Drawing.Point(74, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Introdu Valorile";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(203, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Rezultat:";
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.Transparent;
            this.btnMinus.FlatAppearance.BorderSize = 0;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMinus.ForeColor = System.Drawing.Color.White;
            this.btnMinus.Location = new System.Drawing.Point(146, 70);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(51, 49);
            this.btnMinus.TabIndex = 9;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnRadical
            // 
            this.btnRadical.BackColor = System.Drawing.Color.Transparent;
            this.btnRadical.FlatAppearance.BorderSize = 0;
            this.btnRadical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRadical.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRadical.ForeColor = System.Drawing.Color.White;
            this.btnRadical.Location = new System.Drawing.Point(74, 176);
            this.btnRadical.Name = "btnRadical";
            this.btnRadical.Size = new System.Drawing.Size(51, 49);
            this.btnRadical.TabIndex = 10;
            this.btnRadical.Text = "√";
            this.btnRadical.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRadical.UseVisualStyleBackColor = false;
            this.btnRadical.Click += new System.EventHandler(this.btnRadical_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Gold;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdd.Location = new System.Drawing.Point(11, 44);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(57, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Adauga";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DarkRed;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClear.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClear.Location = new System.Drawing.Point(74, 231);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(123, 27);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Curata";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(449, 273);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRadical);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValori);
            this.Controls.Add(this.btnImpartire);
            this.Controls.Add(this.btnEgal);
            this.Controls.Add(this.btnInmultire);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.lblRez);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRez;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnInmultire;
        private System.Windows.Forms.Button btnEgal;
        private System.Windows.Forms.Button btnImpartire;
        private System.Windows.Forms.TextBox txtValori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnRadical;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
    }
}

