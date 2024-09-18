using Pataufnahme.WPF.ViewModels.CompViewModels;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace Pataufnahme.WPF.Components
{
    /// <summary>
    /// Interaktionslogik für NameComp.xaml
    /// </summary>
    public partial class NameComp : UserControl
    {


        public List<string> Anrede = new List<string>();
        public List<string> Titel = new List<string>();
        public NameComp()
        {
            InitializeComponent();          
            AddAnrede(); 
            AddBirthday();
            AddTitel();
            //SaveBirthday();
        }


        public void SaveBirthday()
        {
            NameViewModel mvm = new NameViewModel("", "", "", DateTime.Now, "");
            try
            {
                int year = Convert.ToInt32(Geburtsjahr);
                int month = Convert.ToInt32(Geburtsmonat);
                int day = Convert.ToInt32(Geburtstag);

                mvm.Geburtsdatum = new DateTime(year,month,day);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void AddTitel()
        {
            Titel.Add("Diplom");
            Titel.Add("Bachelor");
            Titel.Add("Magister");
            Titel.Add("Master");
            Titel.Add("Doktor");
            Titel.Add("Professor");
            TitelBox.ItemsSource = Titel;          
        }

        //public ObservableCollection<string> Anrede = new ObservableCollection<string>();

        public void AddAnrede()
        {
            Anrede.Add("Herr");
            Anrede.Add("Frau");
            Anrede.Add("Neutrale Anrede");
            Anrede.Add("Keine Angabe");
            AnredeBox.ItemsSource = Anrede;
        }

        public void AddBirthday()
        {
            AddDays();
            AddMonths();
            AddYears();
        }

        public void AddDays()
        {
            // Tage hinzufügen
            for (int i = 1; i <= 31; i++)
            {
                Geburtstag.Items.Add(new ComboBoxItem { Content = i.ToString() });
            }
        }

        public void AddMonths()
        {
            // Monate hinzufügen
            for (int i = 1; i <= 12; i++)
            {
                Geburtsmonat.Items.Add(new ComboBoxItem { Content = i.ToString() });
            }
        }

        public void AddYears()
        {
            // Jahre hinzufügen
            for (int i = DateTime.Now.Year; i >= 1920; i--)
            {
                Geburtsjahr.Items.Add(new ComboBoxItem { Content = i.ToString() });
            }
        }
        

        

        private void Geburtsmonat_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Logik für Monat
            UpdateDays();
        }

        private void Geburtsjahr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Logik für Jahr
            UpdateDays();
        }

        private void UpdateDays()
        {
            if (Geburtsmonat.SelectedItem != null && Geburtsjahr.SelectedItem != null)
            {
                int monat = int.Parse((Geburtsmonat.SelectedItem as ComboBoxItem).Content.ToString());
                int jahr = int.Parse((Geburtsjahr.SelectedItem as ComboBoxItem).Content.ToString());

                bool istSchaltjahr = DateTime.IsLeapYear(jahr);
                int maxTage = 31;

                switch (monat)
                {
                    case 2:
                        maxTage = istSchaltjahr ? 29 : 28;
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        maxTage = 30;
                        break;
                }

                // Tage aktualisieren
                Geburtstag.Items.Clear();
                for (int i = 1; i <= maxTage; i++)
                {
                    Geburtstag.Items.Add(new ComboBoxItem { Content = i.ToString() });
                }
            }
        }
    }
}


