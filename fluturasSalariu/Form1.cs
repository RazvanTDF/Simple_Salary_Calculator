using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fluturasSalariu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSalariuBrut.Text, out int salariuBrut))
            {
                // Calculul contribuțiilor pentru angajat
                double CFS_angajat = (salariuBrut / 1000.0) * 5;
                double CAS_angajat = (salariuBrut / 1000.0) * 105;
                double CASS_angajat = (salariuBrut / 1000.0) * 55;
                double Impozit_angajat = ((salariuBrut - CFS_angajat - CAS_angajat - CASS_angajat - 180) / 1000.0) * 160;
                //pt angajator
                double CAS_angajator = (salariuBrut / 1000.0) * 208;
                double CFS_angajator = (salariuBrut / 1000.0) * 50;
                double CFCI = (salariuBrut / 1000.0) * 85;
                double CFGPCS = (salariuBrut / 10000.0) * 25;
                double CASS_angajator = (salariuBrut / 1000.0) * 52;
                double CFAMBP = (salariuBrut / 1000.0) * 4;
                
                label3.Text = $"Contributia la Fondul de Somaj Angajat: {CFS_angajat:F2}";
                label4.Text = $"Contributia la Asigurarile Sociale Angajat: {CAS_angajat:F2}";
                label5.Text = $"Contributia la Asigurarile Sociale de Sanatate Angajat: {CASS_angajat:F2}";
                label6.Text = $"Impozit pe Venit Angajat: {Impozit_angajat:F2}";

               
                label8.Text = $"Contributia la Asigurarile Sociale Angajator: {CAS_angajator:F2}";
                label9.Text = $"Contributia la Fondul de Somaj Angajator: {CFS_angajator:F2}";
                label10.Text = $"Contributia la Fondul de Concedii si Indemnizatii: {CFCI:F2}";
                label11.Text = $"Contributia la Fondul de Garantare a Platii Creantelor Salariale: {CFGPCS:F2}";
                label12.Text = $"Contributia la Asigurarile Sociale de Sanatate Angajator: {CASS_angajator:F2}";
                label13.Text = $"Contributia la Fondul de Accidente de Munca si Boli Profesionale: {CFAMBP:F2}";
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
