namespace Miinaharava.Vaikeustasot
{
    partial class FormTutorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTutorial));
            this.TaakseButton = new System.Windows.Forms.Button();
            this.EteenButton = new System.Windows.Forms.Button();
            this.TutorialText = new System.Windows.Forms.RichTextBox();
            this.ScenarioPicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ScenaarioNumText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ScenarioPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // TaakseButton
            // 
            this.TaakseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaakseButton.Location = new System.Drawing.Point(148, 165);
            this.TaakseButton.Name = "TaakseButton";
            this.TaakseButton.Size = new System.Drawing.Size(75, 30);
            this.TaakseButton.TabIndex = 11;
            this.TaakseButton.Text = "🡄";
            this.TaakseButton.UseVisualStyleBackColor = true;
            this.TaakseButton.Click += new System.EventHandler(this.TaakseButton_Click);
            // 
            // EteenButton
            // 
            this.EteenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EteenButton.Location = new System.Drawing.Point(260, 165);
            this.EteenButton.Name = "EteenButton";
            this.EteenButton.Size = new System.Drawing.Size(75, 30);
            this.EteenButton.TabIndex = 10;
            this.EteenButton.Text = "🡆";
            this.EteenButton.UseVisualStyleBackColor = true;
            this.EteenButton.Click += new System.EventHandler(this.EteenButton_Click);
            // 
            // TutorialText
            // 
            this.TutorialText.Location = new System.Drawing.Point(145, 0);
            this.TutorialText.Name = "TutorialText";
            this.TutorialText.Size = new System.Drawing.Size(196, 147);
            this.TutorialText.TabIndex = 9;
            this.TutorialText.Text = "";
            // 
            // ScenarioPicture
            // 
            this.ScenarioPicture.Image = ((System.Drawing.Image)(resources.GetObject("ScenarioPicture.Image")));
            this.ScenarioPicture.Location = new System.Drawing.Point(12, 0);
            this.ScenarioPicture.Name = "ScenarioPicture";
            this.ScenarioPicture.Size = new System.Drawing.Size(127, 147);
            this.ScenarioPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ScenarioPicture.TabIndex = 8;
            this.ScenarioPicture.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "-Tämä tarkoittaa että peitetyssä kohdassa on miina";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 279);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(10, 233);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "-Tämä tarkoittaa että kohta on tyhjä";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(10, 320);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "-Tämä tarkoittaa että napin 3x3 alueella on 1 miina";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Scenaario: ";
            // 
            // ScenaarioNumText
            // 
            this.ScenaarioNumText.AutoSize = true;
            this.ScenaarioNumText.Location = new System.Drawing.Point(61, 165);
            this.ScenaarioNumText.Name = "ScenaarioNumText";
            this.ScenaarioNumText.Size = new System.Drawing.Size(13, 13);
            this.ScenaarioNumText.TabIndex = 17;
            this.ScenaarioNumText.Text = "1";
            // 
            // FormTutorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 362);
            this.Controls.Add(this.ScenaarioNumText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.TaakseButton);
            this.Controls.Add(this.EteenButton);
            this.Controls.Add(this.TutorialText);
            this.Controls.Add(this.ScenarioPicture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTutorial";
            this.Text = "FormTutorial";
            ((System.ComponentModel.ISupportInitialize)(this.ScenarioPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TaakseButton;
        private System.Windows.Forms.Button EteenButton;
        private System.Windows.Forms.RichTextBox TutorialText;
        private System.Windows.Forms.PictureBox ScenarioPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ScenaarioNumText;
    }
}