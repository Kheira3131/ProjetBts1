using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetBts1
{
    public class Incidents
    {
        public String numeroIncident;
        public String gravite;
        public String nomIncident;
        public String etat;
        public String dateDebut;
        public String dateFin;


        public Incidents(String numeroIncident, String gravite, String nomIncident, String etat, String dateDebut, String dateFin)
        {
            this.numeroIncident = numeroIncident;
            this.gravite = gravite;
            this.nomIncident = nomIncident;
            this.etat = etat;
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
        }
        public string getNumeroIncident()
        {
            return numeroIncident;

        }
        public string getGravite()
        {
            return gravite;
        }
        public string getNomIncident()
        {
            return nomIncident;
        }
        public string getEtat()
        {
            return etat;
        }
        public string getDateDebut()
        {
            return dateDebut;
        }
        public string getDateFin()
        {
            return dateFin;
        }
    }
