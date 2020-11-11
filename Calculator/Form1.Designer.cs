namespace Calculator
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
            this.lbHistory = new System.Windows.Forms.ListBox();
            this.bOne = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelKeyBoard = new System.Windows.Forms.Panel();
            this.bMod = new System.Windows.Forms.Button();
            this.bSqrt = new System.Windows.Forms.Button();
            this.bPower = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.bEqual = new System.Windows.Forms.Button();
            this.bDot = new System.Windows.Forms.Button();
            this.bDiv = new System.Windows.Forms.Button();
            this.bMultip = new System.Windows.Forms.Button();
            this.bMinus = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.bZero = new System.Windows.Forms.Button();
            this.bNine = new System.Windows.Forms.Button();
            this.bEight = new System.Windows.Forms.Button();
            this.bSeven = new System.Windows.Forms.Button();
            this.bSix = new System.Windows.Forms.Button();
            this.bFive = new System.Windows.Forms.Button();
            this.bFour = new System.Windows.Forms.Button();
            this.bThree = new System.Windows.Forms.Button();
            this.bTwo = new System.Windows.Forms.Button();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.panelKeyBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbHistory
            // 
            this.lbHistory.Font = new System.Drawing.Font("Times New Roman", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbHistory.FormattingEnabled = true;
            this.lbHistory.ItemHeight = 53;
            this.lbHistory.Location = new System.Drawing.Point(982, 103);
            this.lbHistory.Name = "lbHistory";
            this.lbHistory.Size = new System.Drawing.Size(416, 534);
            this.lbHistory.TabIndex = 3;
            // 
            // bOne
            // 
            this.bOne.Font = new System.Drawing.Font("Georgia", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bOne.Location = new System.Drawing.Point(24, 244);
            this.bOne.Name = "bOne";
            this.bOne.Size = new System.Drawing.Size(93, 81);
            this.bOne.TabIndex = 4;
            this.bOne.Text = "1";
            this.bOne.UseVisualStyleBackColor = true;
            this.bOne.Click += new System.EventHandler(this.bOne_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 56);
            this.label1.TabIndex = 9;
            this.label1.Text = "Number";
            // 
            // panelKeyBoard
            // 
            this.panelKeyBoard.Controls.Add(this.bMod);
            this.panelKeyBoard.Controls.Add(this.bSqrt);
            this.panelKeyBoard.Controls.Add(this.bPower);
            this.panelKeyBoard.Controls.Add(this.bClear);
            this.panelKeyBoard.Controls.Add(this.bEqual);
            this.panelKeyBoard.Controls.Add(this.bDot);
            this.panelKeyBoard.Controls.Add(this.bDiv);
            this.panelKeyBoard.Controls.Add(this.bMultip);
            this.panelKeyBoard.Controls.Add(this.bMinus);
            this.panelKeyBoard.Controls.Add(this.bAdd);
            this.panelKeyBoard.Controls.Add(this.bZero);
            this.panelKeyBoard.Controls.Add(this.bNine);
            this.panelKeyBoard.Controls.Add(this.bEight);
            this.panelKeyBoard.Controls.Add(this.bSeven);
            this.panelKeyBoard.Controls.Add(this.bSix);
            this.panelKeyBoard.Controls.Add(this.bFive);
            this.panelKeyBoard.Controls.Add(this.bFour);
            this.panelKeyBoard.Controls.Add(this.bThree);
            this.panelKeyBoard.Controls.Add(this.bTwo);
            this.panelKeyBoard.Controls.Add(this.bOne);
            this.panelKeyBoard.Font = new System.Drawing.Font("Times New Roman", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panelKeyBoard.Location = new System.Drawing.Point(50, 154);
            this.panelKeyBoard.Name = "panelKeyBoard";
            this.panelKeyBoard.Size = new System.Drawing.Size(878, 483);
            this.panelKeyBoard.TabIndex = 11;
            // 
            // bMod
            // 
            this.bMod.Font = new System.Drawing.Font("Times New Roman", 6.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bMod.Location = new System.Drawing.Point(494, 354);
            this.bMod.Name = "bMod";
            this.bMod.Size = new System.Drawing.Size(93, 72);
            this.bMod.TabIndex = 23;
            this.bMod.Text = "mod";
            this.bMod.UseVisualStyleBackColor = true;
            this.bMod.Click += new System.EventHandler(this.bMod_Click);
            // 
            // bSqrt
            // 
            this.bSqrt.Font = new System.Drawing.Font("Georgia", 7.1F);
            this.bSqrt.Location = new System.Drawing.Point(620, 244);
            this.bSqrt.Name = "bSqrt";
            this.bSqrt.Size = new System.Drawing.Size(93, 81);
            this.bSqrt.TabIndex = 22;
            this.bSqrt.Text = "Sqrt";
            this.bSqrt.UseVisualStyleBackColor = true;
            this.bSqrt.Click += new System.EventHandler(this.bSqrt_Click);
            // 
            // bPower
            // 
            this.bPower.Font = new System.Drawing.Font("Georgia", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bPower.Location = new System.Drawing.Point(494, 244);
            this.bPower.Name = "bPower";
            this.bPower.Size = new System.Drawing.Size(93, 81);
            this.bPower.TabIndex = 21;
            this.bPower.Text = "^";
            this.bPower.UseVisualStyleBackColor = true;
            this.bPower.Click += new System.EventHandler(this.bPower_Click);
            // 
            // bClear
            // 
            this.bClear.Font = new System.Drawing.Font("Times New Roman", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bClear.Location = new System.Drawing.Point(24, 354);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(93, 81);
            this.bClear.TabIndex = 20;
            this.bClear.Text = "C";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // bEqual
            // 
            this.bEqual.Font = new System.Drawing.Font("Georgia", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bEqual.Location = new System.Drawing.Point(620, 363);
            this.bEqual.Name = "bEqual";
            this.bEqual.Size = new System.Drawing.Size(93, 72);
            this.bEqual.TabIndex = 19;
            this.bEqual.Text = "=";
            this.bEqual.UseVisualStyleBackColor = true;
            this.bEqual.Click += new System.EventHandler(this.bEqual_Click);
            // 
            // bDot
            // 
            this.bDot.Font = new System.Drawing.Font("Georgia", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bDot.Location = new System.Drawing.Point(288, 354);
            this.bDot.Name = "bDot";
            this.bDot.Size = new System.Drawing.Size(93, 81);
            this.bDot.TabIndex = 18;
            this.bDot.Text = ".";
            this.bDot.UseVisualStyleBackColor = true;
            // 
            // bDiv
            // 
            this.bDiv.Font = new System.Drawing.Font("Georgia", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bDiv.Location = new System.Drawing.Point(620, 144);
            this.bDiv.Name = "bDiv";
            this.bDiv.Size = new System.Drawing.Size(93, 81);
            this.bDiv.TabIndex = 17;
            this.bDiv.Text = "/";
            this.bDiv.UseVisualStyleBackColor = true;
            this.bDiv.Click += new System.EventHandler(this.bDiv_Click);
            // 
            // bMultip
            // 
            this.bMultip.Font = new System.Drawing.Font("Georgia", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bMultip.Location = new System.Drawing.Point(494, 144);
            this.bMultip.Name = "bMultip";
            this.bMultip.Size = new System.Drawing.Size(93, 81);
            this.bMultip.TabIndex = 16;
            this.bMultip.Text = "*";
            this.bMultip.UseVisualStyleBackColor = true;
            this.bMultip.Click += new System.EventHandler(this.bMultip_Click);
            // 
            // bMinus
            // 
            this.bMinus.Font = new System.Drawing.Font("Georgia", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bMinus.Location = new System.Drawing.Point(620, 45);
            this.bMinus.Name = "bMinus";
            this.bMinus.Size = new System.Drawing.Size(93, 81);
            this.bMinus.TabIndex = 15;
            this.bMinus.Text = "-";
            this.bMinus.UseVisualStyleBackColor = true;
            this.bMinus.Click += new System.EventHandler(this.bMinus_Click);
            // 
            // bAdd
            // 
            this.bAdd.Font = new System.Drawing.Font("Georgia", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bAdd.Location = new System.Drawing.Point(494, 45);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(93, 81);
            this.bAdd.TabIndex = 14;
            this.bAdd.Text = "+";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bZero
            // 
            this.bZero.Font = new System.Drawing.Font("Georgia", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bZero.Location = new System.Drawing.Point(157, 354);
            this.bZero.Name = "bZero";
            this.bZero.Size = new System.Drawing.Size(93, 81);
            this.bZero.TabIndex = 13;
            this.bZero.Text = "0";
            this.bZero.UseVisualStyleBackColor = true;
            this.bZero.Click += new System.EventHandler(this.bZero_Click);
            // 
            // bNine
            // 
            this.bNine.Font = new System.Drawing.Font("Georgia", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bNine.Location = new System.Drawing.Point(288, 45);
            this.bNine.Name = "bNine";
            this.bNine.Size = new System.Drawing.Size(93, 81);
            this.bNine.TabIndex = 12;
            this.bNine.Text = "9";
            this.bNine.UseVisualStyleBackColor = true;
            this.bNine.Click += new System.EventHandler(this.bNine_Click);
            // 
            // bEight
            // 
            this.bEight.Font = new System.Drawing.Font("Georgia", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bEight.Location = new System.Drawing.Point(157, 45);
            this.bEight.Name = "bEight";
            this.bEight.Size = new System.Drawing.Size(93, 81);
            this.bEight.TabIndex = 11;
            this.bEight.Text = "8";
            this.bEight.UseVisualStyleBackColor = true;
            this.bEight.Click += new System.EventHandler(this.bEight_Click);
            // 
            // bSeven
            // 
            this.bSeven.Font = new System.Drawing.Font("Georgia", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bSeven.Location = new System.Drawing.Point(24, 45);
            this.bSeven.Name = "bSeven";
            this.bSeven.Size = new System.Drawing.Size(93, 81);
            this.bSeven.TabIndex = 10;
            this.bSeven.Text = "7";
            this.bSeven.UseVisualStyleBackColor = true;
            this.bSeven.Click += new System.EventHandler(this.bSeven_Click);
            // 
            // bSix
            // 
            this.bSix.Font = new System.Drawing.Font("Georgia", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bSix.Location = new System.Drawing.Point(288, 144);
            this.bSix.Name = "bSix";
            this.bSix.Size = new System.Drawing.Size(93, 81);
            this.bSix.TabIndex = 9;
            this.bSix.Text = "6";
            this.bSix.UseVisualStyleBackColor = true;
            this.bSix.Click += new System.EventHandler(this.bSix_Click);
            // 
            // bFive
            // 
            this.bFive.Font = new System.Drawing.Font("Georgia", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bFive.Location = new System.Drawing.Point(157, 144);
            this.bFive.Name = "bFive";
            this.bFive.Size = new System.Drawing.Size(93, 81);
            this.bFive.TabIndex = 8;
            this.bFive.Text = "5";
            this.bFive.UseVisualStyleBackColor = true;
            this.bFive.Click += new System.EventHandler(this.bFive_Click);
            // 
            // bFour
            // 
            this.bFour.Font = new System.Drawing.Font("Georgia", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bFour.Location = new System.Drawing.Point(24, 144);
            this.bFour.Name = "bFour";
            this.bFour.Size = new System.Drawing.Size(93, 81);
            this.bFour.TabIndex = 7;
            this.bFour.Text = "4";
            this.bFour.UseVisualStyleBackColor = true;
            this.bFour.Click += new System.EventHandler(this.bFour_Click);
            // 
            // bThree
            // 
            this.bThree.Font = new System.Drawing.Font("Georgia", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bThree.Location = new System.Drawing.Point(288, 244);
            this.bThree.Name = "bThree";
            this.bThree.Size = new System.Drawing.Size(93, 81);
            this.bThree.TabIndex = 6;
            this.bThree.Text = "3";
            this.bThree.UseVisualStyleBackColor = true;
            this.bThree.Click += new System.EventHandler(this.bThree_Click);
            // 
            // bTwo
            // 
            this.bTwo.Font = new System.Drawing.Font("Georgia", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bTwo.Location = new System.Drawing.Point(157, 244);
            this.bTwo.Name = "bTwo";
            this.bTwo.Size = new System.Drawing.Size(93, 81);
            this.bTwo.TabIndex = 5;
            this.bTwo.Text = "2";
            this.bTwo.UseVisualStyleBackColor = true;
            this.bTwo.Click += new System.EventHandler(this.bTwo_Click);
            // 
            // tbNumber
            // 
            this.tbNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbNumber.Location = new System.Drawing.Point(245, 26);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(721, 53);
            this.tbNumber.TabIndex = 12;
            this.tbNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1427, 725);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.panelKeyBoard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbHistory);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelKeyBoard.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbHistory;
        private System.Windows.Forms.Button bOne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelKeyBoard;
        private System.Windows.Forms.Button bZero;
        private System.Windows.Forms.Button bNine;
        private System.Windows.Forms.Button bEight;
        private System.Windows.Forms.Button bSeven;
        private System.Windows.Forms.Button bSix;
        private System.Windows.Forms.Button bFive;
        private System.Windows.Forms.Button bFour;
        private System.Windows.Forms.Button bThree;
        private System.Windows.Forms.Button bTwo;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Button bDiv;
        private System.Windows.Forms.Button bMultip;
        private System.Windows.Forms.Button bMinus;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bDot;
        private System.Windows.Forms.Button bEqual;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button bPower;
        private System.Windows.Forms.Button bSqrt;
        private System.Windows.Forms.Button bMod;
    }
}

