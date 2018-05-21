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
            settings.Columns.Add("workload", typeof(string)); //Folder for Torrents
            settings.Columns.Add("download", typeof(string)); //Folder for finished Downloads
            settings.Columns.Add("watched", typeof(string)); //Folder for watched Episodes
            settings.Columns.Add("archive", typeof(string)); //Folder for archived Episodes (Set only for Archive)
            settings.Columns.Add("autostart", typeof(bool));
            settings.Columns.Add("showpopup", typeof(bool));
            settings.Columns.Add("systray", typeof(bool)); //
            settings.Columns.Add("interval", typeof(Int16)); //Interval for Checks in Minutes
            settings.PrimaryKey = new DataColumn[] { settings.Columns["id"] };

            trackers.Columns.Add("id", typeof(string)); //PK
            trackers.Columns.Add("userid", typeof(string)); //FK
            trackers.Columns.Add("name", typeof(string));
            trackers.Columns.Add("url", typeof(string)); //URL-Pattern for Search and List of Animes and Episodes (use {1} for Substitute)
            trackers.Columns.Add("parser", typeof(string)); //Name of implemented Parser
            trackers.Columns.Add("mode", typeof(string)); //C=Closed (Do not use), F=Full (Scan for new Animes and Episodes), U=Update (Scan only for new Episodes)
            settings.Columns.Add("priority", typeof(Int16)); //Use Tracker with higher Priority first
            trackers.PrimaryKey = new DataColumn[] { trackers.Columns["id"] };

            animes.Columns.Add("id", typeof(string)); //PK
            animes.Columns.Add("userid", typeof(string)); //FK
            animes.Columns.Add("name_jap", typeof(string));
            animes.Columns.Add("name_eng", typeof(string));
            //animes.Columns.Add("name_ger", typeof(string));
            //animes.Columns.Add("language", typeof(string));
            //animes.Columns.Add("sub", typeof(string));
            //animes.Columns.Add("dub", typeof(string));
            animes.Columns.Add("torrent", typeof(string)); 
            animes.Columns.Add("renaming", typeof(string)); //Pattern for renaming Files
            animes.Columns.Add("status", typeof(string));
            animes.Columns.Add("rating", typeof(Int16));
            animes.PrimaryKey = new DataColumn[] { animes.Columns["id"] };

            episodes.Columns.Add("id", typeof(string)); //PK
            episodes.Columns.Add("animeid", typeof(string)); //FK
            episodes.Columns.Add("number", typeof(string));
            episodes.Columns.Add("filename", typeof(string));
            episodes.Columns.Add("checksum", typeof(string));
            episodes.PrimaryKey = new DataColumn[] { episodes.Columns["id"] };
        }
        private void TestData()
        {
            row = users.NewRow();
            row["id"] = "USERID"; //PK
            row["password"] = "PASSWORD";
            row["config"] = "G"; //L=Local (Config stored only Local), G=Global (Same Config for all Clients stored Online), C=Client (Different Config for each Client stored Online)

            row = clients.NewRow();
            row["id"] = "CLIENTID"; //PK
            row["userid"] = "USERID"; //FK
            row["name"] = "CLIENTNAME";

            row = settings.NewRow();
            row["id"] = "SETTINGID"; //PK
            row["userid"] = "USERID"; //FK
            row["clientid"] = ""; //FK
            row["workload"] = @"G:\[VIDEOS]\[AniSync]";
            row["download"] = @"G:\[VIDEOS]";
            row["watched"] = @"G:\[VIDEOS]\[FILE]\[SERIES]";
            row["archive"] = @"G:\[VIDEOS]\[FILE]\[SERIES]";
            row["autostart"] = true;
            row["showpopup"] = true;
            row["systray"] = true;
            row["interval"] = 15;

            row = trackers.NewRow();
            row["id"] = "TRACKERID"; //PK
            row["userid"] = "USERID"; //FK
            row["name"] = "Nyaa.si (HorribleSubs)";
            row["url"] = @"https://nyaa.si/user/HorribleSubs?f=0&c=0_0&q=xxxxx*[720p]";
            row["parser"] = "Nyaa.si";
            row["mode"] = "U"; //C=Closed (Do not use), F=Full (Scan for new Animes and Episodes), U=Update (Scan only for new Episodes)

            row = animes.NewRow();
            row["id"] = ""; //PK
            row["userid"] = ""; //FK
            row["name_jap"] = "";
            row["name_eng"] = "";
            row["name_ger"] = "";
            row["language"] = "";
            row["sub"] = "";
            row["dub"] = "";
            row["torrent"] = "";
            row["renaming"] = "";
            row["status"] = "";
            row["rating"] = 0;

            row = episodes.NewRow();
            row["id"] = ""; //PK
            row["animeid"] = ""; //FK
            row["number"] = "";
            row["filename"] = "";
            row["checksum"] = "";
        }
    }
}
