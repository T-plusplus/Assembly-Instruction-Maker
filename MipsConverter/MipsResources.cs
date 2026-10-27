using System;
namespace MipsConverter
{
    public class MipsResources
    {
        /// <summary>
        /// The string value for the $zero register. Its decimal location in instruction decode is 0, and its hex location is 0. 
        /// This register is frequently used as a comparator.
        /// </summary>
        private static string zero = "zero";
        /// <summary>
        /// The string value for the $at register. Its decimal location in instruction decode is 1, and its hex location is 1. 
        /// $at means Assembler Temporary. The $at register is used to store extra instructions used in pseudoinstructions. 
        /// So for loading a double word, while the lui instruction is executing, the ori instruction will be stored in the $at register.
        /// </summary>
        private static string at = "at";
        private static string v0 = "v0";
        private static string v1 = "v1";
        /// <summary>
        /// The string value for the $a0 register. Its decimal location in instruction decode is 4, and its hex location is 4. 
        /// $a0 is used for function arguments.
        /// </summary>
        private static string a0 = "a0";
        /// <summary>
        /// The string value for the $a1 register. Its decimal location in instruction decode is 5, and its hex location is 5. 
        /// $a1 is used for function arguments.
        /// </summary>
        private static string a1 = "a1";
        /// <summary>
        /// The string value for the $a2 register. Its decimal location in instruction decode is 6, and its hex location is 6. 
        /// $a2 is used for function arguments.
        /// </summary>
        private static string a2 = "a2";
        /// <summary>
        /// The string value for the $a3 register. Its decimal location in instruction decode is 7, and its hex location is 7. 
        /// $a3 is used for function arguments.
        /// </summary>
        private static string a3 = "a3";
        private static string t0 = "t0";
        private static string t1 = "t1";
        private static string t2 = "t2";
        private static string t3 = "t3";
        private static string t4 = "t4";
        private static string t5 = "t5";
        private static string t6 = "t6";
        private static string t7 = "t7";
        private static string s0 = "s0";
        private static string s1 = "s1";
        private static string s2 = "s2";
        private static string s3 = "s3";
        private static string s4 = "s4";
        private static string s5 = "s5";
        private static string s6 = "s6";
        private static string s7 = "s7";
        private static string t8 = "t8";
        private static string t9 = "t9";
        private static string k0 = "k0";
        private static string k1 = "k1";
        private static string gp = "gp";
        /// <summary>
        /// The string value for the $sp register. Its decimal location in instruction decode is 29, and its hex location is 1D. 
        /// $sp means Stack Pointer. The $sp register is used to store temporary values when all the temporaries are full. The 
        /// stack is stored in the top of the memory.
        /// </summary>
        private static string sp = "sp";
        private static string fp = "fp";
        /// <summary>
        /// The string value for the $ra register. Its decimal location in instruction decode is 31, and its hex location is 1F. 
        /// $ra means Return Address. The $ra register is used to execute a function, and then specify where to return to. For example, 
        /// jal stores the PC at that point in the code, and then jumps to the function being called. Then, when that function is done 
        /// being executed, we will call jr $ra, to return to continue the part of the code we jal-ed away from.
        /// </summary>
        private static string ra = "ra";
        /// <summary>
        /// Gets the name of the register using the register's decimal location. 
        /// </summary>
        /// <param name="decRegNum">The decimal location of the register</param>
        /// <returns>The name of the register</returns>
        public static string GetRegisterDescr(int decRegNum)
        {
            switch (decRegNum)
            {
                case 0:
                    return zero;
                case 1:
                    return at;
                case 2:
                    return v0;
                case 3:
                    return v1;
                case 4:
                    return a0;
                case 5:
                    return a1;
                case 6:
                    return a2;
                case 7:
                    return a3;
                case 8:
                    return t0;
                case 9:
                    return t1;
                case 10:
                    return t2;
                case 11:
                    return t3;
                case 12:
                    return t4;
                case 13:
                    return t5;
                case 14:
                    return t6;
                case 15:
                    return t7;
                case 16:
                    return s0;
                case 17:
                    return s1;
                case 18:
                    return s2;
                case 19:
                    return s3;
                case 20:
                    return s4;
                case 21:
                    return s5;
                case 22:
                    return s6;
                case 23:
                    return s7;
                case 24:
                    return t8;
                case 25:
                    return t9;
                case 26:
                    return k0;
                case 27:
                    return k1;
                case 28:
                    return gp;
                case 29:
                    return sp;
                case 30:
                    return fp;
                case 31:
                    return ra;
                default:
                    return "0"; //rewrite this case to do error handling. If someone doesn't choose a register that's real, 
                                //somewhere an expception will be thrown, caught, and print "Invalid Register".
            }

        }
        /// <summary>
        /// Gets the name of the operation being performed. If the instruction doesn't exist, or in another sense, has an 
        /// illegal OpCode, then this will return "No Op".
        /// </summary>
        /// <param name="opHex">The opCode in Hex. All zeros in the OpCode(in the case of Mips) is associated with R type 
        /// instructions. If it is an R-type, then we will also use the funct parameter to determine the operation being 
        /// performed.</param>
        /// <param name="functHex">The funct field in Hex. When we have an R-type instruction, we will use this to figure 
        /// out what operation is being performed.</param>
        /// <returns></returns>
        public static string GetOp(string opHex, string functHex)
        {
            switch (opHex)
            {
                case "00":
                    {
                        switch (functHex)
                        {

                            case "00"://00 0000
                                return "sll";
                            case "02"://00 0010
                                return "srl";
                            case "03"://00 0011
                                return "sra";
                            case "04"://00 0100
                                return "sllv";
                            case "06"://00 0110
                                return "srlv";
                            case "07"://00 0111
                                return "srav";
                            case "08"://00 1000
                                return "jr";
                            case "20"://10 0000
                                return "add";
                            case "21"://10 0001
                                return "addu";
                            case "22"://10 0010
                                return "sub";
                            case "23"://10 0011
                                return "subu";
                            case "24"://10 0100
                                return "and";
                            case "25"://10 0101
                                return "or";
                            case "27"://10 0111
                                return "nor";
                            case "2A"://10 1010
                                return "add";
                            case "2B"://10 1011
                                return "add";
                            case "2C"://10 1100
                                return "add";
                            //single digit entry
                            case "0"://00 0000
                                return "sll";
                            case "2"://00 0010
                                return "srl";
                            case "3"://00 0011
                                return "sra";
                            case "4"://00 0100
                                return "sllv";
                            case "6"://00 0110
                                return "srlv";
                            case "7"://00 0111
                                return "srav";
                            case "8"://00 1000
                                return "jr";
                            default:
                                return "No Op...";
                        }
                    }
                case "02"://00 0010
                    return "j";
                case "03"://00 0011
                    return "jal";
                case "04"://00 0100
                    return "beq";
                case "05"://00 0101
                    return "bne";
                case "08"://00 1000
                    return "addi";
                case "09"://00 1001
                    return "addiu";
                case "0A"://00 1010
                    return "slti";
                case "0B"://00 1011
                    return "sltiu";
                case "0C"://00 1100
                    return "andi";
                case "0D"://00 1101
                    return "ori";
                case "0E"://00 1110
                    return "xori";
                case "0F"://00 1111
                    return "lui";
                case "23"://10 0011
                    return "lw";
                case "2B"://10 1011
                    return "sw";
                //single digit entry
                case "2"://00 0010
                    return "j";
                case "3"://00 0011
                    return "jal";
                case "4"://00 0100
                    return "beq";
                case "5"://00 0101
                    return "bne";
                case "8"://00 1000
                    return "addi";
                case "9"://00 1001
                    return "addiu";
                case "A"://00 1010
                    return "slti";
                case "B"://00 1011
                    return "sltiu";
                case "C"://00 1100
                    return "andi";
                case "D"://00 1101
                    return "ori";
                case "E"://00 1110
                    return "xori";
                case "F"://00 1111
                    return "lui";
                default:
                    return "No Op";
            }
        }
    }
}
