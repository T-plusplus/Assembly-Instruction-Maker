namespace MipsConverter
{
    partial class MipsFieldsForm
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
            this.Type = new System.Windows.Forms.GroupBox();
            this.isJType = new System.Windows.Forms.RadioButton();
            this.IsIType = new System.Windows.Forms.RadioButton();
            this.IsRType = new System.Windows.Forms.RadioButton();
            this.OPcodeL = new System.Windows.Forms.Label();
            this.OpCodeTB = new System.Windows.Forms.TextBox();
            this.RdL = new System.Windows.Forms.Label();
            this.ParamsBox = new System.Windows.Forms.GroupBox();
            this.AddrL = new System.Windows.Forms.Label();
            this.ImmL = new System.Windows.Forms.Label();
            this.AddrTB = new System.Windows.Forms.TextBox();
            this.ImmTB = new System.Windows.Forms.TextBox();
            this.FunctTB = new System.Windows.Forms.TextBox();
            this.shamtTB = new System.Windows.Forms.TextBox();
            this.RsTB = new System.Windows.Forms.TextBox();
            this.RtTB = new System.Windows.Forms.TextBox();
            this.RdTB = new System.Windows.Forms.TextBox();
            this.RtL = new System.Windows.Forms.Label();
            this.FunctL = new System.Windows.Forms.Label();
            this.ShamtL = new System.Windows.Forms.Label();
            this.RsL = new System.Windows.Forms.Label();
            this.generateB = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.Label();
            this.InstrData = new System.Windows.Forms.GroupBox();
            this.PNM = new System.Windows.Forms.Label();
            this.InstrPNML = new System.Windows.Forms.Label();
            this.InstrMachL = new System.Windows.Forms.Label();
            this.Type.SuspendLayout();
            this.ParamsBox.SuspendLayout();
            this.InstrData.SuspendLayout();
            this.SuspendLayout();
            // 
            // Instructions
            // 
            this.Instructions.Location = new System.Drawing.Point(17, 16);
            this.Instructions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Instructions.Name = "Instructions";
            this.Instructions.Size = new System.Drawing.Size(415, 42);
            this.Instructions.TabIndex = 0;
            this.Instructions.Text = "Instructions: Type in the Opcodes, the registers in binary. Hit enter after selec" +
    "tiong instruction type.";
            // 
            // Type
            // 
            this.Type.Controls.Add(this.isJType);
            this.Type.Controls.Add(this.IsIType);
            this.Type.Controls.Add(this.IsRType);
            this.Type.Location = new System.Drawing.Point(17, 62);
            this.Type.Margin = new System.Windows.Forms.Padding(4);
            this.Type.Name = "Type";
            this.Type.Padding = new System.Windows.Forms.Padding(4);
            this.Type.Size = new System.Drawing.Size(415, 115);
            this.Type.TabIndex = 1;
            this.Type.TabStop = false;
            this.Type.Text = "Type";
            // 
            // isJType
            // 
            this.isJType.AutoSize = true;
            this.isJType.Location = new System.Drawing.Point(9, 81);
            this.isJType.Margin = new System.Windows.Forms.Padding(4);
            this.isJType.Name = "isJType";
            this.isJType.Size = new System.Drawing.Size(68, 21);
            this.isJType.TabIndex = 2;
            this.isJType.TabStop = true;
            this.isJType.Text = "J-type";
            this.isJType.UseVisualStyleBackColor = true;
            // 
            // IsIType
            // 
            this.IsIType.AutoSize = true;
            this.IsIType.Location = new System.Drawing.Point(9, 53);
            this.IsIType.Margin = new System.Windows.Forms.Padding(4);
            this.IsIType.Name = "IsIType";
            this.IsIType.Size = new System.Drawing.Size(230, 21);
            this.IsIType.TabIndex = 1;
            this.IsIType.TabStop = true;
            this.IsIType.Text = "I-type(Loads, Stores, Branches)";
            this.IsIType.UseVisualStyleBackColor = true;
            // 
            // IsRType
            // 
            this.IsRType.AutoSize = true;
            this.IsRType.Location = new System.Drawing.Point(9, 25);
            this.IsRType.Margin = new System.Windows.Forms.Padding(4);
            this.IsRType.Name = "IsRType";
            this.IsRType.Size = new System.Drawing.Size(169, 21);
            this.IsRType.TabIndex = 0;
            this.IsRType.TabStop = true;
            this.IsRType.Text = "R-type(most ALU ops)";
            this.IsRType.UseVisualStyleBackColor = true;
            // 
            // OPcodeL
            // 
            this.OPcodeL.AutoSize = true;
            this.OPcodeL.Location = new System.Drawing.Point(9, 25);
            this.OPcodeL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OPcodeL.Name = "OPcodeL";
            this.OPcodeL.Size = new System.Drawing.Size(92, 17);
            this.OPcodeL.TabIndex = 0;
            this.OPcodeL.Text = "OpCode(hex)";
            // 
            // OpCodeTB
            // 
            this.OpCodeTB.Location = new System.Drawing.Point(246, 20);
            this.OpCodeTB.Margin = new System.Windows.Forms.Padding(4);
            this.OpCodeTB.Name = "OpCodeTB";
            this.OpCodeTB.Size = new System.Drawing.Size(132, 22);
            this.OpCodeTB.TabIndex = 1;
            // 
            // RdL
            // 
            this.RdL.AutoSize = true;
            this.RdL.Location = new System.Drawing.Point(9, 55);
            this.RdL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RdL.Name = "RdL";
            this.RdL.Size = new System.Drawing.Size(173, 17);
            this.RdL.TabIndex = 2;
            this.RdL.Text = "Rd(R-types only)(decimal)";
            // 
            // ParamsBox
            // 
            this.ParamsBox.Controls.Add(this.AddrL);
            this.ParamsBox.Controls.Add(this.ImmL);
            this.ParamsBox.Controls.Add(this.AddrTB);
            this.ParamsBox.Controls.Add(this.ImmTB);
            this.ParamsBox.Controls.Add(this.FunctTB);
            this.ParamsBox.Controls.Add(this.shamtTB);
            this.ParamsBox.Controls.Add(this.RsTB);
            this.ParamsBox.Controls.Add(this.RtTB);
            this.ParamsBox.Controls.Add(this.RdTB);
            this.ParamsBox.Controls.Add(this.RtL);
            this.ParamsBox.Controls.Add(this.FunctL);
            this.ParamsBox.Controls.Add(this.ShamtL);
            this.ParamsBox.Controls.Add(this.RsL);
            this.ParamsBox.Controls.Add(this.RdL);
            this.ParamsBox.Controls.Add(this.OpCodeTB);
            this.ParamsBox.Controls.Add(this.OPcodeL);
            this.ParamsBox.Location = new System.Drawing.Point(17, 185);
            this.ParamsBox.Margin = new System.Windows.Forms.Padding(4);
            this.ParamsBox.Name = "ParamsBox";
            this.ParamsBox.Padding = new System.Windows.Forms.Padding(4);
            this.ParamsBox.Size = new System.Drawing.Size(415, 314);
            this.ParamsBox.TabIndex = 2;
            this.ParamsBox.TabStop = false;
            this.ParamsBox.Text = "Parameters";
            // 
            // AddrL
            // 
            this.AddrL.AutoSize = true;
            this.AddrL.Location = new System.Drawing.Point(9, 247);
            this.AddrL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddrL.Name = "AddrL";
            this.AddrL.Size = new System.Drawing.Size(171, 17);
            this.AddrL.TabIndex = 15;
            this.AddrL.Text = "Address(J-type only)(hex)";
            // 
            // ImmL
            // 
            this.ImmL.AutoSize = true;
            this.ImmL.Location = new System.Drawing.Point(9, 215);
            this.ImmL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ImmL.Name = "ImmL";
            this.ImmL.Size = new System.Drawing.Size(178, 17);
            this.ImmL.TabIndex = 14;
            this.ImmL.Text = "Immediate(I type only)(hex)";
            // 
            // AddrTB
            // 
            this.AddrTB.Location = new System.Drawing.Point(246, 244);
            this.AddrTB.Margin = new System.Windows.Forms.Padding(4);
            this.AddrTB.Name = "AddrTB";
            this.AddrTB.Size = new System.Drawing.Size(132, 22);
            this.AddrTB.TabIndex = 13;
            // 
            // ImmTB
            // 
            this.ImmTB.Location = new System.Drawing.Point(246, 212);
            this.ImmTB.Margin = new System.Windows.Forms.Padding(4);
            this.ImmTB.Name = "ImmTB";
            this.ImmTB.Size = new System.Drawing.Size(132, 22);
            this.ImmTB.TabIndex = 12;
            // 
            // FunctTB
            // 
            this.FunctTB.Location = new System.Drawing.Point(246, 180);
            this.FunctTB.Margin = new System.Windows.Forms.Padding(4);
            this.FunctTB.Name = "FunctTB";
            this.FunctTB.Size = new System.Drawing.Size(132, 22);
            this.FunctTB.TabIndex = 11;
            // 
            // shamtTB
            // 
            this.shamtTB.Location = new System.Drawing.Point(246, 148);
            this.shamtTB.Margin = new System.Windows.Forms.Padding(4);
            this.shamtTB.Name = "shamtTB";
            this.shamtTB.Size = new System.Drawing.Size(132, 22);
            this.shamtTB.TabIndex = 10;
            // 
            // RsTB
            // 
            this.RsTB.Location = new System.Drawing.Point(246, 116);
            this.RsTB.Margin = new System.Windows.Forms.Padding(4);
            this.RsTB.Name = "RsTB";
            this.RsTB.Size = new System.Drawing.Size(132, 22);
            this.RsTB.TabIndex = 9;
            // 
            // RtTB
            // 
            this.RtTB.Location = new System.Drawing.Point(246, 84);
            this.RtTB.Margin = new System.Windows.Forms.Padding(4);
            this.RtTB.Name = "RtTB";
            this.RtTB.Size = new System.Drawing.Size(132, 22);
            this.RtTB.TabIndex = 8;
            // 
            // RdTB
            // 
            this.RdTB.Location = new System.Drawing.Point(246, 52);
            this.RdTB.Margin = new System.Windows.Forms.Padding(4);
            this.RdTB.Name = "RdTB";
            this.RdTB.Size = new System.Drawing.Size(132, 22);
            this.RdTB.TabIndex = 7;
            // 
            // RtL
            // 
            this.RtL.AutoSize = true;
            this.RtL.Location = new System.Drawing.Point(8, 87);
            this.RtL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RtL.Name = "RtL";
            this.RtL.Size = new System.Drawing.Size(195, 17);
            this.RtL.TabIndex = 6;
            this.RtL.Text = "Rt(excludes J-types)(decimal)";
            // 
            // FunctL
            // 
            this.FunctL.AutoSize = true;
            this.FunctL.Location = new System.Drawing.Point(9, 183);
            this.FunctL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FunctL.Name = "FunctL";
            this.FunctL.Size = new System.Drawing.Size(156, 17);
            this.FunctL.TabIndex = 5;
            this.FunctL.Text = "Funct(R type only)(hex)";
            // 
            // ShamtL
            // 
            this.ShamtL.AutoSize = true;
            this.ShamtL.Location = new System.Drawing.Point(9, 151);
            this.ShamtL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ShamtL.Name = "ShamtL";
            this.ShamtL.Size = new System.Drawing.Size(195, 17);
            this.ShamtL.TabIndex = 4;
            this.ShamtL.Text = "Shamt(R-type shifts)(decimal)";
            // 
            // RsL
            // 
            this.RsL.AutoSize = true;
            this.RsL.Location = new System.Drawing.Point(9, 119);
            this.RsL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RsL.Name = "RsL";
            this.RsL.Size = new System.Drawing.Size(198, 17);
            this.RsL.TabIndex = 3;
            this.RsL.Text = "Rs(excludes J-types)(decimal)";
            // 
            // generateB
            // 
            this.generateB.Location = new System.Drawing.Point(21, 507);
            this.generateB.Margin = new System.Windows.Forms.Padding(4);
            this.generateB.Name = "generateB";
            this.generateB.Size = new System.Drawing.Size(411, 28);
            this.generateB.TabIndex = 3;
            this.generateB.Text = "Generate Instruction";
            this.generateB.UseVisualStyleBackColor = true;
            this.generateB.Click += new System.EventHandler(this.generateB_Click);
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Location = new System.Drawing.Point(136, 31);
            this.Output.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(56, 17);
            this.Output.TabIndex = 4;
            this.Output.Text = " (None)";
            // 
            // InstrData
            // 
            this.InstrData.Controls.Add(this.PNM);
            this.InstrData.Controls.Add(this.InstrPNML);
            this.InstrData.Controls.Add(this.InstrMachL);
            this.InstrData.Controls.Add(this.Output);
            this.InstrData.Location = new System.Drawing.Point(457, 16);
            this.InstrData.Name = "InstrData";
            this.InstrData.Size = new System.Drawing.Size(381, 206);
            this.InstrData.TabIndex = 5;
            this.InstrData.TabStop = false;
            this.InstrData.Text = "Instruction Data";
            // 
            // PNM
            // 
            this.PNM.AutoSize = true;
            this.PNM.Location = new System.Drawing.Point(139, 52);
            this.PNM.Name = "PNM";
            this.PNM.Size = new System.Drawing.Size(49, 17);
            this.PNM.TabIndex = 7;
            this.PNM.Text = "No Op";
            // 
            // InstrPNML
            // 
            this.InstrPNML.AutoSize = true;
            this.InstrPNML.Location = new System.Drawing.Point(10, 52);
            this.InstrPNML.Name = "InstrPNML";
            this.InstrPNML.Size = new System.Drawing.Size(78, 17);
            this.InstrPNML.TabIndex = 6;
            this.InstrPNML.Text = "Pneumonic";
            // 
            // InstrMachL
            // 
            this.InstrMachL.AutoSize = true;
            this.InstrMachL.Location = new System.Drawing.Point(7, 31);
            this.InstrMachL.Name = "InstrMachL";
            this.InstrMachL.Size = new System.Drawing.Size(105, 17);
            this.InstrMachL.TabIndex = 5;
            this.InstrMachL.Text = "Instruction(hex)";
            // 
            // MipsFieldsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 682);
            this.Controls.Add(this.InstrData);
            this.Controls.Add(this.generateB);
            this.Controls.Add(this.ParamsBox);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.Instructions);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MipsFieldsForm";
            this.Text = "Convert Hex codes to Mips Instructions in Hex";
            this.Type.ResumeLayout(false);
            this.Type.PerformLayout();
            this.ParamsBox.ResumeLayout(false);
            this.ParamsBox.PerformLayout();
            this.InstrData.ResumeLayout(false);
            this.InstrData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Instructions;
        private System.Windows.Forms.GroupBox Type;
        private System.Windows.Forms.RadioButton isJType;
        private System.Windows.Forms.RadioButton IsIType;
        private System.Windows.Forms.RadioButton IsRType;
        private System.Windows.Forms.Label OPcodeL;
        private System.Windows.Forms.TextBox OpCodeTB;
        private System.Windows.Forms.Label RdL;
        private System.Windows.Forms.GroupBox ParamsBox;
        private System.Windows.Forms.TextBox RdTB;
        private System.Windows.Forms.Label RtL;
        private System.Windows.Forms.Label FunctL;
        private System.Windows.Forms.Label ShamtL;
        private System.Windows.Forms.Label RsL;
        private System.Windows.Forms.TextBox RtTB;
        private System.Windows.Forms.TextBox ImmTB;
        private System.Windows.Forms.TextBox FunctTB;
        private System.Windows.Forms.TextBox shamtTB;
        private System.Windows.Forms.TextBox RsTB;
        private System.Windows.Forms.Label AddrL;
        private System.Windows.Forms.Label ImmL;
        private System.Windows.Forms.TextBox AddrTB;
        private System.Windows.Forms.Button generateB;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.GroupBox InstrData;
        private System.Windows.Forms.Label InstrMachL;
        private System.Windows.Forms.Label PNM;
        private System.Windows.Forms.Label InstrPNML;
    }
}

