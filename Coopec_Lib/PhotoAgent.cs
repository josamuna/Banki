using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coopec_Lib
{
    public class PhotoAgent
    {
        private int id;
        private string photo;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int id_agent;
        public int Id_agent
        {
            get { return id_agent; }
            set { id_agent = value; }
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
