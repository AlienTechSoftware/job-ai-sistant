import React from 'react';
import aiSistantImage from '../resources/ai-sistant.ico';
import './StartHere.css';

function StartHere({ setActiveTab }) {
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
      <br/>
      <section className="user-input-data">
      </section>
      <button className="navigation-button" onClick={handleNext}>
        Next
      </button>
    </div>
  );
}

export default StartHere;
