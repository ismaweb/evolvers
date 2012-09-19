using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Evolvers.Model;

namespace Evolvers
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            this.Playground.DataContext = new Universe
            {
                Food = {
                    new FoodElement{CenterX = 10, CenterY = 10, Width = 3, Height = 3}
                },
                Creatures = { 
                    new CreatureElement{CenterX = 100, CenterY = 50, Width = 5, Height = 5}
                }
            };
        }
    }
}
