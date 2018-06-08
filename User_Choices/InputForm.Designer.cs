namespace User_Choices
{
    partial class InputForm
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
            this.lbl_dl = new System.Windows.Forms.Label();
            this.lbl_species = new System.Windows.Forms.Label();
            this.lbl_grade = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbox_species = new System.Windows.Forms.GroupBox();
            this.rbtn_Douglas_fir_larch = new System.Windows.Forms.RadioButton();
            this.rbtn_Hem_fir = new System.Windows.Forms.RadioButton();
            this.rbtn_Southern_pine = new System.Windows.Forms.RadioButton();
            this.rbtn_Spruce_pine_fir = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtn_10 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.rbtn_ss = new System.Windows.Forms.RadioButton();
            this.rbtn_1 = new System.Windows.Forms.RadioButton();
            this.rbtn_2 = new System.Windows.Forms.RadioButton();
            this.rbtn_3 = new System.Windows.Forms.RadioButton();
            this.gbox_grade = new System.Windows.Forms.GroupBox();
            this.gbox_snow = new System.Windows.Forms.GroupBox();
            this.rbtn_70 = new System.Windows.Forms.RadioButton();
            this.rbtn_50 = new System.Windows.Forms.RadioButton();
            this.rbtn_30 = new System.Windows.Forms.RadioButton();
            this.rbtn_209 = new System.Windows.Forms.RadioButton();
            this.btn_done = new System.Windows.Forms.Button();
            this.gbox_species.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbox_grade.SuspendLayout();
            this.gbox_snow.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_dl
            // 
            this.lbl_dl.AutoSize = true;
            this.lbl_dl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_dl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_dl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dl.Location = new System.Drawing.Point(19, 29);
            this.lbl_dl.Name = "lbl_dl";
            this.lbl_dl.Size = new System.Drawing.Size(223, 29);
            this.lbl_dl.TabIndex = 0;
            this.lbl_dl.Text = "Dead Load               : ";
            this.lbl_dl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_dl.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_species
            // 
            this.lbl_species.AutoSize = true;
            this.lbl_species.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_species.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_species.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_species.Location = new System.Drawing.Point(18, 96);
            this.lbl_species.Name = "lbl_species";
            this.lbl_species.Size = new System.Drawing.Size(224, 29);
            this.lbl_species.TabIndex = 1;
            this.lbl_species.Text = "Species                     : ";
            // 
            // lbl_grade
            // 
            this.lbl_grade.AutoSize = true;
            this.lbl_grade.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_grade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_grade.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_grade.Location = new System.Drawing.Point(19, 212);
            this.lbl_grade.Name = "lbl_grade";
            this.lbl_grade.Size = new System.Drawing.Size(223, 29);
            this.lbl_grade.TabIndex = 2;
            this.lbl_grade.Text = "Grade                       : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ground Snow Load : ";
            // 
            // gbox_species
            // 
            this.gbox_species.Controls.Add(this.rbtn_Spruce_pine_fir);
            this.gbox_species.Controls.Add(this.rbtn_Southern_pine);
            this.gbox_species.Controls.Add(this.rbtn_Hem_fir);
            this.gbox_species.Controls.Add(this.rbtn_Douglas_fir_larch);
            this.gbox_species.Location = new System.Drawing.Point(309, 96);
            this.gbox_species.Name = "gbox_species";
            this.gbox_species.Size = new System.Drawing.Size(271, 104);
            this.gbox_species.TabIndex = 4;
            this.gbox_species.TabStop = false;
            this.gbox_species.Text = "IRC";
            // 
            // rbtn_Douglas_fir_larch
            // 
            this.rbtn_Douglas_fir_larch.AutoSize = true;
            this.rbtn_Douglas_fir_larch.Location = new System.Drawing.Point(17, 19);
            this.rbtn_Douglas_fir_larch.Name = "rbtn_Douglas_fir_larch";
            this.rbtn_Douglas_fir_larch.Size = new System.Drawing.Size(107, 17);
            this.rbtn_Douglas_fir_larch.TabIndex = 0;
            this.rbtn_Douglas_fir_larch.TabStop = true;
            this.rbtn_Douglas_fir_larch.Text = "Douglas_fir_larch";
            this.rbtn_Douglas_fir_larch.UseVisualStyleBackColor = true;
            // 
            // rbtn_Hem_fir
            // 
            this.rbtn_Hem_fir.AutoSize = true;
            this.rbtn_Hem_fir.Location = new System.Drawing.Point(162, 19);
            this.rbtn_Hem_fir.Name = "rbtn_Hem_fir";
            this.rbtn_Hem_fir.Size = new System.Drawing.Size(61, 17);
            this.rbtn_Hem_fir.TabIndex = 1;
            this.rbtn_Hem_fir.TabStop = true;
            this.rbtn_Hem_fir.Text = "Hem_fir";
            this.rbtn_Hem_fir.UseVisualStyleBackColor = true;
            // 
            // rbtn_Southern_pine
            // 
            this.rbtn_Southern_pine.AutoSize = true;
            this.rbtn_Southern_pine.Location = new System.Drawing.Point(17, 57);
            this.rbtn_Southern_pine.Name = "rbtn_Southern_pine";
            this.rbtn_Southern_pine.Size = new System.Drawing.Size(94, 17);
            this.rbtn_Southern_pine.TabIndex = 2;
            this.rbtn_Southern_pine.TabStop = true;
            this.rbtn_Southern_pine.Text = "Southern_pine";
            this.rbtn_Southern_pine.UseVisualStyleBackColor = true;
            this.rbtn_Southern_pine.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rbtn_Spruce_pine_fir
            // 
            this.rbtn_Spruce_pine_fir.AutoSize = true;
            this.rbtn_Spruce_pine_fir.Location = new System.Drawing.Point(162, 57);
            this.rbtn_Spruce_pine_fir.Name = "rbtn_Spruce_pine_fir";
            this.rbtn_Spruce_pine_fir.Size = new System.Drawing.Size(99, 17);
            this.rbtn_Spruce_pine_fir.TabIndex = 3;
            this.rbtn_Spruce_pine_fir.TabStop = true;
            this.rbtn_Spruce_pine_fir.Text = "Spruce_pine_fir";
            this.rbtn_Spruce_pine_fir.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton7);
            this.groupBox2.Controls.Add(this.rbtn_10);
            this.groupBox2.Location = new System.Drawing.Point(309, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 47);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PSF";
            // 
            // rbtn_10
            // 
            this.rbtn_10.AutoSize = true;
            this.rbtn_10.Location = new System.Drawing.Point(17, 19);
            this.rbtn_10.Name = "rbtn_10";
            this.rbtn_10.Size = new System.Drawing.Size(37, 17);
            this.rbtn_10.TabIndex = 0;
            this.rbtn_10.TabStop = true;
            this.rbtn_10.Text = "10";
            this.rbtn_10.UseVisualStyleBackColor = true;
            this.rbtn_10.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(162, 19);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(37, 17);
            this.radioButton7.TabIndex = 2;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "20";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // rbtn_ss
            // 
            this.rbtn_ss.AutoSize = true;
            this.rbtn_ss.Location = new System.Drawing.Point(17, 19);
            this.rbtn_ss.Name = "rbtn_ss";
            this.rbtn_ss.Size = new System.Drawing.Size(39, 17);
            this.rbtn_ss.TabIndex = 0;
            this.rbtn_ss.TabStop = true;
            this.rbtn_ss.Text = "SS";
            this.rbtn_ss.UseVisualStyleBackColor = true;
            // 
            // rbtn_1
            // 
            this.rbtn_1.AutoSize = true;
            this.rbtn_1.Location = new System.Drawing.Point(162, 19);
            this.rbtn_1.Name = "rbtn_1";
            this.rbtn_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rbtn_1.Size = new System.Drawing.Size(38, 17);
            this.rbtn_1.TabIndex = 1;
            this.rbtn_1.TabStop = true;
            this.rbtn_1.Text = "#1";
            this.rbtn_1.UseVisualStyleBackColor = true;
            this.rbtn_1.CheckedChanged += new System.EventHandler(this.radioButton9_CheckedChanged);
            // 
            // rbtn_2
            // 
            this.rbtn_2.AutoSize = true;
            this.rbtn_2.Location = new System.Drawing.Point(17, 57);
            this.rbtn_2.Name = "rbtn_2";
            this.rbtn_2.Size = new System.Drawing.Size(38, 17);
            this.rbtn_2.TabIndex = 2;
            this.rbtn_2.TabStop = true;
            this.rbtn_2.Text = "#2";
            this.rbtn_2.UseVisualStyleBackColor = true;
            // 
            // rbtn_3
            // 
            this.rbtn_3.AutoSize = true;
            this.rbtn_3.Location = new System.Drawing.Point(162, 57);
            this.rbtn_3.Name = "rbtn_3";
            this.rbtn_3.Size = new System.Drawing.Size(38, 17);
            this.rbtn_3.TabIndex = 3;
            this.rbtn_3.TabStop = true;
            this.rbtn_3.Text = "#3";
            this.rbtn_3.UseVisualStyleBackColor = true;
            // 
            // gbox_grade
            // 
            this.gbox_grade.Controls.Add(this.rbtn_3);
            this.gbox_grade.Controls.Add(this.rbtn_2);
            this.gbox_grade.Controls.Add(this.rbtn_1);
            this.gbox_grade.Controls.Add(this.rbtn_ss);
            this.gbox_grade.Location = new System.Drawing.Point(309, 212);
            this.gbox_grade.Name = "gbox_grade";
            this.gbox_grade.Size = new System.Drawing.Size(271, 104);
            this.gbox_grade.TabIndex = 6;
            this.gbox_grade.TabStop = false;
            this.gbox_grade.Text = "IRC";
            // 
            // gbox_snow
            // 
            this.gbox_snow.Controls.Add(this.rbtn_70);
            this.gbox_snow.Controls.Add(this.rbtn_50);
            this.gbox_snow.Controls.Add(this.rbtn_30);
            this.gbox_snow.Controls.Add(this.rbtn_209);
            this.gbox_snow.Location = new System.Drawing.Point(309, 328);
            this.gbox_snow.Name = "gbox_snow";
            this.gbox_snow.Size = new System.Drawing.Size(271, 104);
            this.gbox_snow.TabIndex = 7;
            this.gbox_snow.TabStop = false;
            this.gbox_snow.Text = "PSF";
            // 
            // rbtn_70
            // 
            this.rbtn_70.AutoSize = true;
            this.rbtn_70.Location = new System.Drawing.Point(162, 57);
            this.rbtn_70.Name = "rbtn_70";
            this.rbtn_70.Size = new System.Drawing.Size(37, 17);
            this.rbtn_70.TabIndex = 3;
            this.rbtn_70.TabStop = true;
            this.rbtn_70.Text = "70";
            this.rbtn_70.UseVisualStyleBackColor = true;
            // 
            // rbtn_50
            // 
            this.rbtn_50.AutoSize = true;
            this.rbtn_50.Location = new System.Drawing.Point(17, 57);
            this.rbtn_50.Name = "rbtn_50";
            this.rbtn_50.Size = new System.Drawing.Size(37, 17);
            this.rbtn_50.TabIndex = 2;
            this.rbtn_50.TabStop = true;
            this.rbtn_50.Text = "50";
            this.rbtn_50.UseVisualStyleBackColor = true;
            // 
            // rbtn_30
            // 
            this.rbtn_30.AutoSize = true;
            this.rbtn_30.Location = new System.Drawing.Point(162, 19);
            this.rbtn_30.Name = "rbtn_30";
            this.rbtn_30.Size = new System.Drawing.Size(37, 17);
            this.rbtn_30.TabIndex = 1;
            this.rbtn_30.TabStop = true;
            this.rbtn_30.Text = "30";
            this.rbtn_30.UseVisualStyleBackColor = true;
            // 
            // rbtn_209
            // 
            this.rbtn_209.AutoSize = true;
            this.rbtn_209.Location = new System.Drawing.Point(17, 19);
            this.rbtn_209.Name = "rbtn_209";
            this.rbtn_209.Size = new System.Drawing.Size(46, 17);
            this.rbtn_209.TabIndex = 0;
            this.rbtn_209.TabStop = true;
            this.rbtn_209.Text = "20.9";
            this.rbtn_209.UseVisualStyleBackColor = true;
            // 
            // btn_done
            // 
            this.btn_done.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_done.Location = new System.Drawing.Point(471, 438);
            this.btn_done.Name = "btn_done";
            this.btn_done.Size = new System.Drawing.Size(75, 40);
            this.btn_done.TabIndex = 8;
            this.btn_done.Text = "Done";
            this.btn_done.UseVisualStyleBackColor = true;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 489);
            this.Controls.Add(this.btn_done);
            this.Controls.Add(this.gbox_snow);
            this.Controls.Add(this.gbox_grade);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbox_species);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_grade);
            this.Controls.Add(this.lbl_species);
            this.Controls.Add(this.lbl_dl);
            this.Name = "InputForm";
            this.Text = "InputForm";
            this.Load += new System.EventHandler(this.InputForm_Load);
            this.gbox_species.ResumeLayout(false);
            this.gbox_species.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbox_grade.ResumeLayout(false);
            this.gbox_grade.PerformLayout();
            this.gbox_snow.ResumeLayout(false);
            this.gbox_snow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_dl;
        private System.Windows.Forms.Label lbl_species;
        private System.Windows.Forms.Label lbl_grade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbox_species;
        private System.Windows.Forms.RadioButton rbtn_Spruce_pine_fir;
        private System.Windows.Forms.RadioButton rbtn_Southern_pine;
        private System.Windows.Forms.RadioButton rbtn_Hem_fir;
        private System.Windows.Forms.RadioButton rbtn_Douglas_fir_larch;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtn_10;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton rbtn_ss;
        private System.Windows.Forms.RadioButton rbtn_1;
        private System.Windows.Forms.RadioButton rbtn_2;
        private System.Windows.Forms.RadioButton rbtn_3;
        private System.Windows.Forms.GroupBox gbox_grade;
        private System.Windows.Forms.GroupBox gbox_snow;
        private System.Windows.Forms.RadioButton rbtn_70;
        private System.Windows.Forms.RadioButton rbtn_50;
        private System.Windows.Forms.RadioButton rbtn_30;
        private System.Windows.Forms.RadioButton rbtn_209;
        private System.Windows.Forms.Button btn_done;
    }
}