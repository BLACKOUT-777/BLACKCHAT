using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace BLACKCHAT
{
    public partial class Form1 : Form
    {
        private Dictionary<string, List<string>> respostas;
        private string arquivoJson = @"ARCHIVE_DIRECTORY";
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            CarregarRespostas();
        }

        private void CarregarRespostas() // 1
        {
            if (File.Exists(arquivoJson))
            {
                try
                {
                    var json = File.ReadAllText(arquivoJson);
                    respostas = JsonConvert.DeserializeObject<Dictionary<string, List<string>>>(json);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao ler o arquivo JSON: " + ex.Message);
                    respostas = new Dictionary<string, List<string>>();
                }
            }
            else
            {
                respostas = new Dictionary<string, List<string>>();
            }
        }

        private void SalvarRespostas() // 2
        {
            try
            {
                var json = JsonConvert.SerializeObject(respostas);
                File.WriteAllText(arquivoJson, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao escrever no arquivo JSON: " + ex.Message);
            }
        }

        private void buttonEnviar_Click(object sender, EventArgs e) // 3
        {
            var fraseUsuario = txtFrase.Text.Trim().ToLowerInvariant();
            var respostasEncontradas = new List<string>();

            var palavras = fraseUsuario.Split(' ', ',', '.', '´', '[', ']', '?', '_');
            foreach (var palavra in palavras) 
            {
                if (respostas.ContainsKey(palavra))
                {
                    var respostasPossiveis = respostas[palavra];
                    var respostaAleatoria = respostasPossiveis[random.Next(respostasPossiveis.Count)];
                    respostasEncontradas.Add(respostaAleatoria);
                }
            }

            if (respostasEncontradas.Count > 0)
            {
                foreach (var resposta in respostasEncontradas)
                {
					
                    if (resposta.Length >= 30)
                    {
                        listBoxRespostas.HorizontalScrollbar = true;
                        listBoxRespostas.Items.Add("user: " + txtFrase.Text);
                        listBoxRespostas.Items.Add("chat: " + resposta);
                        txtFrase.Clear();
                    }
                    else
                    {
                        listBoxRespostas.HorizontalScrollbar = false;
                        listBoxRespostas.Items.Add("user: " + txtFrase.Text);
                        listBoxRespostas.Items.Add("chat: " + resposta);
                        txtFrase.Clear();
                    }
                }
            }
            else if (string.IsNullOrEmpty(txtFrase.Text))
            {
                MessageBox.Show("É mudo, chapa?");
            }
            else
            {
                MessageBox.Show("NÃO HÁ NADA NO BANCO QUE RESPONDA SUA PERGUNTA");
            }
        }

        private void txtFrase_KeyPress(object sender, KeyPressEventArgs e) // 4
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                buttonEnviar_Click(sender, e);
            }
        }

        private void AdicionarResposta(string palavraChave, string resposta) // 5
        {
            if (respostas.ContainsKey(palavraChave))
            {
                respostas[palavraChave].Add(resposta);
            }
            else
            {
                respostas[palavraChave] = new List<string> { resposta };
            }
            SalvarRespostas();
        }

        private void btnAdd_Click(object sender, EventArgs e) // 6
        {
            AdicionarResposta(PCtxt.Text, Restxt.Text);
            PCtxt.Clear();
            Restxt.Clear();
        }
    }
}

