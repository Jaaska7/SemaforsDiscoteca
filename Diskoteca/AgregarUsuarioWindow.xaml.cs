using Llistes;
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

namespace Diskoteca
{
    public partial class AgregarUsuarioWindow : Window
    {
        private Persona novaPersona;

        public AgregarUsuarioWindow(Persona persona)
        {
            InitializeComponent();
            novaPersona = persona;
        }

        private void BtnAceptar_Click(object sender, RoutedEventArgs e)
        {
            novaPersona.Nom = txtNom.Text;
            if (int.TryParse(txtEdat.Text, out int edat))
            {
                novaPersona.Edat = edat;
            }
            else
            {
                MessageBox.Show("La edat ha de ser un numeur.");
            }

            DialogResult = true;
        }
    }

}
