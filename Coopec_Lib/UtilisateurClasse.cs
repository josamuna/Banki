using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coopec_Lib
{
    public class UtilisateurClasse
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
        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int? id_agent;
        public int? Id_agent
        {
            get { return id_agent; }
            set { id_agent = value; }
        }
        string nomUser;

        public string NomUser
        {
            get { return nomUser; }
            set { nomUser = value; }
        }
        string passWord;

        public string PassWord
        {
            get { return passWord; }
            set { passWord = value; }
        }

        private string categorie;
        
        public string Categorie
        {
            get { return categorie; }
            set { categorie = value; }
        }

        public override string ToString()
        {
            return this.nomUser;
        }
    }
}
