using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect1
{
    class Student : Persoana
    {
        private byte an;
        private byte[] note = new byte[5];
        private float medie;
        public Student(string nume, byte varsta, byte an, byte[] note) : base(nume, varsta)
        {
            this.an = an;
            this.note = note;
        }

        
        public float Medie()
        {
            medie = (float)((note[0] + note[1] + note[2] + note[3] + note[4]) / 5.0);
            return (medie);

        }
        public byte Varsta
        {
            get { return varsta; }
        }
        public float AfisMedie
        {
            get { return medie; }
        }
        public string NumeStudent
        {
            get { return nume; }
        }
        public byte AnStudiu
        {
            get { return an; }
        }
        
    }
}
