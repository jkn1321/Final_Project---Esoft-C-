namespace Final_Project_E162561
{
    partial class frmsilogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmsilogin));
            this.grpbxlogin = new System.Windows.Forms.GroupBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnclr = new System.Windows.Forms.Button();
            this.checkbxsp = new System.Windows.Forms.CheckBox();
            this.txtpw = new System.Windows.Forms.TextBox();
            this.lblpw = new System.Windows.Forms.Label();
            this.txtun = new System.Windows.Forms.TextBox();
            this.lblun = new System.Windows.Forms.Label();
            this.picturebxskill = new System.Windows.Forms.PictureBox();
            this.lblsi = new System.Windows.Forms.Label();
            this.btnext = new System.Windows.Forms.Button();
            this.grpbxlogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebxskill)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbxlogin
            // 
            this.grpbxlogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbxlogin.BackColor = System.Drawing.Color.Transparent;
            this.grpbxlogin.Controls.Add(this.btnlogin);
            this.grpbxlogin.Controls.Add(this.btnclr);
            this.grpbxlogin.Controls.Add(this.checkbxsp);
            this.grpbxlogin.Controls.Add(this.txtpw);
            this.grpbxlogin.Controls.Add(this.lblpw);
            this.grpbxlogin.Controls.Add(this.txtun);
            this.grpbxlogin.Controls.Add(this.lblun);
            this.grpbxlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxlogin.Location = new System.Drawing.Point(46, 267);
            this.grpbxlogin.Name = "grpbxlogin";
            this.grpbxlogin.Size = new System.Drawing.Size(398, 207);
            this.grpbxlogin.TabIndex = 0;
            this.grpbxlogin.TabStop = false;
            this.grpbxlogin.Text = "Login";
            // 
            // btnlogin
            // 
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(270, 165);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(77, 27);
            this.btnlogin.TabIndex = 6;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnclr
            // 
            this.btnclr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclr.Location = new System.Drawing.Point(24, 165);
            this.btnclr.Name = "btnclr";
            this.btnclr.Size = new System.Drawing.Size(77, 27);
            this.btnclr.TabIndex = 5;
            this.btnclr.Text = "Clear";
            this.btnclr.UseVisualStyleBackColor = true;
            this.btnclr.Click += new System.EventHandler(this.btnclr_Click);
            // 
            // checkbxsp
            // 
            this.checkbxsp.AutoSize = true;
            this.checkbxsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbxsp.Location = new System.Drawing.Point(246, 133);
            this.checkbxsp.Name = "checkbxsp";
            this.checkbxsp.Size = new System.Drawing.Size(101, 17);
            this.checkbxsp.TabIndex = 4;
            this.checkbxsp.Text = "Show password";
            this.checkbxsp.UseVisualStyleBackColor = true;
            this.checkbxsp.CheckedChanged += new System.EventHandler(this.checkbxsp_CheckedChanged);
            // 
            // txtpw
            // 
            this.txtpw.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpw.Location = new System.Drawing.Point(188, 103);
            this.txtpw.Name = "txtpw";
            this.txtpw.Size = new System.Drawing.Size(157, 24);
            this.txtpw.TabIndex = 3;
            this.txtpw.UseSystemPasswordChar = true;
            // 
            // lblpw
            // 
            this.lblpw.AutoSize = true;
            this.lblpw.BackColor = System.Drawing.Color.White;
            this.lblpw.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpw.Location = new System.Drawing.Point(41, 106);
            this.lblpw.Name = "lblpw";
            this.lblpw.Size = new System.Drawing.Size(83, 18);
            this.lblpw.TabIndex = 2;
            this.lblpw.Text = "Password";
            // 
            // txtun
            // 
            this.txtun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtun.Location = new System.Drawing.Point(188, 57);
            this.txtun.Name = "txtun";
            this.txtun.Size = new System.Drawing.Size(157, 24);
            this.txtun.TabIndex = 1;
            // 
            // lblun
            // 
            this.lblun.AutoSize = true;
            this.lblun.BackColor = System.Drawing.Color.White;
            this.lblun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblun.Location = new System.Drawing.Point(41, 60);
            this.lblun.Name = "lblun";
            this.lblun.Size = new System.Drawing.Size(85, 18);
            this.lblun.TabIndex = 0;
            this.lblun.Text = "Username";
            // 
            // picturebxskill
            // 
            this.picturebxskill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picturebxskill.BackColor = System.Drawing.Color.Transparent;
            this.picturebxskill.Image = global::Final_Project_E162561.Properties.Resources.Skill_Logo;
            this.picturebxskill.Location = new System.Drawing.Point(123, 91);
            this.picturebxskill.Name = "picturebxskill";
            this.picturebxskill.Size = new System.Drawing.Size(233, 150);
            this.picturebxskill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebxskill.TabIndex = 1;
            this.picturebxskill.TabStop = false;
            // 
            // lblsi
            // 
            this.lblsi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblsi.AutoSize = true;
            this.lblsi.BackColor = System.Drawing.Color.Tan;
            this.lblsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsi.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblsi.Location = new System.Drawing.Point(47, 22);
            this.lblsi.Name = "lblsi";
            this.lblsi.Size = new System.Drawing.Size(431, 55);
            this.lblsi.TabIndex = 2;
            this.lblsi.Text = "Skills International";
            // 
            // btnext
            // 
            this.btnext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnext.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnext.Location = new System.Drawing.Point(2, 500);
            this.btnext.Name = "btnext";
            this.btnext.Size = new System.Drawing.Size(74, 28);
            this.btnext.TabIndex = 7;
            this.btnext.Text = "Exit";
            this.btnext.UseVisualStyleBackColor = true;
            this.btnext.Click += new System.EventHandler(this.btnext_Click);
            // 
            // frmsilogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final_Project_E162561.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(518, 530);
            this.Controls.Add(this.btnext);
            this.Controls.Add(this.lblsi);
            this.Controls.Add(this.picturebxskill);
            this.Controls.Add(this.grpbxlogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmsilogin";
            this.Text = "Login-Skills International";
            this.grpbxlogin.ResumeLayout(false);
            this.grpbxlogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebxskill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxlogin;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnclr;
        private System.Windows.Forms.CheckBox checkbxsp;
        private System.Windows.Forms.TextBox txtpw;
        private System.Windows.Forms.Label lblpw;
        private System.Windows.Forms.TextBox txtun;
        private System.Windows.Forms.Label lblun;
        private System.Windows.Forms.PictureBox picturebxskill;
        private System.Windows.Forms.Label lblsi;
        private System.Windows.Forms.Button btnext;
    }
}

