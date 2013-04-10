using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clientCs
{
    public abstract class Client
    {
      protected int numClient; // numéro de client attribuer
      protected string nomClient; // nom du client
      protected string prenomClient; // prenom du client
      protected string adresseClient; // adresse du client
      protected string civiliteClient;
      protected int cpClient; // code postal
      protected string villeClient;
      protected string telephoneClient;
      

     public Client()
        {
         numClient=1;
         nomClient="Saisir le nom";
         prenomClient="Saisir le prenom";
         adresseClient="Saisir l'adresse";
         civiliteClient = "Saisir la civilité";
        }

     public Client(int numClient)
        {
         this.numClient=numClient;
         nomClient="LEFORT";
         prenomClient="Maxime";
         adresseClient="29 rue de la lauter";
        }

     public Client(int numClient, string nomClient, string prenomClient)
        {
         this.numClient=numClient;
         this.nomClient=nomClient;
         this.prenomClient=prenomClient;
         this.adresseClient="ICI";
        }

     public Client(int numClient, string nomClient, string prenomClient, string civiliteClient)
     {
         this.numClient = numClient;
         this.nomClient = nomClient;
         this.prenomClient = prenomClient;
         this.adresseClient = "ICI";
         this.civiliteClient = civiliteClient;
     }

     public int getNumClient()
        {
         return(numClient);
        }

     public string getNomClient()
        {
         return(nomClient);
        }

     public string getPrenomClient()
        {
         return(prenomClient);
        }

     public string getAdresseClient()
        {
         return(adresseClient);
        }

     public string getCiviliteClient()
        {
            return (civiliteClient);
        }

    public void setCiviliteClient(string civiliteClient)
        {
            this.civiliteClient = civiliteClient;
        }

     public void setNumClient(int numClient)
        {
         this.numClient=numClient;
        }

     public void setNomClient(string nomClient)
        {
         this.nomClient=nomClient;
        }

     public void setPrenomClient(string prenomClient)
        {
         this.prenomClient=prenomClient;
        }

     public void setAdresseClient(string adresseClient)
        {
         this.adresseClient=adresseClient;
        }
     public string permetAddClient()
        {
         string laff;
         laff="les information du client :\n";
         //laff+="Numéro du cliet ..: " + string(numClient) + "\n";
         laff+="Nom du client ..: " + nomClient + "\n";
         laff+="Prénom du client ..: " + prenomClient + "\n";
         laff+="Adresse du client ..: " + adresseClient + "\n\n\n";
         return(laff);
        }

     public void setcpClient(int cpClient)
        {
         this.cpClient = cpClient;
        }

     public int getcpClient()
        {
         return (cpClient);
        }

     public string laville
     {
         get
         {
             return villeClient;
         }
         set
         {
             this.villeClient = villeClient;
         }
     }

     public string letelephone
     {
         get
         {
             return telephoneClient;
         }
         set
         {
             this.telephoneClient = telephoneClient;
         }
     }    


    }
}
