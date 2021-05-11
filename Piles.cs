using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstacApp
{
    public partial class Form_Piles : Form
    {
        public Form_Piles()
        {
            InitializeComponent();
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox_bottleneckFlag.Checked == true)
            {
                textBox_bottleneckFinalDiameter.Visible = true;
                label_bottleneckFinalDiameter.Visible = true;
                textBox_bottleneckLength.Visible = true;
                label_bottleneckLength.Visible = true;
            }
            else
            {
                textBox_bottleneckFinalDiameter.Visible = false;
                label_bottleneckFinalDiameter.Visible = false;
                textBox_bottleneckLength.Visible = false;
                label_bottleneckLength.Visible = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_calculateResults_Click(object sender, EventArgs e)
        {
            try
            {
                textBox_results.Text = FillCheck();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message, "Erro");
                textBox_results.Clear();
            }
        }

        private string FillCheck()
        {
            string check = "OK";
            double db;

            if(textBox_pileName.Text == "")
            {
                throw new Exception("Nome da estaca não informado");
            }

            if (textBox_length.Text == "" || double.TryParse(textBox_length.Text, out db) == false)
            {
                throw new Exception("Comprimento da estaca é inválido! \n Não pode ser vazio e precisa ser um valor numérico.");
            }

            if (textBox_diameter.Text == "" || double.TryParse(textBox_diameter.Text, out db) == false)
            {
                throw new Exception("Diâmetro da estaca é inválido! \n Não pode ser vazio e precisa ser um valor numérico.");
            }

            if (checkBox_bottleneckFlag.Checked && (textBox_bottleneckFinalDiameter.Text == "" || textBox_bottleneckLength.Text == "" || double.TryParse(textBox_bottleneckFinalDiameter.Text, out db) == false  || double.TryParse(textBox_bottleneckLength.Text, out db) == false))
            {
                throw new Exception("Os valores para o afunilamento precisam ser corretamente informados! \n Não pode estar vazios e precisam ser valores numéricos.");
            }

            return check;
        }
    }
}
