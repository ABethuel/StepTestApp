namespace StepTestApp
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxAge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMaxHR = new System.Windows.Forms.Label();
            this.lblHR = new System.Windows.Forms.Label();
            this.lblB1 = new System.Windows.Forms.Label();
            this.lblB2 = new System.Windows.Forms.Label();
            this.comboBoxHeight = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.grpBoxGender = new System.Windows.Forms.GroupBox();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBoxLvl1 = new System.Windows.Forms.TextBox();
            this.txtBoxLvl2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBoxLvl3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBoxLvl4 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBoxLvl5 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnValidate = new System.Windows.Forms.Button();
            this.chartDataStep = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblAerobicCapacity = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.grpBoxGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDataStep)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Step Test data collection and results sheet";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtBoxName
            // 
            this.txtBoxName.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            this.txtBoxName.Location = new System.Drawing.Point(100, 75);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(113, 23);
            this.txtBoxName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Age :";
            // 
            // txtBoxAge
            // 
            this.txtBoxAge.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            this.txtBoxAge.Location = new System.Drawing.Point(100, 114);
            this.txtBoxAge.Name = "txtBoxAge";
            this.txtBoxAge.Size = new System.Drawing.Size(113, 23);
            this.txtBoxAge.TabIndex = 4;
            this.txtBoxAge.TextChanged += new System.EventHandler(this.txtBoxAge_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(253, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "MaxHR :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(253, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "85% MaxHR :";
            // 
            // lblMaxHR
            // 
            this.lblMaxHR.AutoSize = true;
            this.lblMaxHR.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxHR.Location = new System.Drawing.Point(375, 75);
            this.lblMaxHR.Name = "lblMaxHR";
            this.lblMaxHR.Size = new System.Drawing.Size(0, 19);
            this.lblMaxHR.TabIndex = 7;
            this.lblMaxHR.Click += new System.EventHandler(this.lblMaxHR_Click);
            // 
            // lblHR
            // 
            this.lblHR.AutoSize = true;
            this.lblHR.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHR.Location = new System.Drawing.Point(375, 114);
            this.lblHR.Name = "lblHR";
            this.lblHR.Size = new System.Drawing.Size(0, 19);
            this.lblHR.TabIndex = 8;
            // 
            // lblB1
            // 
            this.lblB1.AutoSize = true;
            this.lblB1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB1.Location = new System.Drawing.Point(444, 75);
            this.lblB1.Name = "lblB1";
            this.lblB1.Size = new System.Drawing.Size(13, 19);
            this.lblB1.TabIndex = 9;
            this.lblB1.Text = " ";
            this.lblB1.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblB2
            // 
            this.lblB2.AutoSize = true;
            this.lblB2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB2.Location = new System.Drawing.Point(444, 114);
            this.lblB2.Name = "lblB2";
            this.lblB2.Size = new System.Drawing.Size(13, 19);
            this.lblB2.TabIndex = 10;
            this.lblB2.Text = " ";
            // 
            // comboBoxHeight
            // 
            this.comboBoxHeight.FormattingEnabled = true;
            this.comboBoxHeight.Items.AddRange(new object[] {
            "15cm",
            "20cm",
            "25cm",
            "30cm"});
            this.comboBoxHeight.Location = new System.Drawing.Point(701, 77);
            this.comboBoxHeight.Name = "comboBoxHeight";
            this.comboBoxHeight.Size = new System.Drawing.Size(113, 21);
            this.comboBoxHeight.TabIndex = 11;
            this.comboBoxHeight.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(569, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Step Height  :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(569, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "Date  :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(652, 113);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(162, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // grpBoxGender
            // 
            this.grpBoxGender.Controls.Add(this.radioButtonFemale);
            this.grpBoxGender.Controls.Add(this.radioButtonMale);
            this.grpBoxGender.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxGender.Location = new System.Drawing.Point(863, 59);
            this.grpBoxGender.Name = "grpBoxGender";
            this.grpBoxGender.Size = new System.Drawing.Size(200, 89);
            this.grpBoxGender.TabIndex = 16;
            this.grpBoxGender.TabStop = false;
            this.grpBoxGender.Text = "Gender";
            this.grpBoxGender.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFemale.Location = new System.Drawing.Point(15, 52);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(73, 20);
            this.radioButtonFemale.TabIndex = 1;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            this.radioButtonFemale.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMale.Location = new System.Drawing.Point(15, 26);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(59, 20);
            this.radioButtonMale.TabIndex = 0;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            this.radioButtonMale.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "Level 1 :";
            // 
            // txtBoxLvl1
            // 
            this.txtBoxLvl1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLvl1.Location = new System.Drawing.Point(100, 192);
            this.txtBoxLvl1.Name = "txtBoxLvl1";
            this.txtBoxLvl1.Size = new System.Drawing.Size(50, 21);
            this.txtBoxLvl1.TabIndex = 18;
            this.txtBoxLvl1.TextChanged += new System.EventHandler(this.txtBoxLvl1_TextChanged);
            // 
            // txtBoxLvl2
            // 
            this.txtBoxLvl2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLvl2.Location = new System.Drawing.Point(257, 192);
            this.txtBoxLvl2.Name = "txtBoxLvl2";
            this.txtBoxLvl2.Size = new System.Drawing.Size(50, 21);
            this.txtBoxLvl2.TabIndex = 20;
            this.txtBoxLvl2.TextChanged += new System.EventHandler(this.txtBoxLvl2_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(181, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 19);
            this.label10.TabIndex = 19;
            this.label10.Text = "Level 2 :";
            // 
            // txtBoxLvl3
            // 
            this.txtBoxLvl3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLvl3.Location = new System.Drawing.Point(406, 192);
            this.txtBoxLvl3.Name = "txtBoxLvl3";
            this.txtBoxLvl3.Size = new System.Drawing.Size(50, 21);
            this.txtBoxLvl3.TabIndex = 22;
            this.txtBoxLvl3.TextChanged += new System.EventHandler(this.txtBoxLvl3_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(330, 192);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 19);
            this.label11.TabIndex = 21;
            this.label11.Text = "Level 3 :";
            // 
            // txtBoxLvl4
            // 
            this.txtBoxLvl4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLvl4.Location = new System.Drawing.Point(565, 192);
            this.txtBoxLvl4.Name = "txtBoxLvl4";
            this.txtBoxLvl4.Size = new System.Drawing.Size(50, 21);
            this.txtBoxLvl4.TabIndex = 24;
            this.txtBoxLvl4.TextChanged += new System.EventHandler(this.txtBoxLvl4_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(489, 192);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 19);
            this.label12.TabIndex = 23;
            this.label12.Text = "Level 4 :";
            // 
            // txtBoxLvl5
            // 
            this.txtBoxLvl5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLvl5.Location = new System.Drawing.Point(723, 193);
            this.txtBoxLvl5.Name = "txtBoxLvl5";
            this.txtBoxLvl5.Size = new System.Drawing.Size(50, 21);
            this.txtBoxLvl5.TabIndex = 26;
            this.txtBoxLvl5.TextChanged += new System.EventHandler(this.txtBoxLvl5_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(647, 193);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 19);
            this.label13.TabIndex = 25;
            this.label13.Text = "Level 5 :";
            // 
            // btnValidate
            // 
            this.btnValidate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnValidate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidate.Location = new System.Drawing.Point(863, 188);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(128, 30);
            this.btnValidate.TabIndex = 27;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = false;
            this.btnValidate.Click += new System.EventHandler(this.button1_Click);
            // 
            // chartDataStep
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDataStep.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDataStep.Legends.Add(legend1);
            this.chartDataStep.Location = new System.Drawing.Point(219, 241);
            this.chartDataStep.Name = "chartDataStep";
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.LabelBackColor = System.Drawing.SystemColors.ActiveBorder;
            series1.LabelBorderColor = System.Drawing.SystemColors.ActiveBorder;
            series1.LabelForeColor = System.Drawing.Color.Bisque;
            series1.Legend = "Legend1";
            series1.Name = "Heart Rate";
            this.chartDataStep.Series.Add(series1);
            this.chartDataStep.Size = new System.Drawing.Size(681, 384);
            this.chartDataStep.TabIndex = 28;
            this.chartDataStep.Text = "Yes";
            title1.Name = "Results of the test";
            this.chartDataStep.Titles.Add(title1);
            this.chartDataStep.Click += new System.EventHandler(this.chartDataStep_Click);
            // 
            // lblAerobicCapacity
            // 
            this.lblAerobicCapacity.AutoSize = true;
            this.lblAerobicCapacity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAerobicCapacity.Location = new System.Drawing.Point(215, 641);
            this.lblAerobicCapacity.Name = "lblAerobicCapacity";
            this.lblAerobicCapacity.Size = new System.Drawing.Size(13, 19);
            this.lblAerobicCapacity.TabIndex = 29;
            this.lblAerobicCapacity.Text = " ";
            this.lblAerobicCapacity.Click += new System.EventHandler(this.lblAerobicCapacity_Click);
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRating.Location = new System.Drawing.Point(215, 675);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(13, 19);
            this.lblRating.TabIndex = 30;
            this.lblRating.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1100, 717);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lblAerobicCapacity);
            this.Controls.Add(this.chartDataStep);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.txtBoxLvl5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtBoxLvl4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtBoxLvl3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBoxLvl2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBoxLvl1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.grpBoxGender);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxHeight);
            this.Controls.Add(this.lblB2);
            this.Controls.Add(this.lblB1);
            this.Controls.Add(this.lblHR);
            this.Controls.Add(this.lblMaxHR);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxAge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBoxGender.ResumeLayout(false);
            this.grpBoxGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDataStep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMaxHR;
        private System.Windows.Forms.Label lblHR;
        private System.Windows.Forms.Label lblB1;
        private System.Windows.Forms.Label lblB2;
        private System.Windows.Forms.ComboBox comboBoxHeight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox grpBoxGender;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBoxLvl1;
        private System.Windows.Forms.TextBox txtBoxLvl2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBoxLvl3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBoxLvl4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBoxLvl5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDataStep;
        private System.Windows.Forms.Label lblAerobicCapacity;
        private System.Windows.Forms.Label lblRating;
    }
}

