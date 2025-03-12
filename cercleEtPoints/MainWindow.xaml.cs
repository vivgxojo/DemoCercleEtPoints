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

namespace cercleEtPoints
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Pts> points = new List<Pts>();
        List<Cercle> cercles = new List<Cercle>();

        public MainWindow()
        {
            InitializeComponent();
            lbPoints.ItemsSource = points;
            lbCercles.ItemsSource = cercles;
        }

        private void btnCreerCercle_Click(object sender, RoutedEventArgs e)
        {
            Pts centre = new Pts(double.Parse(txtCX.Text), double.Parse(txtCY.Text));
            Cercle cercle = new Cercle(centre, double.Parse(txtRayon.Text));
            cercles.Add(cercle);
            lbCercles.Items.Refresh();
        }

        private void btnCreerPoint_Click(object sender, RoutedEventArgs e)
        {
            Pts p = new Pts(double.Parse(txtPX.Text), double.Parse(txtPY.Text));
            points.Add(p);
            lbPoints.Items.Refresh();
        }

        private void btnInclus_Click(object sender, RoutedEventArgs e)
        {
            Pts p = (Pts)lbPoints.SelectedItem;
            Cercle c = (Cercle)lbCercles.SelectedItem;
            bool inclus = c.Inclus(p);
            if(inclus)
            {
                MessageBox.Show("Le point fait parti du cercle.");
            }
            else
            {
                MessageBox.Show("Le point ne fait pas parti du cercle.");
            }
        }
    }
}
