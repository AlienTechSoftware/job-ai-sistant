using System;
using System.Data;
using System.IO;
using System.Data.SQLite;
using System.Collections.Generic;

namespace JobAIsistant
{
    class DBManager
    {
        const string dbFilePath = "./resources/job-ai-sistant.db";
        private SQLiteConnection conn;

        public DBManager()
        {
            InitializeConnection();
        }

        private void InitializeConnection()
        {
            bool needCreateTable = !File.Exists(dbFilePath);

            conn = new SQLiteConnection($"Data Source={dbFilePath};");
            conn.Open();

            if (needCreateTable)
            {
                // Read the SQL from the file
                string sql = File.ReadAllText("./resources/CreateDB.sql");

                // Execute the SQL command
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
        }

        public bool JobApplicationExists(string jobUrl)
        {
            using (var cmd = new SQLiteCommand("SELECT COUNT(*) FROM simple_job_applications WHERE job_url = @jobUrl", conn))
            {
                cmd.Parameters.AddWithValue("@jobUrl", jobUrl);

                var count = Convert.ToInt32(cmd.ExecuteScalar());

                return count > 0;
            }
        }

        public void AddOrUpdateJobApplication(
            string jobUrl
            , string jobTitle
            , string jobLocation
            , string companyName
            , string companyMission
            , string focusOn
            , byte[] jobDescriptionRtf
            , byte[] coverLetterRtf
            , byte[] notesRtf
            , string gptPrompt
            , string gptOutput
            , string datetimeApplied
            , string datetimeUpdated
            , string status)
        {
            using (var insertCommand = new SQLiteCommand("INSERT OR REPLACE INTO simple_job_applications " +
                "(job_url, job_title, job_location, company_name, company_mission, focus_on, job_description_rtf, cover_letter_rtf, notes_rtf, gpt_prompt, gpt_output, datetime_applied, datetime_updated, status) " +
                "VALUES (@url, @title, @location, @company, @mission, @focus, @descriptionRtf, @coverLetterRtf, @notesRtf, @gptPrompt, @gptOutput, @applied, @updated, @status)", conn))
            {
                insertCommand.Parameters.AddWithValue("@url", jobUrl);
                insertCommand.Parameters.AddWithValue("@title", jobTitle);
                insertCommand.Parameters.AddWithValue("@location", jobLocation);
                insertCommand.Parameters.AddWithValue("@company", companyName);
                insertCommand.Parameters.AddWithValue("@mission", companyMission);
                insertCommand.Parameters.AddWithValue("@focus", focusOn);
                insertCommand.Parameters.AddWithValue("@descriptionRtf", jobDescriptionRtf);
                insertCommand.Parameters.AddWithValue("@coverLetterRtf", coverLetterRtf);
                insertCommand.Parameters.AddWithValue("@notesRtf", notesRtf);
                insertCommand.Parameters.AddWithValue("@gptPrompt", gptPrompt);
                insertCommand.Parameters.AddWithValue("@gptOutput", gptOutput);
                insertCommand.Parameters.AddWithValue("@applied", datetimeApplied);
                insertCommand.Parameters.AddWithValue("@updated", datetimeUpdated);
                insertCommand.Parameters.AddWithValue("@status", status);
                insertCommand.ExecuteNonQuery();
            }
        }


        public DataTable GetSimpleJobApplicationsTable()
        {
            using (var cmd = new SQLiteCommand("SELECT * FROM simple_job_applications", conn))
            {
                var adapter = new SQLiteDataAdapter(cmd);
                var table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        public void CloseConnection()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }
    }
}
