import React from 'react';
import Tabs from '@material-ui/core/Tabs';
import Tab from '@material-ui/core/Tab';

export default function SidePane({ onTabChange }) {
  const [value, setValue] = React.useState(0);

  const handleChange = (event, newValue) => {
    setValue(newValue);
    onTabChange(newValue);
  };

  return (
    <Tabs value={value} onChange={handleChange} orientation="vertical">
      <Tab label="Start Here" />
      <Tab label="Tab 2" />
      <Tab label="Tab 3" />
    </Tabs>
  );
}
