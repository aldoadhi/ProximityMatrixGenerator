namespace ProxMatrixGUI
{
    partial class Form
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
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxMethod = new System.Windows.Forms.ComboBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonSpace = new System.Windows.Forms.RadioButton();
            this.radioButtonKoma = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumerik = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(210, 33);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(211, 20);
            this.txtPath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose File:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(129, 31);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choose Method:";
            // 
            // comboBoxMethod
            // 
            this.comboBoxMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMethod.FormattingEnabled = true;
            this.comboBoxMethod.Items.AddRange(new object[] {
            "Euclidean Distance",
            "Minkowski Distance (r = 1)",
            "Minkowski Distance (supremum)",
            "Cosine Similarity",
            "Extended Jaccard Coefficient"});
            this.comboBoxMethod.Location = new System.Drawing.Point(129, 127);
            this.comboBoxMethod.Name = "comboBoxMethod";
            this.comboBoxMethod.Size = new System.Drawing.Size(292, 21);
            this.comboBoxMethod.TabIndex = 4;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(29, 166);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(391, 23);
            this.btnGenerate.TabIndex = 7;
            this.btnGenerate.Text = "Generate Proximity Matrix";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Separator:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonKoma);
            this.panel1.Controls.Add(this.radioButtonSpace);
            this.panel1.Location = new System.Drawing.Point(129, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 26);
            this.panel1.TabIndex = 9;
            // 
            // radioButtonSpace
            // 
            this.radioButtonSpace.AutoSize = true;
            this.radioButtonSpace.Checked = true;
            this.radioButtonSpace.Location = new System.Drawing.Point(4, 6);
            this.radioButtonSpace.Name = "radioButtonSpace";
            this.radioButtonSpace.Size = new System.Drawing.Size(54, 17);
            this.radioButtonSpace.TabIndex = 0;
            this.radioButtonSpace.TabStop = true;
            this.radioButtonSpace.Text = "space";
            this.radioButtonSpace.UseVisualStyleBackColor = true;
            // 
            // radioButtonKoma
            // 
            this.radioButtonKoma.AutoSize = true;
            this.radioButtonKoma.Location = new System.Drawing.Point(119, 5);
            this.radioButtonKoma.Name = "radioButtonKoma";
            this.radioButtonKoma.Size = new System.Drawing.Size(59, 17);
            this.radioButtonKoma.TabIndex = 1;
            this.radioButtonKoma.Text = "comma";
            this.radioButtonKoma.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Numeric Attrs Index:\r\n(Separate with \',\')";
            // 
            // txtNumerik
            // 
            this.txtNumerik.Location = new System.Drawing.Point(129, 95);
            this.txtNumerik.Name = "txtNumerik";
            this.txtNumerik.Size = new System.Drawing.Size(292, 20);
            this.txtNumerik.TabIndex = 11;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 219);
            this.Controls.Add(this.txtNumerik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.comboBoxMethod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPath);
            this.Name = "Form";
            this.Text = "Proximity Matrix Generator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxMethod;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonKoma;
        private System.Windows.Forms.RadioButton radioButtonSpace;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumerik;
    }
}

