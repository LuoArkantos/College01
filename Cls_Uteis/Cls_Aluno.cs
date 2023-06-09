﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Cls_Uteis
{
    public class Cls_Aluno
    {
        public string Nome { get; set; }
        public string NomeMae { get; set; }
        public string NomePai { get; set; }
        public string Nascimento { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public string Endereco { get; set; }

        public Cls_Aluno()
        {
            //Nome = nome;
            //NomeMae = nomeMae;
            //NomePai = nomePai;
            //Nascimento = nascimento;
            //Telefone1 = telefone1;
            //Telefone2 = telefone2;
            //Endereco = endereco;
 
    }
        

        
        public static void CadastrarAluno(string nome, string nomeMae, string nomePai, string nascimento, string telefone1, string telefone2, string endereco)

        {
            
            var caminhoDoArquivo = "RelacaoDeAlunos.csv"; //diretório para onde vai exportar os dados

            //new FileStream(caminhoDoArquivo, FileMode.Open);
            using (var fluxoDeArquivo = new FileStream(caminhoDoArquivo, FileMode.Append))
            {
                Cls_Aluno aluno = new Cls_Aluno();
                aluno.Nome=nome;
                aluno.NomeMae = nomeMae;
                aluno.NomePai = nomePai;
                aluno.Nascimento = nascimento;
                aluno.Telefone1 = telefone1;
                aluno.Telefone2 = telefone2;
                aluno.Endereco = endereco;

                var dadosAluno = $"\n{nome};{nomeMae};{nomePai};{nascimento};{telefone1};{telefone2};{endereco}";//Dado q vai ser colocado no documento

                var encoding = Encoding.UTF8; //cria encoding pra converter os bytes

                var bytes = encoding.GetBytes(dadosAluno);//vai converter os bytes para char

                fluxoDeArquivo.Write(bytes, 0, bytes.Length);//vai escrever a var bytes(que é os dados da conta convertidos para UTF8), desde o índice 0 do fluxo, até o tamanho do fluxo... usa length pq não sabemos o tamanho de bytes do fluxo.. assim pegamos o tamanho total.
            }

        }
        public static void MostrarAluno()
        {
            
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

                var nome = campos[0];
                var nomeMae = campos[1];
                var nomePai = campos[2];
                var nascimento = campos[3];
                var contato1 = campos[4];
                var contato2 = campos[5];
                var endereco = campos[6];

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
