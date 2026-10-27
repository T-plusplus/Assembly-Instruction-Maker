namespace MipsConverter
{
    partial class MipsPnmForm
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
            this.Instructions = new System.Windows.Forms.Label();
            this.InstrEntry = new System.Windows.Forms.GroupBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.ExamplesL = new System.Windows.Forms.Label();
            this.InstrInputTB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.InstrOutputL = new System.Windows.Forms.Label();
            this.InstrL = new System.Windows.Forms.Label();
            this.InstrEntry.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Instructions
            // 
            this.Instructions.Location = new System.Drawing.Point(13, 9);
            this.Instructions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Instructions.Name = "Instructions";
            this.Instructions.Size = new System.Drawing.Size(334, 49);
            this.Instructions.TabIndex = 1;
            this.Instructions.Text = "Instructions: Type in the Instruction, see examples below. Hit enter after select" +
    "ing instruction type.";
            // 
            // InstrEntry
            // 
            this.InstrEntry.Controls.Add(this.GenerateButton);
            this.InstrEntry.Controls.Add(this.ExamplesL);
            this.InstrEntry.Controls.Add(this.InstrInputTB);
            this.InstrEntry.Location = new System.Drawing.Point(16, 73);
            this.InstrEntry.Name = "InstrEntry";
            this.InstrEntry.Size = new System.Drawing.Size(331, 185);
            this.InstrEntry.TabIndex = 2;
            this.InstrEntry.TabStop = false;
            this.InstrEntry.Text = "Instruction Entry";
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(33, 120);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(248, 48);
            this.GenerateButton.TabIndex = 2;
            this.GenerateButton.Text = "Generate Instruction";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // ExamplesL
            // 
            this.ExamplesL.AutoSize = true;
            this.ExamplesL.Location = new System.Drawing.Point(6, 47);
            this.ExamplesL.Name = "ExamplesL";
            this.ExamplesL.Size = new System.Drawing.Size(225, 51);
            this.ExamplesL.TabIndex = 1;
            this.ExamplesL.Text = "Examples: addi $t1, $zero, 0x1234\r\n                 j 0x000222\r\n                x" +
    "or $t5, $s2, $sp";
            // 
            // InstrInputTB
            // 
            this.InstrInputTB.Location = new System.Drawing.Point(7, 22);
            this.InstrInputTB.Name = "InstrInputTB";
            this.InstrInputTB.Size = new System.Drawing.Size(318, 22);
            this.InstrInputTB.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.InstrOutputL);
            this.groupBox1.Controls.Add(this.InstrL);
            this.groupBox1.Location = new System.Drawing.Point(354, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 246);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // InstrOutputL
            // 
            this.InstrOutputL.AutoSize = true;
            this.InstrOutputL.Location = new System.Drawing.Point(91, 22);
            this.InstrOutputL.Name = "InstrOutputL";
            this.InstrOutputL.Size = new System.Drawing.Size(42, 17);
            this.InstrOutputL.TabIndex = 1;
            this.InstrOutputL.Text = "None";
            // 
            // InstrL
            // 
            this.InstrL.AutoSize = true;
            this.InstrL.Location = new System.Drawing.Point(7, 22);
            this.InstrL.Name = "InstrL";
            this.InstrL.Size = new System.Drawing.Size(77, 17);
            this.InstrL.TabIndex = 0;
            this.InstrL.Text = "Instruction:";
            // 
            // MipsPnmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.InstrEntry);
            this.Controls.Add(this.Instructions);
            this.Name = "MipsPnmForm";
            this.Text = "Convert pnemonics to Mips Instructions in Hex";
            this.InstrEntry.ResumeLayout(false);
            this.InstrEntry.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Instructions;
        private System.Windows.Forms.GroupBox InstrEntry;
        private System.Windows.Forms.Label ExamplesL;
        private System.Windows.Forms.TextBox InstrInputTB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label InstrOutputL;
        private System.Windows.Forms.Label InstrL;
        private System.Windows.Forms.Button GenerateButton;
    }
}