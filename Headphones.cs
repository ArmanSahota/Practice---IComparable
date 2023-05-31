using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice___IComparable
{
    internal class Headphones : IComparable<Headphones>
    {
        // fields
        private string _connection;
        private string _qBand;
        private string _qEarCushion;
        private string _cable;
        private string _qSpeakers;
        private string _microphones;

        // properties
        public string Connection
        {
            get { return _connection; }
            set { _connection = value; }
        }

        public string QBand
        {
            get { return _qBand; }
            set { _qBand = value; }
        }

        public string QEarCushion
        {
            get { return _qEarCushion; }
            set { _qEarCushion = value; }
        }

        public string Microphones
        {
            get { return _microphones; }
            set { _microphones = value; }
        }

        public string Cable
        {
            get { return _cable; }
            set { _cable = value; }
        }

        public string Speakers
        {
            get { return _qSpeakers; }
            set { _qSpeakers = value; }
        }

        // override ToString()
        public override string ToString()
        {
            return $"Connection: {_connection}, Quality Band: {_qBand}, Quality Ear Cushion: {_qEarCushion}, Cable: {_cable}, Quality Speakers: {_qSpeakers}, Microphones: {_microphones}";
        }

        // implement IComparable<>
        public int CompareTo(Headphones other)
        {
            // Choose a field to sort by (e.g., Connection)
            return string.Compare(_connection, other._connection, StringComparison.OrdinalIgnoreCase);
        }
    }
}
