using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AniSync
{
    /*
    struct users
    {
        public string id; //PK
        public string password;
        public string config; //L=Local (Config stored only Local), G=Global (Same Config for all Clients stored Online), C=Client (Different Config for each Client stored Online)
    }
    struct clients
    {
        public string id; //PK
        public string userid; //FK
        public string name;
    }
    struct settings
    {
        public string id; //PK
        public string userid; //FK
        public string clientid; //FK
        public string download;
        public string workload;
        public string watched;
        public string archive;
        public bool autostart;
        public bool showpopup;
        public bool systray;
        public Int16 interval;
    }
    struct trackers
    {
        public string id; //PK
        public string userid; //FK
        public string name;
        public string url;
        public string mode; //C=Closed (Do not use), F=Full (Scan for new Animes and Episodes), U=Update (Scan only for new Episodes)
    }
    struct animes
    {
        public string id; //PK
        public string userid; //FK
        public string name_jap;
        public string name_eng;
        public string name_ger;
        public string language;
        public string sub;
        public string dub;
        public string torrent;
        public string filename;
        public string status;
        public float rating;
    }
    struct episodes
    {
        public string id; //PK
        public string animeid; //FK
        public string number;
        public string filename;
        public string checksum;
    }
    */
    public class Tables
    {
        DataTable tab;
        DataColumn col;
        DataRow row;

        public DataTable users = new DataTable("users");
        public DataTable clients = new DataTable("clients");
        public DataTable settings = new DataTable("settings");
        public DataTable trackers = new DataTable("trackers");
        public DataTable animes = new DataTable("animes");
        public DataTable episodes = new DataTable("episodes");

        public void Init()
        {
            users.Columns.Add("id", typeof(string)); //PK
            users.Columns.Add("password", typeof(string));
            users.Columns.Add("config", typeof(string)); //L=Local (Config stored only Local), G=Global (Same Config for all Clients stored Online), C=Client (Different Config for each Client stored Online)
            users.PrimaryKey = new DataColumn[] { users.Columns["id"] };

            clients.Columns.Add("id", typeof(string)); //PK
            clients.Columns.Add("userid", typeof(string)); //FK
            clients.Columns.Add("name", typeof(string));
            clients.PrimaryKey = new DataColumn[] { clients.Columns["id"] };

            settings.Columns.Add("id", typeof(string)); //PK
            settings.Columns.Add("userid", typeof(string)); //FK
            settings.Columns.Add("clientid", typeof(string)); //FK
            settings.Columns.Add("download", typeof(string));
            settings.Columns.Add("workload", typeof(string));
            settings.Columns.Add("watched", typeof(string));
            settings.Columns.Add("archive", typeof(string));
            settings.Columns.Add("autostart", typeof(string));
            settings.Columns.Add("showpopup", typeof(string));
            settings.Columns.Add("systray", typeof(string));
            settings.Columns.Add("interval", typeof(Int16));
            settings.PrimaryKey = new DataColumn[] { settings.Columns["id"] };

            trackers.Columns.Add("id", typeof(string)); //PK
            trackers.Columns.Add("userid", typeof(string)); //FK
            trackers.Columns.Add("name", typeof(string));
            trackers.Columns.Add("url", typeof(string));
            trackers.Columns.Add("mode", typeof(string)); //C=Closed (Do not use), F=Full (Scan for new Animes and Episodes), U=Update (Scan only for new Episodes)
            trackers.PrimaryKey = new DataColumn[] { trackers.Columns["id"] };

            animes.Columns.Add("id", typeof(string)); //PK
            animes.Columns.Add("userid", typeof(string)); //FK
            animes.Columns.Add("name_jap", typeof(string));
            animes.Columns.Add("name_eng", typeof(string));
            animes.Columns.Add("name_ger", typeof(string));
            animes.Columns.Add("language", typeof(string));
            animes.Columns.Add("sub", typeof(string));
            animes.Columns.Add("dub", typeof(string));
            animes.Columns.Add("torrent", typeof(string));
            animes.Columns.Add("filename", typeof(string));
            animes.Columns.Add("status", typeof(string));
            animes.Columns.Add("rating", typeof(string));
            animes.PrimaryKey = new DataColumn[] { animes.Columns["id"] };

            episodes.Columns.Add("id", typeof(string)); //PK
            episodes.Columns.Add("animeid", typeof(string)); //FK
            episodes.Columns.Add("number", typeof(string));
            episodes.Columns.Add("filename", typeof(string));
            episodes.Columns.Add("checksum", typeof(string));
            episodes.PrimaryKey = new DataColumn[] { episodes.Columns["id"] };
        }
    }
}
