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

        //Chama Class
        public ClassListaFrutas _novaFruta = new ClassListaFrutas(new List<string> {""});

        //Botão Adicionar/Listar/Ordenar
        
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string nomeFruta = tbxFruta.Text.Trim();
            if (nomeFruta != "")
            {
                tbxFruta.Focus();
                _novaFruta.Adicionar(nomeFruta);
                MessageBox.Show($"A fruta {nomeFruta} foi adicionada com sucesso!", "Fruta adicionada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxFruta.Clear(); //Limpa
                lbxListaFruta.Items.Add(nomeFruta);
            }
            else
            {
                MessageBox.Show("Por favor, insira o nome de uma fruta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Botão Remover
        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (lbxListaFruta.SelectedItem != null) 
            {
                tbxFruta.Focus();
                string nomeFruta = lbxListaFruta.SelectedItem.ToString();
                MessageBox.Show($"A fruta {nomeFruta} foi removida.", "Fruta removida.");
                lbxListaFruta.Items.Remove(nomeFruta);
                _novaFruta.Remover(nomeFruta);
            }
            else
            {
                MessageBox.Show("Selecione uma fruta para remove-la","Aviso");
            }
        }

        private void tbxFruta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnAdicionar_Click(sender, e);
            }
        }

        
    }
}
    

