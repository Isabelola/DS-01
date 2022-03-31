using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DS_01
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();

        private void txtUsuario_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btMostrarSenha_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btEsqSenha_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btEntrar_Click(object sender, RoutedEventArgs e)
        {
            string senha = pwSenha.Password.ToString();
            string usuario = txtUsuario.Text;
            if (senha == "abc" && usuario == "isabelly")
            {
                MessageBox.Show("Sucesso!");
                Calculadora calculadora = new Calculadora();
                txtUsuario.Clear();
                pwSenha.Clear();
                calculadora.ShowDialog();
            }
            else
            {
                MessageBox.Show("Incorreto, tente novamente!");
                txtUsuario.Clear();
                pwSenha.Clear();
            }
        }

        private void btCadastrar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
