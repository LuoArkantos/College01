using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Cls_Uteis
{
    public class Cls_Aluno
    {
        //Dados de aluno
        public string ID { get; set; }
        public string Nome { get; set; }
        public string NomeMae { get; set; }
        public string NomePai { get; set; }
        public string Nascimento { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public string Rua { get; set; }
        public string Cep { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }

        // notas
        public string Caderno { get; set; }
        public string Trabalhos { get; set; }
        public string Prova { get; set; }
        public string Complementar { get; set; }



        public Cls_Aluno()
        {
        
        }

        public static void LancarNotas(string id, string caderno, string trabalho, string prova, string complementar)
        {
            var caminhoDoArquivo = "boletin.csv"; //diretório para onde vai exportar os dados

            //new FileStream(caminhoDoArquivo, FileMode.Open);
            using (var fluxoDeArquivo = new FileStream(caminhoDoArquivo, FileMode.Append))
            {
                Cls_Aluno aluno = new Cls_Aluno();

                aluno.ID = id;

                aluno.Caderno = caderno;
                aluno.Trabalhos = trabalho;
                aluno.Prova = prova;
                aluno.Complementar = complementar;

                var dadosAluno = $"\n{id};{caderno};{trabalho};{prova};{complementar}";//Dado q vai ser colocado no documento

                var encoding = Encoding.UTF8; //cria encoding pra converter os bytes

                var bytes = encoding.GetBytes(dadosAluno);//vai converter os bytes para char

                fluxoDeArquivo.Write(bytes, 0, bytes.Length);//vai escrever a var bytes(que é os dados da conta convertidos para UTF8), desde o índice 0 do fluxo, até o tamanho do fluxo... usa length pq não sabemos o tamanho de bytes do fluxo.. assim pegamos o tamanho total.
            }
        }

        public static void CadastrarAluno(string id, string nome, string nomeMae, string nomePai, string nascimento, string telefone1, string telefone2, string rua, string numero, string cep, string bairro, string cidade, string uf)

        {
            
            var caminhoDoArquivo = "RelacaoDeAlunos.csv"; //diretório para onde vai exportar os dados

            //new FileStream(caminhoDoArquivo, FileMode.Open);
            using (var fluxoDeArquivo = new FileStream(caminhoDoArquivo, FileMode.Append))
            {
                Cls_Aluno aluno = new Cls_Aluno();

                aluno.ID = id;

                aluno.Nome=nome;
                aluno.NomeMae = nomeMae;
                aluno.NomePai = nomePai;
                aluno.Nascimento = nascimento;
                aluno.Telefone1 = telefone1;
                aluno.Telefone2 = telefone2;

                aluno.Rua = rua;
                aluno.Numero = numero;
                aluno.Cep = cep;
                aluno.Bairro = bairro;
                aluno.Cidade = cidade;
                aluno.Uf = uf;

                var dadosAluno = $"\n{id};{nome};{nomeMae};{nomePai};{nascimento};{telefone1};{telefone2};{rua};{numero};{cep};{bairro};{cidade};{uf}";//Dado q vai ser colocado no documento

                var encoding = Encoding.UTF8; //cria encoding pra converter os bytes

                var bytes = encoding.GetBytes(dadosAluno);//vai converter os bytes para char

                fluxoDeArquivo.Write(bytes, 0, bytes.Length);//vai escrever a var bytes(que é os dados da conta convertidos para UTF8), desde o índice 0 do fluxo, até o tamanho do fluxo... usa length pq não sabemos o tamanho de bytes do fluxo.. assim pegamos o tamanho total.
            }

        }

        public static string GerarId()
        {
            Random randNum = new Random();

            int id = randNum.Next(100000, 999999);
            return id.ToString();
        }

        public static void EncontrarAluno(string nomeBusca)
        {
            string localDoArquivo = "RelacaoDeAlunos.csv";
            string nomeDeBusca = nomeBusca;

            string[] linhas = File.ReadAllLines(localDoArquivo);//Vai criar a lista[] de linhas lendo as linhas do arquivo

            foreach(string linha in linhas)
            {
                string[] dado = linha.Split(';');

                if (dado[0] == nomeDeBusca)
                {
                    string nome = dado[0];
                    string nomeMae = dado[1];
                    string nomePai = dado[2];
                    string nascimento = dado[3];
                    string contato1 = dado[4];
                    string contato2 = dado[5];
                    string endereco = dado[6];

                    //Lbl_Nome.Text = nome;
                    //Lbl_NomeMae.Text = nomeMae;
                    //Lbl_NomePai.Text = nomePai;
                    //Lbl_Nascimento.Text = nascimento;
                    //Lbl_Contato1.Text = contato1;
                    //Lbl_Contato2.Text = contato2;
                    //Lbl_Endereco.Text = endereco;

                    break;
                }
            }
        }

        public static bool BuscarAluno(string busca)
        {
            var caminhoDoArquivo = "RelacaoDeAlunos.csv"; //diretório para onde vai exportar os dados
            var lista = new StreamReader(caminhoDoArquivo);
            lista.ReadLine();

            List<string> array = new List<string>
                {
 
                };
            while (!lista.EndOfStream)
            {
                var linha = lista.ReadLine();
                var campos = linha.Split(';');

                var id = campos[0];
                var nome = campos[1];
                var nomeMae = campos[2];
                var nomePai = campos[3];
                var nascimento = campos[4];
                var contato1 = campos[5];
                var contato2 = campos[6];
                var endereco = campos[7];

                array.Add(id);
                array.Add(nome);
                array.Add(nomeMae);
                array.Add(nomePai);
                array.Add(nascimento);
                array.Add(contato1);
                array.Add(contato2);
                array.Add(contato1);
                array.Add(endereco);
                
            }
            bool existe = false;
            for (int i = 0; i < array.Count; i++)
            {
                if (array[i] == busca)
                {
                    return existe = true;
                }
                else
                {
                    return existe = false;
                }
            }
            if(existe){
                return true;
            }
            else 
            { 
                return false; 
            }
            //lista.ReadLine();
        }
    }
}
