using System;

namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DeleteButton = new System.Windows.Forms.Button();
            this.PercentButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.DevideButton = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.Seven = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.SubstrictionButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.EqualsButton = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.Point = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.OutputText = new System.Windows.Forms.TextBox();
            this.Five = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Linen;
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteButton.ForeColor = System.Drawing.Color.Green;
            this.DeleteButton.Location = new System.Drawing.Point(316, 213);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(95, 40);
            this.DeleteButton.TabIndex = 0;
            this.DeleteButton.Text = "Backspace";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // PercentButton
            // 
            this.PercentButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PercentButton.ForeColor = System.Drawing.Color.Green;
            this.PercentButton.Location = new System.Drawing.Point(114, 213);
            this.PercentButton.Name = "PercentButton";
            this.PercentButton.Size = new System.Drawing.Size(95, 40);
            this.PercentButton.TabIndex = 0;
            this.PercentButton.Text = "%";
            this.PercentButton.UseVisualStyleBackColor = true;
            this.PercentButton.Click += new System.EventHandler(this.PercentButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.Linen;
            this.ClearButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClearButton.ForeColor = System.Drawing.Color.Red;
            this.ClearButton.Location = new System.Drawing.Point(13, 213);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(95, 40);
            this.ClearButton.TabIndex = 0;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // DevideButton
            // 
            this.DevideButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DevideButton.ForeColor = System.Drawing.Color.Green;
            this.DevideButton.Location = new System.Drawing.Point(215, 213);
            this.DevideButton.Name = "DevideButton";
            this.DevideButton.Size = new System.Drawing.Size(95, 40);
            this.DevideButton.TabIndex = 0;
            this.DevideButton.Text = "/";
            this.DevideButton.UseVisualStyleBackColor = true;
            this.DevideButton.Click += new System.EventHandler(this.DevideButton_Click);
            // 
            // Nine
            // 
            this.Nine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Nine.Location = new System.Drawing.Point(214, 259);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(95, 40);
            this.Nine.TabIndex = 0;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = true;
            this.Nine.Click += new System.EventHandler(this.Nine_Click);
            // 
            // Seven
            // 
            this.Seven.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Seven.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Seven.Location = new System.Drawing.Point(12, 259);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(95, 40);
            this.Seven.TabIndex = 0;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = true;
            this.Seven.Click += new System.EventHandler(this.Seven_Click);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MultiplyButton.ForeColor = System.Drawing.Color.Green;
            this.MultiplyButton.Location = new System.Drawing.Point(316, 259);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(95, 40);
            this.MultiplyButton.TabIndex = 0;
            this.MultiplyButton.Text = "X";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // SubstrictionButton
            // 
            this.SubstrictionButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SubstrictionButton.ForeColor = System.Drawing.Color.Green;
            this.SubstrictionButton.Location = new System.Drawing.Point(316, 305);
            this.SubstrictionButton.Name = "SubstrictionButton";
            this.SubstrictionButton.Size = new System.Drawing.Size(95, 40);
            this.SubstrictionButton.TabIndex = 0;
            this.SubstrictionButton.Text = "-";
            this.SubstrictionButton.UseVisualStyleBackColor = true;
            this.SubstrictionButton.Click += new System.EventHandler(this.SubstrictionButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddButton.ForeColor = System.Drawing.Color.Green;
            this.AddButton.Location = new System.Drawing.Point(316, 351);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(95, 40);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "+";
            this.AddButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EqualsButton
            // 
            this.EqualsButton.BackColor = System.Drawing.Color.Green;
            this.EqualsButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EqualsButton.ForeColor = System.Drawing.Color.White;
            this.EqualsButton.Location = new System.Drawing.Point(215, 398);
            this.EqualsButton.Name = "EqualsButton";
            this.EqualsButton.Size = new System.Drawing.Size(196, 40);
            this.EqualsButton.TabIndex = 0;
            this.EqualsButton.Text = "=";
            this.EqualsButton.UseVisualStyleBackColor = false;
            this.EqualsButton.Click += new System.EventHandler(this.Equals_Click);
            // 
            // Six
            // 
            this.Six.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Six.Location = new System.Drawing.Point(214, 305);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(95, 40);
            this.Six.TabIndex = 0;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = true;
            this.Six.Click += new System.EventHandler(this.Six_Click);
            // 
            // Three
            // 
            this.Three.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Three.Location = new System.Drawing.Point(215, 351);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(95, 40);
            this.Three.TabIndex = 0;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = true;
            this.Three.Click += new System.EventHandler(this.Three_Click);
            // 
            // Point
            // 
            this.Point.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Point.Location = new System.Drawing.Point(114, 398);
            this.Point.Name = "Point";
            this.Point.Size = new System.Drawing.Size(95, 40);
            this.Point.TabIndex = 0;
            this.Point.Text = ".";
            this.Point.UseVisualStyleBackColor = true;
            this.Point.Click += new System.EventHandler(this.Point_Click);
            // 
            // Eight
            // 
            this.Eight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Eight.Location = new System.Drawing.Point(113, 259);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(95, 40);
            this.Eight.TabIndex = 0;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = true;
            this.Eight.Click += new System.EventHandler(this.Eight_Click);
            // 
            // OutputText
            // 
            this.OutputText.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.OutputText.Location = new System.Drawing.Point(11, 12);
            this.OutputText.Multiline = true;
            this.OutputText.Name = "OutputText";
            this.OutputText.Size = new System.Drawing.Size(399, 145);
            this.OutputText.TabIndex = 1;
            // 
            // Five
            // 
            this.Five.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Five.Location = new System.Drawing.Point(113, 305);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(95, 40);
            this.Five.TabIndex = 0;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = true;
            this.Five.Click += new System.EventHandler(this.Five_Click);
            // 
            // Four
            // 
            this.Four.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Four.Location = new System.Drawing.Point(12, 305);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(95, 40);
            this.Four.TabIndex = 0;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = true;
            this.Four.Click += new System.EventHandler(this.Four_Click);
            // 
            // Two
            // 
            this.Two.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Two.Location = new System.Drawing.Point(113, 352);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(95, 40);
            this.Two.TabIndex = 0;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = true;
            this.Two.Click += new System.EventHandler(this.Two_Click);
            // 
            // One
            // 
            this.One.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.One.Location = new System.Drawing.Point(12, 351);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(95, 40);
            this.One.TabIndex = 0;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = true;
            this.One.Click += new System.EventHandler(this.One_Click);
            // 
            // Zero
            // 
            this.Zero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Zero.Location = new System.Drawing.Point(13, 398);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(95, 40);
            this.Zero.TabIndex = 0;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = true;
            this.Zero.Click += new System.EventHandler(this.Zero_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "last";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(423, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OutputText);
            this.Controls.Add(this.Eight);
            this.Controls.Add(this.PercentButton);
            this.Controls.Add(this.Seven);
            this.Controls.Add(this.One);
            this.Controls.Add(this.Two);
            this.Controls.Add(this.Three);
            this.Controls.Add(this.Zero);
            this.Controls.Add(this.Point);
            this.Controls.Add(this.Four);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.Six);
            this.Controls.Add(this.Nine);
            this.Controls.Add(this.EqualsButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SubstrictionButton);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.DevideButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.DeleteButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button PercentButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button DevideButton;
        private System.Windows.Forms.Button Nine;
        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button SubstrictionButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EqualsButton;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button Three;
        private System.Windows.Forms.Button Point;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.TextBox OutputText;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button Zero;
        private System.Windows.Forms.Label label1;
    }
}
