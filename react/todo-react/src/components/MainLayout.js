import React from 'react';

import ListItem from './ListItem.js';
import NewItemInput from './NewItemInput.js';
import RemainingItems from './RemainingItems.js';

const MainLayout = (props) => {
  return (
    <div className="app">
      <h1>{props.title}</h1>
      {props.initialTodos.map(todo =>
        <ListItem
          key={todo.id}
          todo={todo}
        />
      )}
      <div>
        <NewItemInput
        />
        <RemainingItems
        />
      </div>
    </div>
  )
}

export default MainLayout;
