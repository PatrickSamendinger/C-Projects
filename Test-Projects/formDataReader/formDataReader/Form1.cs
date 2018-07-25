using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.IO;


namespace formDataReader
{
    public partial class Form1 : Form
    {

       // Boolean newFile = false;
        //string filepath = null;
        
        public Form1()
        {
            InitializeComponent();
            

        }
        public static Boolean IsFileLocked(FileInfo file)
        {
            FileStream stream = null;

            try
            {
                stream = file.Open
                (
                    FileMode.Open,
                FileAccess.Read,
                FileShare.None
                );
            }
            catch (IOException)
            {
                return true;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
            return false;
        }
       

        private void btnGo_Click(object sender, EventArgs e)
        {
            FileSystemWatcher marsWatcher = new FileSystemWatcher();
            marsWatcher.Path = "C:\\Test";
            marsWatcher.Created += FileSystemWatcher_Created;
            marsWatcher.EnableRaisingEvents = true;


        }


      
        private static void FileSystemWatcher_Created(object sender, FileSystemEventArgs e)
        {
            // Test connectionstring + einlesen dummy Daten
            int KUNUMMER = 1234567;
            string KUAUSK = "test";
            DateTime KUAUSD = DateTime.Now;
            //string KUGESF = "asd";
            //string KUGESI = "Test Kunde 69";

            // XML-Datei einlesen
            XDocument xdoc = XDocument.Load((e.FullPath));

            // für jeden Kunden eine Instanz erstellen
            var Kunden = from r in xdoc.Descendants("data")
                         select new
                         {
                             Vorname = r.Element("customers_firstname").Value,
                             Nachname = r.Element("customers_lastname").Value,
                             Email = r.Element("customers_email_address").Value,
                         };



            foreach (var r in Kunden)
            {
                using (SqlConnection connection = new SqlConnection
                    ("Connectionstring"))
               
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        //command.Connection = connection;
                        //command.CommandType = CommandType.Text;
                        //command.CommandText = "INSERT INTO dbo.KUNDEN2 (KUNUMMER,KUAUSK,KUAUSD,KUGESF,KUGESI) VALUES (@KUNUMMER,@KUAUSK,@KUAUSD,@KUGESF,@KUGESI)";
                        //command.Parameters.AddWithValue("@KUNUMMER", KUNUMMER);
                        //command.Parameters.AddWithValue("@KUAUSK", KUAUSK);
                        //command.Parameters.AddWithValue("@KUAUSD", KUAUSD);
                        //command.Parameters.AddWithValue("@KUGESF", KUGESF);
                        //command.Parameters.AddWithValue("@KUGESI", KUGESI);


                        command.Connection = connection;
                        command.CommandType = CommandType.Text;
                        command.CommandText = "Insert INTO dbo.KUNDEN2 (KUNUMMER,KUAUSK,KUAUSD,KUGESF,KUGESI)VALUES (@KUNUMMER,@KUAUSK,@KUAUSD,@KUGESF,@KUGESI)";
                        command.Parameters.AddWithValue("@KUNUMMER", KUNUMMER);
                        command.Parameters.AddWithValue("@KUAUSK", KUAUSK);
                        command.Parameters.AddWithValue("@KUAUSD", KUAUSD);
                        command.Parameters.AddWithValue("@KUGESF", r.Email);
                        command.Parameters.AddWithValue("@KUGESI", r.Vorname + r.Nachname);

                        try
                        {
                            //Verbindung herstellen
                            connection.Open();
                            int recordsAffected = command.ExecuteNonQuery();

                        }
                        catch (SqlException Fehler)
                        {
                            // bei Fehlern Fehlermeldung anzeigen
                            MessageBox.Show("Fehler!" + Fehler);
                        }

                        // Verbindung wieder schließen
                        connection.Close();
                    }

                }
            }






        }
    }
}
