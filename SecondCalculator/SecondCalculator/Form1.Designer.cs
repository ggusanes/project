namespace SecondCalculator {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tanButton = new System.Windows.Forms.Button();
            this.factoButton = new System.Windows.Forms.Button();
            this.cosButton = new System.Windows.Forms.Button();
            this.sinButton = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.displayArea = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.Equal = new System.Windows.Forms.Button();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.logButton = new System.Windows.Forms.Button();
            this.lnButton = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.exponButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tanButton
            // 
            this.tanButton.Location = new System.Drawing.Point(237, 339);
            this.tanButton.Name = "tanButton";
            this.tanButton.Size = new System.Drawing.Size(75, 23);
            this.tanButton.TabIndex = 52;
            this.tanButton.Text = "tan";
            this.tanButton.UseVisualStyleBackColor = true;
            this.tanButton.Click += new System.EventHandler(this.trigonFuncs);
            // 
            // factoButton
            // 
            this.factoButton.Location = new System.Drawing.Point(332, 339);
            this.factoButton.Name = "factoButton";
            this.factoButton.Size = new System.Drawing.Size(75, 23);
            this.factoButton.TabIndex = 51;
            this.factoButton.Text = "n!";
            this.factoButton.UseVisualStyleBackColor = true;
            this.factoButton.Click += new System.EventHandler(this.factoFunc);
            // 
            // cosButton
            // 
            this.cosButton.Location = new System.Drawing.Point(145, 339);
            this.cosButton.Name = "cosButton";
            this.cosButton.Size = new System.Drawing.Size(75, 23);
            this.cosButton.TabIndex = 50;
            this.cosButton.Text = "cos";
            this.cosButton.UseVisualStyleBackColor = true;
            this.cosButton.Click += new System.EventHandler(this.trigonFuncs);
            // 
            // sinButton
            // 
            this.sinButton.Location = new System.Drawing.Point(57, 339);
            this.sinButton.Name = "sinButton";
            this.sinButton.Size = new System.Drawing.Size(75, 23);
            this.sinButton.TabIndex = 49;
            this.sinButton.Text = "sin";
            this.sinButton.UseVisualStyleBackColor = true;
            this.sinButton.Click += new System.EventHandler(this.trigonFuncs);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(237, 254);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(75, 23);
            this.button20.TabIndex = 48;
            this.button20.Text = ")";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.braketClick);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(145, 253);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(75, 23);
            this.button19.TabIndex = 47;
            this.button19.Text = "(";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.braketClick);
            // 
            // displayArea
            // 
            this.displayArea.Location = new System.Drawing.Point(55, 35);
            this.displayArea.Name = "displayArea";
            this.displayArea.Size = new System.Drawing.Size(352, 29);
            this.displayArea.TabIndex = 46;
            this.displayArea.Text = "0";
            this.displayArea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(332, 166);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 45;
            this.deleteButton.Text = "C";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteClick);
            // 
            // Equal
            // 
            this.Equal.Location = new System.Drawing.Point(332, 254);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(75, 23);
            this.Equal.TabIndex = 44;
            this.Equal.Text = "=";
            this.Equal.UseVisualStyleBackColor = true;
            this.Equal.Click += new System.EventHandler(this.equalClick);
            // 
            // TextBox
            // 
            this.TextBox.Font = new System.Drawing.Font("Gulim", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TextBox.Location = new System.Drawing.Point(55, 77);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(352, 29);
            this.TextBox.TabIndex = 43;
            this.TextBox.Text = "0";
            this.TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(332, 125);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 42;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearClick);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(332, 298);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 23);
            this.button15.TabIndex = 41;
            this.button15.Text = "/";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.operatorClick);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(237, 298);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 23);
            this.button14.TabIndex = 40;
            this.button14.Text = "*";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.operatorClick);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(145, 298);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 39;
            this.button13.Text = "-";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.operatorClick);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(55, 298);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 38;
            this.button12.Text = "+";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.operatorClick);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(332, 212);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 37;
            this.button11.Text = ".";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.numberClick);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(55, 254);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 36;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.numberClick);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(237, 212);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 35;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.numberClick);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(145, 213);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 34;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.numberClick);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(55, 213);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 33;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.numberClick);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(237, 167);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 32;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.numberClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(145, 168);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 31;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.numberClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(55, 169);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 30;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.numberClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(237, 125);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 29;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.numberClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(145, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.numberClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.numberClick);
            // 
            // logButton
            // 
            this.logButton.Location = new System.Drawing.Point(57, 379);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(75, 23);
            this.logButton.TabIndex = 53;
            this.logButton.Text = "log";
            this.logButton.UseVisualStyleBackColor = true;
            this.logButton.Click += new System.EventHandler(this.trigonFuncs);
            // 
            // lnButton
            // 
            this.lnButton.Location = new System.Drawing.Point(145, 379);
            this.lnButton.Name = "lnButton";
            this.lnButton.Size = new System.Drawing.Size(75, 23);
            this.lnButton.TabIndex = 54;
            this.lnButton.Text = "ln";
            this.lnButton.UseVisualStyleBackColor = true;
            this.lnButton.Click += new System.EventHandler(this.trigonFuncs);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(237, 379);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(75, 23);
            this.button18.TabIndex = 55;
            this.button18.Text = "√";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.trigonFuncs);
            // 
            // exponButton
            // 
            this.exponButton.Location = new System.Drawing.Point(332, 379);
            this.exponButton.Name = "exponButton";
            this.exponButton.Size = new System.Drawing.Size(75, 23);
            this.exponButton.TabIndex = 56;
            this.exponButton.Text = "e^x";
            this.exponButton.UseVisualStyleBackColor = true;
            this.exponButton.Click += new System.EventHandler(this.trigonFuncs);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 461);
            this.Controls.Add(this.exponButton);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.lnButton);
            this.Controls.Add(this.logButton);
            this.Controls.Add(this.tanButton);
            this.Controls.Add(this.factoButton);
            this.Controls.Add(this.cosButton);
            this.Controls.Add(this.sinButton);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.displayArea);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.Equal);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tanButton;
        private System.Windows.Forms.Button factoButton;
        private System.Windows.Forms.Button cosButton;
        private System.Windows.Forms.Button sinButton;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Label displayArea;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button Equal;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button logButton;
        private System.Windows.Forms.Button lnButton;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button exponButton;
    }
}

