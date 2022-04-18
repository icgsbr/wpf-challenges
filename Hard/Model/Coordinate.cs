using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace Hard.Model
{
    public class Coordinate : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private Point3D _position;

        public Point3D Position
        {
            get { return _position; }
            set
            {
                _position = value;
                OnPropertyChanged("Coordinates");
            }
        }
    }
}
