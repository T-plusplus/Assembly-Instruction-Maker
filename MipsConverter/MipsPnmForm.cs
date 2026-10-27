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
    public partial class MipsPnmForm : Form
    {
        public MipsPnmForm()
        {
            InitializeComponent();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            string toParse = InstrInputTB.Text;
            //decode the opcode
            String[] parsing = toParse.Split(' ');
            StringBuilder sb = new StringBuilder();
            sb.Append(parsing[0]);
            //decode the register data
        }
    }
}
