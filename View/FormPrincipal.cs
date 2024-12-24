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

        private void ActiveButton(Button frmAtivo)
        {
            foreach (Control ctrl in NavBar.Controls)
            {
                ctrl.ForeColor = Color.White;
            }
            frmAtivo.ForeColor = Color.Red;
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Ajuda_Popup(object sender, PopupEventArgs e)
        {

        }

        private void ajudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {            
            MessageBox.Show("Teste");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bombaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FormShow(new FrmBomba());
            
            
        }
    }
}
