using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Forms;
using READOO.Properties;

namespace READOO
{
    public class HarvestKeywords
    {

        // DECLARE SETUP VARIABLES
        // KEEP PATHS RELATIVE !

        // WHERE THE PROGRAM KEEPS ITS LOG
        public static string KeywordsLog = Settings.Default.KeywordsLog;
        // WHERE PEOPLE CAN READ THE KEYWORDS
        public static string KeywordsLogForHumans = Settings.Default.KeywordsLogForHumans;
        // WHERE THE SERVER KEEPS IT'S LOGS
        public static string LogsDirectory = Settings.Default.LogsDirectory;
        // WHERE YOU KEEP THE PAGE TITLE XML
        public static string PageTitleXML = Settings.Default.PageTitleXML;
        // WHERE YOU WANT THE HOT SEARCHES XML
        public static string HotSearchesXML = Settings.Default.HotSearchesXML;

        // REGEX TO BLACKLIST KEYWORDS
        public static string UnwantedKeywords = Settings.Default.UnwantedKeywords;
        // WHAT THE INCLUDED TEXT SAYS
        public static string HTMLText = Settings.Default.HTMLText;

        // HOW MANY TIMES TO RUN BEFORE CLEANUP
        public static int RunsBeforeCleaning = Settings.Default.RunsBeforeCleaning;
        // MINIMUM OCCURRENCES KEPT DURING CLEANUP
        public static int MinimumOccurrencesToKeep = Settings.Default.MinimumOccurrencesToKeep;

        // HOW THE SERVER NAMES THE REFERRER LOGS
        public static string SystemLogFormat = Settings.Default.SystemLogFormat;

        public static bool PlainText = Settings.Default.PlainText;
        public static bool DeliminatedFlatFile = Settings.Default.deliminatedFlatFile;
        public static bool XML = Settings.Default.XML;

        public static bool PrintToConsole = false;






        //###############################################################//

        // DECLARE GENERAL VARIABLES

        public static string CurrentLog = LogsDirectory + "/ex090716.log";			// # # EDIT ME TO WORK IN REAL LIFE # #
        public static List<Referral> Referrals = new List<Referral>();
        public static string newTitleXML;
        public static string newHotSearchXML;
        public static string Today = DateTime.Now.ToString("yyyy-MMM-dd");
        private static string Yesterday = Convert.ToString(Convert.ToInt32(DateTime.Now.ToString("yyMMdd")) - 1);
        private static string line;
        private static int RunCount;

        public delegate void ReportDelegate(int percent, string status);





        //////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////


        // REFERRAL OBJECT CLASS

        public class Referral
        {
            public string URL;
            public Dictionary<string, int> Keywords = new Dictionary<string, int>();

            private static List<string> URLs = new List<string>();
            private bool UniqueURL;

            // CONSTRUCTOR
            public Referral(string MyURL, string MyKeyword, int MyOccurrences)
            {

                if (Referrals.Count == 0)
                {
                    URL = MyURL;
                    Keywords.Add(MyKeyword, MyOccurrences);
                    URLs.Add(MyURL);
                }
                else
                {
                    // RESET FLAG
                    UniqueURL = true;

                    for (int i = 0; i < Referrals.Count; i++)
                    {
                        if (Referrals[i].URL == MyURL)
                        {
                            // TRIP URL FLAG
                            UniqueURL = false;

                            // NOW CHECK KEYWORDS OF URL
                            if (Referrals[i].Keywords.ContainsKey(MyKeyword) == true)
                            {
                                // ADD TO OCCURRENCES
                                Referrals[i].Keywords[MyKeyword] += MyOccurrences;
                            }

                            // IF IT DOESNT HAVE THE KEY
                            if (Referrals[i].Keywords.ContainsKey(MyKeyword) == false)
                            {
                                // ADD TO LIST
                                Referrals[i].Keywords.Add(MyKeyword, MyOccurrences);
                            }
                        }
                    }

                    // IF IT'S A NEW URL
                    if (UniqueURL == true)
                    {
                        URL = MyURL;
                        Keywords.Add(MyKeyword, MyOccurrences);
                        URLs.Add(MyURL);
                    }
                }
            }

            // GIVES TOP KEYWORDS
            public static List<string> GetKeywords(string MyURL, int HowMany)
            {

                List<string> TopKeywords = new List<string>();

                for (int i = 0; i < Referrals.Count; i++)
                {
                    if (Regex.IsMatch(Referrals[i].URL, MyURL))
                    {
                        foreach (var Keyword in Referrals[i].Keywords)
                        {
                            if (TopKeywords.Count < HowMany)
                            {
                                TopKeywords.Add(Keyword.Key);
                            }
                        }
                    }
                }

                return TopKeywords;
            }

