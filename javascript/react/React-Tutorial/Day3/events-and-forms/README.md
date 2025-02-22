# Handling Events and Forms

Demo:

![Demo](./demo.gif)

## Handling events

[Read here](https://reactjs.org/docs/handling-events.html)

- React events are named using camelCase, rather than lowercase.

- With JSX you pass a function as the event handler, rather than a string.

```js
// HTML Example
<button onclick="activateLasers()">
  Activate Lasers
</button>

// React Example
<button onClick={activateLasers}>
  Activate Lasers
</button>
```

- You cannot return false to prevent default behavior in React

```js
function ActionLink() {
  function handleClick(e) {
    e.preventDefault();
    console.log('The link was clicked.');
  }

  return (
    <a href="#" onClick={handleClick}>
      Click me
    </a>
  );
}
```

- When using React you should generally not need to call addEventListener to add listeners to a DOM element after it is created. Instead, just provide a listener when the element is initially rendered.

- When you define a component using an ES6 class, a common pattern is for an event handler to be a method on the class. For example, this Toggle component renders a button that lets the user toggle between “ON” and “OFF” states:

```js
// index.js
import App from './components/App'

ReactDOM.render(
  <App />,
  document.getElementById('root')
);

// App.js
import React from 'react';

class App extends React.Component {
  constructor(props) {
    super(props);
    this.state = {isToggleOn: true};
  }
  handleClick = () => {
    this.setState(state => ({
      isToggleOn: !state.isToggleOn
    }));
  }
  render() {
    return (
      <div className="App">
        <div>
          <button onClick={this.handleClick}>
            Click me
          </button>
          <p> Current isToggleOn: {this.state.isToggleOn.toString()} </p>
        </div>
      </div>
    );
  }
}
export default App;
```

- Ex of events with state

You can use arrow functions to do so:

```js
// App.js
handleChange = (event, stateKey) => {
    this.setState({
      ...this.state,
      [stateKey]: event.target.value
    });
 }
handleEnterPress = (event) => {
  if (event.key === 'Enter') {
    this.setState({
      ...this.state,
      name: '',
      people: [
        ...this.state.people,
        event.target.value
      ]
    });
  }
}

// EventsAndState.js
const EventsAndState = (props) => (
  <div>
    <h2> Input a name </h2>
    <input
      type="text"
      value={props.name}
      onKeyDown={props.onKeyDown}
      onChange={props.onChange}
    />
    <p> Current Name: {props.name} </p>
    <p> Current array of people: {props.people.map((person, index) => {
      if (index !== (props.people.length - 1)) {
        return `${person}, `;
      } else {
        return person;
      }
    })} </p>
  </div>
);
```

- Passing arguments into event functions:

```js
<form onSubmit={(event) => props.onSubmit(event, props.food)}>
```

## Forms

- Use State as the 'single source of truth' for your data. Do so by changing state variables with onChange

1. Form

```js
// App.js
handleChange = (event, stateKey) => {
    this.setState({
      ...this.state,
      [stateKey]: event.target.value
    });
 }
 handleSubmit = (event, stateKey, input) => {
   alert(`Sumited: ${input}`);
   this.setState({
     ...this.state,
     [stateKey]: '',
   });
   event.preventDefault();
 }

// Form.js
const Form = (props) => (
  <div>
    <form onSubmit={props.onSubmit}>
      <p>My cool form:</p>
      <label>
        Input your favorite food
        <input type="text" value={props.food} onChange={props.onChange} />
      </label>
      <input type="submit" value="Submit" />
    </form>
  </div>
);
```

2. Textarea

```js
// App.js
<TextArea
  onSubmit={(event) => this.handleSubmit(event, 'poem', this.state.poem)}
  poem={this.state.poem}
  onChange={(event) => this.handleChange(event, 'poem')}
/>

// TextArea.js
const TextArea = (props) => (
  <form onSubmit={props.onSubmit}>
    <p>Write me a poem</p>
    <label>
      Poem:
      <textarea value={props.poem} onChange={props.onChange} />
    </label>
    <input type="submit" value="Submit" />
  </form>
);
```

3. Select

```js
const Select = (props) => (
  <form onSubmit={props.onSubmit}>
     <label>
       Pick your favorite chocolate bar:
       <select value={props.chocolate} onChange={props.onChange}>
         <option value="grapefruit">Grapefruit</option>
         <option value="lime">Lime</option>
         <option value="coconut">Coconut</option>
         <option value="mango">Mango</option>
       </select>
     </label>
     <input type="submit" value="Submit" />
   </form>
)
```

#### Multiple Inputs

In their docs, they talk about doing it this way:

[Click me](https://reactjs.org/docs/forms.html#handling-multiple-inputs)

I have personally done it slighly different in this example. (By passing the 'name' as a parameter onto handleSubmit, and changing that directly. This allow me to not have to worry on how many inputs use the handleSubmit())

```js
handleChange = (event, stateKey) => {
    this.setState({
      ...this.state,
      [stateKey]: event.target.value
    });
 }

<TextArea
  onChange={(event) => this.handleChange(event, 'poem')}
/>
<Select
  onChange={(event) => this.handleChange(event, 'chocolate')}
/>
```

#### State key

Notice you can update state by using a dynamic key:

```js
handleChange = (event, stateKey) => {
    this.setState({
      ...this.state,
      [stateKey]: event.target.value
    });
 }
```

From docs:

- Overall, this makes it so that `<input type="text">, <textarea>, and <select>` all work very similarly - they all accept a value attribute that you can use to implement a controlled component.
