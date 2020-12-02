using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diagram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.Units' table. You can move, or remove it, as needed.
            this.unitsTableAdapter.Fill(this.database1DataSet1.Units);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                unitsBindingSource.EndEdit();
                unitsTableAdapter.Update(database1DataSet1.Units);
                MessageBox.Show("Your data has been saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /* chart1.Series["Date"].XValueMember = "Date";
             chart1.Series["Date"].YValueMembers = "Date";*/
             
            chart1.Series[1].XValueMember = "Date";
            chart1.Series[1].YValueMembers = "money";
            /*
            int.Parse("money".ToString());*/
            
            chart1.DataSource = database1DataSet1.Units;
            chart1.DataBind();
            /*
            chart2.Series[0].XValueMember = chart1.Series[1].XValueMember;
            chart2.Series[0].YValueMembers = chart1.Series[1].YValueMembers - */
        }
    }
}
