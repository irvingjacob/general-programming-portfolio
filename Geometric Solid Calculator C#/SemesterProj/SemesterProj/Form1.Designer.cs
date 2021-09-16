namespace SemesterProj
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
            this.chooseLabelHead = new System.Windows.Forms.Label();
            this.sphereBtn = new System.Windows.Forms.RadioButton();
            this.boxBtn = new System.Windows.Forms.RadioButton();
            this.roundConeBtn = new System.Windows.Forms.RadioButton();
            this.pyramidBtn = new System.Windows.Forms.RadioButton();
            this.cylinderBtn = new System.Windows.Forms.RadioButton();
            this.inputLabel = new System.Windows.Forms.Label();
            this.radiusInput = new System.Windows.Forms.TextBox();
            this.radiusLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.heightInput = new System.Windows.Forms.TextBox();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.lengthInput = new System.Windows.Forms.TextBox();
            this.widthLabel = new System.Windows.Forms.Label();
            this.widthInput = new System.Windows.Forms.TextBox();
            this.chooseSolid = new System.Windows.Forms.Button();
            this.calculate = new System.Windows.Forms.Button();
            this.restartLabel = new System.Windows.Forms.Label();
            this.restartBtn = new System.Windows.Forms.Button();
            this.resultsHeadLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionLabel2 = new System.Windows.Forms.Label();
            this.breakerLabel = new System.Windows.Forms.Label();
            this.volumeLabel = new System.Windows.Forms.Label();
            this.surfaceAreaLabel = new System.Windows.Forms.Label();
            this.volumeOutputLabel = new System.Windows.Forms.Label();
            this.sAreaOutputLabel = new System.Windows.Forms.Label();
            this.resultsPanel = new System.Windows.Forms.Panel();
            this.resultsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // chooseLabelHead
            // 
            this.chooseLabelHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseLabelHead.Location = new System.Drawing.Point(14, 83);
            this.chooseLabelHead.Name = "chooseLabelHead";
            this.chooseLabelHead.Size = new System.Drawing.Size(256, 26);
            this.chooseLabelHead.TabIndex = 0;
            this.chooseLabelHead.Text = "Please Choose A Geometric Solid:";
            // 
            // sphereBtn
            // 
            this.sphereBtn.AutoSize = true;
            this.sphereBtn.Location = new System.Drawing.Point(18, 113);
            this.sphereBtn.Name = "sphereBtn";
            this.sphereBtn.Size = new System.Drawing.Size(59, 17);
            this.sphereBtn.TabIndex = 1;
            this.sphereBtn.TabStop = true;
            this.sphereBtn.Text = "Sphere";
            this.sphereBtn.UseVisualStyleBackColor = true;
            // 
            // boxBtn
            // 
            this.boxBtn.AutoSize = true;
            this.boxBtn.Location = new System.Drawing.Point(84, 113);
            this.boxBtn.Name = "boxBtn";
            this.boxBtn.Size = new System.Drawing.Size(73, 17);
            this.boxBtn.TabIndex = 2;
            this.boxBtn.TabStop = true;
            this.boxBtn.Text = "Cube/Box";
            this.boxBtn.UseVisualStyleBackColor = true;
            // 
            // roundConeBtn
            // 
            this.roundConeBtn.AutoSize = true;
            this.roundConeBtn.Location = new System.Drawing.Point(164, 113);
            this.roundConeBtn.Name = "roundConeBtn";
            this.roundConeBtn.Size = new System.Drawing.Size(121, 17);
            this.roundConeBtn.TabIndex = 3;
            this.roundConeBtn.TabStop = true;
            this.roundConeBtn.Text = "Round Bottom Cone";
            this.roundConeBtn.UseVisualStyleBackColor = true;
            // 
            // pyramidBtn
            // 
            this.pyramidBtn.AutoSize = true;
            this.pyramidBtn.Location = new System.Drawing.Point(292, 113);
            this.pyramidBtn.Name = "pyramidBtn";
            this.pyramidBtn.Size = new System.Drawing.Size(62, 17);
            this.pyramidBtn.TabIndex = 4;
            this.pyramidBtn.TabStop = true;
            this.pyramidBtn.Text = "Pyramid";
            this.pyramidBtn.UseVisualStyleBackColor = true;
            // 
            // cylinderBtn
            // 
            this.cylinderBtn.AutoSize = true;
            this.cylinderBtn.Location = new System.Drawing.Point(361, 113);
            this.cylinderBtn.Name = "cylinderBtn";
            this.cylinderBtn.Size = new System.Drawing.Size(62, 17);
            this.cylinderBtn.TabIndex = 5;
            this.cylinderBtn.TabStop = true;
            this.cylinderBtn.Text = "Cylinder";
            this.cylinderBtn.UseVisualStyleBackColor = true;
            // 
            // inputLabel
            // 
            this.inputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLabel.Location = new System.Drawing.Point(14, 155);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(382, 26);
            this.inputLabel.TabIndex = 6;
            this.inputLabel.Text = "Please Input the Dimensions of your Chosen Solid: ";
            this.inputLabel.Visible = false;
            // 
            // radiusInput
            // 
            this.radiusInput.Location = new System.Drawing.Point(142, 181);
            this.radiusInput.Name = "radiusInput";
            this.radiusInput.Size = new System.Drawing.Size(100, 20);
            this.radiusInput.TabIndex = 7;
            this.radiusInput.Visible = false;
            // 
            // radiusLabel
            // 
            this.radiusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiusLabel.Location = new System.Drawing.Point(14, 179);
            this.radiusLabel.Name = "radiusLabel";
            this.radiusLabel.Size = new System.Drawing.Size(74, 22);
            this.radiusLabel.TabIndex = 8;
            this.radiusLabel.Text = "Radius:";
            this.radiusLabel.Visible = false;
            // 
            // heightLabel
            // 
            this.heightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightLabel.Location = new System.Drawing.Point(14, 212);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(74, 22);
            this.heightLabel.TabIndex = 9;
            this.heightLabel.Text = "Height:";
            this.heightLabel.Visible = false;
            // 
            // heightInput
            // 
            this.heightInput.Location = new System.Drawing.Point(142, 212);
            this.heightInput.Name = "heightInput";
            this.heightInput.Size = new System.Drawing.Size(100, 20);
            this.heightInput.TabIndex = 10;
            this.heightInput.Visible = false;
            // 
            // lengthLabel
            // 
            this.lengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthLabel.Location = new System.Drawing.Point(14, 246);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(74, 22);
            this.lengthLabel.TabIndex = 11;
            this.lengthLabel.Text = "Length:";
            this.lengthLabel.Visible = false;
            // 
            // lengthInput
            // 
            this.lengthInput.Location = new System.Drawing.Point(142, 246);
            this.lengthInput.Name = "lengthInput";
            this.lengthInput.Size = new System.Drawing.Size(100, 20);
            this.lengthInput.TabIndex = 12;
            this.lengthInput.Visible = false;
            // 
            // widthLabel
            // 
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.Location = new System.Drawing.Point(14, 281);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(74, 22);
            this.widthLabel.TabIndex = 13;
            this.widthLabel.Text = "Width:";
            this.widthLabel.Visible = false;
            // 
            // widthInput
            // 
            this.widthInput.Location = new System.Drawing.Point(142, 281);
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(100, 20);
            this.widthInput.TabIndex = 14;
            this.widthInput.Visible = false;
            // 
            // chooseSolid
            // 
            this.chooseSolid.Location = new System.Drawing.Point(429, 110);
            this.chooseSolid.Name = "chooseSolid";
            this.chooseSolid.Size = new System.Drawing.Size(75, 23);
            this.chooseSolid.TabIndex = 15;
            this.chooseSolid.Text = "Select";
            this.chooseSolid.UseVisualStyleBackColor = true;
            this.chooseSolid.Click += new System.EventHandler(this.ChooseSolid_Click);
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(154, 307);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 23);
            this.calculate.TabIndex = 16;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Visible = false;
            this.calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // restartLabel
            // 
            this.restartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartLabel.Location = new System.Drawing.Point(519, 297);
            this.restartLabel.Name = "restartLabel";
            this.restartLabel.Size = new System.Drawing.Size(133, 22);
            this.restartLabel.TabIndex = 17;
            this.restartLabel.Text = "Restart Program:";
            // 
            // restartBtn
            // 
            this.restartBtn.Location = new System.Drawing.Point(676, 296);
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.Size = new System.Drawing.Size(75, 23);
            this.restartBtn.TabIndex = 18;
            this.restartBtn.Text = "Restart";
            this.restartBtn.UseVisualStyleBackColor = true;
            this.restartBtn.Click += new System.EventHandler(this.RestartBtn_Click);
            // 
            // resultsHeadLabel
            // 
            this.resultsHeadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsHeadLabel.Location = new System.Drawing.Point(66, 9);
            this.resultsHeadLabel.Name = "resultsHeadLabel";
            this.resultsHeadLabel.Size = new System.Drawing.Size(63, 26);
            this.resultsHeadLabel.TabIndex = 19;
            this.resultsHeadLabel.Text = "Results";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(12, 9);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(309, 26);
            this.descriptionLabel.TabIndex = 20;
            this.descriptionLabel.Text = "Surface Area and Volume Calculator!";
            // 
            // descriptionLabel2
            // 
            this.descriptionLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel2.Location = new System.Drawing.Point(13, 35);
            this.descriptionLabel2.Name = "descriptionLabel2";
            this.descriptionLabel2.Size = new System.Drawing.Size(658, 26);
            this.descriptionLabel2.TabIndex = 21;
            this.descriptionLabel2.Text = "A Program that Calculates Surface Area and Volume Based on User Specified Dimensi" +
    "ons.";
            // 
            // breakerLabel
            // 
            this.breakerLabel.AutoSize = true;
            this.breakerLabel.Location = new System.Drawing.Point(15, 58);
            this.breakerLabel.Name = "breakerLabel";
            this.breakerLabel.Size = new System.Drawing.Size(766, 13);
            this.breakerLabel.TabIndex = 22;
            this.breakerLabel.Text = resources.GetString("breakerLabel.Text");
            // 
            // volumeLabel
            // 
            this.volumeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volumeLabel.Location = new System.Drawing.Point(9, 49);
            this.volumeLabel.Name = "volumeLabel";
            this.volumeLabel.Size = new System.Drawing.Size(73, 26);
            this.volumeLabel.TabIndex = 23;
            this.volumeLabel.Text = "Volume:";
            // 
            // surfaceAreaLabel
            // 
            this.surfaceAreaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surfaceAreaLabel.Location = new System.Drawing.Point(9, 94);
            this.surfaceAreaLabel.Name = "surfaceAreaLabel";
            this.surfaceAreaLabel.Size = new System.Drawing.Size(110, 26);
            this.surfaceAreaLabel.TabIndex = 24;
            this.surfaceAreaLabel.Text = "Surface Area:";
            // 
            // volumeOutputLabel
            // 
            this.volumeOutputLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.volumeOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.volumeOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volumeOutputLabel.Location = new System.Drawing.Point(124, 48);
            this.volumeOutputLabel.Name = "volumeOutputLabel";
            this.volumeOutputLabel.Size = new System.Drawing.Size(147, 26);
            this.volumeOutputLabel.TabIndex = 25;
            // 
            // sAreaOutputLabel
            // 
            this.sAreaOutputLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.sAreaOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sAreaOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sAreaOutputLabel.Location = new System.Drawing.Point(124, 93);
            this.sAreaOutputLabel.Name = "sAreaOutputLabel";
            this.sAreaOutputLabel.Size = new System.Drawing.Size(147, 26);
            this.sAreaOutputLabel.TabIndex = 26;
            // 
            // resultsPanel
            // 
            this.resultsPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.resultsPanel.Controls.Add(this.surfaceAreaLabel);
            this.resultsPanel.Controls.Add(this.volumeLabel);
            this.resultsPanel.Controls.Add(this.volumeOutputLabel);
            this.resultsPanel.Controls.Add(this.sAreaOutputLabel);
            this.resultsPanel.Controls.Add(this.resultsHeadLabel);
            this.resultsPanel.Location = new System.Drawing.Point(510, 83);
            this.resultsPanel.Name = "resultsPanel";
            this.resultsPanel.Size = new System.Drawing.Size(278, 207);
            this.resultsPanel.TabIndex = 27;
            this.resultsPanel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 342);
            this.Controls.Add(this.resultsPanel);
            this.Controls.Add(this.breakerLabel);
            this.Controls.Add(this.descriptionLabel2);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.restartBtn);
            this.Controls.Add(this.restartLabel);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.chooseSolid);
            this.Controls.Add(this.widthInput);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.lengthInput);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.heightInput);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.radiusLabel);
            this.Controls.Add(this.radiusInput);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.cylinderBtn);
            this.Controls.Add(this.pyramidBtn);
            this.Controls.Add(this.roundConeBtn);
            this.Controls.Add(this.boxBtn);
            this.Controls.Add(this.sphereBtn);
            this.Controls.Add(this.chooseLabelHead);
            this.Name = "Form1";
            this.Text = "Form1";
            this.resultsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label chooseLabelHead;
        private System.Windows.Forms.RadioButton sphereBtn;
        private System.Windows.Forms.RadioButton boxBtn;
        private System.Windows.Forms.RadioButton roundConeBtn;
        private System.Windows.Forms.RadioButton pyramidBtn;
        private System.Windows.Forms.RadioButton cylinderBtn;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.TextBox radiusInput;
        private System.Windows.Forms.Label radiusLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.TextBox heightInput;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.TextBox lengthInput;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.TextBox widthInput;
        private System.Windows.Forms.Button chooseSolid;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label restartLabel;
        private System.Windows.Forms.Button restartBtn;
        private System.Windows.Forms.Label resultsHeadLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label descriptionLabel2;
        private System.Windows.Forms.Label breakerLabel;
        private System.Windows.Forms.Label volumeLabel;
        private System.Windows.Forms.Label surfaceAreaLabel;
        private System.Windows.Forms.Label volumeOutputLabel;
        private System.Windows.Forms.Label sAreaOutputLabel;
        private System.Windows.Forms.Panel resultsPanel;
    }
}

