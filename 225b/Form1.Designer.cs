namespace _225b
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
            this.components = new System.ComponentModel.Container();
            this.raceTrack = new System.Windows.Forms.PictureBox();
            this.dog4 = new System.Windows.Forms.PictureBox();
            this.dog2 = new System.Windows.Forms.PictureBox();
            this.dog1 = new System.Windows.Forms.PictureBox();
            this.dog3 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dogNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.betNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.buttonBet = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.janekBetLabel = new System.Windows.Forms.Label();
            this.bartekBetLabel = new System.Windows.Forms.Label();
            this.arekBetLebel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.arekRadioButton = new System.Windows.Forms.RadioButton();
            this.bartekRadioButton = new System.Windows.Forms.RadioButton();
            this.janekRadioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.minimumBetLebel = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.raceTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // raceTrack
            // 
            this.raceTrack.Image = global::_225b.Properties.Resources.racetrack;
            this.raceTrack.Location = new System.Drawing.Point(12, 12);
            this.raceTrack.Name = "raceTrack";
            this.raceTrack.Size = new System.Drawing.Size(728, 200);
            this.raceTrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.raceTrack.TabIndex = 0;
            this.raceTrack.TabStop = false;
            // 
            // dog4
            // 
            this.dog4.Image = global::_225b.Properties.Resources.dog;
            this.dog4.Location = new System.Drawing.Point(23, 177);
            this.dog4.Name = "dog4";
            this.dog4.Size = new System.Drawing.Size(75, 20);
            this.dog4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dog4.TabIndex = 1;
            this.dog4.TabStop = false;
            // 
            // dog2
            // 
            this.dog2.Image = global::_225b.Properties.Resources.dog;
            this.dog2.Location = new System.Drawing.Point(23, 73);
            this.dog2.Name = "dog2";
            this.dog2.Size = new System.Drawing.Size(75, 20);
            this.dog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dog2.TabIndex = 2;
            this.dog2.TabStop = false;
            // 
            // dog1
            // 
            this.dog1.Image = global::_225b.Properties.Resources.dog;
            this.dog1.Location = new System.Drawing.Point(23, 24);
            this.dog1.Name = "dog1";
            this.dog1.Size = new System.Drawing.Size(75, 20);
            this.dog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dog1.TabIndex = 3;
            this.dog1.TabStop = false;
            // 
            // dog3
            // 
            this.dog3.Image = global::_225b.Properties.Resources.dog;
            this.dog3.Location = new System.Drawing.Point(23, 120);
            this.dog3.Name = "dog3";
            this.dog3.Size = new System.Drawing.Size(75, 20);
            this.dog3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dog3.TabIndex = 4;
            this.dog3.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dogNumericUpDown);
            this.groupBox1.Controls.Add(this.betNumericUpDown);
            this.groupBox1.Controls.Add(this.buttonBet);
            this.groupBox1.Controls.Add(this.startButton);
            this.groupBox1.Controls.Add(this.janekBetLabel);
            this.groupBox1.Controls.Add(this.bartekBetLabel);
            this.groupBox1.Controls.Add(this.arekBetLebel);
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.arekRadioButton);
            this.groupBox1.Controls.Add(this.bartekRadioButton);
            this.groupBox1.Controls.Add(this.janekRadioButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.minimumBetLebel);
            this.groupBox1.Location = new System.Drawing.Point(12, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(728, 183);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dom bukmacherski";
            // 
            // dogNumericUpDown
            // 
            this.dogNumericUpDown.Location = new System.Drawing.Point(329, 150);
            this.dogNumericUpDown.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.dogNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dogNumericUpDown.Name = "dogNumericUpDown";
            this.dogNumericUpDown.Size = new System.Drawing.Size(58, 22);
            this.dogNumericUpDown.TabIndex = 13;
            this.dogNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // betNumericUpDown
            // 
            this.betNumericUpDown.Location = new System.Drawing.Point(136, 150);
            this.betNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.betNumericUpDown.Name = "betNumericUpDown";
            this.betNumericUpDown.Size = new System.Drawing.Size(55, 22);
            this.betNumericUpDown.TabIndex = 12;
            this.betNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonBet
            // 
            this.buttonBet.Location = new System.Drawing.Point(66, 149);
            this.buttonBet.Name = "buttonBet";
            this.buttonBet.Size = new System.Drawing.Size(64, 23);
            this.buttonBet.TabIndex = 11;
            this.buttonBet.Text = "stawia";
            this.buttonBet.UseVisualStyleBackColor = true;
            this.buttonBet.Click += new System.EventHandler(this.buttonBet_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(521, 53);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(201, 115);
            this.startButton.TabIndex = 10;
            this.startButton.Text = "Start!";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // janekBetLabel
            // 
            this.janekBetLabel.AutoSize = true;
            this.janekBetLabel.Location = new System.Drawing.Point(207, 57);
            this.janekBetLabel.Name = "janekBetLabel";
            this.janekBetLabel.Size = new System.Drawing.Size(98, 17);
            this.janekBetLabel.TabIndex = 9;
            this.janekBetLabel.Text = "janekBetLabel";
            // 
            // bartekBetLabel
            // 
            this.bartekBetLabel.AutoSize = true;
            this.bartekBetLabel.Location = new System.Drawing.Point(207, 82);
            this.bartekBetLabel.Name = "bartekBetLabel";
            this.bartekBetLabel.Size = new System.Drawing.Size(104, 17);
            this.bartekBetLabel.TabIndex = 8;
            this.bartekBetLabel.Text = "bartekBetLabel";
            // 
            // arekBetLebel
            // 
            this.arekBetLebel.AutoSize = true;
            this.arekBetLebel.Location = new System.Drawing.Point(207, 109);
            this.arekBetLebel.Name = "arekBetLebel";
            this.arekBetLebel.Size = new System.Drawing.Size(92, 17);
            this.arekBetLebel.TabIndex = 7;
            this.arekBetLebel.Text = "arekBetLebel";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(8, 152);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(43, 17);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "zł na charta numer";
            // 
            // arekRadioButton
            // 
            this.arekRadioButton.AutoSize = true;
            this.arekRadioButton.Location = new System.Drawing.Point(11, 107);
            this.arekRadioButton.Name = "arekRadioButton";
            this.arekRadioButton.Size = new System.Drawing.Size(135, 21);
            this.arekRadioButton.TabIndex = 4;
            this.arekRadioButton.TabStop = true;
            this.arekRadioButton.Text = "arekRadioButton";
            this.arekRadioButton.UseVisualStyleBackColor = true;
            this.arekRadioButton.CheckedChanged += new System.EventHandler(this.arekRadioButton_CheckedChanged);
            // 
            // bartekRadioButton
            // 
            this.bartekRadioButton.AutoSize = true;
            this.bartekRadioButton.Location = new System.Drawing.Point(11, 80);
            this.bartekRadioButton.Name = "bartekRadioButton";
            this.bartekRadioButton.Size = new System.Drawing.Size(147, 21);
            this.bartekRadioButton.TabIndex = 3;
            this.bartekRadioButton.TabStop = true;
            this.bartekRadioButton.Text = "bartekRadioButton";
            this.bartekRadioButton.UseVisualStyleBackColor = true;
            this.bartekRadioButton.CheckedChanged += new System.EventHandler(this.bartekRadioButton_CheckedChanged);
            // 
            // janekRadioButton
            // 
            this.janekRadioButton.AutoSize = true;
            this.janekRadioButton.Location = new System.Drawing.Point(11, 53);
            this.janekRadioButton.Name = "janekRadioButton";
            this.janekRadioButton.Size = new System.Drawing.Size(141, 21);
            this.janekRadioButton.TabIndex = 2;
            this.janekRadioButton.TabStop = true;
            this.janekRadioButton.Text = "janekRadioButton";
            this.janekRadioButton.UseVisualStyleBackColor = true;
            this.janekRadioButton.CheckedChanged += new System.EventHandler(this.janekRadioButton_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(206, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Zakłady";
            // 
            // minimumBetLebel
            // 
            this.minimumBetLebel.AutoSize = true;
            this.minimumBetLebel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minimumBetLebel.Location = new System.Drawing.Point(7, 30);
            this.minimumBetLebel.Name = "minimumBetLebel";
            this.minimumBetLebel.Size = new System.Drawing.Size(96, 20);
            this.minimumBetLebel.TabIndex = 0;
            this.minimumBetLebel.Text = "Zawodnicy";
            // 
            // timer2
            // 
            this.timer2.Interval = 50;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(753, 408);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dog3);
            this.Controls.Add(this.dog1);
            this.Controls.Add(this.dog2);
            this.Controls.Add(this.dog4);
            this.Controls.Add(this.raceTrack);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Wyścigi psów";
            ((System.ComponentModel.ISupportInitialize)(this.raceTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox raceTrack;
        private System.Windows.Forms.PictureBox dog4;
        private System.Windows.Forms.PictureBox dog2;
        private System.Windows.Forms.PictureBox dog1;
        private System.Windows.Forms.PictureBox dog3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown dogNumericUpDown;
        private System.Windows.Forms.NumericUpDown betNumericUpDown;
        private System.Windows.Forms.Button buttonBet;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label janekBetLabel;
        private System.Windows.Forms.Label bartekBetLabel;
        private System.Windows.Forms.Label arekBetLebel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton arekRadioButton;
        private System.Windows.Forms.RadioButton bartekRadioButton;
        private System.Windows.Forms.RadioButton janekRadioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label minimumBetLebel;
        private System.Windows.Forms.Timer timer2;
    }
}

