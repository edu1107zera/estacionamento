using System.Numerics;

namespace Estacionamento
{
    public partial class Form1 : Form
    {
        List<string> Estacionamento = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }


       

             
         
        private void btnEstacionar_Click(object sender, EventArgs e)
        {
           //verifica se ta cheio o estacionamento
            if( Estacionamento.Count > 5 )
            {
                MessageBox.Show("Estacionamento cheio");
                return;
            }
          // verifica se a pessoa digitou alg
            if(txtPlaca.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }
            
            //adiciona placa na lista do codigo
            string placa = txtPlaca.Text;
            Estacionamento.Add(placa);

            //atualiza o lael de contagem
            lblQuantidade.Text = Estacionamento.Count.ToString();
              
            //atualiza a lista da interface
            lvLista.Items.Clear();
            for (int i = 0; i < Estacionamento.Count; i++)
            {
            
                lvLista.Items.Add($"[VAGA {i}] - {Estacionamento[i]}");
            }
            
            
            
            //  lvLista.Items.Add("[Vaga]-"+placa);
            
        }

        private void txtPlaca_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            //REMOVER
            string placa = txtPlaca.Text;
            Estacionamento.Remove(placa);
            //atualiza o lael de contagem
            lblQuantidade.Text = Estacionamento.Count.ToString();

            //atualiza a lista da interface
            lvLista.Items.Clear();
            for (int i = 0; i < Estacionamento.Count; i++)
            {

                lvLista.Items.Add($"[VAGA {i}] - {Estacionamento[i]}");
            }

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if(Estacionamento.Count == 0)
            {
                MessageBox.Show("O estafionamento fechou");
                return;
            }
            else
            {
                MessageBox.Show("Ha veiculos dentro, retire antes de fechar!");
            }
        }
    }
}