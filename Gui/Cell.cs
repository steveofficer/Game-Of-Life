using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Gui
{
    public class Cell : INotifyPropertyChanged
    {
        private bool m_state;

        public Cell(bool state) {
            m_state = state;
        }

        public bool State {
            get { return m_state; }
            set {
                if (m_state != value) {
                    m_state = value;
                    OnPropertyChanged("State");
                }
            }
        }

        private void OnPropertyChanged(string property_name) {
            if (PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(property_name));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
