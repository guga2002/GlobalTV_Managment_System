using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobalTV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void globalTVBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.globalTVBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbMarjDataSet);


            //if (workTextBox.Text.Length == 0)
            //{
            //    MessageBox.Show("unda  shemoitanot aqtivoba");
            //    {
            //        Form1_Load(sender, e);
            //    }
            //}
            //if (channelComboBox.SelectedIndex == -1 || workerComboBox.SelectedIndex == -1)
            //{
            //    MessageBox.Show("gtxovt cariels nu datovet momushaves an  arkhis dasaxelebas");
            //    Form1_Load(sender, e);
            //}
            //string[] st = startTextBox.Text.Split(':');
            //string[] st1 = endTextBox.Text.Split(':');
            //if (st.Length != 2 || st1.Length != 2)
            //{
            //    MessageBox.Show("araswori formatit iyo shemotanili dro amitom  ver chaemata chanaweri");
            //    Form1_Load(sender, e);
            //}
            //if (st[0].Length > 2 || st[1].Length > 2 || st1[0].Length > 2 || st1[1].Length > 2)
            //{
            //    MessageBox.Show("dasrulebis an dawyebis dro araswor formatshi iyo");
            //    Form1_Load(sender, e);
            //}
            //int hr1 = int.Parse(st[0]);
            //int hr2 = int.Parse(st1[0]);
            //int min1 = int.Parse(st[0]);
            //int min2 = int.Parse(st1[0]);

            //if (hr1 > 24 || hr1 < 0 || hr2 > 24 || hr2 < 0 || min1 > 60 || min1 < 0 || min2 > 60 || min2 < 0)
            //{
            //    MessageBox.Show("out of range");
            //    Form1_Load(sender, e);
            //}
            //if (hr2 < hr1)
            //{
            //    MessageBox.Show("dawyebis dro unda iyos naklebi damtavrebis droze");
            //    Form1_Load(sender, e);
            //}
            //else if (min2 < min1)
            //{
            //    MessageBox.Show("dawyebis dro unda iyos naklebi damtavrebis droze");
            //    Form1_Load(sender, e);
            //}

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbMarjDataSet.GlobalTV' table. You can move, or remove it, as needed.
     
            this.globalTVTableAdapter.Fill(this.dbMarjDataSet.GlobalTV);
       

        }
      

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            

        }

        private void startTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void endTextBox_TextChanged(object sender, EventArgs e)
        {
          
         
        }

        private void comments_P_S_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void workTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void channelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void workerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void channelLabel_Click(object sender, EventArgs e)
        {

        }

        private void dateLabel_Click(object sender, EventArgs e)
        {

        }

        private void startLabel_Click(object sender, EventArgs e)
        {

        }

        private void endLabel_Click(object sender, EventArgs e)
        {

        }

        private void comments_P_S_Label_Click(object sender, EventArgs e)
        {

        }

        private void workerLabel_Click(object sender, EventArgs e)
        {

        }

        private void workLabel_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void globalTVDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            dbMarjDataSet.GlobalTV.IdColumn.SetOrdinal(0);
        }

        private void idLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
