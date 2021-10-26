
namespace WorkWithCarColection
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.modelBox = new System.Windows.Forms.TextBox();
            this.yearNumeric = new System.Windows.Forms.NumericUpDown();
            this.colorBox = new System.Windows.Forms.ComboBox();
            this.probegNum = new System.Windows.Forms.NumericUpDown();
            this.volNum = new System.Windows.Forms.NumericUpDown();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.showCarbtn = new System.Windows.Forms.Button();
            this.carInfoBox = new System.Windows.Forms.GroupBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.plateTextBox = new System.Windows.Forms.TextBox();
            this.vinCodeBox = new System.Windows.Forms.TextBox();
            this.carsBox = new System.Windows.Forms.ComboBox();
            this.carlistBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.yearNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.probegNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volNum)).BeginInit();
            this.carInfoBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Model:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Year:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Color:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Probeg:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "Engine Volume:";
            // 
            // modelBox
            // 
            this.modelBox.Location = new System.Drawing.Point(113, 25);
            this.modelBox.Name = "modelBox";
            this.modelBox.Size = new System.Drawing.Size(178, 20);
            this.modelBox.TabIndex = 5;
            // 
            // yearNumeric
            // 
            this.yearNumeric.Location = new System.Drawing.Point(113, 70);
            this.yearNumeric.Maximum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.yearNumeric.Minimum = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            this.yearNumeric.Name = "yearNumeric";
            this.yearNumeric.Size = new System.Drawing.Size(178, 20);
            this.yearNumeric.TabIndex = 6;
            this.yearNumeric.Value = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            // 
            // colorBox
            // 
            this.colorBox.FormattingEnabled = true;
            this.colorBox.Items.AddRange(new object[] {
            "Black",
            "Green",
            "Yellow",
            "White",
            "Brown",
            "Purple"});
            this.colorBox.Location = new System.Drawing.Point(113, 110);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(178, 21);
            this.colorBox.TabIndex = 7;
            // 
            // probegNum
            // 
            this.probegNum.Location = new System.Drawing.Point(127, 145);
            this.probegNum.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.probegNum.Name = "probegNum";
            this.probegNum.Size = new System.Drawing.Size(164, 20);
            this.probegNum.TabIndex = 8;
            // 
            // volNum
            // 
            this.volNum.DecimalPlaces = 1;
            this.volNum.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.volNum.Location = new System.Drawing.Point(222, 190);
            this.volNum.Maximum = new decimal(new int[] {
            55,
            0,
            0,
            65536});
            this.volNum.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            65536});
            this.volNum.Name = "volNum";
            this.volNum.Size = new System.Drawing.Size(69, 20);
            this.volNum.TabIndex = 9;
            this.volNum.Value = new decimal(new int[] {
            12,
            0,
            0,
            65536});
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(18, 341);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(273, 32);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Add Car";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteBtn.Location = new System.Drawing.Point(18, 379);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(273, 33);
            this.deleteBtn.TabIndex = 11;
            this.deleteBtn.Text = "Delete Selected Car";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // showCarbtn
            // 
            this.showCarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showCarbtn.Location = new System.Drawing.Point(18, 418);
            this.showCarbtn.Name = "showCarbtn";
            this.showCarbtn.Size = new System.Drawing.Size(273, 32);
            this.showCarbtn.TabIndex = 12;
            this.showCarbtn.Text = "Show Car Info";
            this.showCarbtn.UseVisualStyleBackColor = true;
            this.showCarbtn.Click += new System.EventHandler(this.showCarbtn_Click);
            // 
            // carInfoBox
            // 
            this.carInfoBox.Controls.Add(this.carlistBox);
            this.carInfoBox.Controls.Add(this.carsBox);
            this.carInfoBox.Controls.Add(this.loadButton);
            this.carInfoBox.Controls.Add(this.saveButton);
            this.carInfoBox.Location = new System.Drawing.Point(332, 48);
            this.carInfoBox.Name = "carInfoBox";
            this.carInfoBox.Size = new System.Drawing.Size(398, 402);
            this.carInfoBox.TabIndex = 13;
            this.carInfoBox.TabStop = false;
            // 
            // loadButton
            // 
            this.loadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadButton.Location = new System.Drawing.Point(223, 354);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(169, 36);
            this.loadButton.TabIndex = 2;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(15, 354);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(169, 36);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label6.Location = new System.Drawing.Point(446, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "Aviable Cars";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 31);
            this.label7.TabIndex = 15;
            this.label7.Text = "Plate Number:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 31);
            this.label8.TabIndex = 16;
            this.label8.Text = "Vin-Code:";
            // 
            // plateTextBox
            // 
            this.plateTextBox.Location = new System.Drawing.Point(205, 229);
            this.plateTextBox.Name = "plateTextBox";
            this.plateTextBox.Size = new System.Drawing.Size(86, 20);
            this.plateTextBox.TabIndex = 17;
            // 
            // vinCodeBox
            // 
            this.vinCodeBox.Location = new System.Drawing.Point(153, 270);
            this.vinCodeBox.Name = "vinCodeBox";
            this.vinCodeBox.Size = new System.Drawing.Size(138, 20);
            this.vinCodeBox.TabIndex = 18;
            // 
            // carsBox
            // 
            this.carsBox.FormattingEnabled = true;
            this.carsBox.Location = new System.Drawing.Point(6, 19);
            this.carsBox.Name = "carsBox";
            this.carsBox.Size = new System.Drawing.Size(386, 21);
            this.carsBox.TabIndex = 19;
            // 
            // carlistBox
            // 
            this.carlistBox.FormattingEnabled = true;
            this.carlistBox.Location = new System.Drawing.Point(6, 45);
            this.carlistBox.Name = "carlistBox";
            this.carlistBox.Size = new System.Drawing.Size(386, 303);
            this.carlistBox.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 468);
            this.Controls.Add(this.vinCodeBox);
            this.Controls.Add(this.plateTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.carInfoBox);
            this.Controls.Add(this.showCarbtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.volNum);
            this.Controls.Add(this.probegNum);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.yearNumeric);
            this.Controls.Add(this.modelBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.yearNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.probegNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volNum)).EndInit();
            this.carInfoBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox modelBox;
        private System.Windows.Forms.NumericUpDown yearNumeric;
        private System.Windows.Forms.ComboBox colorBox;
        private System.Windows.Forms.NumericUpDown probegNum;
        private System.Windows.Forms.NumericUpDown volNum;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button showCarbtn;
        private System.Windows.Forms.GroupBox carInfoBox;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox plateTextBox;
        private System.Windows.Forms.TextBox vinCodeBox;
        private System.Windows.Forms.ComboBox carsBox;
        private System.Windows.Forms.ListBox carlistBox;
    }
}

