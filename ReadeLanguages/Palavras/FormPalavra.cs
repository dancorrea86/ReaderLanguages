using ReadeLanguage.Data;
using ReadeLanguage.Data.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadeLanguages.Palavras
{
    public partial class FormPalavra : Form
    {
        public string palavra; 
        public FormPalavra(string palavra)
        {
            this.palavra = palavra;
            InitializeComponent();
        }

        private void FormPalavra_Load(object sender, EventArgs e)
        {
            lblPalavraTrad.Text = this.palavra;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        public void SalvarPalavraDb()
        {
            using (var contexto = new DicionarioDbContext())
            {

                if (contexto.PalavrasFrances.Where(s => s.PalavraFr == this.palavra).FirstOrDefault() == null)
                {
                    var palavra = new PalavraFrances();
                    palavra.PalavraFr = this.palavra;

                    contexto.PalavrasFrances.Add(palavra);
                    contexto.SaveChanges();
                }

                if (contexto.Palavras.Where(s => s.PalavraPt == this.palavra).FirstOrDefault() == null)
                {
                    var palavra = new Palavra();
                    palavra.PalavraPt = txtTraducao.Text;

                    contexto.Palavras.Add(palavra);
                    contexto.SaveChanges();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SalvarPalavraDb();
            Close();
        }
    }
}
