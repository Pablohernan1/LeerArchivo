using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeerArchivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
            this.CenterToScreen();
        }



        private void button1_Click(object sender, EventArgs e)
        {

            int boleta = 0;
            int cheque = 0;
            int contador = 1;
            int contador2 = 1;
            int acumuladorBoletas = 0;
            int acumuladorCheques = 0;
            string line;

  
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"C:\\Users\\Pabli\\Desktop\\CABTDCEIP.txt");
            while ((line = file.ReadLine()) != null)
            {

                
                if (line.Length == 183)
                {
                    boleta++;
                    
                    //Agregamos nuevo renglon
                    int n = dtgvProductos.Rows.Add();
                    
                    //Colocamos info
                    dtgvProductos.Rows[n].HeaderCell.Value = contador.ToString();
                    dtgvProductos.Rows[n].Cells[0].Value = line.Substring(0, 3);
                    dtgvProductos.Rows[n].Cells[1].Value = line.Substring(3, 3);
                    dtgvProductos.Rows[n].Cells[2].Value = line.Substring(7, 8);
                    dtgvProductos.Rows[n].Cells[3].Value = line.Substring(16, 9);
                    dtgvProductos.Rows[n].Cells[4].Value = line.Substring(25, 3);
                    dtgvProductos.Rows[n].Cells[5].Value = line.Substring(28, 9);
                    dtgvProductos.Rows[n].Cells[6].Value = line.Substring(37, 15);
                    dtgvProductos.Rows[n].Cells[7].Value = line.Substring(52, 15);
                    dtgvProductos.Rows[n].Cells[8].Value = line.Substring(67, 3);
                    dtgvProductos.Rows[n].Cells[9].Value = line.Substring(70, 4);
                    dtgvProductos.Rows[n].Cells[10].Value = line.Substring(74, 8);
                    dtgvProductos.Rows[n].Cells[11].Value = line.Substring(82, 8);

                    dtgvProductos.Rows[n].Cells[12].Value = line.Substring(90, 18);
                    acumuladorBoletas = acumuladorBoletas + Int32.Parse(line.Substring(90, 18));

                    dtgvProductos.Rows[n].Cells[13].Value = line.Substring(108, 18);
                    dtgvProductos.Rows[n].Cells[14].Value = line.Substring(126, 3);
                    dtgvProductos.Rows[n].Cells[15].Value = line.Substring(129, 3);
                    dtgvProductos.Rows[n].Cells[16].Value = line.Substring(132, 4);
                    dtgvProductos.Rows[n].Cells[17].Value = line.Substring(136, 8);
                    dtgvProductos.Rows[n].Cells[18].Value = line.Substring(144, 4);
                    dtgvProductos.Rows[n].Cells[19].Value = line.Substring(148, 4);
                    dtgvProductos.Rows[n].Cells[20].Value = line.Substring(152, 9);
                    dtgvProductos.Rows[n].Cells[21].Value = line.Substring(161, 3);
                    dtgvProductos.Rows[n].Cells[22].Value = line.Substring(164, 3);
                    dtgvProductos.Rows[n].Cells[23].Value = line.Substring(167, 16);
                    contador++;

                }
                
                if (line.Length == 395)
                {
                    //Agregamos nuevo renglon
                    int p = dgvtCheque.Rows.Add();

                    //Colocamos info
                    dgvtCheque.Rows[p].HeaderCell.Value = contador2.ToString();
                    dgvtCheque.Rows[p].Cells[0].Value = line.Substring(0, 3);
                    dgvtCheque.Rows[p].Cells[1].Value = line.Substring(3, 3);
                    dgvtCheque.Rows[p].Cells[2].Value = line.Substring(6, 9);
                    dgvtCheque.Rows[p].Cells[3].Value = line.Substring(15, 10);
                    dgvtCheque.Rows[p].Cells[4].Value = line.Substring(25, 3);
                    dgvtCheque.Rows[p].Cells[5].Value = line.Substring(28, 9);
                    dgvtCheque.Rows[p].Cells[6].Value = line.Substring(37, 15);
                    dgvtCheque.Rows[p].Cells[7].Value = line.Substring(52, 15);
                    dgvtCheque.Rows[p].Cells[8].Value = line.Substring(67, 3);
                    dgvtCheque.Rows[p].Cells[9].Value = line.Substring(70, 3);
                    dgvtCheque.Rows[p].Cells[10].Value = line.Substring(73, 12);
                    dgvtCheque.Rows[p].Cells[11].Value = line.Substring(85, 3);
                    dgvtCheque.Rows[p].Cells[12].Value = line.Substring(88, 15);
                    dgvtCheque.Rows[p].Cells[13].Value = line.Substring(103, 3);
                    dgvtCheque.Rows[p].Cells[14].Value = line.Substring(106, 3);
                    dgvtCheque.Rows[p].Cells[15].Value = line.Substring(109, 3);
                    dgvtCheque.Rows[p].Cells[16].Value = line.Substring(112, 3);
                    dgvtCheque.Rows[p].Cells[17].Value = line.Substring(115, 3);
                    dgvtCheque.Rows[p].Cells[18].Value = line.Substring(118, 4);
                    dgvtCheque.Rows[p].Cells[19].Value = line.Substring(122, 8);
                    dgvtCheque.Rows[p].Cells[20].Value = line.Substring(130, 8);
                    dgvtCheque.Rows[p].Cells[21].Value = line.Substring(138, 1);

                    dgvtCheque.Rows[p].Cells[22].Value = line.Substring(139, 18);
                    
                    acumuladorCheques = acumuladorCheques + Int32.Parse(line.Substring(139, 18));

                    dgvtCheque.Rows[p].Cells[23].Value = line.Substring(157, 18);
                    dgvtCheque.Rows[p].Cells[24].Value = line.Substring(175, 3);
                    dgvtCheque.Rows[p].Cells[25].Value = line.Substring(178, 3);
                    dgvtCheque.Rows[p].Cells[26].Value = line.Substring(181, 3);
                    dgvtCheque.Rows[p].Cells[27].Value = line.Substring(184, 9);
                    dgvtCheque.Rows[p].Cells[28].Value = line.Substring(193, 4);
                    dgvtCheque.Rows[p].Cells[29].Value = line.Substring(197, 4);
                    dgvtCheque.Rows[p].Cells[30].Value = line.Substring(201, 9);
                    dgvtCheque.Rows[p].Cells[31].Value = line.Substring(210, 3);
                    dgvtCheque.Rows[p].Cells[32].Value = line.Substring(213, 3);
                    dgvtCheque.Rows[p].Cells[33].Value = line.Substring(216, 16);

                    contador2++;
                    cheque++;
                }
            }
            lblBoletas.Text = boleta.ToString();
            lblCheque.Text = cheque.ToString();
            file.Close();
            button1.Enabled = false;
            button2.Enabled = true;
            //Buscamos la cantidad de digitos
            int posicion = acumuladorCheques.ToString().Length;
            int posicion2 = acumuladorCheques.ToString().Length;
            lblTotal.Text = acumuladorCheques.ToString().Insert(posicion - 2, ".");
            lblTotalBol.Text = acumuladorBoletas.ToString().Insert(posicion2 - 2, ".");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvtCheque.Rows.Clear();
            dtgvProductos.Rows.Clear();
            button1.Enabled = true;
            button2.Enabled = false;
            lblTotal.Text = "";
            lblTotalBol.Text = "";
            lblBoletas.Text = "";
            lblCheque.Text = "";
        }
    }
}
