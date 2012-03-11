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
using System.Collections.ObjectModel;
using System.Timers;
using System.Windows.Threading;

namespace Gui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer m_timer = new DispatcherTimer();
        private int m_gen_counter = 0;

        public MainWindow() {
            InitializeComponent();
            DataContext = this;
            Population = InitialPopulation
                .TenCellRow()
                .Select(row => row.Select(cell => new Cell(cell)).ToList())
                .ToList();

            m_timer.Interval = new TimeSpan(1000000);
            m_timer.Tick += (s, e) => UpdatePopulation();
            m_timer.Start();
        }

        private void UpdatePopulation() {
            var population = Population.Select(row => row.Select(cell => cell.State));
            var new_population = GameOfLife.Tick(population, GameOfLife.GridType.Bound);
            m_gen_counter += 1;
            var all_source_cells = Population.SelectMany(row => row);
            using (var enumerator = all_source_cells.GetEnumerator()) {
                enumerator.MoveNext();
                foreach (var row in new_population) {
                    foreach (var cell in row) {
                        enumerator.Current.State = cell;
                        enumerator.MoveNext();
                    }
                }
            }
            Generation.Text = m_gen_counter.ToString();
        }

        public IEnumerable<IList<Cell>> Population { get; private set; }
    }
}
