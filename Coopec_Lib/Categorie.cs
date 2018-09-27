using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coopec_Lib
{
    public class Categorie
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
        private string designation;

        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }

        public override string ToString()
        {
            return this.Designation;
        }

    }
}
