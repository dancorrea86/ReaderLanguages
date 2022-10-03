using ReadeLanguages.Palavras;
using System.Text.RegularExpressions;

namespace ReadeLanguages
{
    public partial class FormReader : Form
    {
        public FormReader()
        {
            InitializeComponent();
        }

        private void ChamaSalvarArquivo()
        {
            if (!string.IsNullOrEmpty(rtxtLeitor.Text))
            {
                if ((MessageBox.Show("Deseja Salvar o arquivo ?", "Salvar Arquivo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes))
                {
                    Salvar_Arquivo();
                }
            }
        }

        private void Salvar_Arquivo()
        {
            try
            {
                // Pega o nome do arquivo para salvar
                if (this.svdlg.ShowDialog() == DialogResult.OK)
                {
                    // abre um stream para escrita e cria um StreamWriter para implementar o stream
                    FileStream fs = new FileStream(svdlg.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter m_streamWriter = new StreamWriter(fs);
                    m_streamWriter.Flush();
                    // Escreve para o arquivo usando a classe StreamWriter
                    m_streamWriter.BaseStream.Seek(0, SeekOrigin.Begin);
                    // escreve no controle richtextbox
                    m_streamWriter.Write(this.rtxtLeitor.Text);
                    // fecha o arquivo
                    m_streamWriter.Flush();
                    m_streamWriter.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AbrirArquivo()
        {
            //define as propriedades do controle 
            //OpenFileDialog
            this.openFileDialog.Multiselect = true;
            this.openFileDialog.Title = "Selecionar Arquivo";
            openFileDialog.InitialDirectory = @"C:\Dados\";
            //filtra para exibir somente arquivos textos
            openFileDialog.Filter = "Images (*.TXT)|*.TXT|" + "All files (*.*)|*.*";
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.ReadOnlyChecked = true;
            openFileDialog.ShowReadOnly = true;
            DialogResult dr = this.openFileDialog.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader m_streamReader = new StreamReader(fs);
                    // Lê o arquivo usando a classe StreamReader
                    m_streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                    // Lê cada linha do stream e faz o parse até a última linha
                    this.rtxtLeitor.Text = "";
                    string strLine = m_streamReader.ReadLine();
                    while (strLine != null)
                    {
                        this.rtxtLeitor.Text += strLine + "\n";
                        strLine = m_streamReader.ReadLine();
                    }
                    // Fecha o stream
                    m_streamReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void SalvarPalavraDb()
        {
            
        }

        private void toolStripNovo_Click(object sender, EventArgs e)
        {
            ChamaSalvarArquivo();
            rtxtLeitor.Clear();
            rtxtLeitor.Focus();
        }

        private void mnuNovo_Click(object sender, EventArgs e)
        {
            ChamaSalvarArquivo();
            rtxtLeitor.Clear();
            rtxtLeitor.Focus();
        }

        public void MostrarPalavra(string palavra)
        {
            var m = new FormPalavra(palavra);
            m.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            ProcurarPalavra();

            //string textoLeitura = LimpezaTexto(rtxtLeitor.Text);
            //string[] palavrasTexto = textoLeitura.ToLower().Split(' ');
            //load();

        }

        public string LimpezaTexto(string textoLeitura)
        {
            string textoParaSanitizar = textoLeitura.ToLower();
            string[] caractIndesejaveis = { "?", "[", "]", ",", "!", "«", "»", "\n" };
                        
            foreach (string caract in caractIndesejaveis)
            {
                textoParaSanitizar = textoParaSanitizar.Replace(caract, "");
            }

            string textoSanitizado = textoParaSanitizar;

            textoSanitizado = textoParaSanitizar.Replace("  ", " ");

            return textoSanitizado;
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            load();
        }

        public void ProcurarPalavra()
        {
            string[] wordToSearch = { "Game", "français", "dans" };

            foreach(string word in wordToSearch)
            {
                string primeiraLetraPalavra = word.Substring(0, 1);

                string teste = word.Substring(1, word.Length - 1);

                string inicioRegex = string.Format(@"[{0}-{1}]", primeiraLetraPalavra.ToUpper(), primeiraLetraPalavra.ToLower());
                string regexProcurar = string.Format(@"{0}{1}", inicioRegex, teste);


                Regex regex = new Regex(regexProcurar);
                MatchCollection matches = regex.Matches(rtxtLeitor.Text);
               //rtxtLeitor.SelectAll();
                //rtxtLeitor.SelectionBackColor = rtxtLeitor.BackColor;
                foreach (Match match in matches)
                {
                    rtxtLeitor.Select(match.Index, match.Length);
                    rtxtLeitor.SelectionBackColor = Color.Yellow;
                }
            }

        }

        public void load()
        {
            rtxtLeitor.Font = new Font("Consolas", 18f, FontStyle.Bold);
            rtxtLeitor.BackColor = Color.AliceBlue;
            string[] words =
            {
                "Dot",
                "Net",
                "Perls",
                "is",
                "a",
                "nice",
                "website."
            };
            Color[] colors =
            {
                Color.Aqua,
                Color.CadetBlue,
                Color.Cornsilk,
                Color.Gold,
                Color.HotPink,
                Color.Lavender,
                Color.Moccasin
            };
            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                Color color = colors[i];
                {
                    rtxtLeitor.SelectionBackColor = color;
                    rtxtLeitor.AppendText(word);
                    rtxtLeitor.SelectionBackColor = Color.AliceBlue;
                    rtxtLeitor.AppendText(" ");
                }
            }
        }

        private void rtxtLeitor_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            MostrarPalavra(rtxtLeitor.SelectedText);
        }


    }
}