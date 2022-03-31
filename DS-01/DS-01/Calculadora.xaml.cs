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
using System.Windows.Shapes;

namespace DS_01
{
    /// <summary>
    /// Lógica interna para Calculadora.xaml
    /// </summary>
    public partial class Calculadora : Window
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btAdicao_Click(object sender, RoutedEventArgs e)
        {
            double numeroX = Convert.ToDouble(txtNumX.Text);
            double numeroY = Convert.ToDouble(txtNumY.Text);
            double resultado = numeroX + numeroY;
            txtResultado.Text = numeroX.ToString() + " + " + numeroY.ToString() + " = " + resultado.ToString();
        }

        private void btSub_Click(object sender, RoutedEventArgs e)
        {
            double numeroX = Convert.ToDouble(txtNumX.Text);
            double numeroY = Convert.ToDouble(txtNumY.Text);
            double resultado = numeroX - numeroY;
            txtResultado.Text = numeroX.ToString() + " - " + numeroY.ToString() + " = " + resultado.ToString();
        }

        private void btMult_Click(object sender, RoutedEventArgs e)
        {
            double numeroX = Convert.ToDouble(txtNumX.Text);
            double numeroY = Convert.ToDouble(txtNumY.Text);
            double resultado = numeroX * numeroY;
            txtResultado.Text = numeroX.ToString() + " x " + numeroY.ToString() + " = " + resultado.ToString();
        }

        private void btDiv_Click(object sender, RoutedEventArgs e)
        {
            double numeroX = Convert.ToDouble(txtNumX.Text);
            double numeroY = Convert.ToDouble(txtNumY.Text);
            double resultado = numeroX / numeroY;
            txtResultado.Text = numeroX.ToString() + " / " + numeroY.ToString() + " = " + resultado.ToString();
        }
    }
}
