using Hard.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Media.Media3D;

namespace Hard.ViewModel
{
    public class CoordinateViewModel : ObservableCollection<Coordinate>
    {
        public string filePath = @"C:\Users\Usuario\Downloads\TestPlus.txt";

        public List<string> lines = new List<string>();

        public List<Point3D> listCoordinate = new List<Point3D>();

        public CoordinateViewModel()
        {
            PrepareCoordinateCollection();
        }

        public void PrepareCoordinateCollection()
        {
            lines = File.ReadAllLines(filePath).ToList();

            foreach (string line in lines)
            {
                listCoordinate.Add(Point3D.Parse(line));
            }

            foreach (Point3D point in listCoordinate)
            {
                var coordinate = new Coordinate
                {
                    Position = point
                };
                Add(coordinate);
            }
        }
    }
}
