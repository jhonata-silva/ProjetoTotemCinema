using ProjetoTotemCinema.controller;
namespace ProjetoTotemCinema

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool retorno = true;
            String nomeSala = "";
            String assentos = "";

            nomeSala = txtSala.Text;
            assentos = txtAssentos.Text;
            ControllerSalaDeExibicao controllerSalaDeExibicao = new ControllerSalaDeExibicao();
            retorno = controllerSalaDeExibicao.Salvar_SalaDeExibicao(nomeSala, assentos);
            if (retorno == true)
            {
                MessageBox.Show("Dados Salvos com Sucesso!!!");
            }
            else
            {
                MessageBox.Show("Caro Usuario, Favor preencher os campos corretamente.");
            }
        }
    }
}