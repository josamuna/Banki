﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coopec_Lib
{
    public class Entree
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
        private DateTime date_entree;

        public DateTime Date_entree
        {
            get { return date_entree; }
            set { date_entree = value; }
        }
        private double montant;

        public double Montant
        {
            get { return montant; }
            set
            {
                if (value <= 0) throw new Exception("Veullez saisir un montant valide svp !!");
                else montant = value; 
            }
        }
        private int id_compte;

        public int Id_compte
        {
            get { return id_compte; }
            set { id_compte = value; }
        } 
    }
}