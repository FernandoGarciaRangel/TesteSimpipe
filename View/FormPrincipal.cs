using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TesteSimpipe.Models;

namespace TesteSimpipe
{
    public partial class FormPrincipal: Form
    {
        private Form frmAtivo;
        public FormPrincipal()
        {
            InitializeComponent();
           
        }

        private void FormShow(Form frm)
        {
            ActiveFormClose();
            frmAtivo = frm;
            frm.TopLevel = false;
            panelForm.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void ActiveFormClose()
        {
            if (frmAtivo != null)
            {
                frmAtivo.Close();
            }
            }
        

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

     

        private void ajudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {            
            MessageBox.Show("Clique em Bomba ou válvula para iniciar os cálculos, logo após insira os dados para calculo. Letras vermelhas são variáveis de saída, e as azuis são variáveis de entrada.");

        }


        private void bombaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FormShow(new FrmBomba());
            
            
        }

        private void válvulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormShow(new FrmValvula());
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
