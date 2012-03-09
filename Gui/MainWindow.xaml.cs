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

namespace Gui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Timer m_timer = new Timer();
        private int m_gen_counter = 0;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            Population = Acorn();

            m_timer.Interval = 100;
            m_timer.AutoReset = true;
            m_timer.Elapsed += (s, e) => UpdatePopulation();
            //m_timer.Start();
        }

        private static ObservableCollection<ObservableCollection<bool>> Glider() {
            return new ObservableCollection<ObservableCollection<bool>> {
                new ObservableCollection<bool> {false, true, false, false, false, false, false, false, false, false},
                new ObservableCollection<bool> {false, false, true, false, false, false, false, false, false, false},
                new ObservableCollection<bool> {true, true, true, false, false, false, false, false, false, false},
                new ObservableCollection<bool> {false, false, false, false, false, false, false, false, false, false},
                new ObservableCollection<bool> {false, false, false, false, false, false, false, false, false, false},
                new ObservableCollection<bool> {false, false, false, false, false, false, false, false, false, false},
                new ObservableCollection<bool> {false, false, false, false, false, false, false, false, false, false},
                new ObservableCollection<bool> {false, false, false, false, false, false, false, false, false, false},
                new ObservableCollection<bool> {false, false, false, false, false, false, false, false, false, false},
                new ObservableCollection<bool> {false, false, false, false, false, false, false, false, false, false},
                new ObservableCollection<bool> {false, false, false, false, false, false, false, false, false, false},
                new ObservableCollection<bool> {false, false, false, false, false, false, false, false, false, false},
                new ObservableCollection<bool> {false, false, false, false, false, false, false, false, false, false},
                new ObservableCollection<bool> {false, false, false, false, false, false, false, false, false, false},
                new ObservableCollection<bool> {false, false, false, false, false, false, false, false, false, false},
                new ObservableCollection<bool> {false, false, false, false, false, false, false, false, false, false},
                new ObservableCollection<bool> {false, false, false, false, false, false, false, false, false, false},
                new ObservableCollection<bool> {false, false, false, false, false, false, false, false, false, false},
                new ObservableCollection<bool> {false, false, false, false, false, false, false, false, false, false},
                new ObservableCollection<bool> {false, false, false, false, false, false, false, false, false, false},
            };
        }

        private static ObservableCollection<ObservableCollection<bool>> Acorn()
        {
            return new ObservableCollection<ObservableCollection<bool>> {
                new ObservableCollection<bool> {false, false, false, false, false, false, false, false, false, false},
                new ObservableCollection<bool> {false, false, true, false, false, false, false, false, false, false},
                new ObservableCollection<bool> {false, false, false, false, true, false, false, false, false, false},
                new ObservableCollection<bool> {false, true, true, false, false, true, true, true, false, false},
                new ObservableCollection<bool> {false, false, false, false, false, false, false, false, false, false},
                new ObservableCollection<bool> {false, false, false, false, false, false, false, false, false, false},
                new ObservableCollection<bool> {false, false, false, false, false, false, false, false, false, false},
                new ObservableCollection<bool> {false, false, false, false, false, false, false, false, false, false},
                new ObservableCollection<bool> {false, false, false, false, false, false, false, false, false, false},
                new ObservableCollection<bool> {false, false, false, false, false, false, false, false, false, false},
                new ObservableCollection<bool> {false, false, false, false, false, false, false, false, false, false},
                new ObservableCollection<bool> {false, false, false, false, false, false, false, false, false, false},
                new ObservableCollection<bool> {false, false, false, false, false, false, false, false, false, false},
                new ObservableCollection<bool> {false, false, false, false, false, false, false, false, false, false},
                new ObservableCollection<bool> {false, false, false, false, false, false, false, false, false, false},
                new ObservableCollection<bool> {false, false, false, false, false, false, false, false, false, false},
                new ObservableCollection<bool> {false, false, false, false, false, false, false, false, false, false},
                new ObservableCollection<bool> {false, false, false, false, false, false, false, false, false, false},
                new ObservableCollection<bool> {false, false, false, false, false, false, false, false, false, false},
                new ObservableCollection<bool> {false, false, false, false, false, false, false, false, false, false},
            };
        }

        private void UpdatePopulation()
        {
            var new_population = GameOfLife.Tick(Population);
            m_gen_counter += 1;
            Dispatcher.Invoke(new Action(() => {
                Population.Clear();
                foreach (var row in new_population)
                {
                    var new_row = new ObservableCollection<bool>();
                    foreach (var cell in row)
                    {
                        new_row.Add(cell);
                    }
                    Population.Add(new_row);
                }
                Generation.Text = m_gen_counter.ToString();
            }));
        }

        public ObservableCollection<ObservableCollection<bool>> Population { get; private set; }
    }
}
