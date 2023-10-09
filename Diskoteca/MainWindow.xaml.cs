using Diskoteca;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace Llistes
{
    public partial class MainWindow : Window
    {
        private List<Persona> llista;
        private DispatcherTimer timer;
        private Random rand;

        public MainWindow()
        {
            InitializeComponent();
            llista = new List<Persona>();
            llista.Clear();
            IbPrincipal.ItemsSource = llista;

            rand = new Random();

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1); 
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void BtnAfegir_Click(object sender, RoutedEventArgs e)
        {
            if (llista.Count < 15)
            {
                Persona novaPersona = new Persona();

                AgregarUsuarioWindow finestraAgregarUsuario = new AgregarUsuarioWindow(novaPersona);
                if (finestraAgregarUsuario.ShowDialog() == true)
                {
                    llista.Add(novaPersona);
                    IbPrincipal.Items.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Com a màxim són 15 persones");
            }
        }



        private void BtnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if (IbPrincipal.SelectedItems.Count > 0)
            {
                List<Persona> personasSeleccionadas = new List<Persona>();
                foreach (var item in IbPrincipal.SelectedItems)
                {
                    personasSeleccionadas.Add((Persona)item);
                }
                foreach (var persona in personasSeleccionadas)
                {
                    llista.Remove(persona);
                }
                IbPrincipal.Items.Refresh();
            }
            if (IbDesti.SelectedItems.Count > 0)
            {
                List<Persona> personasSeleccionadas = new List<Persona>();
                foreach (var item in IbDesti.SelectedItems)
                {
                    personasSeleccionadas.Add((Persona)item);
                }
                foreach (var persona in personasSeleccionadas)
                {
                    IbDesti.Items.Remove(persona);
                }
            }
        }

        private void BtnMoure_Click(object sender, RoutedEventArgs e)
        {
            if (IbPrincipal.SelectedItems.Count > 0)
            {
                List<Persona> personasSeleccionadas = new List<Persona>();
                foreach (var item in IbPrincipal.SelectedItems)
                {
                    personasSeleccionadas.Add((Persona)item);
                }

                int personasEnDesti = IbDesti.Items.Count;
                if (personasEnDesti + personasSeleccionadas.Count <= 5)
                {
                    foreach (var persona in personasSeleccionadas)
                    {
                        llista.Remove(persona);

                        // CANVIAR TEMPS
                        persona.TiempoRestante = rand.Next(10, 30);

                        IbDesti.Items.Add(persona);
                    }
                    IbPrincipal.Items.Refresh();
                    IbDesti.Items.Refresh();
                }
                else
                {
                    MessageBox.Show("Nomes poden entrar 5 personas");
                }
            }
            else if (IbDesti.SelectedItems.Count > 0)
            {
                List<Persona> personasSeleccionadas = new List<Persona>();
                foreach (var item in IbDesti.SelectedItems)
                {
                    personasSeleccionadas.Add((Persona)item);
                }

                foreach (var persona in personasSeleccionadas)
                {
                    IbDesti.Items.Remove(persona);
                    llista.Add(persona);
                }
                IbPrincipal.Items.Refresh();
                IbDesti.Items.Refresh();
            }
            else
            {
                MessageBox.Show("No has seleccionat a ninguv.");
            }
        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            List<Persona> personasAEliminar = new List<Persona>();
            foreach (var persona in IbDesti.Items)
            {
                Persona p = (Persona)persona;
                p.TiempoRestante--;

                if (p.TiempoRestante <= 0)
                {
                    personasAEliminar.Add(p);
                }
            }

            foreach (var persona in personasAEliminar)
            {
                IbDesti.Items.Remove(persona);
            }
            IbDesti.Items.Refresh();
        }

        private void IbPrincipal_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
    }
}
