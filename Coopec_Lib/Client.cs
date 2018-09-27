using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coopec_Lib
{
    public class Client
    {
        public void Enregistrer()
        {
            Factory.Instance.Save(this);
        }

        public void Modifier()
        {
            Factory.Instance.Update(this);
        }

        public void Supprimer()
        {
            Factory.Instance.Delete(this);
        }

        private string matricule;

        public string Matricule
        {
            get { return matricule; }
            set { matricule = value; }
        }

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int id_agent;

        public int Id_Agent
        {
            get { return id_agent; }
            set { id_agent = value; }
        }

        public override string ToString()
        {
            return this.Nom + " " + this.PostNom + " " + this.Prenom;
        }

        private string nom;

        public string Nom
        {
            get { return nom; }
            set { nom = ValiderNom(value, false).ToUpper(); }
        }
        private string postNom;

        public string PostNom
        {
            get { return postNom; }
            set { postNom = ValiderNom(value, true).ToUpper(); }
        }
        private string prenom;

        public string Prenom
        {
            get { return prenom; }
            set { prenom = ValiderNom(value, true).ToUpper(); }
        }

        private DateTime dateNaissance;

        public DateTime DateNaissance
        {
            get { return dateNaissance; }
            set
            {
                if (value > DateTime.Today) throw new Exception("La date de naissance ne peut être supérieur à la date du jour");
                else dateNaissance = value;
            }
        }

        public string ValiderNom(String value, bool autoriserNull)
        {
            if (string.IsNullOrEmpty(value) && !autoriserNull)
            {
                throw new Exception("Le nom de la personne est obligatoire !");
            }
            return value.ToUpper();
        }

        private string sexe;

        public string Sexe
        {
            get { return sexe; }
            set { sexe = value; }
        }

        private string etatCivil;

        public string EtatCivil
        {
            get { return etatCivil; }
            set { etatCivil = value; }
        }

        private string telephone;

        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }
    }
}
