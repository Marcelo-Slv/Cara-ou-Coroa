using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;

namespace CaraOuCoroa
{
    public partial class MainPage : ContentPage
    {
        int ContadorDeVitorias = 0;
        int ContadorDeDerrotas = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void LancarMoedaButton_Clicked(object sender, EventArgs e)
        {
            Random moeda = new Random();
            int LadoSorteado = moeda.Next(2); // Exemplo: 0 para cara, 1 para coroa

            ResultadoLabel.Text = LadoSorteado.ToString();

            // Verificando se o item selecionado no Picker é igual a "cara"
            if (LadoPicker.SelectedItem.ToString() == "cara")
            {
                if (LadoSorteado == 0)
                {

                    ResultadoLabel.Text = "Você acertou, Parabéns!";

                    ContadorDeVitorias++;

                    ContadorVitorias.Text =  ContadorDeVitorias.ToString();

                    return;

                }
                else
                {
                    ResultadoLabel.Text = "Você Errou! tente novamente."; // O que acontece se não for

                    ContadorDeDerrotas++;

                    ContaodeDerrotas.Text = ContadorDeDerrotas.ToString();

                    return;


                }
            }
            if (LadoSorteado == 1)
            {

                ResultadoLabel.Text = "Você Acertou, parabéns!";

                ContadorDeVitorias++;

                ContadorVitorias.Text = ContadorDeVitorias.ToString();

                return;

            }
            else
            {
                ResultadoLabel.Text = "Você errou, tente novamente!";     // Caso o usuário tenha escolhido coroa

                ContadorDeDerrotas++;

                ContaodeDerrotas.Text = ContadorDeDerrotas.ToString();

                return;


            }
        }


    }
    
}
