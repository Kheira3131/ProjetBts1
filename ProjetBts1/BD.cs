using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace ProjetBts1
{
    public class BD
    
    { String connStr = "Server=localhost; Database=Projetbts1; Uid=root; Pwd=;";

        public static void addIncidents (Incidents incidents)
        {
            string connStr = "Server = localhost; Database=Projetbts1; UUid= root; Pwd= ;";
            string requete= "INSERT INTO Incidents (numeroIncident, gravite, nomIncident, etat, dateDebut, dateFin) VALUES ('" + incidents.getNumeroIncident() + "', '" + incidents.getGravite() + "', '" + incidents.getNomIncident() + "', '" + incidents.getEtat() + "', '" + incidents.getDateDebut() + "', '" + incidents.getDateFin() + "')";

            MySqlCommand command = new MySqlCommand(requete,connection);
        }


    }
}
