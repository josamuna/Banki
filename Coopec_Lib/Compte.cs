using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coopec_Lib
{
    public class Compte
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
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private int id_Client;

        private int id_Categorie;

        public int Id_Categorie
        {
            get { return id_Categorie; }
            set { id_Categorie = value; }
        }
        public int Id_Client
        {
            get { return id_Client; }
            set { id_Client = value; }
        }
        private string designation;

        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }

        private string typeCompte;

        public string TypeCompte
        {
            get { return typeCompte; }
            set { typeCompte = value; }
        }

        public override string ToString()
        {
            return this.id_Client+ "=>"+this.Designation + " => " + this.id;
        }
    }
}