            // REMOVES ALL OBJECTS FROM LIST
            public static void Clean()
            {
                for (int i = 0; i < Referrals.Count(); i++)
                {
                    Referrals.Remove(Referrals[i]);
                }
            }
        }






        //////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////


        // METHOD: PROCESS LOG

        static void ProcessLog(string fileName, ReportDelegate _update_Delegate)
        {
            using (StreamReader r = new StreamReader(fileName))
            {

                while ((line = r.ReadLine()) != null)
                {
                    // FIND QUERIES
                    Match m = Regex.Match(line, @"(p|q)=([^\s%]+)");
                    string referringWords = m.Groups[2].Value;

                    if (m.Success)
                    {
                        // GET URL
                        Match m2 = Regex.Match(line, @"\s/[^\s]+");
                        string referringURL = m2.Value;

                        // GET KEYWORDS
                        referringWords = Regex.Replace(referringWords, "&(.*)", " ");
                        referringWords = Regex.Replace(referringWords, "[^a-zA-Z]", " ");

                        // IF EVERYTHING MAKES SENSE??
                        if (
                         Regex.IsMatch(referringWords, "[a-zA-Z]{3,50}") &&
                         Regex.IsMatch(referringURL, "\\.(aspx|asp|html|php|xhtml|)") &&        //ALLOW USER TO SELECT APPROPRIATE EXTENSIONS
                         Regex.IsMatch(referringURL, "/site/default\\.aspx$") == false &&
                         Regex.IsMatch(referringWords, "cache|http|www|iceurl") == false &&
                         Regex.IsMatch(referringWords, UnwantedKeywords) == false
                            )
                        {
                            var NewReferral = new Referral(referringURL.Trim(), referringWords.Trim().ToLower(), 1);
                            if (NewReferral.URL == referringURL.Trim()) { Referrals.Add(NewReferral); }
                        }
                    }

                    // GET CLIENT IP // 165.155.110.2
                    //Match i = Regex.Match(line, @"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}");
                    //string ClientIP = i.Groups[0].Value + "\n";
                    //Console.Write(line + "##" + ClientIP + "##" + );


                }
            }
        }






        //////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////


        // METHOD: PROCESS KEYWORD FILE

        static void ProcessKeywordFile(ReportDelegate _update_Delegate)
        {

            //INIT VARS
            int Occurrences = 0;
            string URL = "";
            string Keyword = "";
            int counter = 1;

            //GET OLD DATA
            using (StreamReader r = new StreamReader(KeywordsLog))
            {
                while ((line = r.ReadLine()) != null)
                {
                    if (counter > 1)
                    {
                        // GET URL
                        URL = Regex.Match(line, "/site/[^$]*").Value;

                        foreach (string Pair in Regex.Split(line, "\\$"))
                        {
                            // GET KEYWORDS && OCCURRENCES
                            Match m = Regex.Match(Pair, "^([0-9]+)#(.+)");

                            if (Regex.IsMatch(m.Groups[1].Value, "[0-9]+"))
                            {
                                Occurrences = Convert.ToInt32(m.Groups[1].Value);
                                Keyword = m.Groups[2].Value;

                                var NewReferral = new Referral(URL, Keyword, Occurrences);
                                if (NewReferral.Keywords.ContainsKey(Keyword)) { Referrals.Add(NewReferral); }
                            }
                        }
                    }
                    counter++;
                }
            }
        }






        //////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////


        // METHOD: CLEAN ANOMALIES FROM KEYWORD LOG

