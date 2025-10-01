using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryFrutas;

namespace WindowsFormsFrutas
{
    public partial class FormFruta : Form
    {
        public FormFruta()
        {
            InitializeComponent();
        }


        public ClassListaFrutas _fruta = new ClassListaFrutas("");

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string nomeFruta = tbxFruta.Text.Trim();

            if (nomeFruta != "")
            {
                ClassListaFrutas novaFruta = new ClassListaFrutas(nomeFruta);
                _fruta.Adicionar(novaFruta);
                MessageBox.Show($"A fruta {nomeFruta} foi adicionada com sucesso!", "Fruta adicionada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxFruta.Clear(); //Limpa
                tbxFruta.Focus();
                
            }
            else
            {
                MessageBox.Show("Por favor, insira o nome de uma fruta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            
               
            
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            string nomeFruta = tbxFruta.Text.Trim();

            if (lbxListaFruta.SelectedItem != null) 
            {
                MessageBox.Show($"A fruta {lbxListaFruta} foi removida.", "Fruta removida.");
            }
            else
            {
                MessageBox.Show("Selecione uma fruta para remove-la","Aviso");
            }
        }

        private void FormFruta_Load(object sender, EventArgs e)
        {

        }
    }
}
    

