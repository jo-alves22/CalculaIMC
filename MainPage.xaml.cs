

namespace IMC
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            // Verificar se os valores de peso e altura foram inseridos corretamente
            if (double.TryParse(pesoEntry.Text, out double peso) &&
                double.TryParse(alturaEntry.Text, out double alturaCm))
            {
                // Converter altura de centímetros para metros
                double alturaM = alturaCm / 100;

                // Calcular o IMC
                double imc = peso / (alturaM * alturaM);

                // Exibir o resultado formatado no Label
                resultadoLabel.Text = $"Seu IMC é {imc:F2}";
                if(imc < 18.5)
                {
                    diagnosticoLabel.Text = "Voce esta Abaixo do Peso";
                } else if (imc >= 18.5 && imc < 25)
                {
                    diagnosticoLabel.Text = "Peso Normal";
                } else if (imc >= 25 && imc < 30)
                {
                    diagnosticoLabel.Text = "Acima do Peso";
                } else if (imc >= 30 && imc < 35)
                {
                    diagnosticoLabel.Text = "Obesidade Grau I";
                } else if (imc >= 35 && imc < 40)
                {
                    diagnosticoLabel.Text = "Obesidade Grau II";
                } else
                {
                    diagnosticoLabel.Text = "Obesidade Grau III";
                }
            }
            else
            {
                // Exibir mensagem de erro se os valores não forem válidos
                resultadoLabel.Text = "Por favor, insira valores válidos para peso e altura.";
            }
        }

    }

}
