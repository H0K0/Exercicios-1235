using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Exercicios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutarExec1_Click(object sender, System.EventArgs e)
        {
            ValoresExercicio1 Dados = new ValoresExercicio1();
            Dados.Entrada = int.Parse(txtEntradaExec1.Text);
            Dados.Dolar = decimal.Parse("5,31");
            Dados.Saida = Dados.Entrada * Dados.Dolar;
            txtSaidaExec1.Text = Dados.Saida.ToString();
        }

        private void btnExecutarExec2_Click(object sender, System.EventArgs e)
        {

            ValoresExercicio2 Dados = new ValoresExercicio2();
            Dados.Entrada = txtEntradaExec2.Text;
            Dados.QuantidadeCaracter = txtEntradaExec2.Text.Length;
            Dados.Lista = new List<int>();

            for (int i = 0; i < Dados.QuantidadeCaracter; i++)
            {
                int valor = int.Parse(Dados.Entrada.Substring(i, 1));
                Dados.Lista.Add(valor);
            }

            var Agrupando = Dados.Lista.GroupBy(x => x).Select(x => new { Numero = x.Key, Quantidade = x.Count() });
            var MaiorEncontrado = Dados.Lista.GroupBy(x => x).Max(x => x.Count()); // colocar inteiro
            var Resultado = Agrupando.Where(x => x.Quantidade == MaiorEncontrado).Select(x => x.Numero).FirstOrDefault(); // colocar string

            txtSaidaExec2.Text = Resultado.ToString();
        }

        private void btnExecutarExec3_Click(object sender, System.EventArgs e)
        {
            ValoresExercicio3 Dados = new ValoresExercicio3();
            int ValorCarne = 20, ValorFrango = 16, ValorBatata = 6, ValorRefri = 4, ValorSalada = 2, ValorMaionese = 1;

            Dados.Carne = int.Parse(txtEntradaExeclc3.Text);
            Dados.SaladaCarne = checkExerciciolc3.Checked;
            Dados.Frango = int.Parse(txtEntradaExeclf3.Text);
            Dados.SaladaFrango = checkExerciciolf3.Checked;
            Dados.Fritas = int.Parse(txtEntradaExecba3.Text);
            Dados.Maionese = checkExercicioba3.Checked;
            Dados.Refri = int.Parse(txtEntradaExecre3.Text);

            if (Dados.SaladaCarne)
            {
                Dados.ValorTotal = (ValorCarne + ValorSalada) * Dados.Carne;
            }
            else
            {
                Dados.ValorTotal = ValorCarne * Dados.Carne;
            }


            if (Dados.SaladaFrango)
            {
                Dados.ValorTotal = Dados.ValorTotal + (ValorFrango + ValorSalada) * Dados.Frango;
            }
            else
            {
                Dados.ValorTotal = Dados.ValorTotal + ValorFrango * Dados.Frango;
            }

            if (Dados.Maionese)
            {
                Dados.ValorTotal = Dados.ValorTotal + (ValorBatata + ValorMaionese) * Dados.Fritas;
            }
            else
            {
                Dados.ValorTotal = Dados.ValorTotal + ValorBatata * Dados.Fritas;
            }

            Dados.Saida = Dados.ValorTotal + ValorRefri * Dados.Refri;

            txtEntradaExecSaida3.Text = string.Concat("R$ ", Dados.Saida.ToString());
        }

        private void btnExecutarExec5_Click(object sender, System.EventArgs e)
        {
            string Texto; // colocar string
            int teste = int.Parse(txtEntradaExec4.Text); // colocar inteiro
            int[] dp = new int[teste + 1];

            dp[1] = 1;
            Texto = dp[1] + " ";

            for (int i = 2; i <= teste; i++)
            {
                dp[i] = 1 + dp[i - dp[dp[i - 1]]];
                Texto = string.Concat(Texto," ", dp[i] , " ");
            }

            txtSaidaExec4.Text = Texto;
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {

        }
    }
}