        static void CleanAnomalies(ReportDelegate _update_Delegate)
        {
            bool pass = false;

            if (PrintToConsole == true) { Console.Write("\n\tCleaning logs. . . \n\n"); }

            Referral.Clean();
            ProcessKeywordFile(_update_Delegate);

            // OPEN STREAM TO KEYWORDS.LOG
            StreamWriter fileWrite = new StreamWriter(KeywordsLog);
            StreamWriter fileWriteForHumans = new StreamWriter(KeywordsLogForHumans);

            // RESET RUN COUNT
            fileWrite.WriteLine("0");

            fileWriteForHumans.WriteLine("READOO!\r\n\r\nKEYWORDS CAUGHT TO DATE: {0}\r\n RUNS BEFORE NEXT CLEANUP: {1}", Today, RunsBeforeCleaning);
            if (PrintToConsole == true) { Console.WriteLine("\n\nREADOO!\n\nKEYWORDS CAUGHT TO DATE: {0}\n RUNS BEFORE NEXT CLEANUP: {1}", Today, RunsBeforeCleaning); }

            for (int i = 0; i < Referrals.Count(); i++)
            {
                pass = false;

                // FIRST THE URL
                if (PrintToConsole == true) { Console.Write("\n\n{0}\n-", Referrals[i].URL); }

                fileWriteForHumans.WriteLine("");
                fileWriteForHumans.WriteLine("{0}", Referrals[i].URL);

                // IF THERES AN ALLOWED KEYWORD
                // NOW TO THE FILE!
                foreach (string Phrase in Referrals[i].Keywords.Keys)
                {
                    if (Referrals[i].Keywords[Phrase] >= MinimumOccurrencesToKeep)
                    {
                        pass = true;
                    }
                }
                if (pass == true)
                {
                    fileWrite.Write("{0}", Referrals[i].URL);
                }

                var SortedKeys = from k in Referrals[i].Keywords.Keys orderby Referrals[i].Keywords[k] descending select k;
                foreach (string Phrase in SortedKeys)
                {
                    if (Referrals[i].Keywords[Phrase] >= MinimumOccurrencesToKeep)
                    {
                        if (PrintToConsole == true) { Console.Write("\t({0}) {1}\n", Referrals[i].Keywords[Phrase], Phrase); }
                        fileWriteForHumans.WriteLine("\t({0}) {1}", Referrals[i].Keywords[Phrase], Phrase);
                        fileWrite.Write("${0}#{1}", Referrals[i].Keywords[Phrase], Phrase);
                    }
                }

                // LINE BREAK FOR FILE!
                fileWrite.WriteLine("");
                fileWriteForHumans.WriteLine("");
            }

            fileWriteForHumans.WriteLine("");
            fileWriteForHumans.WriteLine("");

            // CLOSE FILE STREAM
            fileWrite.Close();
            fileWriteForHumans.Close();

            if (PrintToConsole == true) { Console.Write("\n\nDone!"); }

            Referral.Clean();

        }






        //////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////


        // METHOD: UPDATE PROGRAM LOGS

        static void UpdateProgramLogs(ReportDelegate _update_Delegate)
        {

            // OPEN STREAM TO KEYWORDS.LOG
            StreamWriter fileWrite = new StreamWriter(KeywordsLog);
            StreamWriter fileWriteForHumans = new StreamWriter(KeywordsLogForHumans);

            // UPDATE RUN TALLY
            fileWrite.WriteLine(RunCount);

            fileWriteForHumans.WriteLine("READOO! Written by Dylan Lloyd.\r\n\r\nKEYWORDS CAUGHT TO DATE: {0}\r\n RUNS BEFORE NEXT CLEANUP: {1}", Today, RunsBeforeCleaning - RunCount);

            for (int i = 0; i < Referrals.Count(); i++)
            {
                fileWriteForHumans.WriteLine("");
                fileWriteForHumans.WriteLine("{0}", Referrals[i].URL);

                // NOW TO THE FILE!
                fileWrite.Write("{0}", Referrals[i].URL);

                var SortedKeys = from k in Referrals[i].Keywords.Keys orderby Referrals[i].Keywords[k] descending select k;
                foreach (string Phrase in SortedKeys)
                {
                    fileWriteForHumans.WriteLine("\t({0}) {1}", Referrals[i].Keywords[Phrase], Phrase);

                    // NOW TO THE FILE!
                    fileWrite.Write("${0}#{1}", Referrals[i].Keywords[Phrase], Phrase);
                }

                // LINE BREAK FOR FILE!
                fileWrite.WriteLine("");
                fileWriteForHumans.WriteLine("");
            }

            // CLOSE FILE STREAM
            fileWrite.Close();
            fileWriteForHumans.Close();
        }






        //////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////


        // METHOD: Update XML

