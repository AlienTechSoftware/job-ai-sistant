import React from 'react';
import StartHere from './StartHere';
import Tab2 from './Tab2';
import Tab3 from './Tab3';

function ContentView({ selectedTab, setActiveTab }) {
  switch (selectedTab) {
    case 0:
      return <StartHere setActiveTab={setActiveTab} />;
    case 1:
      return <Tab2 />;
    case 2:
      return <Tab3 />;
    default:
      return null;
  }
}

export default ContentView;
