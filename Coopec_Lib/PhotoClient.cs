using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coopec_Lib
{
    public class PhotoClient
    {
        private int id;
        private string photo;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private int id_client;

        public int Id_client
        {
            get { return id_client; }
            set { id_client = value; }
        }

        public string PhotoPersonne
        {
            get { return photo; }
            set { photo = value; }
        }

        public void Enregistrer()
        {
            Factory.Instance.Save(this);
        }
        public void Supprimer()
        {
            Factory.Instance.Delete(this);
        }
        public void Modifier()
        {
            Factory.Instance.Update(this);
        }
    }
}
