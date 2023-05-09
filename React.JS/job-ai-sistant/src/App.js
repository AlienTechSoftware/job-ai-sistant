import React, { useState } from 'react';
import './App.css';
import SidePane from './components/SidePane';
import ContentView from './components/ContentView';

function App() {
  const [activeTab, setActiveTab] = useState(0);
  const [formValues, setFormValues] = useState({
    url: '',
    title: '',
    company: '',
    location: '',
    jobDescription: '',
    companyMission: '',
    focusOn: '',
    llmModel: ''
  });

  const handleTabChange = (newValue) => {
    setActiveTab(newValue);
  };
  const handleFormChange = (event) => {
    const { name, value } = event.target;
    setFormValues((prevFormValues) => ({ ...prevFormValues, [name]: value }));
  };

  return (
    <div className="App">
      <SidePane onTabChange={handleTabChange} />
      <ContentView 
        selectedTab={activeTab}  
        setActiveTab={setActiveTab}
        formValues={formValues}
        handleFormChange={handleFormChange} />
    </div>
  );
}

export default App;
