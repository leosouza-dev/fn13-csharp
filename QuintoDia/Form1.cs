using QuintoDia.Extensions;
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

namespace QuintoDia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            List<string> clientes = new List<string>();

            List<string> devedores = new List<string>();
            devedores.Add("Leonardo");
            devedores.Add("Caio");
            devedores.Add("Lucas");
            devedores.Add("Larissa");
            devedores.Add("Leonardo");
            devedores.Add("Gabriela");

            var devedor1 = devedores[0];

            foreach (var item in devedores)
            {
                MessageBox.Show(item);
            }

            if (devedores.Contains("Jose"))
            {
                MessageBox.Show("Cliente Devedor");
            }
            else
            {
                clientes.Add("Jose");
                MessageBox.Show("Cliente Adicionado");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> clientes = new List<string>();

            HashSet<string> devedores = new HashSet<string>();
            devedores.Add("Leonardo");
            devedores.Add("Caio");
            devedores.Add("Lucas");
            devedores.Add("Larissa");
            devedores.Add("Leonardo");
            devedores.Add("Gabriela");

            foreach (var item in devedores)
            {
                MessageBox.Show(item);
            }

            if (devedores.Contains("Gabriela"))
            {
                MessageBox.Show("Cliente Devedor");
            }
            else
            {
                clientes.Add("Gabriela");
                MessageBox.Show("Cliente Adicionado");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HashSet<string> devedores = new HashSet<string>();
            devedores.Add("Leonardo");
            devedores.Add("Caio");
            devedores.Add("Lucas");
            devedores.Add("Larissa");
            devedores.Add("Leonardo");
            devedores.Add("Gabriela");

            foreach (var item in devedores)
            {
                MessageBox.Show(item);
            }

            MessageBox.Show("Numero de devedores: " + devedores.Count);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SortedSet<string> devedores = new SortedSet<string>();
            devedores.Add("Leonardo");
            devedores.Add("Caio");
            devedores.Add("Lucas");
            devedores.Add("Larissa");
            devedores.Add("Leonardo");
            devedores.Add("Gabriela");
            devedores.Add("Alan");


            foreach (var item in devedores)
            {
                MessageBox.Show(item);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<Conta> contas = new List<Conta>
            {
                new Conta("Caio"),
                new Conta("Leonardo"),
                new Conta("José"),
                new Conta("Antonio"),
                new Conta("Darci"),
            };

            string titularDaBusca = "Darci";
            Conta contaEsperada = null;

            foreach (var conta in contas)
            {
                if (conta.Titular.Equals(titularDaBusca))
                {
                    contaEsperada = conta;
                    break;
                }
            }

            MessageBox.Show("Resultado: " + contaEsperada.Titular);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var conta1 = new Conta("Maria");
            var conta2 = new Conta("José");
            var conta3 = new Conta("Pedro");

            //Dictinary<key, Value>
            Dictionary<string, Conta> dicionarioDeConta = new Dictionary<string, Conta>();
            dicionarioDeConta.Add(conta1.Titular, conta1);
            dicionarioDeConta.Add(conta2.Titular, conta2);
            dicionarioDeConta.Add(conta3.Titular, conta3);


            Conta contaEsperada = dicionarioDeConta["Pedro"];
            MessageBox.Show("Resultado: " + contaEsperada.Titular);

            foreach (var conta in dicionarioDeConta)
            {
                MessageBox.Show("A chave é: " + conta.Key);
                MessageBox.Show("O valor é: " + conta.Value);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var contas = new List<Conta>
            {
                new Conta("Mariana", 100),
                new Conta("Caio", 2500),
                new Conta("Rodrigo", 300),
                new Conta("Larissa", 3000),
                new Conta("Gabriela", 200),
            };

            var listaFiltrada = new List<Conta>();

            foreach (var conta in contas)
            {
                if(conta.Saldo > 2000)
                {
                    listaFiltrada.Add(conta);
                }
            }

            foreach (var conta in listaFiltrada)
            {
                MessageBox.Show(conta.Titular);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var contas = new List<Conta>
            {
                new Conta("Mariana", 100),
                new Conta("Caio", 2500),
                new Conta("Rodrigo", 300),
                new Conta("Larissa", 3000),
                new Conta("Gabriela", 200),
            };

            var listaFiltrada = contas.Where((Conta c) => { return c.Saldo > 2000; });

            foreach (var conta in listaFiltrada)
            {
                MessageBox.Show(conta.Titular);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var contas = new List<Conta>
            {
                new Conta("Mariana", 100),
                new Conta("Caio", 2500),
                new Conta("Rodrigo", 300),
                new Conta("Larissa", 3000),
                new Conta("Gabriela", 200),
            };

            var listaFiltrada = contas.Where(c => c.Saldo > 2000);

            foreach (var conta in listaFiltrada)
            {
                MessageBox.Show(conta.Titular);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var contas = new List<Conta>
            {
                new Conta("Mariana", 100),
                new Conta("Caio", 2500),
                new Conta("Rodrigo", 300),
                new Conta("Larissa", 3000),
                new Conta("Gabriela", 200),
            };

            var saldoTotal = contas.Sum(c => c.Saldo);

            MessageBox.Show("Saldo totak: " + saldoTotal);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var contas = new List<Conta>
            {
                new Conta("Mariana", 100),
                new Conta("Caio", 2500),
                new Conta("Rodrigo", 300),
                new Conta("Larissa", 3000),
                new Conta("Gabriela", 200),
            };

            var listaFiltrada = from c in contas
                              where c.Saldo > 2000
                              select c;

            foreach (var conta in listaFiltrada)
            {
                MessageBox.Show(conta.Titular);
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            var contas = new List<Conta>
            {
                new Conta("Mariana", 100),
                new Conta("Caio", 2500),
                new Conta("Rodrigo", 300),
                new Conta("Larissa", 3000),
                new Conta("Gabriela", 200),
            };

            var listaFiltrada = from c in contas
                                where c.Saldo > 2000
                                select c.Titular;

            foreach (var conta in listaFiltrada)
            {
                MessageBox.Show(conta);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            var contas = new List<Conta>
            {
                new Conta("Mariana", 100),
                new Conta("Caio", 2500),
                new Conta("Rodrigo", 300),
                new Conta("Larissa", 3000),
                new Conta("Gabriela", 200),
            };

            var listaFiltrada = from c in contas
                                where c.Saldo > 2000
                                select new { c.Titular, c.Saldo} ;

            foreach (var item in listaFiltrada)
            {
                MessageBox.Show("Titular: " + item.Titular);
                MessageBox.Show("Saldo: " + item.Saldo);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            var contas = new List<Conta>
            {
                new Conta("Mariana", 100),
                new Conta("Caio", 2500),
                new Conta("Rodrigo", 300),
                new Conta("Larissa", 3000),
                new Conta("Gabriela", 200),
                new Conta("Alan", 20000),
                new Conta("Alan", 10000),
            };

            var listaFiltrada = from c in contas
                                where c.Saldo > 2000
                                orderby c.Titular, c.Numero
                                select c;

            foreach (var conta in listaFiltrada)
            {
                MessageBox.Show(conta.Titular);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            var contas = new List<Conta>
            {
                new Conta("Mariana", 100),
                new Conta("Caio", 2500),
                new Conta("Rodrigo", 300),
                new Conta("Larissa", 3000),
                new Conta("Gabriela", 200),
                new Conta("Alan", 20000),
            };

            var listaFiltrada = from c in contas
                                where c.Saldo > 2000
                                orderby c.Titular descending
                                select c;

            foreach (var conta in listaFiltrada)
            {
                MessageBox.Show(conta.Titular);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            // pastaDoPRojeto/bin/debug
            StreamReader leitor = new StreamReader("arquivo-teste-leitura.txt");
            var mensagem = leitor.ReadToEnd();
            MessageBox.Show(mensagem);

            leitor.Close();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            StreamWriter gravador = new StreamWriter("arquivo-teste-leitura.txt");
            var mensagem = "Escrevendo no Arquivo, aula FN-13!";
            gravador.Write(mensagem);

            gravador.Close();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            using (StreamReader leitor = new StreamReader("arquivo-teste-leitura.txt"))
            {
                var mensagem = leitor.ReadToEnd();
                MessageBox.Show(mensagem);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            using (StreamWriter gravador = new StreamWriter("arquivo-teste-leitura.txt"))
            {
                var mensagem = "Escrevendo no Arquivo, usando Using, aula FN-13!";
                gravador.Write(mensagem);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            string pastaMeusDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string caminhoAquivo = Path.Combine(pastaMeusDocumentos, "CriandoArquivoEmAula.txt");

            using (StreamWriter gravador = new StreamWriter(caminhoAquivo))
            {
                gravador.Write("Gravando mensagem durante a aula de sábado! FN13");
            }
        }

        // criando e imprimindo uma string
        private void button21_Click(object sender, EventArgs e)
        {
            string mensagem = "Sabadou na Caelum!";
            MessageBox.Show(mensagem);
        }

        // concatenação de strings
        private void button22_Click(object sender, EventArgs e)
        {
            string msg = "Sabadou" + " na" + " caelum";
            msg += "!";
            MessageBox.Show(msg);
        }

        // concatenação com int
        private void button23_Click(object sender, EventArgs e)
        {
            int a = 51;
            string mensagem = a + " uma boa ideia";

            MessageBox.Show(mensagem);
        }


        // interpolação
        private void button24_Click(object sender, EventArgs e)
        {
            int a = 51;
            string mensagem = $"{a} uma boa ideia";

            MessageBox.Show(mensagem);
        }

        // String.Format
        private void button25_Click(object sender, EventArgs e)
        {
            string nome = "Caio";
            int idade = 25;
            string mensagem = string.Format("Olá {0}, sua idade é {1}", nome, idade);

            MessageBox.Show(mensagem);
        }

        // split
        private void button26_Click(object sender, EventArgs e)
        {
            string texto = "guilherme silveira, 42, São Paulo, Brasil";
            string[] textoSeparado = texto.Split(',');

            foreach (var item in textoSeparado)
            {
                MessageBox.Show(item);
            }
        }

        // string é imutavel
        private void button27_Click(object sender, EventArgs e)
        {
            string curso = "fn13";
            curso.ToUpper();
            MessageBox.Show(curso);
        }

        // ToUpper
        private void button28_Click(object sender, EventArgs e)
        {
            string curso = "fn13";
            string maiuscula = curso.ToUpper();
            MessageBox.Show(maiuscula);
        }

        // replace
        private void button29_Click(object sender, EventArgs e)
        {
            string curso = "fn13";
            curso = curso.ToUpper();
            curso = curso.Replace("1", "2");
            MessageBox.Show(curso);
        }

        // quebrando em partes menores - substring
        private void button30_Click(object sender, EventArgs e)
        {
            string nomeCompleto = "guilherme silveira";
            string nome = nomeCompleto.Substring(0, 9);
            MessageBox.Show(nome);
        }

        // indexOf
        private void button31_Click(object sender, EventArgs e)
        {
            string nomeCompleto = "guilherme silveira";
            int posicaoDoEspaco = nomeCompleto.IndexOf(" ");
            MessageBox.Show(posicaoDoEspaco.ToString());
        }

        // concatenando métodos
        private void button32_Click(object sender, EventArgs e)
        {
            string curso = "fn13";
            curso = curso.ToUpper().Replace("1", "2");
            MessageBox.Show(curso);
        }

        // IndexOf + substring
        private void button33_Click(object sender, EventArgs e)
        {
            string nomeCompleto = "guilherme silveira";
            int posicaoDoS = nomeCompleto.IndexOf("s");
            string segundoNome = nomeCompleto.Substring(posicaoDoS);

            MessageBox.Show(segundoNome);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            string banco = "banco";
            string bancoNoPLural = StringUtils.Pluralize(banco);
            //string bancoNoPLural = banco.Pluralize();


            MessageBox.Show(bancoNoPLural);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            string banco = "banco";
            string bancoNoPLural = banco.Pluralize();

            MessageBox.Show(bancoNoPLural);
        }
    }
}
