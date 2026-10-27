using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MipsConverter
{
    public partial class MipsFieldsForm : Form
    {
        public MipsFieldsForm()
        {
            InitializeComponent();
        }

        private void generateB_Click(object sender, EventArgs e)
        {
            ResetFields();//reset errors, change all labels back to black

            string opcode_bin_string = "";
            string rd_bin_string = "";
            string rs_bin_string = "";
            string rt_bin_string = "";
            string shamt_bin_string = "";
            string funct_bin_string = "";
            string imm_bin_string = "";
            string addr_bin_string = "";
            Boolean Flag = false;
            try
            {
                //convert opcode to binary
                if (OpCodeTB.Text != "")
                {
                    int opcode_dec_int = int.Parse(OpCodeTB.Text, System.Globalization.NumberStyles.HexNumber);
                    opcode_bin_string = Convert.ToString(opcode_dec_int, 2);
                    opcode_bin_string = Adjust(opcode_bin_string, 6);
                }
                else
                {
                    //Change label color, All instructions must have an OpCode.
                    Output.Text = "All instructions must have an OpCode.";
                    Output.ForeColor = System.Drawing.Color.Red;
                    OPcodeL.ForeColor = System.Drawing.Color.Red;
                    Flag = true;
                }
                //convert Rd to binary
                if (RdTB.Text != "")
                {
                    int rd_dec_int = Convert.ToInt32(RdTB.Text);
                    rd_bin_string = Convert.ToString(rd_dec_int, 2);
                    rd_bin_string = Adjust(rd_bin_string, 5);
                }
                else
                {
                    if(IsRType.Checked) //We only would want to error correct if we have an R type, as they're the only 
                        //instructions that use Rd. 
                    {
                        Output.Text = "This instruction must have an Rd field.";
                        Output.ForeColor = System.Drawing.Color.Red;
                        RdL.ForeColor = System.Drawing.Color.Red;
                        Flag = true;
                    }
                }
                //convert Rs to binary
                if (RsTB.Text != "")
                {
                    int rs_dec_int = Convert.ToInt32(RsTB.Text, 10);
                    rs_bin_string = Convert.ToString(rs_dec_int, 2);
                    rs_bin_string = Adjust(rs_bin_string, 5);
                }
                else
                {
                    if (IsRType.Checked || IsIType.Checked) //All I and R types use this. 
                    {
                        Output.Text = "This instruction must have an Rs field.";
                        Output.ForeColor = System.Drawing.Color.Red;
                        RsL.ForeColor = System.Drawing.Color.Red;
                        Flag = true;
                    }
                }
                //convert Rt to binary
                if (RtTB.Text != "")
                {
                    int rt_dec_int = Convert.ToInt32(RtTB.Text);
                    rt_bin_string = Convert.ToString(rt_dec_int, 2);
                    rt_bin_string = Adjust(rt_bin_string, 5);
                }
                else
                {
                    if (IsRType.Checked || IsIType.Checked) //All I and R types use this. 
                    {
                        Output.Text = "This instruction must have an Rt field.";
                        Output.ForeColor = System.Drawing.Color.Red;
                        RtL.ForeColor = System.Drawing.Color.Red;
                        Flag = true;
                    }
                }
                //convert Shamt to binary
                if (shamtTB.Text != "")
                {
                    int shamt_dec_int = Convert.ToInt32(shamtTB.Text);
                    shamt_bin_string = Convert.ToString(shamt_dec_int, 2);
                    shamt_bin_string = Adjust(shamt_bin_string, 5);
                }
                else
                {
                    if (IsRType.Checked) //We only would want to error correct if we have an R type, as they're the only 
                                         //instructions that use shamt. 
                    {
                        Output.Text = "This instruction must have an Shift Amount field.";
                        Output.ForeColor = System.Drawing.Color.Red;
                        ShamtL.ForeColor = System.Drawing.Color.Red;
                        Flag = true;
                    }
                }
                //convert Funct to binary
                if (FunctTB.Text != "")
                {
                    int funct_dec_int = int.Parse(FunctTB.Text, System.Globalization.NumberStyles.HexNumber);
                    funct_bin_string = Convert.ToString(funct_dec_int, 2);
                    funct_bin_string = Adjust(funct_bin_string, 6);
                }
                else
                {
                    if (IsRType.Checked) //We only would want to error correct if we have an R type, as they're the only 
                                         //instructions that use funct. 
                    {
                        Output.Text = "This instruction must have an Funct field.";
                        Output.ForeColor = System.Drawing.Color.Red;
                        FunctL.ForeColor = System.Drawing.Color.Red;
                        Flag = true;
                    }
                }
                //convert Immediate to binary
                if (ImmTB.Text != "")
                {
                    int imm_dec_int = int.Parse(ImmTB.Text, System.Globalization.NumberStyles.HexNumber);
                    imm_bin_string = Convert.ToString(imm_dec_int, 2);
                    imm_bin_string = Adjust(imm_bin_string, 16);
                }
                else
                {
                    if (IsIType.Checked) //We only would want to error correct if we have an I type, as they're the only 
                                         //instructions that use 16 bit immediates. 
                    {
                        Output.Text = "This instruction must have an Immediate field.";
                        Output.ForeColor = System.Drawing.Color.Red;
                        ImmL.ForeColor = System.Drawing.Color.Red;
                        Flag = true;
                    }
                }
                //convert Address to binary
                if (AddrTB.Text != "")
                {
                    int addr_dec_int = int.Parse(AddrTB.Text, System.Globalization.NumberStyles.HexNumber);
                    addr_bin_string = Convert.ToString(addr_dec_int, 2);
                    addr_bin_string = Adjust(addr_bin_string, 26);
                }
                else
                {
                    if (isJType.Checked) //We only would want to error correct if we have an J type, as they're the only 
                                         //instructions that use a pc address. 
                    {
                        Output.Text = "This instruction must have an Address field.";
                        Output.ForeColor = System.Drawing.Color.Red;
                        AddrL.ForeColor = System.Drawing.Color.Red;
                        Flag = true;
                    }
                }


                string instr_bin_string = "";

                if (IsRType.Checked)
                {
                    instr_bin_string = opcode_bin_string + rs_bin_string + rt_bin_string + rd_bin_string + shamt_bin_string + funct_bin_string;
                }
                else if (IsIType.Checked)
                {
                    instr_bin_string = opcode_bin_string + rs_bin_string + rt_bin_string + imm_bin_string;
                }
                else if (isJType.Checked)
                {
                    instr_bin_string = opcode_bin_string + addr_bin_string;
                }
                uint instr_dec_int = Convert.ToUInt32(instr_bin_string, 2);
                string instru = Convert.ToString(instr_dec_int, 16);
                instru = Adjust(instru, 8);
                Output.Text = instru;
                SetPNM();
            }
            catch(Exception)
            {
                if(!Flag)
                    Output.Text = "Error occured";
                Output.ForeColor = System.Drawing.Color.Red;
            }
            
            //Testing
            //Output.Text =Output.Text+ instr_bin_string + " " +instr_bin_string.Length+ "\n op " + opcode_bin_string + "   rs " + rs_bin_string + "\n rt " + rt_bin_string + "   rd " + rd_bin_string + "\n s" + shamt_bin_string + "   f " + funct_bin_string;
        }
        
        private string Adjust(string toFix, int length)
            {
                while(toFix.Length!=length)
                {
                    toFix = "0" + toFix;
                }
                return toFix;
            }
        private void SetPNM()
        {
            string rd_p_string = "";
            string rt_p_string = "";
            string rs_p_string = "";
            string imm_p_string = "";
            string j_p_string = "";
            string regdata = "";
            string OPstr= MipsResources.GetOp(OpCodeTB.Text, FunctTB.Text);
            if (IsRType.Checked)
            {
                rd_p_string = MipsResources.GetRegisterDescr(Convert.ToInt32(RdTB.Text));
                rt_p_string = MipsResources.GetRegisterDescr(Convert.ToInt32(RtTB.Text));
                rs_p_string = MipsResources.GetRegisterDescr(Convert.ToInt32(RsTB.Text));
                if (OPstr=="jr")
                {
                    regdata = "$"+rs_p_string;
                }
                else if(OPstr=="sll" || OPstr=="sra" || OPstr=="srl")
                {
                    regdata = "$"+rd_p_string + ", $" + rt_p_string + ", "+shamtTB.Text;
                }
                else
                {
                    regdata = "$" + rd_p_string + ", $" + rt_p_string + ", $" + rs_p_string;
                }
            }
            if(IsIType.Checked)
            {
                rt_p_string = MipsResources.GetRegisterDescr(Convert.ToInt32(RtTB.Text));
                rs_p_string = MipsResources.GetRegisterDescr(Convert.ToInt32(RsTB.Text));
                imm_p_string = ImmTB.Text;
                //loads and stores
                if(OPstr=="lw" || OPstr=="sw")
                {
                    regdata = "$" + rt_p_string + ", 0x" + imm_p_string + "( $" + rs_p_string + ")";
                }
                //all else, branches, basic alu ops with immediates
                else
                {
                    regdata = "$" + rt_p_string + ", $" + rs_p_string + ", " + "0x" + imm_p_string;
                }
            }
            if(isJType.Checked)
            {
                j_p_string = AddrTB.Text;
                regdata = "0x" + j_p_string;
            }
            PNM.Text = OPstr + " " + regdata;
        }
        /// <summary>
        /// Resets all Error Handling, and highlighting. It's called every time, because if something still isn't 
        /// correct, it will just go back and highlight it again.
        /// </summary>
        private void ResetFields()
        {
            Output.ForeColor = System.Drawing.Color.Black;
            OPcodeL.ForeColor = System.Drawing.Color.Black;
            RdL.ForeColor = System.Drawing.Color.Black;
            RtL.ForeColor = System.Drawing.Color.Black;
            RsL.ForeColor = System.Drawing.Color.Black;
            FunctL.ForeColor = System.Drawing.Color.Black;
            ShamtL.ForeColor = System.Drawing.Color.Black;
            ImmL.ForeColor = System.Drawing.Color.Black;
            AddrL.ForeColor = System.Drawing.Color.Black;
        }

        
    }
}
