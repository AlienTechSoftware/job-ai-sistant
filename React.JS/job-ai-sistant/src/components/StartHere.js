import React from 'react';
import aiSistantImage from '../resources/ai-sistant.ico';
import './StartHere.css';
import ReactQuill from 'react-quill';
import 'react-quill/dist/quill.snow.css';

function StartHere({ setActiveTab, formValues, handleFormChange }) {
  const handleNext = () => {
    setActiveTab(1);
  };

  return (
    <div className="start-here">
      <h2>Job AI-sistant</h2>
      <p>
        Job AI-sistant is an application that helps job seekers to manage their job search process in an efficient way. 
        This tool is useful for generating a fluent cover letter based on a template, and a job description. 
        It is essentially form to generate an affective prompt for ChatGPT.
      </p>
      <img src={aiSistantImage} />
      <br />
      <section className="user-input-data">
        <div className="form-group">
          <label htmlFor="url">URL</label>
          <input 
            type="text" 
            id="url" 
            name="url" 
            value={formValues.url} 
            onChange={handleFormChange}
          />
        </div>
        <div className="form-group">
          <label htmlFor="title">Title</label>
          <input 
            type="text" 
            id="title" 
            name="title" 
            value={formValues.title} 
            onChange={handleFormChange}
          />
        </div>
        <div className="form-group">
          <label htmlFor="company">Company</label>
          <input 
            type="text" 
            id="company" 
            name="company" 
            value={formValues.company} 
            onChange={handleFormChange}
          />
        </div>
        <div className="form-group">
          <label htmlFor="location">Location</label>
          <input 
            type="text" 
            id="location" 
            name="location" 
            value={formValues.location} 
            onChange={handleFormChange}
          />
        </div>
        <div className="form-group">
          <label htmlFor="job-description">Job Description</label>
          <ReactQuill 
            theme="snow" 
            value={formValues.jobDescription} 
            onChange={(value) => handleFormChange({ target: { name: "jobDescription", value } })}
          />
        </div>
        <div className="form-group">
          <label htmlFor="company-mission">Company Mission</label>
          <ReactQuill 
            theme="snow" 
            value={formValues.companyMission} 
            onChange={(value) => handleFormChange({ target: { name: "companyMission", value } })}
          />
        </div>
        <div className="form-group">
          <label htmlFor="focus-on">Focus On</label>
          <ReactQuill 
            theme="snow" 
            value={formValues.focusOn} 
            onChange={(value) => handleFormChange({ target: { name: "focusOn", value } })}
          />
        </div>
        <div className="form-group">
          <label htmlFor="llm-model">LLM Model</label>
          <select 
            id="llm-model" 
            name="llmModel" 
            value={formValues.llmModel} 
            onChange={handleFormChange}
          >
            <option value="">--Please choose an option--</option>
            <option value="model1">Model 1</option>
            <option value="model2">Model 2</option>
            <option value="model3">Model 3</option>
          </select>
        </div>
      </section>
      <button className="navigation-button" onClick={handleNext}>
        Next
      </button>
    </div>
  );
}

export default StartHere;