        static void UpdateXML(ReportDelegate _update_Delegate)
        {
            string HotSearches = "";

            // OPEN PAGE TITLES XML
            using (StreamReader r = new StreamReader(PageTitleXML))
            {
                while ((line = r.ReadLine()) != null)
                {
                    _update_Delegate(70, "Getting XML information");

                    // GET NAME && BEGINNING OF LINE
                    Match m = Regex.Match(line, "([^n]+name=\")([^\"]+)");
                    string beginning = m.Groups[1].Value;
                    string name = m.Groups[2].Value;

                    // GET TITLE && END OF LINE
                    m = Regex.Match(line, ">([^<(&#)]+)[^<]*(.+)");
                    string title = m.Groups[1].Value.Trim();
                    string end = m.Groups[2].Value;

                    // GATHER TOP KEYWORDS FOR INDIVIDUAL PAGES
                    if (Regex.IsMatch(title, "[a-zA-Z]") && Regex.IsMatch(name, "[a-zA-Z]"))
                    {
                        newTitleXML += beginning + name + "\">" + title;
                        newHotSearchXML += beginning + name + "\">";

                        List<string> MyKeywordList = new List<string>(Referral.GetKeywords(name + "$", 5));

                        for (int counter = MyKeywordList.Count - 1; counter >= 0; counter--)
                        {
                            if (Regex.IsMatch(title, MyKeywordList[counter], RegexOptions.IgnoreCase) |
                             Regex.IsMatch(MyKeywordList[counter], "tempositions", RegexOptions.IgnoreCase)
                             )
                            {
                                MyKeywordList.Remove(MyKeywordList[counter]);
                            }
                        }
                        
                        int i = 0;
                        HotSearches = "";
                        foreach (string keyword in MyKeywordList)
                        {
                            if (i == 0 && i != MyKeywordList.Count - 1) { newTitleXML += " &#124; " + keyword + " &#149; "; HotSearches += keyword + ", "; }
                            else if (i == 0) { newTitleXML += " &#124; " + keyword; HotSearches += keyword; }
                            else if (i != MyKeywordList.Count - 1) { newTitleXML += keyword + " &#149; "; HotSearches += keyword + ", "; }
                            else { newTitleXML += keyword; HotSearches += keyword; }
                            i++;
                        }
                        newTitleXML += end + "\r\n";
                        if (Regex.IsMatch(HotSearches, "[a-zA-Z]"))
                        {
                            newHotSearchXML += HTMLText + HotSearches + ".";
                        }
                        newHotSearchXML += "</page>\r\n";
                    }

                    else if (Regex.IsMatch(line, "[a-zA-Z]"))
                    {
                        newTitleXML += line + "\r\n";
                        newHotSearchXML += line + "\r\n";
                    }
                }
            }

            _update_Delegate(70, "Overwriting results files");

            // OPEN STREAM TO PAGE TITLES XML
            StreamWriter TitleXML = new StreamWriter(PageTitleXML);
            TitleXML.Write(newTitleXML);
            // CLOSE FILE STREAM
            TitleXML.Close();


            // OPEN STREAM TO HOT SEARCHES XML
            StreamWriter HotSearchXML = new StreamWriter(HotSearchesXML);
            HotSearchXML.Write(newHotSearchXML);
            // CLOSE FILE STREAM
            HotSearchXML.Close();
        }






        //////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////



        // METHOD: MAIN

        public static void Run(ReportDelegate _update_Delegate)
        {
            _update_Delegate(0, "Starting READOO!");
            _update_Delegate(0, "Calculating approximate completion time");

            long TotalLogDirectorySize = 0;
            int HowManyLogs = 0;
            int progress = 0;
            string[] fileEntries;

            // // // // // THIS DOES NOTHING.
            // // // // // THIS DOES NOTHING.
            // // // // // THIS DOES NOTHING.
            // // // // // THIS DOES NOTHING.
            // // // // // THIS DOES NOTHING.
            // // // // // FIX ME. FILE SIZES MUST BE PASSED, ADDED TO VAR AND THEN USED TO FIND %
            fileEntries = Directory.GetFiles(LogsDirectory, SystemLogFormat);
            foreach (string fileName in fileEntries)
            {
                FileInfo FileInfo = new FileInfo(fileName);
                TotalLogDirectorySize += FileInfo.Length;
                HowManyLogs++;
            }
            int Increment = Convert.ToInt32(TotalLogDirectorySize / HowManyLogs);
            Increment = 70 / Increment;


            // FIRST TIME? JUST USE ALL THE OLD LOGS! THEN START RUNCOUNT.
            if (System.IO.File.Exists(KeywordsLog) == false)
            {
                _update_Delegate(progress, "First time running!");
                foreach (string fileName in fileEntries)
                {
                    _update_Delegate(progress, "Processing log " + fileName);
                    ProcessLog(fileName, _update_Delegate);
                    RunCount = 1;
                    progress += Increment;
                }
            }

            // NOT FIRST TIME? COLLECT YOUR OLD KEYWORDS, THEN GET TODAYS. THEN ADD TO RUN TALLY.
            else
            {
                _update_Delegate(0, "Not first time running");
                _update_Delegate(0, "Processing READOO generated keyword file");
                ProcessKeywordFile(_update_Delegate);

                _update_Delegate(70, "Processing last completed log");
                ProcessLog(CurrentLog, _update_Delegate);

                _update_Delegate(70, "Updating run cycle");
                using (StreamReader r = new StreamReader(KeywordsLog))
                {
                    RunCount = Convert.ToInt32(r.ReadLine());
                    RunCount++;
                }
            }

            _update_Delegate(70, "Updating READOO generated XML files");

            // PUT ALL THE DATA TO USE
            UpdateProgramLogs(_update_Delegate);
            if (Settings.Default.XML)
            {
                UpdateXML(_update_Delegate); 
            }

            // CLEAN UP IF NECESSARY
            _update_Delegate(95, "Checking run cycle");
            if (RunCount > RunsBeforeCleaning)
            {
                _update_Delegate(98, "Cleaning old logs. . .");
                CleanAnomalies(_update_Delegate);
            }

            _update_Delegate(100, "DONE!");
        }

    } 
}