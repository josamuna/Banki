using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using CryptageJosam_LIB;

namespace Coopec_Lib
{
    public class Factory
    {
        public IDbConnection con;
        public OleDbConnection connect;
        public string stringConnect;
        private static string fileParamBd = "parametres.par";
        private static Factory staticFactory;
        private static string parmaFileValue;

        private static bool enterForFormClient = false;
        private static bool enterForFormCategorie = false;
        private static bool enterForFormAgent = false;
        public static int okLoginUser = 0;//Pour verifier quel utilisateur se connecte:1->Administrateur ou SuperAdim et 2->Agent(Invite)
        public static int idAgentConnecte = -1;

        #region parametre statique de la classe moteur
        public static Factory Instance
        {
            get
            {
                if (staticFactory == null)
                    staticFactory = new Factory();
                return staticFactory;
            }
        }
        private Factory()
        {
        }
        #endregion

        #region Operation sur la Connection a la base de donnees

        #region Valeur pour DB
        //Chemin acces BD
        public static string ParmaFileValue
        {
            get { return parmaFileValue; }
            set { parmaFileValue = value; }
        }

        //Accesseurs-Mutateur pour recuperer la valeur settant la reussite ou l'echec de la connexion
        //pour activer ou desactiver des menus
        //private static bool valueDb;

        //public static bool ValueDb
        //{
        //    get { return valueDb; }
        //    set { valueDb = value; }
        //}
        #endregion

