using System.Windows.Forms;

namespace JobAIsistant
{
    partial class frmMainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1_1 = new System.Windows.Forms.SplitContainer();
            this.buttonGenerateChatGPTOutput = new System.Windows.Forms.Button();
            this.txtAPIKey = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtJobTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.richJobDescription = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFocus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMission = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richrichCoverLetterTemplate = new System.Windows.Forms.RichTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtChatGPT = new System.Windows.Forms.TextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainerCoverLetter = new System.Windows.Forms.SplitContainer();
            this.btnPrintCoverLetter = new System.Windows.Forms.Button();
            this.btnUpdateDB = new System.Windows.Forms.Button();
            this.richCoverLetter = new System.Windows.Forms.RichTextBox();
            this.tabDatabase = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.jobSimpleViewer = new System.Windows.Forms.TabControl();
            this.jobSimpleViewerTab = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.richTextDescriptionView = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextCoverView = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.notesTabPage = new System.Windows.Forms.TabPage();
            this.notesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.notesLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1_1)).BeginInit();
            this.splitContainer1_1.Panel1.SuspendLayout();
            this.splitContainer1_1.Panel2.SuspendLayout();
            this.splitContainer1_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerCoverLetter)).BeginInit();
            this.splitContainerCoverLetter.Panel1.SuspendLayout();
            this.splitContainerCoverLetter.Panel2.SuspendLayout();
            this.splitContainerCoverLetter.SuspendLayout();
            this.tabDatabase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.jobSimpleViewer.SuspendLayout();
            this.jobSimpleViewerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.notesTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabDatabase);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1040, 758);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1_1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1032, 732);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Job Details";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1_1
            // 
            this.splitContainer1_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1_1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1_1.Name = "splitContainer1_1";
            this.splitContainer1_1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1_1.Panel1
            // 
            this.splitContainer1_1.Panel1.Controls.Add(this.buttonGenerateChatGPTOutput);
            this.splitContainer1_1.Panel1.Controls.Add(this.txtAPIKey);
            this.splitContainer1_1.Panel1.Controls.Add(this.label10);
            this.splitContainer1_1.Panel1.Controls.Add(this.txtLocation);
            this.splitContainer1_1.Panel1.Controls.Add(this.label9);
            this.splitContainer1_1.Panel1.Controls.Add(this.txtURL);
            this.splitContainer1_1.Panel1.Controls.Add(this.label6);
            this.splitContainer1_1.Panel1.Controls.Add(this.txtCompany);
            this.splitContainer1_1.Panel1.Controls.Add(this.label2);
            this.splitContainer1_1.Panel1.Controls.Add(this.txtJobTitle);
            this.splitContainer1_1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1_1.Panel2
            // 
            this.splitContainer1_1.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer1_1.Size = new System.Drawing.Size(1026, 726);
            this.splitContainer1_1.SplitterDistance = 63;
            this.splitContainer1_1.TabIndex = 0;
            // 
            // buttonGenerateChatGPTOutput
            // 
            this.buttonGenerateChatGPTOutput.Location = new System.Drawing.Point(787, 29);
            this.buttonGenerateChatGPTOutput.Name = "buttonGenerateChatGPTOutput";
            this.buttonGenerateChatGPTOutput.Size = new System.Drawing.Size(199, 24);
            this.buttonGenerateChatGPTOutput.TabIndex = 12;
            this.buttonGenerateChatGPTOutput.Text = "Generate ChatGPT Output";
            this.buttonGenerateChatGPTOutput.UseVisualStyleBackColor = true;
            this.buttonGenerateChatGPTOutput.Click += new System.EventHandler(this.buttonGenerateChatGPTOutput_Click_1);
            // 
            // txtAPIKey
            // 
            this.txtAPIKey.Location = new System.Drawing.Point(841, 3);
            this.txtAPIKey.Name = "txtAPIKey";
            this.txtAPIKey.Size = new System.Drawing.Size(145, 20);
            this.txtAPIKey.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(784, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "API Key";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(600, 22);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(145, 20);
            this.txtLocation.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(543, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Location";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(41, 3);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(283, 20);
            this.txtURL.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "URL";
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(387, 26);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(145, 20);
            this.txtCompany.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Company";
            // 
            // txtJobTitle
            // 
            this.txtJobTitle.Location = new System.Drawing.Point(41, 29);
            this.txtJobTitle.Name = "txtJobTitle";
            this.txtJobTitle.Size = new System.Drawing.Size(283, 20);
            this.txtJobTitle.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Title";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.richJobDescription);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtFocus);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.txtMission);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Size = new System.Drawing.Size(1026, 659);
            this.splitContainer1.SplitterDistance = 533;
            this.splitContainer1.TabIndex = 11;
            // 
            // richJobDescription
            // 
            this.richJobDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richJobDescription.Location = new System.Drawing.Point(0, 13);
            this.richJobDescription.Name = "richJobDescription";
            this.richJobDescription.Size = new System.Drawing.Size(533, 646);
            this.richJobDescription.TabIndex = 9;
            this.richJobDescription.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Job Description";
            // 
            // txtFocus
            // 
            this.txtFocus.Location = new System.Drawing.Point(119, 159);
            this.txtFocus.Multiline = true;
            this.txtFocus.Name = "txtFocus";
            this.txtFocus.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFocus.Size = new System.Drawing.Size(245, 102);
            this.txtFocus.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Focus On";
            // 
            // txtMission
            // 
            this.txtMission.Location = new System.Drawing.Point(119, 34);
            this.txtMission.Multiline = true;
            this.txtMission.Name = "txtMission";
            this.txtMission.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMission.Size = new System.Drawing.Size(245, 102);
            this.txtMission.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Company Mission";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richrichCoverLetterTemplate);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1032, 732);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Template";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // richrichCoverLetterTemplate
            // 
            this.richrichCoverLetterTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richrichCoverLetterTemplate.Location = new System.Drawing.Point(3, 3);
            this.richrichCoverLetterTemplate.Name = "richrichCoverLetterTemplate";
            this.richrichCoverLetterTemplate.Size = new System.Drawing.Size(1026, 726);
            this.richrichCoverLetterTemplate.TabIndex = 0;
            this.richrichCoverLetterTemplate.Text = "";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtChatGPT);
            this.tabPage4.Controls.Add(this.richTextBox4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1032, 732);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Logging";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtChatGPT
            // 
            this.txtChatGPT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtChatGPT.Location = new System.Drawing.Point(0, 0);
            this.txtChatGPT.Multiline = true;
            this.txtChatGPT.Name = "txtChatGPT";
            this.txtChatGPT.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtChatGPT.Size = new System.Drawing.Size(1032, 732);
            this.txtChatGPT.TabIndex = 14;
            // 
            // richTextBox4
            // 
            this.richTextBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox4.Location = new System.Drawing.Point(0, 0);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(1032, 732);
            this.richTextBox4.TabIndex = 2;
            this.richTextBox4.Text = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.splitContainerCoverLetter);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1032, 732);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Cover Letter";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainerCoverLetter
            // 
            this.splitContainerCoverLetter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerCoverLetter.Location = new System.Drawing.Point(0, 0);
            this.splitContainerCoverLetter.Name = "splitContainerCoverLetter";
            this.splitContainerCoverLetter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerCoverLetter.Panel1
            // 
            this.splitContainerCoverLetter.Panel1.Controls.Add(this.btnPrintCoverLetter);
            this.splitContainerCoverLetter.Panel1.Controls.Add(this.btnUpdateDB);
            // 
            // splitContainerCoverLetter.Panel2
            // 
            this.splitContainerCoverLetter.Panel2.Controls.Add(this.richCoverLetter);
            this.splitContainerCoverLetter.Size = new System.Drawing.Size(1032, 732);
            this.splitContainerCoverLetter.SplitterDistance = 60;
            this.splitContainerCoverLetter.TabIndex = 0;
            // 
            // btnPrintCoverLetter
            // 
            this.btnPrintCoverLetter.Location = new System.Drawing.Point(737, 22);
            this.btnPrintCoverLetter.Name = "btnPrintCoverLetter";
            this.btnPrintCoverLetter.Size = new System.Drawing.Size(75, 23);
            this.btnPrintCoverLetter.TabIndex = 2;
            this.btnPrintCoverLetter.Text = "Save";
            this.btnPrintCoverLetter.UseVisualStyleBackColor = true;
            this.btnPrintCoverLetter.Click += new System.EventHandler(this.btnPrintCoverLetter_Click);
            // 
            // btnUpdateDB
            // 
            this.btnUpdateDB.Location = new System.Drawing.Point(854, 16);
            this.btnUpdateDB.Name = "btnUpdateDB";
            this.btnUpdateDB.Size = new System.Drawing.Size(168, 35);
            this.btnUpdateDB.TabIndex = 1;
            this.btnUpdateDB.Text = "Update Database";
            this.btnUpdateDB.UseVisualStyleBackColor = true;
            this.btnUpdateDB.Click += new System.EventHandler(this.btnUpdateDB_Click);
            // 
            // richCoverLetter
            // 
            this.richCoverLetter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richCoverLetter.Location = new System.Drawing.Point(0, 0);
            this.richCoverLetter.Name = "richCoverLetter";
            this.richCoverLetter.Size = new System.Drawing.Size(1032, 668);
            this.richCoverLetter.TabIndex = 1;
            this.richCoverLetter.Text = "";
            // 
            // tabDatabase
            // 
            this.tabDatabase.Controls.Add(this.splitContainer2);
            this.tabDatabase.Location = new System.Drawing.Point(4, 22);
            this.tabDatabase.Name = "tabDatabase";
            this.tabDatabase.Padding = new System.Windows.Forms.Padding(3);
            this.tabDatabase.Size = new System.Drawing.Size(1032, 732);
            this.tabDatabase.TabIndex = 4;
            this.tabDatabase.Text = "Database";
            this.tabDatabase.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.jobSimpleViewer);
            this.splitContainer2.Size = new System.Drawing.Size(1026, 726);
            this.splitContainer2.SplitterDistance = 213;
            this.splitContainer2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1026, 213);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // jobSimpleViewer
            // 
            this.jobSimpleViewer.Controls.Add(this.jobSimpleViewerTab);
            this.jobSimpleViewer.Controls.Add(this.notesTabPage);
            this.jobSimpleViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jobSimpleViewer.Location = new System.Drawing.Point(0, 0);
            this.jobSimpleViewer.Name = "jobSimpleViewer";
            this.jobSimpleViewer.SelectedIndex = 0;
            this.jobSimpleViewer.Size = new System.Drawing.Size(1026, 509);
            this.jobSimpleViewer.TabIndex = 0;
            // 
            // jobSimpleViewerTab
            // 
            this.jobSimpleViewerTab.Controls.Add(this.splitContainer3);
            this.jobSimpleViewerTab.Location = new System.Drawing.Point(4, 22);
            this.jobSimpleViewerTab.Name = "jobSimpleViewerTab";
            this.jobSimpleViewerTab.Size = new System.Drawing.Size(1018, 483);
            this.jobSimpleViewerTab.TabIndex = 0;
            this.jobSimpleViewerTab.Text = "Job Simple Viewer";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.richTextDescriptionView);
            this.splitContainer3.Panel1.Controls.Add(this.label7);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.richTextCoverView);
            this.splitContainer3.Panel2.Controls.Add(this.label8);
            this.splitContainer3.Size = new System.Drawing.Size(1018, 483);
            this.splitContainer3.SplitterDistance = 364;
            this.splitContainer3.TabIndex = 0;
            // 
            // richTextDescriptionView
            // 
            this.richTextDescriptionView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextDescriptionView.Location = new System.Drawing.Point(0, 13);
            this.richTextDescriptionView.Name = "richTextDescriptionView";
            this.richTextDescriptionView.Size = new System.Drawing.Size(364, 470);
            this.richTextDescriptionView.TabIndex = 11;
            this.richTextDescriptionView.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Job Description";
            // 
            // richTextCoverView
            // 
            this.richTextCoverView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextCoverView.Location = new System.Drawing.Point(0, 13);
            this.richTextCoverView.Name = "richTextCoverView";
            this.richTextCoverView.Size = new System.Drawing.Size(650, 470);
            this.richTextCoverView.TabIndex = 11;
            this.richTextCoverView.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Job Description";
            // 
            // notesTabPage
            // 
            this.notesTabPage.Controls.Add(this.notesRichTextBox);
            this.notesTabPage.Controls.Add(this.notesLabel);
            this.notesTabPage.Location = new System.Drawing.Point(4, 22);
            this.notesTabPage.Name = "notesTabPage";
            this.notesTabPage.Size = new System.Drawing.Size(1018, 483);
            this.notesTabPage.TabIndex = 1;
            this.notesTabPage.Text = "Notes";
            // 
            // notesRichTextBox
            // 
            this.notesRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notesRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.notesRichTextBox.Name = "notesRichTextBox";
            this.notesRichTextBox.Size = new System.Drawing.Size(1018, 483);
            this.notesRichTextBox.TabIndex = 0;
            this.notesRichTextBox.Text = "";
            // 
            // notesLabel
            // 
            this.notesLabel.Location = new System.Drawing.Point(0, 0);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(100, 23);
            this.notesLabel.TabIndex = 1;
            this.notesLabel.Text = "Notes:";
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 758);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmMainWindow";
            this.Text = "Job Search AI-sistant (Ver 0.1)";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1_1.Panel1.ResumeLayout(false);
            this.splitContainer1_1.Panel1.PerformLayout();
            this.splitContainer1_1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1_1)).EndInit();
            this.splitContainer1_1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.splitContainerCoverLetter.Panel1.ResumeLayout(false);
            this.splitContainerCoverLetter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerCoverLetter)).EndInit();
            this.splitContainerCoverLetter.ResumeLayout(false);
            this.tabDatabase.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.jobSimpleViewer.ResumeLayout(false);
            this.jobSimpleViewerTab.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.notesTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richrichCoverLetterTemplate;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtJobTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer1_1;
        private System.Windows.Forms.SplitContainer splitContainerCoverLetter;
        private System.Windows.Forms.RichTextBox richJobDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFocus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMission;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.TextBox txtChatGPT;
        private System.Windows.Forms.RichTextBox richCoverLetter;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdateDB;
        private System.Windows.Forms.TabPage tabDatabase;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.RichTextBox richTextDescriptionView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextCoverView;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonGenerateChatGPTOutput;
        private System.Windows.Forms.Button btnPrintCoverLetter;

        private TabControl jobSimpleViewer;
        private TabPage jobSimpleViewerTab;
        private TabPage notesTabPage;
        private RichTextBox notesRichTextBox;
        private Label notesLabel;
        private TextBox txtAPIKey;
        private Label label10;
    }
}

