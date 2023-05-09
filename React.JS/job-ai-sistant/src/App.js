import React, { useState } from 'react';
import './App.css';
import SidePane from './components/SidePane';
import ContentView from './components/ContentView';

function App() {
  const [activeTab, setActiveTab] = useState(0);

  const handleTabChange = (newValue) => {
    setActiveTab(newValue);
  };

  return (
    <div className="App">
      <SidePane onTabChange={handleTabChange} />
      <ContentView selectedTab={activeTab}  setActiveTab={setActiveTab} />
    </div>
  );
}

export default App;
