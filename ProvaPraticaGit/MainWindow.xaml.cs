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

namespace ProvaPraticaGit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void creaLibro_btn_Click(object sender, RoutedEventArgs e)
        {
            toString(Autore, Titolo, AnnoDiPubblicazione, Editore, NumeroDiPagine);
            autore_txt.Text toString.Autore;
            titolo_txt.Text toString.Titolo;
            annoPubblicazione_txt.Text toString.AnnoDiPubblicazione;
            editore_txt.Text toString.Editore;
            numeroPagine_txt.Text toString.NumeroDiPagine;

            creaLibro_lbl = toString(Autore, Titolo, AnnoDiPubblicazione, Editore, NumeroDiPagine);
            readingTime_lbl = readingTime(NumeroPagine);


        }

        private void biblioteca_btn_Click(object sender, RoutedEventArgs e)
        {
            Biblioteca(nome, orariApertura, orariChiusura, elencoLibri);
            nome_lbl = Biblioteca.nome;
            orariApertura_lbl = Biblioteca.orariApertura;
            orariChiusura_lbl = Biblioteca.orariChiusura;
            elencoLibri_lbl = Biblioteca.elencoLibri;
        }
    }
}
