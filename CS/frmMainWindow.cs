using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobAIsistant
{
    public partial class frmMainWindow : Form
    {
        private string constHeader = System.IO.File.ReadAllText("resources/cl-header.rtf");
        private readonly DBManager m_db_manager = new DBManager();

        public frmMainWindow()
        {
            InitializeComponent();

            // Initialize rich text boxes
            richrichCoverLetterTemplate.Rtf = System.IO.File.ReadAllText("resources/cl-template.rtf");
            richCoverLetter.Rtf = constHeader;
            richJobDescription.Rtf = System.IO.File.ReadAllText("resources/README.rtf");

            // Initialize text boxes
            txtJobTitle.Text = "<JOB_TITLE>";
            txtCompany.Text = "<COMPANY>";
            txtMission.Text = "<MISSION>";
            txtLocation.Text = "<LOCATION>";
            txtURL.Text = "<JOB_URL>";
            this.txtFocus.Text = File.ReadAllText("resources/FocusOn.txt");
            this.txtAPIKey.Text = File.ReadAllText("resources/.API_KEY");

            // Initialize OpenAI
            openAI = new OpenAI(this.txtAPIKey.Text);

            // Bind the DataTable to the DataGridView
            this.dataGridView1.DataSource = m_db_manager.GetSimpleJobApplicationsTable();
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.SelectionChanged += new EventHandler(dataGridView1_SelectionChanged);

            // Set which columns to show in the DataGridView
            List<string> visibleColumns = new List<string> { "job_url", "company_name", "job_title", "job_location", "datetime_applied", "status" };
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.Visible = visibleColumns.Contains(column.Name);
            }

            // Refresh the DataGridView
            dataGridView1.Refresh();
        }

        private void btnUpdateDB_Click(object sender, EventArgs e)
        {
            string jobUrl = txtURL.Text;
            string jobTitle = txtJobTitle.Text;
            string jobLocation = txtLocation.Text;
            string companyName = txtCompany.Text;
            string companyMission = txtMission.Text;
            string focusOn = txtFocus.Text;
            string jobDescription = richJobDescription.Text;
            byte[] jobDescriptionRtf = Encoding.ASCII.GetBytes(richJobDescription.Rtf);
            string coverLetter = richCoverLetter.Text;
            byte[] coverLetterRtf = Encoding.ASCII.GetBytes(richCoverLetter.Rtf);
            byte[] notesRtf = Encoding.ASCII.GetBytes(notesRichTextBox.Rtf);
            string datetimeApplied = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string datetimeUpdated = null;
            string status = "applied";
            string gptPrompt = chatGPTPrompt;
            string gptOutput = chatGPTOutput;

            if (tabControl1.SelectedIndex == 1 || tabControl1.SelectedIndex == 2)
            {
                // read the fields and push them to the DB
            }
            else if (tabControl1.SelectedIndex == 4)
            {
                MessageBox.Show("Not yet implemented", "Not yet implemented", MessageBoxButtons.OK);
                return;

                if (dataGridView1.SelectedRows.Count > 0)
                {
                    jobUrl = dataGridView1.SelectedRows[0].DataBoundItem.ToString();
                    coverLetter = richCoverLetter.Text;
                    coverLetterRtf = Encoding.ASCII.GetBytes(richCoverLetter.Rtf);
                    datetimeApplied = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                }
            }

            if (m_db_manager.JobApplicationExists(jobUrl))
            {
                var result = MessageBox.Show("This job application already exists in the database. Do you want to update it?",
                                              "Confirmation",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Warning);

                status = "updating";

                if (result != DialogResult.Yes)
                {
                    return;
                }
            }

            m_db_manager.AddOrUpdateJobApplication(
                jobUrl,
                jobTitle,
                jobLocation,
                companyName,
                companyMission,
                focusOn,
                jobDescriptionRtf,
                coverLetterRtf,
                notesRtf,
                gptPrompt,
                gptOutput,
                datetimeApplied,
                datetimeUpdated,
                status
            );

            tabControl1.SelectedIndex = 4;
            dataGridView1.DataSource = m_db_manager.GetSimpleJobApplicationsTable();
            dataGridView1.Refresh();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                if (string.IsNullOrEmpty(selectedRow.Cells["job_url"].Value?.ToString()))
                {
                    return;
                }

                // Retrieve the values of the cells in the selected row
                byte[] rtfBytes = (byte[])selectedRow.Cells["job_description_rtf"].Value;
                string rtfString = Encoding.UTF8.GetString(rtfBytes);
                this.richTextDescriptionView.Rtf = rtfString;

                rtfBytes = (byte[])selectedRow.Cells["cover_letter_rtf"].Value;
                rtfString = Encoding.UTF8.GetString(rtfBytes);
                this.richTextCoverView.Rtf = rtfString;
            }
        }

        private string chatGPTPrompt = "";
        private string chatGPTOutput = "";
        private OpenAI openAI = null;

        private string GenerateCoverLetterPrompt()
        {
            string template = richrichCoverLetterTemplate.Text; // Get the template from the rich text box

            // Define a dictionary to store placeholder-value pairs
            Dictionary<string, string> replacements = new Dictionary<string, string>
            {
                { "<JOB_TITLE>", txtJobTitle.Text },
                { "<COMPANY>", txtCompany.Text },
                { "<MISSION>", txtMission.Text },
                { "<LOCATION>", txtLocation.Text },
                { "<JOB_URL>", txtURL.Text },
                { "<FOCUS>", txtFocus.Text },
                { "<JOB_DESCRIPTION>", richJobDescription.Text }
            };

            // Replace all placeholders in the template
            foreach (var replacement in replacements)
            {
                template = template.Replace(replacement.Key, replacement.Value);
            }

            return template;
        }

        private void UpdateCoverLetter()
        {
            this.Invoke((Action)(() =>
            {
                // for debugging
                this.txtChatGPT.Text += "\r\noutput: \r\n" + chatGPTOutput;

                // start fresh
                richCoverLetter.Rtf = constHeader;

                // Clipboard.SetText(chatGPTOutput);

                this.richCoverLetter.AppendText(chatGPTOutput);

                this.richCoverLetter.Invalidate();

                // Find the text to replace

                tabControl1.SelectedIndex = 3;
            }));
        }

        [STAThread]
        private void HandleTaskCompletion(Task<string> task)
        {
            if (task.IsFaulted)
            {
                Console.WriteLine("Error: " + task.Exception.Message);
                this.Invoke((Action)(() =>
                {
                    tabControl1.SelectedIndex = 2;
                }));
            }
            else
            {
                var completion = task.Result;
                Console.WriteLine(completion);
                this.chatGPTOutput = completion;
                UpdateCoverLetter();
            }
        }

        private void buttonGenerateChatGPTOutput_Click_1(object sender, EventArgs e)
        {
            string outString = GenerateCoverLetterPrompt();

            txtChatGPT.Text = chatGPTPrompt = outString;

            var task = openAI.Complete(
                prompt: chatGPTPrompt,
                model: "text-davinci-003",
                temperature: 0.7,
                maxTokens: 512);

            task.ContinueWith(HandleTaskCompletion);
        }

        private void btnPrintCoverLetter_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Rich Text Format (*.rtf)|*.rtf";
            saveFileDialog1.FileName = txtCompany.Text;
            saveFileDialog1.Title = "Save Cover Letter";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richCoverLetter.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void txtAPIKey_TextChanged(object sender, EventArgs e)
        {
            File.WriteAllText("resources/.API_KEY", this.txtAPIKey.Text); // Save the new key
            if(this.openAI != null)
            {
                this.openAI.setAPIkey(this.txtAPIKey.Text);
            }
            
        }
    }
}
