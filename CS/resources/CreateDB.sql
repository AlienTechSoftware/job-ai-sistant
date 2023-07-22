DROP TABLE IF EXISTS `CoverLetters`;
CREATE TABLE `CoverLetters` (
	`ID`	TEXT,
	`ParentID`	TEXT,
	`HTML`	BLOB,
	`RTF`	REAL,
	`MD`	TEXT,
	`BLOB`	BLOB,
	`Notes`	TEXT,
	`Created`	TEXT,
	`Modified`	TEXT,
	PRIMARY KEY(`ID`)
);

DROP TABLE IF EXISTS `Resumes`;
CREATE TABLE `Resumes` (
	`ID`	TEXT,
	`ParentID`	TEXT,
	`HTML`	BLOB,
	`RTF`	REAL,
	`MD`	TEXT,
	`BLOB`	BLOB,
	`Notes`	TEXT,
	`Created`	TEXT,
	`Modified`	TEXT,
	PRIMARY KEY(`ID`)
);

DROP TABLE IF EXISTS `hiring_companies`;
CREATE TABLE `hiring_companies` (
    `id` INTEGER PRIMARY KEY,
    `name` TEXT NOT NULL,
    `email` TEXT UNIQUE NOT NULL,
    `website` TEXT,
    `mission` TEXT,
    `values` TEXT,
    `phone_number` TEXT,
    `address` TEXT,
    `city` TEXT,
    `state` TEXT,
    `country` TEXT,
    `size` INTEGER,
    `tenure_years` REAL,
    `type` TEXT,
    `startup_stage` TEXT,
    `funding_level` TEXT,
    UNIQUE(`name`, `email`)
);

DROP TABLE IF EXISTS `job_descriptions`;
CREATE TABLE `job_descriptions` (
    `id` INTEGER PRIMARY KEY,
    `title` TEXT NOT NULL,
    `req_id` TEXT NOT NULL,
    `url` TEXT NOT NULL,
    `LinkedIn` TEXT NOT NULL,
    `description` TEXT NOT NULL,
    `salary_range_min` INTEGER,
    `salary_range_max` INTEGER,
    `requirements` TEXT,
    `post_date` TEXT,
    `update_date` TEXT,
    `is_active` INTEGER,
    `already_applied_for` INTEGER,
    `company_id` INTEGER NOT NULL,
    FOREIGN KEY (`company_id`) REFERENCES `hiring_companies`(`id`),
    CHECK (`salary_range_min` <= `salary_range_max`)
);
CREATE INDEX `idx_job_descriptions_company_id` ON `job_descriptions`(`company_id`);

DROP TABLE IF EXISTS `job_applications`;
CREATE TABLE `job_applications` (
    `id` INTEGER PRIMARY KEY,
    `job_id` INTEGER NOT NULL,
    `resume_id` INTEGER NOT NULL,
    `cover_letter_id` INTEGER,
    `datetime_applied` TEXT NOT NULL,
    `stage` TEXT NOT NULL,
    `recruiter_info` TEXT,
    `hiring_manager_info` TEXT,
    `communication_summary` TEXT,
    FOREIGN KEY (`job_id`) REFERENCES `job_descriptions`(`id`),
    FOREIGN KEY (`resume_id`) REFERENCES `Resumes`(`ID`),
    FOREIGN KEY (`cover_letter_id`) REFERENCES `CoverLetters`(`ID`)
);


DROP TABLE IF EXISTS `simple_job_applications`;
CREATE TABLE `simple_job_applications` (
    `job_url` TEXT PRIMARY KEY,
    `status` TEXT,
    `job_title` TEXT NOT NULL,
    `job_location` TEXT,
    `company_name` TEXT NOT NULL,
    `company_mission` TEXT,
    `focus_on` TEXT,
    `job_description_rtf` BLOB,
    `cover_letter_rtf` BLOB,
    `notes_rtf` BLOB,
    `gpt_prompt` TEXT,
    `gpt_output` TEXT,
    `datetime_applied` TEXT NOT NULL,
    `datetime_updated` TEXT
);


DROP INDEX IF EXISTS `idx_job_applications_job_id`;
CREATE INDEX `idx_job_applications_job_id` ON `job_applications`(`job_id`);
DROP INDEX IF EXISTS `idx_job_applications_resume_id`;
CREATE INDEX `idx_job_applications_resume_id` ON `job_applications`(`resume_id`);
DROP INDEX IF EXISTS `idx_job_applications_cover_letter_id`;
CREATE INDEX `idx_job_applications_cover_letter_id` ON `job_applications`(`cover_letter_id`);

