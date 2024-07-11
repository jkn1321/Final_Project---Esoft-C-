namespace Final_Project_E162561
{
    partial class frmsrsi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmsrsi));
            this.lblregsi = new System.Windows.Forms.Label();
            this.lnklbllgout = new System.Windows.Forms.LinkLabel();
            this.grpbxsr = new System.Windows.Forms.GroupBox();
            this.btnclr = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnreg = new System.Windows.Forms.Button();
            this.cmbbxrn = new System.Windows.Forms.ComboBox();
            this.lblrn = new System.Windows.Forms.Label();
            this.grpbxpd = new System.Windows.Forms.GroupBox();
            this.txtpn = new System.Windows.Forms.TextBox();
            this.txtnic = new System.Windows.Forms.TextBox();
            this.txtcn = new System.Windows.Forms.TextBox();
            this.lblcn = new System.Windows.Forms.Label();
            this.lblnic = new System.Windows.Forms.Label();
            this.lblpn = new System.Windows.Forms.Label();
            this.grpbxcd = new System.Windows.Forms.GroupBox();
            this.txthp = new System.Windows.Forms.TextBox();
            this.txtmp = new System.Windows.Forms.TextBox();
            this.txteml = new System.Windows.Forms.TextBox();
            this.txtaddr = new System.Windows.Forms.TextBox();
            this.lblhp = new System.Windows.Forms.Label();
            this.lblmp = new System.Windows.Forms.Label();
            this.lbleml = new System.Windows.Forms.Label();
            this.lbladdr = new System.Windows.Forms.Label();
            this.grpbxbd = new System.Windows.Forms.GroupBox();
            this.radioButtonfm = new System.Windows.Forms.RadioButton();
            this.radioButtonm = new System.Windows.Forms.RadioButton();
            this.dateTimePickerdob = new System.Windows.Forms.DateTimePicker();
            this.txtln = new System.Windows.Forms.TextBox();
            this.txtfn = new System.Windows.Forms.TextBox();
            this.lblg = new System.Windows.Forms.Label();
            this.lbldob = new System.Windows.Forms.Label();
            this.lblln = new System.Windows.Forms.Label();
            this.lblfn = new System.Windows.Forms.Label();
            this.lnklblext = new System.Windows.Forms.LinkLabel();
            this.grpbxsr.SuspendLayout();
            this.grpbxpd.SuspendLayout();
            this.grpbxcd.SuspendLayout();
            this.grpbxbd.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblregsi
            // 
            this.lblregsi.AutoSize = true;
            this.lblregsi.BackColor = System.Drawing.Color.Transparent;
            this.lblregsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregsi.Location = new System.Drawing.Point(458, 19);
            this.lblregsi.Name = "lblregsi";
            this.lblregsi.Size = new System.Drawing.Size(296, 37);
            this.lblregsi.TabIndex = 0;
            this.lblregsi.Text = "Skills International";
            // 
            // lnklbllgout
            // 
            this.lnklbllgout.AutoSize = true;
            this.lnklbllgout.BackColor = System.Drawing.Color.Transparent;
            this.lnklbllgout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklbllgout.Location = new System.Drawing.Point(16, 19);
            this.lnklbllgout.Name = "lnklbllgout";
            this.lnklbllgout.Size = new System.Drawing.Size(51, 15);
            this.lnklbllgout.TabIndex = 1;
            this.lnklbllgout.TabStop = true;
            this.lnklbllgout.Text = "Logout";
            this.lnklbllgout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklbllgout_LinkClicked);
            // 
            // grpbxsr
            // 
            this.grpbxsr.BackColor = System.Drawing.Color.Transparent;
            this.grpbxsr.Controls.Add(this.btnclr);
            this.grpbxsr.Controls.Add(this.btndel);
            this.grpbxsr.Controls.Add(this.btnupdate);
            this.grpbxsr.Controls.Add(this.btnreg);
            this.grpbxsr.Controls.Add(this.cmbbxrn);
            this.grpbxsr.Controls.Add(this.lblrn);
            this.grpbxsr.Controls.Add(this.grpbxpd);
            this.grpbxsr.Controls.Add(this.grpbxcd);
            this.grpbxsr.Controls.Add(this.grpbxbd);
            this.grpbxsr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxsr.Location = new System.Drawing.Point(20, 67);
            this.grpbxsr.Name = "grpbxsr";
            this.grpbxsr.Size = new System.Drawing.Size(1240, 462);
            this.grpbxsr.TabIndex = 2;
            this.grpbxsr.TabStop = false;
            this.grpbxsr.Text = "Student Registration";
            // 
            // btnclr
            // 
            this.btnclr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclr.Location = new System.Drawing.Point(908, 323);
            this.btnclr.Name = "btnclr";
            this.btnclr.Size = new System.Drawing.Size(75, 23);
            this.btnclr.TabIndex = 7;
            this.btnclr.Text = "Clear";
            this.btnclr.UseVisualStyleBackColor = true;
            this.btnclr.Click += new System.EventHandler(this.btnclr_Click);
            // 
            // btndel
            // 
            this.btndel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.Location = new System.Drawing.Point(1008, 323);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(75, 23);
            this.btndel.TabIndex = 6;
            this.btndel.Text = "Delete";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(804, 323);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 5;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnreg
            // 
            this.btnreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreg.Location = new System.Drawing.Point(693, 323);
            this.btnreg.Name = "btnreg";
            this.btnreg.Size = new System.Drawing.Size(75, 23);
            this.btnreg.TabIndex = 4;
            this.btnreg.Text = "Register";
            this.btnreg.UseVisualStyleBackColor = true;
            this.btnreg.Click += new System.EventHandler(this.btnreg_Click);
            // 
            // cmbbxrn
            // 
            this.cmbbxrn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbxrn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxrn.FormattingEnabled = true;
            this.cmbbxrn.Location = new System.Drawing.Point(165, 25);
            this.cmbbxrn.Name = "cmbbxrn";
            this.cmbbxrn.Size = new System.Drawing.Size(138, 21);
            this.cmbbxrn.TabIndex = 3;
            this.cmbbxrn.SelectedValueChanged += new System.EventHandler(this.cmbbxrn_SelectedValueChanged);
            // 
            // lblrn
            // 
            this.lblrn.AutoSize = true;
            this.lblrn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrn.Location = new System.Drawing.Point(55, 27);
            this.lblrn.Name = "lblrn";
            this.lblrn.Size = new System.Drawing.Size(50, 13);
            this.lblrn.TabIndex = 2;
            this.lblrn.Text = "Reg No";
            // 
            // grpbxpd
            // 
            this.grpbxpd.Controls.Add(this.txtpn);
            this.grpbxpd.Controls.Add(this.txtnic);
            this.grpbxpd.Controls.Add(this.txtcn);
            this.grpbxpd.Controls.Add(this.lblcn);
            this.grpbxpd.Controls.Add(this.lblnic);
            this.grpbxpd.Controls.Add(this.lblpn);
            this.grpbxpd.Location = new System.Drawing.Point(6, 282);
            this.grpbxpd.Name = "grpbxpd";
            this.grpbxpd.Size = new System.Drawing.Size(572, 161);
            this.grpbxpd.TabIndex = 1;
            this.grpbxpd.TabStop = false;
            this.grpbxpd.Text = "Parent Details";
            // 
            // txtpn
            // 
            this.txtpn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpn.Location = new System.Drawing.Point(143, 32);
            this.txtpn.Name = "txtpn";
            this.txtpn.Size = new System.Drawing.Size(411, 22);
            this.txtpn.TabIndex = 13;
            // 
            // txtnic
            // 
            this.txtnic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnic.Location = new System.Drawing.Point(143, 80);
            this.txtnic.Name = "txtnic";
            this.txtnic.Size = new System.Drawing.Size(123, 22);
            this.txtnic.TabIndex = 12;
            // 
            // txtcn
            // 
            this.txtcn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcn.Location = new System.Drawing.Point(143, 122);
            this.txtcn.Name = "txtcn";
            this.txtcn.Size = new System.Drawing.Size(123, 22);
            this.txtcn.TabIndex = 11;
            // 
            // lblcn
            // 
            this.lblcn.AutoSize = true;
            this.lblcn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcn.Location = new System.Drawing.Point(36, 126);
            this.lblcn.Name = "lblcn";
            this.lblcn.Size = new System.Drawing.Size(98, 13);
            this.lblcn.TabIndex = 10;
            this.lblcn.Text = "Contact Number";
            // 
            // lblnic
            // 
            this.lblnic.AutoSize = true;
            this.lblnic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnic.Location = new System.Drawing.Point(36, 84);
            this.lblnic.Name = "lblnic";
            this.lblnic.Size = new System.Drawing.Size(28, 13);
            this.lblnic.TabIndex = 9;
            this.lblnic.Text = "NIC";
            // 
            // lblpn
            // 
            this.lblpn.AutoSize = true;
            this.lblpn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpn.Location = new System.Drawing.Point(36, 41);
            this.lblpn.Name = "lblpn";
            this.lblpn.Size = new System.Drawing.Size(80, 13);
            this.lblpn.TabIndex = 8;
            this.lblpn.Text = "Parent Name";
            // 
            // grpbxcd
            // 
            this.grpbxcd.Controls.Add(this.txthp);
            this.grpbxcd.Controls.Add(this.txtmp);
            this.grpbxcd.Controls.Add(this.txteml);
            this.grpbxcd.Controls.Add(this.txtaddr);
            this.grpbxcd.Controls.Add(this.lblhp);
            this.grpbxcd.Controls.Add(this.lblmp);
            this.grpbxcd.Controls.Add(this.lbleml);
            this.grpbxcd.Controls.Add(this.lbladdr);
            this.grpbxcd.Location = new System.Drawing.Point(630, 52);
            this.grpbxcd.Name = "grpbxcd";
            this.grpbxcd.Size = new System.Drawing.Size(572, 194);
            this.grpbxcd.TabIndex = 1;
            this.grpbxcd.TabStop = false;
            this.grpbxcd.Text = "Contact Details";
            // 
            // txthp
            // 
            this.txthp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthp.Location = new System.Drawing.Point(431, 155);
            this.txthp.Name = "txthp";
            this.txthp.Size = new System.Drawing.Size(123, 22);
            this.txthp.TabIndex = 7;
            // 
            // txtmp
            // 
            this.txtmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmp.Location = new System.Drawing.Point(149, 155);
            this.txtmp.Name = "txtmp";
            this.txtmp.Size = new System.Drawing.Size(100, 22);
            this.txtmp.TabIndex = 6;
            // 
            // txteml
            // 
            this.txteml.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txteml.Location = new System.Drawing.Point(149, 109);
            this.txteml.Name = "txteml";
            this.txteml.Size = new System.Drawing.Size(405, 22);
            this.txteml.TabIndex = 5;
            // 
            // txtaddr
            // 
            this.txtaddr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddr.Location = new System.Drawing.Point(149, 38);
            this.txtaddr.Multiline = true;
            this.txtaddr.Name = "txtaddr";
            this.txtaddr.Size = new System.Drawing.Size(405, 57);
            this.txtaddr.TabIndex = 4;
            // 
            // lblhp
            // 
            this.lblhp.AutoSize = true;
            this.lblhp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhp.Location = new System.Drawing.Point(344, 158);
            this.lblhp.Name = "lblhp";
            this.lblhp.Size = new System.Drawing.Size(79, 13);
            this.lblhp.TabIndex = 3;
            this.lblhp.Text = "Home Phone";
            // 
            // lblmp
            // 
            this.lblmp.AutoSize = true;
            this.lblmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmp.Location = new System.Drawing.Point(36, 158);
            this.lblmp.Name = "lblmp";
            this.lblmp.Size = new System.Drawing.Size(84, 13);
            this.lblmp.TabIndex = 2;
            this.lblmp.Text = "Mobile Phone";
            // 
            // lbleml
            // 
            this.lbleml.AutoSize = true;
            this.lbleml.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbleml.Location = new System.Drawing.Point(36, 112);
            this.lbleml.Name = "lbleml";
            this.lbleml.Size = new System.Drawing.Size(37, 13);
            this.lbleml.TabIndex = 1;
            this.lbleml.Text = "Email";
            // 
            // lbladdr
            // 
            this.lbladdr.AutoSize = true;
            this.lbladdr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdr.Location = new System.Drawing.Point(36, 41);
            this.lbladdr.Name = "lbladdr";
            this.lbladdr.Size = new System.Drawing.Size(52, 13);
            this.lbladdr.TabIndex = 0;
            this.lbladdr.Text = "Address";
            // 
            // grpbxbd
            // 
            this.grpbxbd.BackColor = System.Drawing.Color.Transparent;
            this.grpbxbd.Controls.Add(this.radioButtonfm);
            this.grpbxbd.Controls.Add(this.radioButtonm);
            this.grpbxbd.Controls.Add(this.dateTimePickerdob);
            this.grpbxbd.Controls.Add(this.txtln);
            this.grpbxbd.Controls.Add(this.txtfn);
            this.grpbxbd.Controls.Add(this.lblg);
            this.grpbxbd.Controls.Add(this.lbldob);
            this.grpbxbd.Controls.Add(this.lblln);
            this.grpbxbd.Controls.Add(this.lblfn);
            this.grpbxbd.Location = new System.Drawing.Point(6, 52);
            this.grpbxbd.Name = "grpbxbd";
            this.grpbxbd.Size = new System.Drawing.Size(572, 194);
            this.grpbxbd.TabIndex = 0;
            this.grpbxbd.TabStop = false;
            this.grpbxbd.Text = "Basic Details";
            // 
            // radioButtonfm
            // 
            this.radioButtonfm.AutoSize = true;
            this.radioButtonfm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonfm.Location = new System.Drawing.Point(246, 149);
            this.radioButtonfm.Name = "radioButtonfm";
            this.radioButtonfm.Size = new System.Drawing.Size(72, 20);
            this.radioButtonfm.TabIndex = 11;
            this.radioButtonfm.TabStop = true;
            this.radioButtonfm.Text = "Female";
            this.radioButtonfm.UseVisualStyleBackColor = true;
            // 
            // radioButtonm
            // 
            this.radioButtonm.AutoSize = true;
            this.radioButtonm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonm.Location = new System.Drawing.Point(143, 149);
            this.radioButtonm.Name = "radioButtonm";
            this.radioButtonm.Size = new System.Drawing.Size(56, 20);
            this.radioButtonm.TabIndex = 10;
            this.radioButtonm.TabStop = true;
            this.radioButtonm.Text = "Male";
            this.radioButtonm.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerdob
            // 
            this.dateTimePickerdob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerdob.Location = new System.Drawing.Point(143, 105);
            this.dateTimePickerdob.Name = "dateTimePickerdob";
            this.dateTimePickerdob.Size = new System.Drawing.Size(280, 22);
            this.dateTimePickerdob.TabIndex = 9;
            // 
            // txtln
            // 
            this.txtln.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtln.Location = new System.Drawing.Point(143, 70);
            this.txtln.Name = "txtln";
            this.txtln.Size = new System.Drawing.Size(411, 22);
            this.txtln.TabIndex = 8;
            // 
            // txtfn
            // 
            this.txtfn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfn.Location = new System.Drawing.Point(143, 34);
            this.txtfn.Name = "txtfn";
            this.txtfn.Size = new System.Drawing.Size(411, 22);
            this.txtfn.TabIndex = 7;
            // 
            // lblg
            // 
            this.lblg.AutoSize = true;
            this.lblg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblg.Location = new System.Drawing.Point(30, 149);
            this.lblg.Name = "lblg";
            this.lblg.Size = new System.Drawing.Size(48, 13);
            this.lblg.TabIndex = 6;
            this.lblg.Text = "Gender";
            // 
            // lbldob
            // 
            this.lbldob.AutoSize = true;
            this.lbldob.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldob.Location = new System.Drawing.Point(30, 111);
            this.lbldob.Name = "lbldob";
            this.lbldob.Size = new System.Drawing.Size(79, 13);
            this.lbldob.TabIndex = 5;
            this.lbldob.Text = "Date of Birth";
            // 
            // lblln
            // 
            this.lblln.AutoSize = true;
            this.lblln.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblln.Location = new System.Drawing.Point(30, 73);
            this.lblln.Name = "lblln";
            this.lblln.Size = new System.Drawing.Size(67, 13);
            this.lblln.TabIndex = 4;
            this.lblln.Text = "Last Name";
            // 
            // lblfn
            // 
            this.lblfn.AutoSize = true;
            this.lblfn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfn.Location = new System.Drawing.Point(30, 37);
            this.lblfn.Name = "lblfn";
            this.lblfn.Size = new System.Drawing.Size(67, 13);
            this.lblfn.TabIndex = 3;
            this.lblfn.Text = "First Name";
            // 
            // lnklblext
            // 
            this.lnklblext.AutoSize = true;
            this.lnklblext.BackColor = System.Drawing.Color.Transparent;
            this.lnklblext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblext.Location = new System.Drawing.Point(1229, 532);
            this.lnklblext.Name = "lnklblext";
            this.lnklblext.Size = new System.Drawing.Size(31, 15);
            this.lnklblext.TabIndex = 8;
            this.lnklblext.TabStop = true;
            this.lnklblext.Text = "Exit";
            this.lnklblext.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblext_LinkClicked);
            // 
            // frmsrsi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final_Project_E162561.Properties.Resources.istockphoto_1178789102_612x612;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1272, 558);
            this.Controls.Add(this.lnklblext);
            this.Controls.Add(this.grpbxsr);
            this.Controls.Add(this.lnklbllgout);
            this.Controls.Add(this.lblregsi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmsrsi";
            this.Text = "Student Registration-Skills International";
            this.grpbxsr.ResumeLayout(false);
            this.grpbxsr.PerformLayout();
            this.grpbxpd.ResumeLayout(false);
            this.grpbxpd.PerformLayout();
            this.grpbxcd.ResumeLayout(false);
            this.grpbxcd.PerformLayout();
            this.grpbxbd.ResumeLayout(false);
            this.grpbxbd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblregsi;
        private System.Windows.Forms.LinkLabel lnklbllgout;
        private System.Windows.Forms.GroupBox grpbxsr;
        private System.Windows.Forms.Label lblrn;
        private System.Windows.Forms.GroupBox grpbxpd;
        private System.Windows.Forms.GroupBox grpbxcd;
        private System.Windows.Forms.GroupBox grpbxbd;
        private System.Windows.Forms.ComboBox cmbbxrn;
        private System.Windows.Forms.RadioButton radioButtonfm;
        private System.Windows.Forms.RadioButton radioButtonm;
        private System.Windows.Forms.DateTimePicker dateTimePickerdob;
        private System.Windows.Forms.TextBox txtln;
        private System.Windows.Forms.TextBox txtfn;
        private System.Windows.Forms.Label lblg;
        private System.Windows.Forms.Label lbldob;
        private System.Windows.Forms.Label lblln;
        private System.Windows.Forms.Label lblfn;
        private System.Windows.Forms.Button btnclr;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnreg;
        private System.Windows.Forms.TextBox txtpn;
        private System.Windows.Forms.TextBox txtnic;
        private System.Windows.Forms.TextBox txtcn;
        private System.Windows.Forms.Label lblcn;
        private System.Windows.Forms.Label lblnic;
        private System.Windows.Forms.Label lblpn;
        private System.Windows.Forms.TextBox txthp;
        private System.Windows.Forms.TextBox txtmp;
        private System.Windows.Forms.TextBox txteml;
        private System.Windows.Forms.TextBox txtaddr;
        private System.Windows.Forms.Label lblhp;
        private System.Windows.Forms.Label lblmp;
        private System.Windows.Forms.Label lbleml;
        private System.Windows.Forms.Label lbladdr;
        private System.Windows.Forms.LinkLabel lnklblext;
    }
}