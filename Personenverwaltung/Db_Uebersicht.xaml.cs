using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Personenverwaltung
{
    /// <summary>
    /// Interaction logic for Db_Uebersicht.xaml
    /// </summary>
    public partial class Db_Uebersicht : Window
    {
        public ObservableCollection<Person> Personenliste { get; set; }

        public Db_Uebersicht()
        {
            InitializeComponent();

            Personenliste = new ObservableCollection<Person>()
            {
                new Person(){Vorname="Anna", Nachname="Nass", Geburtsdatum=new DateTime(1999,5,23), Geschlecht=Gender.Weiblich, Verheiratet=true, Lieblingsfarbe=Colors.CornflowerBlue}
            };

            this.DataContext = this;
        }

        private void Mei_Beenden_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Btn_Neu_Click(object sender, RoutedEventArgs e)
        {
            PersonenDialog dialog = new PersonenDialog();

            if (dialog.ShowDialog() == true)
            {
                Personenliste.Add(dialog.DataContext as Person);
            }
        }

        private void Btn_Aendern_Click(object sender, RoutedEventArgs e)
        {
            if (Dgd_Personen.SelectedItem is Person)
            {
                PersonenDialog dialog = new PersonenDialog();

                dialog.DataContext = new Person(Dgd_Personen.SelectedItem as Person);
                
                dialog.Title = (dialog.DataContext as Person).Vorname + " " + (dialog.DataContext as Person).Nachname;

                if (dialog.ShowDialog() == true)
                    Personenliste[Dgd_Personen.SelectedIndex] = (dialog.DataContext as Person);
            }
        }

        private void Btn_Loeschen_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Soll diese Person wirklich gelöscht werden?", "Person löschen?", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                Personenliste.Remove(Dgd_Personen.SelectedItem as Person);
        }
    }
}