        #region Sauvegarde des parametres de connection
        private static string updateCreateDirectory(string nomRepertoire)//ParametersProgramms
        {
            string cheminAccesRepertoire = "";
            //Recuperation du nom du lecteur dans lequel le projet se trouve
            string lecteur = Environment.CurrentDirectory.ToString().Substring(0, 2);
            DirectoryInfo directory = new DirectoryInfo(lecteur + @"\" + nomRepertoire);
            if (!directory.Exists)
            {
                //Creation du repertoire
                directory.Create();
                directory.Attributes = FileAttributes.Hidden;
                cheminAccesRepertoire = directory.FullName;
                //Console.WriteLine("directory.FullName = " + directory.FullName);
            }
            else
            {
                //Dossier existant
                cheminAccesRepertoire = directory.FullName;
                //throw new Exception("Echec de la céeation du répertoire");
            }
            return cheminAccesRepertoire;
        }
        #endregion

        #region Connection a la base de donnees pour les etats de sortie
        public OleDbConnection connectDB()
        {
            connect = new OleDbConnection(stringConnect);
            if (connect.State.ToString().Equals("")) throw new Exception("Impossible de charger les données de la Base de données !!");
            else if (connect.State.ToString().Equals("Open")) { }
            else connect.Open();
            return connect;
        }
        # endregion

        #region connection a la base de donnees pour les formulaires
        public bool VerifieDoConnect(string database)
        {
            bool ok = false;
            //Access 2003, 2007 ou 2010
            if (string.IsNullOrEmpty(database))
                throw new Exception("Cette base de données n'existe pas !!");
            else
            {//.accdb=bdcca. et .mdb=bdm.
                string strReverse = "";
                for (int i = 0, j = database.Length - 1; i < database.Length; i++, j--) strReverse = strReverse + database[j];

                if (strReverse[0].ToString() == 'b'.ToString() && strReverse[1].ToString() == 'd'.ToString()
                    && strReverse[2].ToString() == 'c'.ToString() && strReverse[3].ToString() == 'c'.ToString()
                    && strReverse[4].ToString() == 'a'.ToString() && strReverse[5].ToString() == '.'.ToString())
                    //Fichier Microsoft Access 2007 ou 2010
                    stringConnect = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + database;//Acsess
                else if (strReverse[0].ToString() == 'b'.ToString() && strReverse[1].ToString() == 'd'.ToString()
                    && strReverse[2].ToString() == 'm'.ToString() && strReverse[3].ToString() == '.'.ToString())
                    //Fichier Microsoft Access 2003
                    stringConnect = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + database;//Acsess
                else throw new Exception("Fichier de base de donnée Microsoft Access inconnu !!");

                con = new OleDbConnection(stringConnect);
                con.Open();
                ParmaFileValue = database;
                saveParamConnection(database);

                ok = true;
            }

            return ok;
        }

        /// <summary>
        /// Permet d'enregistrer la chaîne de connexion pour un fichier texte contenu dans un repertoire créé dynamiquement 
        /// </summary>
        /// <param name="bd">chemin d'acces de la BD</param>
        private static void saveParamConnection(string bd)
        {
            using (StreamWriter srw = new StreamWriter(updateCreateDirectory("GestionCoopec") + @"\" + fileParamBd, false))
            {
                //On crypte la chaine a sauvegarde
                srw.WriteLine("{0}", clsMetier.GetInstance().doCrypte(bd));
                srw.Close();
            }
        }

        /// <summary>
        /// Permet de charger la chaîne de connection à partir d'un fichier texte pour une Base Access et retourne un string
        /// contenant le chemin d'accès à la Base de données
        /// </summary>
        /// <returns>retourne un string</returns>
        public string loadParam()
        {
            string values = "";
            //Access
            //Decryptage de la chaine de connexion
            string strChaine = updateCreateDirectory("GestionCoopec") + @"\" + fileParamBd;
            if (File.Exists(strChaine))
            {
                using (StreamReader sr = new StreamReader(strChaine))
                {
                    if (!sr.EndOfStream)
                    {
                        string str = sr.ReadLine();
                        //string[] value = str.Split(new char[] { ';' });
                        //On peut ne pas decrypter la chaine a lire dans notre cas present
                        values = clsMetier.GetInstance().doDeCrypte(str);
                        sr.Close();
                    }
                }
            }

            return values;
        }

        /// <summary>
        /// Permet de vider le fichier contenant le chemin d'acceès de la base des données sur laquelle on doit se connnecté
        /// </summary>
        public void EmptyFileParametersDataBase()
        {
            StreamWriter write = new StreamWriter(updateCreateDirectory("GestionCoopec") + @"\parametres.par", false);
            write.WriteLine("{0}", "");
            write.Close();
        }

        /// <summary>
        /// Permet de verifier les paramètres de connexion de l'utilisateur, donc username et password
        /// et retourne un booleen
        /// </summary>
        /// <param name="username">String nom d'utilisateur</param>
        /// <param name="password">String mot de passe</param>
        /// <returns>Booleen pour la reusite ou l'echec de la connexion</returns>
        public bool verifieLoginUser(string username, string password)
        {
            bool ok = false;
            if (username.Equals("superuser") && password.Equals("superpassword"))
            {
                Factory.okLoginUser = 1;
                Factory.idAgentConnecte = -2;
                ok = true;
            }
            else
            {
                //Echec de la connexion en superAdministrateur alors on peut se connecte en utilisateur Administrateur ou in invite
                if (con.State.ToString().Equals("Open")) { }
                else con.Open();

                IDbCommand cmdVeriLoginUI = con.CreateCommand();
                cmdVeriLoginUI.CommandText = @"SELECT * FROM utilisateur WHERE nomUser=@nomUser AND passWord=@passWord";
                IDataParameter paramNomUser = cmdVeriLoginUI.CreateParameter();
                createParamString("@nomUser", username, cmdVeriLoginUI);
                createParamString("@passWord", password, cmdVeriLoginUI);

                IDataReader dr = cmdVeriLoginUI.ExecuteReader();

                if (dr.Read())
                {
                    if (Convert.ToString(dr["nomUser"]).Equals(username) && Convert.ToString(dr["passWord"]).Equals(password) && Convert.ToString(dr["categorie"]).Trim().ToLower().Equals("administrateur"))
                    {//Administrateur connecte
                        ok = true;
                        Factory.okLoginUser = 1;
                        Factory.idAgentConnecte = -2;
                    }
                    else if (Convert.ToString(dr["nomUser"]).Equals(username) && Convert.ToString(dr["passWord"]).Equals(password) && Convert.ToString(dr["categorie"]).Trim().ToLower().Equals("agent"))
                    {//Agent (Inite) connecte
                        ok = true;
                        Factory.okLoginUser = 2;
                        Factory.idAgentConnecte = int.Parse(dr["id_agent"].ToString());
                    }
                    else
                    {
                        ok = false;
                        Factory.okLoginUser = 0;
                    }
                }
                else ok = false;

                dr.Close();
                cmdVeriLoginUI.Dispose();
                con.Close();
            }

            return ok;
        }
        #endregion

        #region Fermeture de la connexion a la base de donnees
        /// <summary>
        /// Permet la fermeture de la connexion à la base de données
        /// </summary>
        public void closeConnection()
        {
            con = null;
        }
        #endregion

        #endregion

        #region operation sur la base de donnees

        #region Valeur pour actualisation des comboBox de form ouvert sur le form principal
        public static bool EnterForFormClient
        {
            get { return enterForFormClient; }
            set { enterForFormClient = value; }
        }

        public static bool EnterForFormCategorie
        {
            get { return enterForFormCategorie; }
            set { enterForFormCategorie = value; }
        }

        public static bool EnterForFormAgent
        {
            get { return enterForFormAgent; }
            set { enterForFormAgent = value; }
        }
        #endregion

        #region Creation automatique d'un Id pour chaque table de la base de donnees
        /// <summary>
        /// Permet d'obtenir un nouveau ID pour l'objet passe en paramètre
        /// </summary>
        /// <param name="parametre">Paramètre de type Object</param>
        /// <returns>Un entier</returns>
        public int ReNewIdValue(object obj)
        {
            int goodId = 0;
            string tablename = "";
            string[] tbNanetable = new string[] { "Client", "Agent", "Compte", "Entree", "Sortie", "Categorie", "PhotoAgent", "PhotoClient","Utilisateur" };
            if (obj is Client) tablename = Convert.ToString(tbNanetable[0]);
            else if (obj is Agent) tablename = Convert.ToString(tbNanetable[1]);
            else if (obj is Compte) tablename = Convert.ToString(tbNanetable[2]);
            else if (obj is Entree) tablename = Convert.ToString(tbNanetable[3]);
            else if (obj is Sortie) tablename = Convert.ToString(tbNanetable[4]);
            else if (obj is Categorie) tablename = Convert.ToString(tbNanetable[5]);
            else if (obj is PhotoAgent) tablename = Convert.ToString(tbNanetable[6]);
            else if (obj is PhotoClient) tablename = Convert.ToString(tbNanetable[7]);
            else if (obj is UtilisateurClasse) tablename = Convert.ToString(tbNanetable[8]);
            else tablename = "";

            con.Close();
            con.Open();
            IDbCommand cmdRenewID = con.CreateCommand();
            cmdRenewID.CommandText = "SELECT MAX(id) AS maxid FROM " + tablename;

            IDataReader dr = cmdRenewID.ExecuteReader();
            if (dr.Read())
            {
                if (dr["maxid"] == DBNull.Value || Convert.ToInt32(dr["maxid"]) == 0) goodId = 1;
                else goodId = Convert.ToInt32(dr["maxid"]) + 1;
            }
            dr.Close();
            cmdRenewID.Dispose();
            con.Close();
            return goodId;
        }

        public string generateMatriculeClient(int id)
        {
            string t;
            if (id.ToString().Length == 1) { t = "0000" + id; }
            else if (id.ToString().Length == 2) { t = "000" + id; }
            else if (id.ToString().Length == 3) { t = "00" + id; }
            else if (id.ToString().Length == 4) { t = "0" + id; }

            else { t = id.ToString(); }
            return t;
        }

        public string generateMatriculeAgent(int id)
        {
            string t;
            if (id.ToString().Length == 1) { t = "00" + id; }
            else if (id.ToString().Length == 2) { t = "0" + id; }
            else { t = id.ToString(); }
            return t;
        }
        #endregion

        #region creation des parametres
        public void createParamString(string ParamName, string value, IDbCommand cmd)
        {
            IDataParameter param = cmd.CreateParameter();
            param.ParameterName = ParamName;
            param.Value = value;
            cmd.Parameters.Add(param);
        }

        public void createParamInt(string ParamName, int value, IDbCommand cmd)
        {
            IDataParameter param = cmd.CreateParameter();
            param.ParameterName = ParamName;
            param.Value = value;
            cmd.Parameters.Add(param);
        }

        public void createParamIntNull(string ParamName, int? value, IDbCommand cmd)
        {
            IDataParameter param = cmd.CreateParameter();
            param.ParameterName = ParamName;
            param.Value = value;
            cmd.Parameters.Add(param);
        }

        public void createParamDate(string ParamName, DateTime value, IDbCommand cmd)
        {
            IDataParameter param = cmd.CreateParameter();
            param.ParameterName = ParamName;
            param.Value = value;
            cmd.Parameters.Add(param);
        }


        public void createParamDouble(string ParamName, Double value, IDbCommand cmd)
        {
            IDataParameter param = cmd.CreateParameter();
            param.ParameterName = ParamName;
            param.Value = value;
            cmd.Parameters.Add(param);
        }

        public void createParamBool(string ParamName, bool value, IDbCommand cmd)
        {
            IDataParameter param = cmd.CreateParameter();
            param.ParameterName = ParamName;
            param.Value = value;
            cmd.Parameters.Add(param);
        }

        public void createParamByteTable(string ParamName, byte[] value, IDbCommand cmd)
        {
            IDataParameter param = cmd.CreateParameter();
            param.ParameterName = ParamName;
            param.Value = value;
            cmd.Parameters.Add(param);
        }

        #endregion

        #region PHOTO Personne(Operation sur la photo de la Client)

        #region Recuperation de la photo de l'agent
        /// <summary>
        /// Permet de récupéré une photo que devrait être affichée dans un objet imagebox
        /// et reçoit en paramètre l'object de type photo (Client)
        /// </summary>
        /// <param name="obj">Objet de la classe</param>
        /// <returns>Retourne un objet MemoryStream</returns>
        public MemoryStream GetPhotoPersonneClient(PhotoClient photo)
        {
            MemoryStream ms = new MemoryStream();

            if (con.State.Equals("Open")) { }
            else con.Open();

            IDbCommand cmdGetPhoto = con.CreateCommand();
            cmdGetPhoto.CommandText = "SELECT photo FROM photoClient WHERE id=@id";
            IDataParameter paramPhotoPers = cmdGetPhoto.CreateParameter();
            paramPhotoPers.ParameterName = "@id";
            paramPhotoPers.Value = photo.Id;
            cmdGetPhoto.Parameters.Add(paramPhotoPers);
            ms = new MemoryStream((Byte[])cmdGetPhoto.ExecuteScalar());

            cmdGetPhoto.Dispose();
            con.Close();
            return ms;
        }
        #endregion

        /// <summary>
        /// Permet de retourner la photo de la peronne suivant son identifiant passé en paramètre
        /// </summary>
        /// <param name="id">Indetifinat de la Personne</param>
        /// <returns>Une photo du client</returns>
        public PhotoClient GetPhotoClient(int idClient)
        {
            PhotoClient photoPers = null;

            if (con.State.ToString().Equals("Open")) { }
            else con.Open();

            IDbCommand cmdGetPhotoClient = con.CreateCommand();
            cmdGetPhotoClient.CommandText = "select *from photoClient where id_client=@id_client";

            createParamInt("@id_client", idClient, cmdGetPhotoClient);

            IDataReader dr = cmdGetPhotoClient.ExecuteReader();
            if (dr.Read()) photoPers = getPhotoClient(dr);

            dr.Close();
            cmdGetPhotoClient.Dispose();
            con.Close();
            return photoPers;
        }

        private static PhotoClient getPhotoClient(IDataReader dr)
        {
            PhotoClient photoPers = new PhotoClient();
            photoPers.Id = Convert.ToInt32(dr["id"]);
            photoPers.Id_client = Convert.ToInt32(dr["id_client"]);
            photoPers.PhotoPersonne = dr["photo"].ToString();
            return photoPers;
        }

        public int GetIdPhotoClient(int idClient)
        {
            int idPhoto = 0;

            if (con.State.ToString().Equals("Open")) { }
            else con.Open();

            IDbCommand cmdGetIdPhotoClient = con.CreateCommand();
            cmdGetIdPhotoClient.CommandText = "select id from photoClient where id_client=@id_client";

            createParamInt("@id_client", idClient, cmdGetIdPhotoClient);

            IDataReader dr = cmdGetIdPhotoClient.ExecuteReader();
            if (dr.Read()) idPhoto = Convert.ToInt32(dr["id"]);

            dr.Close();
            cmdGetIdPhotoClient.Dispose();
            con.Close();
            return idPhoto;
        }
        #endregion

        #region PHOTO Personne(Operation sur la photo de la Agent)

        #region Recuperation de la photo de l'agent
        /// <summary>
        /// Permet de récupéré une photo que devrait être affichée dans un objet imagebox
        /// et reçoit en paramètre l'object de type photo (Agent)
        /// </summary>
        /// <param name="obj">Objet de la classe</param>
        /// <returns>Retourne un objet MemoryStream</returns>
        public MemoryStream GetPhotoPersonneAgent(PhotoAgent photo)
        {
            MemoryStream ms = new MemoryStream();

            if (con.State.Equals("Open")) { }
            else con.Open();

            IDbCommand cmdGetPhoto = con.CreateCommand();
            cmdGetPhoto.CommandText = "SELECT photo FROM photoAgent WHERE id=@id";
            IDataParameter paramPhotoPers = cmdGetPhoto.CreateParameter();
            paramPhotoPers.ParameterName = "@id";
            paramPhotoPers.Value = photo.Id;
            cmdGetPhoto.Parameters.Add(paramPhotoPers);
            ms = new MemoryStream((Byte[])cmdGetPhoto.ExecuteScalar());

            cmdGetPhoto.Dispose();
            con.Close();
            return ms;
        }
        #endregion

        /// <summary>
        /// Permet de retourner la photo de la peronne suivant son identifiant passé en paramètre
        /// </summary>
        /// <param name="id">Indetifinat de la Personne</param>
        /// <returns>Une photo du agent</returns>
        public PhotoAgent GetPhotoAgent(int idAgent)
        {
            PhotoAgent photoPers = null;

            if (con.State.ToString().Equals("Open")) { }
            else con.Open();

            IDbCommand cmdGetPhotoAgent = con.CreateCommand();
            cmdGetPhotoAgent.CommandText = "select *from photoAgent where id_agent=@id_agent";

            createParamInt("@id_agent", idAgent, cmdGetPhotoAgent);

            IDataReader dr = cmdGetPhotoAgent.ExecuteReader();
            if (dr.Read()) photoPers = getPhotoAgent(dr);

            dr.Close();
            cmdGetPhotoAgent.Dispose();
            con.Close();
            return photoPers;
        }

        private static PhotoAgent getPhotoAgent(IDataReader dr)
        {
            PhotoAgent photoPers = new PhotoAgent();
            photoPers.Id = Convert.ToInt32(dr["id"]);
            photoPers.Id_agent = Convert.ToInt32(dr["id_agent"]);
            photoPers.PhotoPersonne = dr["photo"].ToString();
            return photoPers;
        }

        public int GetIdPhotoAgent(int idAgent)
        {
            int idPhoto = 0;

            if (con.State.ToString().Equals("Open")) { }
            else con.Open();

            IDbCommand cmdGetIdPhotoAgent = con.CreateCommand();
            cmdGetIdPhotoAgent.CommandText = "select id from photoAgent where id_agent=@id_agent";

            createParamInt("@id_agent", idAgent, cmdGetIdPhotoAgent);

            IDataReader dr = cmdGetIdPhotoAgent.ExecuteReader();
            if (dr.Read()) idPhoto = Convert.ToInt32(dr["id"]);

            dr.Close();
            cmdGetIdPhotoAgent.Dispose();
            con.Close();
            return idPhoto;
        }
        #endregion

        #region CONVERTION DE L'IMAGE EN BINAIRE
        /// <summary>
        /// Permet de convertire l'image en données binaires
        /// </summary>
        /// <param name="filePath">Chemin de l'image</param>
        /// <returns>L'image sous forme de byte[]</returns>
        private byte[] GetImage(string cheminFichier)
        {
            FileStream fs = new FileStream(cheminFichier, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] img = br.ReadBytes((int)fs.Length);
            br.Close();
            fs.Close();
            return img;
        }
        #endregion

        #region VERIFICATION DE L'EXTENSION DU FICHIER (JPG,JPEG OU PNG)
        public bool verifiePhotoExtension(string fileName)
        {
            bool ok = false;
            string strReverse = "";
            for (int i = 0, j = fileName.Length - 1; i < fileName.Length; i++, j--) strReverse = strReverse + fileName[j];

            if (strReverse[0].ToString().ToLower() == 'g'.ToString() && strReverse[1].ToString().ToLower() == 'p'.ToString()
            && strReverse[2].ToString().ToLower() == 'j'.ToString() && strReverse[3].ToString() == '.'.ToString())
                //Fifhier jpg
                ok = true;
            else if (strReverse[0].ToString() == 'g'.ToString() && strReverse[1].ToString() == 'e'.ToString()
            && strReverse[2].ToString() == 'p'.ToString() && strReverse[3].ToString() == 'j'.ToString()
            && strReverse[4].ToString() == '.'.ToString())
                //Fifhier jpg
                ok = true;
            else if (strReverse[0].ToString().ToLower() == 'g'.ToString() && strReverse[1].ToString().ToLower() == 'n'.ToString()
            && strReverse[2].ToString().ToLower() == 'p'.ToString() && strReverse[3].ToString() == '.'.ToString())
                //Fifhier jpg
                ok = true;
            else throw new Exception("le format de la photo n'est pas valide, veuillez charger une photo au format jpg ou png svp !");
            return ok;
        }

        #endregion

        #region Insertion dans la base selon la classe en cours
        /// <summary>
        /// Permet d'enregistrer un item dans la base de données quelque soit le type d'objet
        /// </summary>
        /// <param name="obj">Object</param>
        internal void Save(object obj)
        {
            if (con.State.ToString().Equals("Open")) { }
            else con.Open();
            IDbCommand cmdSave = null, cmdSaveNnull = null, cmdSavePh = null;
            bool okClient = false, okAgent = false;
            if (obj is Categorie)
            {
                cmdSave = con.CreateCommand();
                cmdSave.CommandText = "insert into Categorie(id,designation) values(@id,@designation)";
                createParamInt("@id", ((Categorie)obj).Id, cmdSave);
                createParamString("@designation", ((Categorie)obj).Designation, cmdSave);
            }
            else if (obj is Compte)
            {
                cmdSave = con.CreateCommand();
                cmdSave.CommandText = "insert into Compte(id,id_Client,id_Categorie,designation,typeCompte) values(@id,@id_Client,id_Categorie,@designation,@typeCompte)";
                createParamInt("@id", ((Compte)obj).Id, cmdSave);
                createParamInt("@id_Client", ((Compte)obj).Id_Client, cmdSave);
                createParamInt("@id_Categorie", ((Compte)obj).Id_Categorie, cmdSave);
                createParamString("@designation", ((Compte)obj).Designation, cmdSave);
                createParamString("@typeCompte", ((Compte)obj).TypeCompte, cmdSave);
            }
            else if (obj is Entree)
            {
                cmdSave = con.CreateCommand();
                cmdSave.CommandText = "insert into Entree(id,date_entree,id_Compte,Montant) values(@id,@date_entree,@id_Compte,@montant)";
                createParamInt("@id", ((Entree)obj).Id, cmdSave);
                createParamDate("@date_entree", ((Entree)obj).Date_entree, cmdSave);
                createParamInt("@id_Compte", ((Entree)obj).Id_compte, cmdSave);
                createParamDouble("@montant", ((Entree)obj).Montant, cmdSave);
            }
            else if (obj is Sortie)
            {
                cmdSave = con.CreateCommand();
                cmdSave.CommandText = "insert into Sortie(id,date_sortie,id_Compte,Montant) values(@id,@date_sortie,@id_Compte,@montant)";
                createParamInt("@id", ((Sortie)obj).Id, cmdSave);
                createParamDate("@date_sortie", ((Sortie)obj).Date_sortie, cmdSave);
                createParamInt("@id_Compte", ((Sortie)obj).Id_compte, cmdSave);
                createParamDouble("@montant", ((Sortie)obj).Montant, cmdSave);
            }
            else if (obj is Agent)
            {
                cmdSave = con.CreateCommand();
                cmdSave.CommandText = @"insert into Agent(id,matricule,nom,postnom,prenom,sexe,etatCivil,dateNaissance,numeroTel)
                 values(@id,@matricule,@nom,@postnom,@prenom,@sexe,@etatCivil,@dateNaissance,@numeroTel)";
                createParamInt("@id", ((Agent)obj).Id, cmdSave);
                createParamString("@matricule", ((Agent)obj).Matricule, cmdSave);
                createParamString("@nom", ((Agent)obj).Nom, cmdSave);
                createParamString("@postnom", ((Agent)obj).PostNom, cmdSave);
                createParamString("@prenom", ((Agent)obj).Prenom, cmdSave);
                createParamString("@sexe", ((Agent)obj).Sexe, cmdSave);
                createParamString("@etatCivil", ((Agent)obj).EtatCivil, cmdSave);
                createParamDate("@dateNaissance", ((Agent)obj).DateNaissance, cmdSave);
                createParamString("@numeroTel", ((Agent)obj).Telephone, cmdSave);
            }
            else if (obj is PhotoClient)
            {
                okClient = true;
                if ((((PhotoClient)obj).PhotoPersonne) == null)
                {
                    cmdSaveNnull = con.CreateCommand();
                    cmdSaveNnull.CommandText = "insert into photoClient(id,id_client,photo) values(@id,@id_client,null)";
                    createParamInt("@id", ((PhotoClient)obj).Id, cmdSaveNnull);
                    createParamInt("@id_client", ((PhotoClient)obj).Id_client, cmdSaveNnull);
                    cmdSaveNnull.ExecuteNonQuery();
                    cmdSaveNnull.Dispose();
                }
                else
                {
                    cmdSavePh = con.CreateCommand();
                    cmdSavePh.CommandText = "insert into photoClient(id,id_client,photo) values(@id,@id_client,@photo)";
                    createParamInt("@id", ((PhotoClient)obj).Id, cmdSavePh);
                    createParamInt("@id_client", ((PhotoClient)obj).Id_client, cmdSavePh);
                    createParamByteTable("@photo", GetImage(((PhotoClient)obj).PhotoPersonne), cmdSavePh);
                    cmdSavePh.ExecuteNonQuery();
                    cmdSavePh.Dispose();
                }
            }
            else if (obj is PhotoAgent)
            {
                okAgent = true;
                if ((((PhotoAgent)obj).PhotoPersonne) == null)
                {
                    cmdSaveNnull = con.CreateCommand();
                    cmdSaveNnull.CommandText = "insert into photoAgent(id,id_agent,photo) values(@id,@id_agent,null)";
                    createParamInt("@id", ((PhotoAgent)obj).Id, cmdSaveNnull);
                    createParamInt("@id_agent", ((PhotoAgent)obj).Id_agent, cmdSaveNnull);
                    cmdSaveNnull.ExecuteNonQuery();
                    cmdSaveNnull.Dispose();
                }
                else
                {
                    cmdSavePh = con.CreateCommand();
                    cmdSavePh.CommandText = "insert into photoAgent(id,id_agent,photo) values(@id,@id_agent,@photo)";
                    createParamInt("@id", ((PhotoAgent)obj).Id, cmdSavePh);
                    createParamInt("@id_agent", ((PhotoAgent)obj).Id_agent, cmdSavePh);
                    createParamByteTable("@photo", GetImage(((PhotoAgent)obj).PhotoPersonne), cmdSavePh);
                    cmdSavePh.ExecuteNonQuery();
                    cmdSavePh.Dispose();
                }
            }
            else if (obj is Client)
            {
                cmdSave = con.CreateCommand();
                cmdSave.CommandText = @"insert into Client(id,id_agent,matricule,nom,postnom,prenom,sexe,etatCivil,dateNaissance,numeroTel)
                  values(@id,@id_agent,@matricule,@nom,@postnom,@prenom,@sexe,@etatCivil,@dateNaissance,@numeroTel)";
                createParamInt("@id", ((Client)obj).Id, cmdSave);
                createParamInt("@id_agent", ((Client)obj).Id_Agent, cmdSave);
                createParamString("@matricule", ((Client)obj).Matricule, cmdSave);
                createParamString("@nom", ((Client)obj).Nom, cmdSave);
                createParamString("@postnom", ((Client)obj).PostNom, cmdSave);
                createParamString("@prenom", ((Client)obj).Prenom, cmdSave);
                createParamString("@sexe", ((Client)obj).Sexe, cmdSave);
                createParamString("@etatCivil", ((Client)obj).EtatCivil, cmdSave);
                createParamDate("@dateNaissance", ((Client)obj).DateNaissance, cmdSave);
                createParamString("@numeroTel", ((Client)obj).Telephone, cmdSave);
            }
            else if (obj is UtilisateurClasse) 
            {
                cmdSave = con.CreateCommand();
                if((((UtilisateurClasse)obj).Id_agent) == null) cmdSave.CommandText  = "insert into Utilisateur values(" + ((UtilisateurClasse)obj).Id + ",null,'" + ((UtilisateurClasse)obj).NomUser + "','" + ((UtilisateurClasse)obj).PassWord + "','" + ((UtilisateurClasse)obj).Categorie + "')";
                else  cmdSave.CommandText = "insert into Utilisateur values(" + ((UtilisateurClasse)obj).Id + "," + (((UtilisateurClasse)obj).Id_agent) + ",'" + ((UtilisateurClasse)obj).NomUser + "','" + ((UtilisateurClasse)obj).PassWord + "','" + ((UtilisateurClasse)obj).Categorie + "')";
                //string 
                //cmdSave.CommandText = str;
                //Console.WriteLine(str);
                //createParamInt("@id", ((UtilisateurClasse)obj).Id, cmdSave);
                
                //createParamIntNull("@id_agent", t, cmdSave);
                //createParamString("@nomUser", ((UtilisateurClasse)obj).NomUser, cmdSave);
                //createParamString("@passWord", ((UtilisateurClasse)obj).PassWord, cmdSave);
                //createParamString("@categorie", ((UtilisateurClasse)obj).Categorie, cmdSave);
            }
            if (okClient || okAgent) { }
            else
            {
                int misJour = cmdSave.ExecuteNonQuery();

                cmdSave.Dispose();
            }
            con.Close();
        }
        #endregion

        #region Modification dans la base selon la classe en cours
        internal void Update(object obj)
        {
            if (con.State.ToString().Equals("Open")) { }
            else con.Open();

            IDbCommand cmdUpdate = null, cmdUpdateNnull = null;
            bool okClient = false, okAgent = false;

            if (obj is Categorie)
            {
                cmdUpdate = con.CreateCommand();
                cmdUpdate.CommandText = "update Categorie set designation=@designation where id=@id";

                createParamString("@designation", ((Categorie)obj).Designation, cmdUpdate);
                createParamInt("@id", ((Categorie)obj).Id, cmdUpdate);
            }
            if (obj is Compte)
            {
                cmdUpdate = con.CreateCommand();
                cmdUpdate.CommandText = "update Compte set id_Client=@id_Client,id_Categorie=@id_Categorie,designation=@designation,typeCompte=@typeCompte where id=@id";

                createParamInt("@id_Client", ((Compte)obj).Id_Client, cmdUpdate);
                createParamInt("@id_Categorie", ((Compte)obj).Id_Categorie, cmdUpdate);
                createParamString("@designation", ((Compte)obj).Designation, cmdUpdate);
                createParamString("@typeCompte", ((Compte)obj).TypeCompte, cmdUpdate);
                createParamInt("@id", ((Compte)obj).Id, cmdUpdate);
            }
            if (obj is Entree)
            {
                cmdUpdate = con.CreateCommand();
                cmdUpdate.CommandText = "update Entree set date_entree=@date_entree,id_compte=@id_compte,montant=@montant where id=@id";
                createParamDate("@date_entree", ((Entree)obj).Date_entree, cmdUpdate);
                createParamInt("@id_compte", ((Entree)obj).Id_compte, cmdUpdate);
                createParamDouble("@montant", ((Entree)obj).Montant, cmdUpdate);
                createParamInt("@id", ((Entree)obj).Id, cmdUpdate);
            }
            if (obj is Sortie)
            {
                cmdUpdate = con.CreateCommand();
                cmdUpdate.CommandText = "update Sortie set date_sortie=@date_sortie,id_compte=@id_compte,montant=@montant where id=@id";
                createParamDate("@date_sortie", ((Sortie)obj).Date_sortie, cmdUpdate);
                createParamInt("@id_compte", ((Sortie)obj).Id_compte, cmdUpdate);
                createParamDouble("@montant", ((Sortie)obj).Montant, cmdUpdate);
                createParamInt("@id", ((Sortie)obj).Id, cmdUpdate);
            }
            else if (obj is Agent)
            {
                cmdUpdate = con.CreateCommand();
                cmdUpdate.CommandText = @"update Agent set matricule=@matricule,nom=@nom,postnom=@postnom,prenom=@prenom,sexe=@sexe,etatCivil=@etatCivil,
                 dateNaissance=@dateNaissance,numeroTel=@numeroTel where id=@id";

                createParamString("@matricule", ((Agent)obj).Matricule, cmdUpdate);
                createParamString("@nom", ((Agent)obj).Nom, cmdUpdate);
                createParamString("@postnom", ((Agent)obj).PostNom, cmdUpdate);
                createParamString("@prenom", ((Agent)obj).Prenom, cmdUpdate);
                createParamString("@sexe", ((Agent)obj).Sexe, cmdUpdate);
                createParamString("@etatCivil", ((Agent)obj).EtatCivil, cmdUpdate);
                createParamDate("@dateNaissance", ((Agent)obj).DateNaissance, cmdUpdate);
                createParamString("@numeroTel", ((Agent)obj).Telephone, cmdUpdate);
                createParamInt("@id", ((Agent)obj).Id, cmdUpdate);
            }
            else if (obj is PhotoClient)
            {
                okClient = true;
                if ((((PhotoClient)obj).PhotoPersonne) == null)
                {
                    cmdUpdateNnull = con.CreateCommand();
                    cmdUpdateNnull.CommandText = "update photoClient set id_client=@id_client,photo=null where id=@id";
                    
                    createParamInt("@id_client", ((PhotoClient)obj).Id_client, cmdUpdateNnull);
                    createParamInt("@id", ((PhotoClient)obj).Id, cmdUpdateNnull);
                    cmdUpdateNnull.ExecuteNonQuery();
                    cmdUpdateNnull.Dispose();
                }
                else
                {
                    cmdUpdate = con.CreateCommand();
                    cmdUpdate.CommandText = "update photoClient set id_client=@id_client,photo=@photo where id=@id";
                    
                    createParamInt("@id_client", ((PhotoClient)obj).Id_client, cmdUpdate);
                    createParamByteTable("@photo", GetImage(((PhotoClient)obj).PhotoPersonne), cmdUpdate);
                    createParamInt("@id", ((PhotoClient)obj).Id, cmdUpdate);
                    cmdUpdate.ExecuteNonQuery();
                    cmdUpdate.Dispose();
                }
            }
            else if (obj is PhotoAgent)
            {
                okAgent = true;
                if ((((PhotoAgent)obj).PhotoPersonne) == null)
                {
                    cmdUpdateNnull = con.CreateCommand();
                    cmdUpdateNnull.CommandText = "update photoAgent set id_agent=@id_agent,photo=null where id=@id";
                    
                    createParamInt("@id_agent", ((PhotoAgent)obj).Id_agent, cmdUpdateNnull);
                    createParamInt("@id", ((PhotoAgent)obj).Id, cmdUpdateNnull);
                    cmdUpdateNnull.ExecuteNonQuery();
                    cmdUpdateNnull.Dispose();
                }
                else
                {
                    cmdUpdate = con.CreateCommand();
                    cmdUpdate.CommandText = "update photoAgent set id_agent=@id_agent,photo=@photo where id=@id";
                    
                    createParamInt("@id_agent", ((PhotoAgent)obj).Id_agent, cmdUpdate);
                    createParamByteTable("@photo", GetImage(((PhotoAgent)obj).PhotoPersonne), cmdUpdate);
                    createParamInt("@id", ((PhotoAgent)obj).Id, cmdUpdate);
                    cmdUpdate.ExecuteNonQuery();
                    cmdUpdate.Dispose();
                }
            }
            else if (obj is Client)
            {
                cmdUpdate = con.CreateCommand();
                cmdUpdate.CommandText = @"update client set id_agent=@id_agent,matricule=@matricule,nom=@nom,postnom=@postnom,prenom=@prenom,
                 sexe=@sexe,etatCivil=@etatCivil,dateNaissance=@dateNaissance,numeroTel=@numeroTel where id=@id";

                createParamInt("@id_agent", ((Client)obj).Id_Agent, cmdUpdate);
                createParamString("@matricule", ((Client)obj).Matricule, cmdUpdate);
                createParamString("@nom", ((Client)obj).Nom, cmdUpdate);
                createParamString("@postnom", ((Client)obj).PostNom, cmdUpdate);
                createParamString("@prenom", ((Client)obj).Prenom, cmdUpdate);
                createParamString("@sexe", ((Client)obj).Sexe, cmdUpdate);
                createParamString("@etatCivil", ((Client)obj).EtatCivil, cmdUpdate);
                createParamDate("@dateNaissance", ((Client)obj).DateNaissance, cmdUpdate);
                createParamString("@numeroTel", ((Client)obj).Telephone, cmdUpdate);
                createParamInt("@id", ((Client)obj).Id, cmdUpdate);
            }
            else if (obj is UtilisateurClasse) 
            {
                cmdUpdate = con.CreateCommand();
                if ((((UtilisateurClasse)obj).Id_agent) == null) { cmdUpdate.CommandText = "update Utilisateur set id_agent=null,nomUser='" + ((UtilisateurClasse)obj).NomUser + "',passWord='" + ((UtilisateurClasse)obj).PassWord + "',categorie='" + ((UtilisateurClasse)obj).Categorie + "' WHERE id=" + ((UtilisateurClasse)obj).Id; string s = "update Utilisateur set id_agent=null,nomUser='" + ((UtilisateurClasse)obj).NomUser + "',passWord='" + ((UtilisateurClasse)obj).PassWord + "',categorie='" + ((UtilisateurClasse)obj).Categorie + "' WHERE id=" + ((UtilisateurClasse)obj).Id; Console.WriteLine(s); }
                else { cmdUpdate.CommandText = "update Utilisateur set id_agent=" + ((UtilisateurClasse)obj).Id_agent + ",nomUser='" + ((UtilisateurClasse)obj).NomUser + "',passWord='" + ((UtilisateurClasse)obj).PassWord + "',categorie='" + ((UtilisateurClasse)obj).Categorie + "' WHERE id=" + ((UtilisateurClasse)obj).Id; string t = "update Utilisateur set id_agent=" + ((UtilisateurClasse)obj).Id_agent + ",nomUser='" + ((UtilisateurClasse)obj).NomUser + "',passWord='" + ((UtilisateurClasse)obj).PassWord + "',categorie='" + ((UtilisateurClasse)obj).Categorie + "' WHERE id=" + ((UtilisateurClasse)obj).Id; Console.WriteLine(t); }
                
                //cmdUpdate.CommandText = @"update Utilisateur set id_agent=@id_agent,nomUser=@nomUser, passWord=@passWord,categorie=@categorie where id=@id";
                //createParamIntNull("@id_agent", ((UtilisateurClasse)obj).Id_agent, cmdUpdate);
                //createParamString("@nomUser", ((UtilisateurClasse)obj).NomUser, cmdUpdate);
                //createParamString("@passWord", ((UtilisateurClasse)obj).PassWord, cmdUpdate);
                //createParamString("@categorie", ((UtilisateurClasse)obj).Categorie, cmdUpdate);
                //createParamInt("@id", ((UtilisateurClasse)obj).Id, cmdUpdate);
            }
            if (okAgent || okClient) { }
            else
            {
                int misJour = cmdUpdate.ExecuteNonQuery();
                if (misJour == 0) throw new Exception("Vérifier que cet enregistrement existe");
                cmdUpdate.Dispose();
            }
            con.Close();
        }

        #endregion

        #region Suppression dans la base de donnees selon la classe en cours
        /// <summary>
        /// Permet de supprimer un item dans la base de données quelque soit le type d'objet
        /// </summary>l
        /// <param name="obj">Object</param>
        internal void Delete(object obj)
        {
            if (con.State.ToString().Equals("Open")) { }
            else con.Open();

            IDbCommand cmdDelete = null;

            if (obj is Categorie)
            {
                cmdDelete = con.CreateCommand();
                cmdDelete.CommandText = "delete from Categorie where id=@id";

                createParamInt("@id", ((Categorie)obj).Id, cmdDelete);
            }
            else if (obj is Compte)
            {
                cmdDelete = con.CreateCommand();
                cmdDelete.CommandText = "delete from Compte where id=@id";

                createParamInt("@id", ((Compte)obj).Id, cmdDelete);
            }
            else if (obj is Entree)
            {
                cmdDelete = con.CreateCommand();
                cmdDelete.CommandText = "delete from Entree where id=@id";

                createParamInt("@id", ((Entree)obj).Id, cmdDelete);
            }
            else if (obj is Sortie)
            {
                cmdDelete = con.CreateCommand();
                cmdDelete.CommandText = "delete from Sortie  where id=@id";

                createParamInt("@id", ((Sortie)obj).Id, cmdDelete);
            }
            else if (obj is Agent)
            {
                cmdDelete = con.CreateCommand();
                cmdDelete.CommandText = "delete from Agent where id=@id";

                createParamInt("@id", ((Agent)obj).Id, cmdDelete);

            }
            else if (obj is Client)
            {
                cmdDelete = con.CreateCommand();
                cmdDelete.CommandText = "delete from Client where id=@id";

                createParamInt("@id", ((Client)obj).Id, cmdDelete);
            }
            else if (obj is UtilisateurClasse) 
            {
                cmdDelete = con.CreateCommand();
                cmdDelete.CommandText = "delete from Utilisateur where id=@id";

                createParamInt("@id", ((UtilisateurClasse)obj).Id, cmdDelete);
            }
            cmdDelete.ExecuteNonQuery();
            cmdDelete.Dispose();
            con.Close();
        }
        #endregion

        #endregion

        #region Operation sur les classes

        #region Operation sur Categorie

        private static Categorie getCategorie(IDataReader dr)
        {
            Categorie categorie = new Categorie();
            categorie.Id = Convert.ToInt32(dr["id"]);
            categorie.Designation = dr["designation"].ToString();
            return categorie;
        }

        public List<Categorie> GetCategories()
        {
            List<Categorie> list = new List<Categorie>();

            if (con.State.ToString().Equals("Open")) { }
            else con.Open();

            IDbCommand cmdGetCategorie = con.CreateCommand();
            cmdGetCategorie.CommandText = "SELECT * FROM Categorie ORDER BY id ASC";
            IDataReader dr = cmdGetCategorie.ExecuteReader();
            while (dr.Read())
            {
                list.Add(getCategorie(dr));
            }
            dr.Close();
            cmdGetCategorie.Dispose();
            con.Close();
            return list;
        }

        /// <summary>
        /// Permet de retourner une Fonction suivant son identifiant passé en paramètre
        /// </summary>
        /// <param name="id">Indetifinat de la Fonction</param>
        /// <returns>une Fonction</returns>
        public Categorie GetCategorie(int id)
        {
            Categorie categorie = null;

            if (con.State.ToString().Equals("Open")) { }
            else con.Open();

            IDbCommand cmdGetCategorie = con.CreateCommand();
            cmdGetCategorie.CommandText = "select id,designation from Categorie where id=@id ";
            createParamInt("@id", id, cmdGetCategorie);
            IDataReader dr = cmdGetCategorie.ExecuteReader();
            if (dr.Read()) categorie = getCategorie(dr);

            dr.Close();
            cmdGetCategorie.Dispose();
            con.Close();
            return categorie;
        }
        #endregion

        #region operation sur le compte
        private static Compte getCompte(IDataReader dr)
        {
            Compte compte = new Compte();
            compte.Id = Convert.ToInt32(dr["id"]);
            compte.Id_Client = Convert.ToInt32(dr["id_Client"]);
            compte.Id_Categorie = Convert.ToInt32(dr["id_Categorie"]);
            compte.Designation = dr["designation"].ToString();
            compte.TypeCompte = dr["typeCompte"].ToString();
            return compte;
        }

        public List<Compte> GetComptes()
        {
            List<Compte> list = new List<Compte>();

            if (con.State.ToString().Equals("Open")) { }
            else con.Open();

            IDbCommand cmdGetCompte = con.CreateCommand();
            cmdGetCompte.CommandText = "SELECT * FROM Compte ORDER BY id ASC";
            IDataReader dr = cmdGetCompte.ExecuteReader();
            while (dr.Read())
            {
                list.Add(getCompte(dr));
            }
            dr.Close();
            cmdGetCompte.Dispose();
            con.Close();
            return list;
        }

        public List<Compte> GetComptes(int idAgent)
        {
            List<Compte> list = new List<Compte>();

            if (con.State.ToString().Equals("Open")) { }
            else con.Open();

            IDbCommand cmdGetCompte = con.CreateCommand();
            cmdGetCompte.CommandText = @"SELECT Compte.id, Compte.id_Client, Compte.id_Categorie, Compte.designation, Compte.typeCompte
            FROM (Agent INNER JOIN Client ON Agent.id = Client.id_agent) INNER JOIN Compte ON Client.id = Compte.id_Client WHERE Agent.id=@id ORDER BY Compte.id ASC";
            createParamInt("@id", idAgent, cmdGetCompte);
            IDataReader dr = cmdGetCompte.ExecuteReader();
            while (dr.Read())
            {
                list.Add(getCompte(dr));
            }
            dr.Close();
            cmdGetCompte.Dispose();
            con.Close();
            return list;
        }

        public Compte GetCompte(int id)
        {
            Compte compte = null;

            if (con.State.ToString().Equals("Open")) { }
            else con.Open();

            IDbCommand cmdGetCompte = con.CreateCommand();
            cmdGetCompte.CommandText = "SELECT id,id_Client,id_Categorie,designation,typeCompte FROM Compte where id=@id ";
            createParamInt("@id", id, cmdGetCompte);
            IDataReader dr = cmdGetCompte.ExecuteReader();
            if (dr.Read()) compte = getCompte(dr);

            dr.Close();
            cmdGetCompte.Dispose();
            con.Close();
            return compte;
        }
        #endregion

        #region Operation sur les entrees

        private static Entree getEntree(IDataReader dr)
        {
            Entree entree = new Entree();
            entree.Id = Convert.ToInt32(dr["id"]);
            entree.Date_entree = Convert.ToDateTime(dr["date_entree"]);
            entree.Id_compte = Convert.ToInt32(dr["id_compte"]);
            entree.Montant = Convert.ToDouble(dr["montant"]);
            return entree;
        }

        public List<Entree> GetEntrees()
        {
            List<Entree> list = new List<Entree>();
            con.Close();
            con.Open();

            IDbCommand cmdGetEntree = con.CreateCommand();
            cmdGetEntree.CommandText = "SELECT * FROM Entree  ORDER BY id ASC";
            IDataReader dr = cmdGetEntree.ExecuteReader();
            while (dr.Read())
            {
                list.Add(getEntree(dr));
            }

            dr.Close();
            cmdGetEntree.Dispose();
            con.Close();
            return list;
        }

        public List<Entree> GetEntrees(int idAgent)
        {
            List<Entree> list = new List<Entree>();
            con.Close();
            con.Open();

            IDbCommand cmdGetEntree = con.CreateCommand();
            cmdGetEntree.CommandText = @"SELECT Entree.id AS id, Entree.date_entree AS date_entree, Entree.id_compte AS id_compte, Entree.montant AS montant, * FROM ((Agent INNER JOIN Client ON Agent.id = Client.id_agent) 
            INNER JOIN Compte ON Client.id = Compte.id_Client) INNER JOIN Entree ON Compte.id = Entree.id_compte
            WHERE (((Agent.id)=@id))";

            createParamInt("@id", idAgent, cmdGetEntree);
            IDataReader dr = cmdGetEntree.ExecuteReader();
            while (dr.Read())
            {
                list.Add(getEntree(dr));
            }

            dr.Close();
            cmdGetEntree.Dispose();
            con.Close();
            return list;
        }

        public double CalculEntree(int id_compte)
        {
            if (con.State.ToString().Equals("Open")) { }
            else con.Open();
            double totEntee = 0;

            IDbCommand cmdGetEntee = con.CreateCommand();
            cmdGetEntee.CommandText = @"SELECT sum(montant) as totEntee from Entree where id_compte=@id_compte";

            IDataParameter paramid_compte = cmdGetEntee.CreateParameter();
            paramid_compte.ParameterName = "@id_compte";
            paramid_compte.Value = id_compte;
            cmdGetEntee.Parameters.Add(paramid_compte);

            IDataReader dr = cmdGetEntee.ExecuteReader();

            if (dr.Read()) totEntee = dr["totEntee"].Equals(DBNull.Value) ? 0 : Convert.ToDouble(dr["totEntee"]);

            dr.Close();
            cmdGetEntee.Dispose();
            con.Close();
            return totEntee;
        }
        #endregion

        #region operation sur les sorties
        private static Sortie getSortie(IDataReader dr)
        {
            Sortie sortie = new Sortie();
            sortie.Id = Convert.ToInt32(dr["id"]);
            sortie.Date_sortie = Convert.ToDateTime(dr["date_sortie"]);
            sortie.Id_compte = Convert.ToInt32(dr["id_compte"]);
            sortie.Montant = Convert.ToDouble(dr["montant"]);
            return sortie;
        }
      
        public List<Sortie> GetSorties()
        {
            List<Sortie> list = new List<Sortie>();
            con.Close();
            con.Open();

            IDbCommand cmdGetSortie = con.CreateCommand();
            cmdGetSortie.CommandText = "SELECT * FROM Sortie ORDER BY id ASC";
            IDataReader dr = cmdGetSortie.ExecuteReader();
            while (dr.Read())
            {
                list.Add(getSortie(dr));
            }

            dr.Close();
            cmdGetSortie.Dispose();
            con.Close();
            return list;
        }

        public List<Sortie> GetSorties(int idAgent)
        {
            List<Sortie> list = new List<Sortie>();
            con.Close();
            con.Open();

            IDbCommand cmdGetSortie = con.CreateCommand();
            cmdGetSortie.CommandText = @"SELECT Sortie.id AS id, Sortie.date_sortie AS date_sortie, Sortie.id_compte AS id_compte, Sortie.montant AS montant, * FROM ((Agent INNER JOIN Client ON Agent.id = Client.id_agent) 
            INNER JOIN Compte ON Client.id = Compte.id_Client) INNER JOIN Sortie ON Compte.id = Sortie.id_compte WHERE (((Agent.id)=@id))";

            createParamInt("@id", idAgent, cmdGetSortie);
            IDataReader dr = cmdGetSortie.ExecuteReader();
            while (dr.Read())
            {
                list.Add(getSortie(dr));
            }

            dr.Close();
            cmdGetSortie.Dispose();
            con.Close();
            return list;
        }

        public double CalculSortie(int id_compte)
        {
            if (con.State.ToString().Equals("Open")) { }
            else con.Open();
            double totSortie = 0;

            IDbCommand cmdGetSortie = con.CreateCommand();
            cmdGetSortie.CommandText = @"SELECT sum(montant) as totSortie from Sortie where id_compte=@id_compte";

            IDataParameter paramid_compte = cmdGetSortie.CreateParameter();
            paramid_compte.ParameterName = "@id_compte";
            paramid_compte.Value = id_compte;
            cmdGetSortie.Parameters.Add(paramid_compte);

            IDataReader dr = cmdGetSortie.ExecuteReader();

            if (dr.Read()) totSortie = dr["totSortie"].Equals(DBNull.Value) ? 0 : Convert.ToDouble(dr["totSortie"]);

            dr.Close();
            cmdGetSortie.Dispose();
            con.Close();
            return totSortie;
        }
        #endregion

        #region Operation sur le client
        private static Client getClient(IDataReader dr)
        {
            Client client = new Client();
            client.Id = Convert.ToInt32(dr["id"].ToString());
            client.Id_Agent = Convert.ToInt32(dr["id_agent"].ToString());
            client.Nom = dr["nom"].ToString();
            client.PostNom = dr["postnom"].ToString();
            client.Prenom = dr["prenom"].ToString();
            client.Sexe = dr["sexe"].ToString();
            client.EtatCivil = dr["etatCivil"].ToString();
            client.Telephone = dr["numeroTel"].ToString();
            client.DateNaissance = Convert.ToDateTime(dr["dateNaissance"]);
            client.Matricule = dr["matricule"].ToString();
            return client;
        }

        /// <summary>
        /// Permet de retourner touts les Agent
        /// </summary>
        /// <returns>Liste des Agents</returns>
        public List<Client> GetClients()
        {
            List<Client> list = new List<Client>();

            con.Close();
            if (con.State.ToString().Equals("Open")) { }
            else con.Open();
            IDbCommand cmdGetPersonnes = con.CreateCommand();
            cmdGetPersonnes.CommandText = @"SELECT id,id_agent,matricule,nom,postnom,prenom,sexe,etatcivil,dateNaissance,numeroTel FROM Client ";
            IDataReader dr = cmdGetPersonnes.ExecuteReader();
            while (dr.Read())
            {
                list.Add(getClient(dr));
            }
            dr.Close();
            cmdGetPersonnes.Dispose();
            con.Close();
            return list;
        }

        public List<Client> GetClients(int idAgent)
        {
            List<Client> list = new List<Client>();

            con.Close();
            if (con.State.ToString().Equals("Open")) { }
            else con.Open();
            IDbCommand cmdGetPersonnes = con.CreateCommand();
            cmdGetPersonnes.CommandText = @"SELECT id,id_agent,matricule,nom,postnom,prenom,sexe,etatcivil,dateNaissance,numeroTel FROM Client WHERE id_agent=@id";
            createParamInt("@id", idAgent, cmdGetPersonnes);
            IDataReader dr = cmdGetPersonnes.ExecuteReader();
            while (dr.Read())
            {
                list.Add(getClient(dr));
            }
            dr.Close();
            cmdGetPersonnes.Dispose();
            con.Close();
            return list;
        }

        /// <summary>
        /// Permet de retourner un Agent son identifiant passé en paramètre
        /// </summary>
        /// <param name="id">Indetifinat de l'Agent</param>
        /// <returns>un Agent</returns>
        public Client GetClient(int id)
        {
            Client client = null;

            if (con.State.ToString().Equals("Open")) { }
            else con.Open();

            IDbCommand cmdGeClient = con.CreateCommand();
            cmdGeClient.CommandText = @"SELECT id,id_agent,matricule,nom,postnom,prenom,sexe,etatcivil,dateNaissance,numeroTel FROM Client WHERE id=@id";
            createParamInt("@id", id, cmdGeClient);

            IDataReader dr = cmdGeClient.ExecuteReader();
            if (dr.Read()) client = getClient(dr);

            dr.Close();
            cmdGeClient.Dispose();
            con.Close();
            return client;
        }
        #endregion

        #region operation sur l'agent
        private static Agent getAgent(IDataReader dr)
        {
            Agent agent = new Agent();
            agent.Id = Convert.ToInt32(dr["id"].ToString());
            agent.Nom = dr["nom"].ToString();
            agent.PostNom = dr["postnom"].ToString();
            agent.Prenom = dr["prenom"].ToString();
            agent.Sexe = dr["sexe"].ToString();
            agent.EtatCivil = dr["etatCivil"].ToString();
            agent.Telephone = dr["numeroTel"].ToString();
            agent.DateNaissance = Convert.ToDateTime(dr["dateNaissance"]);
            agent.Matricule = dr["matricule"].ToString();
            return agent;
        }

        /// <summary>
        /// Permet de retourner touts les Agent
        /// </summary>
        /// <returns>Liste des Agents</returns>
        public List<Agent> GetAgents()
        {
            List<Agent> list = new List<Agent>();

            if (con.State.ToString().Equals("Open")) { }
            else con.Open();
            IDbCommand cmdGetPersonnes = con.CreateCommand();
            cmdGetPersonnes.CommandText = @"SELECT id,matricule,nom,postnom,prenom,sexe,etatcivil,dateNaissance,numeroTel FROM agent";
            IDataReader dr = cmdGetPersonnes.ExecuteReader();
            while (dr.Read())
            {
                list.Add(getAgent(dr));
            }
            dr.Close();
            cmdGetPersonnes.Dispose();
            con.Close();
            return list;
        }

        public List<Agent> GetAgents(int idAgent)
        {
            List<Agent> list = new List<Agent>();

            if (con.State.ToString().Equals("Open")) { }
            else con.Open();
            IDbCommand cmdGetPersonnes = con.CreateCommand();
            cmdGetPersonnes.CommandText = @"SELECT id,matricule,nom,postnom,prenom,sexe,etatcivil,dateNaissance,numeroTel FROM agent WHERE id=@id";
            createParamInt("@id", idAgent, cmdGetPersonnes);
            IDataReader dr = cmdGetPersonnes.ExecuteReader();
            if (dr.Read()) list.Add(getAgent(dr));
            dr.Close();
            cmdGetPersonnes.Dispose();
            con.Close();
            return list;
        }

        /// <summary>
        /// Permet de retourner un Agent son identifiant passé en paramètre
        /// </summary>
        /// <param name="id">Indetifinat de l'Agent</param>
        /// <returns>un Agent</returns>
        public Agent GetAgent(int id)
        {
            Agent agent = null;

            if (con.State.ToString().Equals("Open")) { }
            else con.Open();

            IDbCommand cmdGeAgent = con.CreateCommand();
            cmdGeAgent.CommandText = @"SELECT id,matricule,nom,postnom,prenom,sexe,etatcivil,dateNaissance,numeroTel FROM Agent WHERE id=@id";
            createParamInt("@id", id, cmdGeAgent); 
            IDataReader dr = cmdGeAgent.ExecuteReader();
            if (dr.Read()) agent = getAgent(dr);

            dr.Close();
            cmdGeAgent.Dispose();
            con.Close();
            return agent;
        }

        public Agent GetAgentNotNull(int? id)
        {
            Agent agent = null;

            if (con.State.ToString().Equals("Open")) { }
            else con.Open();

            IDbCommand cmdGeAgent = con.CreateCommand();
            cmdGeAgent.CommandText = @"SELECT id,matricule,nom,postnom,prenom,sexe,etatcivil,dateNaissance,numeroTel FROM Agent WHERE id=@id";
            createParamIntNull("@id", id, cmdGeAgent);
            IDataReader dr = cmdGeAgent.ExecuteReader();
            if (dr.Read()) agent = getAgent(dr);

            dr.Close();
            cmdGeAgent.Dispose();
            con.Close();
            return agent;
        }

        #endregion

        #region operation sur les utilisateurs
        private static UtilisateurClasse getUtilisateur(IDataReader dr)
        {
            UtilisateurClasse utilisateur = new UtilisateurClasse();
            utilisateur.Id = Convert.ToInt32(dr["id"]);
            if (dr["id_agent"] == DBNull.Value) utilisateur.Id_agent = null;
            //if (Convert.ToInt32(dr["id_agent"]) == 0) utilisateur.Id_agent = 0;
            else utilisateur.Id_agent = Convert.ToInt32(dr["id_agent"]);
            utilisateur.NomUser = dr["nomUser"].ToString();
            utilisateur.PassWord = dr["passWord"].ToString();
            utilisateur.Categorie = dr["categorie"].ToString();
            
            return utilisateur;
        }

        public List<UtilisateurClasse> GetUtilisateurs()
        {
            List<UtilisateurClasse> list = new List<UtilisateurClasse>();

            if (con.State.ToString().Equals("Open")) { }
            else con.Open();

            IDbCommand cmdGetUtilisateur = con.CreateCommand();
            cmdGetUtilisateur.CommandText = "SELECT * FROM Utilisateur ORDER BY id ASC";
            IDataReader dr = cmdGetUtilisateur.ExecuteReader();
            while (dr.Read())
            {
                list.Add(getUtilisateur(dr));
            }
            dr.Close();
            cmdGetUtilisateur.Dispose();
            con.Close();
            return list;
        }

        /// <summary>
        /// Permet de retourner une Fonction suivant son identifiant passé en paramètre
        /// </summary>
        /// <param name="id">Indetifinat de la Fonction</param>
        /// <returns>une Fonction</returns>
        public UtilisateurClasse GetUtilisateur(int id)
        {
            UtilisateurClasse utilisateur = null;

            if (con.State.ToString().Equals("Open")) { }
            else con.Open();

            IDbCommand cmdGetUtilisateur = con.CreateCommand();
            cmdGetUtilisateur.CommandText = "select * from Utilisateur where id=@id ";
            createParamInt("@id", id, cmdGetUtilisateur);
            IDataReader dr = cmdGetUtilisateur.ExecuteReader();
            if (dr.Read()) utilisateur = getUtilisateur(dr);

            dr.Close();
            cmdGetUtilisateur.Dispose();
            con.Close();
            return utilisateur;
        }

        /// <summary>
        /// Permet de vérifier le mot de passe de l'utilisateur passé en parametre
        /// </summary>
        /// <param name="userName">String Nom user</param>
        /// <returns>Booleen</returns>
        public bool VerifiePassword(string userName)
        {
            bool ok = false;
            //if (con.State.ToString().Equals("Open")) { }
            //else con.Open();
            con.Close();
            con.Open();

            IDbCommand cmdVerifPwd = con.CreateCommand();
            cmdVerifPwd.CommandText = "SELECT passWord FROM Utilisateur WHERE nomUser=@nomUser";

            IDataParameter paramNomuser = cmdVerifPwd.CreateParameter();
            paramNomuser.ParameterName = "@nomUser";
            paramNomuser.Value = userName;
            cmdVerifPwd.Parameters.Add(paramNomuser);

            IDataReader dr = cmdVerifPwd.ExecuteReader();

            if (dr.Read())
            {
                if (!dr["passWord"].Equals(DBNull.Value)) ok = true;
                else ok = false;
            }

            dr.Close();
            cmdVerifPwd.Dispose();
            con.Close();
            return ok;
        }

        ///// <summary>
        ///// Permet de modifier uniquement le mot de passe de l'utilisateur en lui passant en paramètre le nom d'utilisateur et le nouveau mot de passe de ce dernier
        ///// </summary>
        ///// <param name="userName">String</param>
        ///// <param name="password">String</param>
        //public void UpdatePasswordUser(string userName, string password)
        //{
        //    int idUtilisateur = 0;
        //    if (con.State.ToString().Equals("Open")) { }
        //    else con.Open();
        //    //con.Close();
        //    //con.Open();
        //    IDbCommand cmdGetIdUserName2 = null;
        //    cmdGetIdUserName2 = con.CreateCommand();
        //    cmdGetIdUserName2.CommandText = "select id from Utilisateur where nomUser=@nomUser";

        //    IDataParameter paramNomuser = cmdGetIdUserName2.CreateParameter();
        //    paramNomuser.ParameterName = "@nomUser";
        //    paramNomuser.Value = userName;
        //    cmdGetIdUserName2.Parameters.Add(paramNomuser);

        //    IDataReader dr = cmdGetIdUserName2.ExecuteReader();
        //    if (dr.Read()) idUtilisateur = Convert.ToInt32(dr["id"]);

        //    dr.Close();

        //    cmdGetIdUserName2.Dispose();

        //    IDbCommand cmdUpdatePasswordUser = null;
        //    cmdUpdatePasswordUser = con.CreateCommand();
        //    cmdUpdatePasswordUser.CommandText = "update Utilisateur set passWord=@passWord where id=@id";

        //    IDataParameter paramMotpass = cmdUpdatePasswordUser.CreateParameter();
        //    paramMotpass.ParameterName = "@passWord";
        //    paramMotpass.Value = password;
        //    IDataParameter paramId = cmdUpdatePasswordUser.CreateParameter();
        //    paramId.ParameterName = "@id";
        //    paramId.Value = idUtilisateur;

        //    cmdUpdatePasswordUser.Parameters.Add(paramMotpass);
        //    cmdUpdatePasswordUser.Parameters.Add(paramId);

        //    int misJour = cmdUpdatePasswordUser.ExecuteNonQuery();
        //    cmdUpdatePasswordUser.Dispose();
        //    con.Close();
        //    if (misJour == 0) throw new Exception("rassurez vous que cet enregistrement existe réellement et réessayez svp");
        //}

        /// <summary>
        /// Permet de modifier uniquement le nom de l'utilisateur en lui passant en paramètre l'ancien nom d'utilisateur ansi que le nouveau a changer
        /// </summary>
        /// <param name="oldNameUser">String</param>
        /// /// <param name="newNameUser">String</param>
        public void UpdateUserName(string oldNameUser, string newNameUser)
        {
            int idUtilisateur = 0;
            //if (con.State.ToString().Equals("Open")) { }
            //else con.Open();
            con.Close();
            con.Open();
            IDbCommand cmdGetIdUserName = null;
            cmdGetIdUserName = con.CreateCommand();
            cmdGetIdUserName.CommandText = "select id from Utilisateur where nomUser=@nomUser";

            IDataParameter paramNomuser = cmdGetIdUserName.CreateParameter();
            paramNomuser.ParameterName = "@nomUser";
            paramNomuser.Value = oldNameUser;
            cmdGetIdUserName.Parameters.Add(paramNomuser);
            IDataReader dr = cmdGetIdUserName.ExecuteReader();
            if (dr.Read()) idUtilisateur = Convert.ToInt32(dr["id"]);

            dr.Close();
            cmdGetIdUserName.Dispose();

            IDbCommand cmdUpdateUserName = null;
            cmdUpdateUserName = con.CreateCommand();
            cmdUpdateUserName.CommandText = "update Utilisateur set nomUser=@nomUser WHERE id=@id";

            IDataParameter paramNomuser1 = cmdUpdateUserName.CreateParameter();
            paramNomuser1.ParameterName = "@nomUser";
            paramNomuser1.Value = newNameUser;
            IDataParameter paramId = cmdUpdateUserName.CreateParameter();
            paramId.ParameterName = "@id";
            paramId.Value = idUtilisateur;

            cmdUpdateUserName.Parameters.Add(paramNomuser1);
            cmdUpdateUserName.Parameters.Add(paramId);

            int misJour = cmdUpdateUserName.ExecuteNonQuery();
            cmdUpdateUserName.Dispose();
            con.Close();
            if (misJour == 0) throw new Exception("rassurez vous que cet enregistrement existe réellement et réessayez svp");
        }

        public bool VerifieUniqueAdmin()
        {
            bool ok = false;
            //if (con.State.ToString().Equals("Open")) { }
            //else con.Open();
            con.Close();
            con.Open();

            IDbCommand cmdVerifPwd = con.CreateCommand();
            cmdVerifPwd.CommandText = "SELECT COUNT(id) AS nbrAdmin FROM Utilisateur WHERE categorie='Administrateur'";

            IDataReader dr = cmdVerifPwd.ExecuteReader();

            if (dr.Read()) 
            {
                if (Convert.ToInt32(dr["nbrAdmin"].ToString()) == 1) ok = false;
                else ok = true;
            }

            dr.Close();
            cmdVerifPwd.Dispose();
            con.Close();
            return ok;
        }
        #endregion

        #endregion
    }
}
