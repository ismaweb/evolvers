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

namespace Evolvers.Presentation
{
    /// <summary>
    /// Lógica de interacción para UniverseView.xaml
    /// </summary>
    public partial class UniverseView : UserControl
    {

        private static Rect _size = new Rect(0, 0, 400, 300);

        public Universe Universe
        {
            get { return DataContext as Universe; }
            set { this.DataContext = value; }
        }


        public UniverseView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(Playground_DataContextChanged);
            this.SnapsToDevicePixels = true;
        }


        void Playground_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (this.Universe != null)
            {
                this.Universe.Changed += new Action(Universe_Changed);
                Universe_Changed();
            }
        }

        void Universe_Changed()
        {
            InvalidateVisual();
        }

        protected override void OnRender(System.Windows.Media.DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);

            SolidColorBrush blackBrush = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            SolidColorBrush greenBrush = new SolidColorBrush(Color.FromRgb(0, 128, 0));
            SolidColorBrush redBrush = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            Pen blackPen = new Pen(blackBrush, 1);
            Pen greenPen = new Pen(greenBrush, 1);
            Pen redPen = new Pen(redBrush, 1);

            drawingContext.DrawRectangle(null, blackPen, _size);



            if (Universe == null)
                return;

            foreach (FoodElement element in Universe.Food)
            {
                drawingContext.DrawEllipse(null, greenPen, new Point(element.CenterX, element.CenterY), element.Width, element.Width);
            }

            foreach (CreatureElement creature in Universe.Creatures)
            {
                drawingContext.DrawEllipse(null, redPen, new Point(creature.CenterX, creature.CenterY), creature.Width, creature.Width);
            }

        }

    }
}
