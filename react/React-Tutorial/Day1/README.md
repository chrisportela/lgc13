# Day 1 topics

## Wiki

Talk about why/how to create and use one.

## ES6

Put simply, ECMAScript is a standard. While JavaScript is the most popular implementation of that standard. JavaScript implements ECMAScript and builds on top of it

Read about it [here](https://codeburst.io/javascript-wtf-is-es6-es8-es-2017-ecmascript-dca859e4821c)

[Features of ES6](http://exploringjs.com/es6/ch_overviews.html)

Some common used ones:

- Usage of const/let vs var
```js
let name = 'lucas';
name = 'sasha'; // allowed

const lastName = 'costa';
lastName = 'gomes'; // not allowed
```

- for of loop
```js
const colors = ['red', 'blue', 'green', 'purple'];

for (let color of colors) {
  console.log(color); // prints out each individual color
}
for (const [index, element] of colors.entries()) {
    console.log(`${index}. ${element}`); // prints out each index, then the color
}
```

- Arrow functions

Also called fat arrows. They are similar to lambdas in Python/C#. This allows you to NOT type `function`, ` return`(this is implicit in arrow functions), and curly braces.


Read more [here](https://www.sitepoint.com/es6-arrow-functions-new-fat-concise-syntax-javascript/)

``` js
// ES5
var multiplyES5 = function(x, y) {
  return x * y;
};
multiplyES5(1, 3);

// ES6 (note the curly braces are not required)
const multiplyES6 = (x, y) => { return x * y };
multiplyES6(5, 6);
```

- Array manipulation methods (available from ES5 but worth mentioning)

```js
const persons = [
  {
    id: 1,
    name: "Lucas",
    mood: "Hungry"
  },
  {
    id: 2,
    name: "Sasha",
    mood: "Excited"
  },
  {
    id: 3,
    name: "David",
    mood: "Uncaffeinated"
  }
];
// find
let result = persons.find(person => person.id === 1);
console.log('Result with id of 1: ', result);

// filter
let peopleHungry = persons.filter(person => person.mood === "Hungry");
console.log("People hungry: ", peopleHungry);

// forEach
persons.forEach(person => console.log(person.name));

// map
  // ES5
result = persons.map(function(person) {
console.log('Currently iterating through person', person.name, 'who is', person.mood);
if (person.mood === 'Excited') {
  person.mood = "Hungry";
}
return person;
});
console.log("result: ", result);
  // ES6
result = persons.map(person => {
console.log('Currently iterating through person', person.name, 'who is', person.mood);
if (person.mood === 'Uncaffeinated') {
  person.mood = "Sleepy";
}
return person;
})
console.log("result 2: ", result);
```

More ES5 stuff [here](https://www.w3schools.com/whatis/whatis_es5.asp)

## Babel

[Babel docs](https://babeljs.io/docs/en/)

- TLDR: Toolchain that converts ES6 into older versions of JS. Ex:

```js
// Babel Input: ES2015 arrow function
[1, 2, 3].map((n) => n + 1);

// Babel Output: ES5 equivalent
[1, 2, 3].map(function(n) {
  return n + 1;
});
```

[See it in action](https://babeljs.io/repl/#?presets=react&code_lz=GYVwdgxgLglg9mABACwKYBt1wBQEpEDeAUIogE6pQhlIA8AJjAG4B8AEhlogO5xnr0AhLQD0jVgG4iAXyJA)

## React

[React](https://reactjs.org/) is a popular JavaScript library for building user interfaces. Its simple core concepts make the library a useful base for building applications for a variety of platforms, including both web and mobile interfaces. Its popularity and widespread adoption have resulted in a large community that has produced libraries and plugins that make working with React a pleasure.

- Components: encapsulate code to smaller isolated pieces, so its more maintainable and dynamic.
- Declarative (efficiently update and render components as data changes)

## Setup

- First, check out hello-world app

- create-react-app [(Instructions)](https://github.com/facebook/create-react-app)

1. Install [Node.js](https://nodejs.org/en/)

2. Install [Yarn](https://yarnpkg.com/latest.msi)

3. Run `yarn create react-app your-app-name`

- if you come across an issue like `is not recognized as an internal or external command, operable program or batch file`, then run the following:

```sh
yarn global add create-react-app
create-react-app your-app-name
```

4. Run your app

```sh
cd your-app-name
yarn start
```

- This will run your app on localhost:3000

## First look

- for now, focus attention on public/index.html, src/index.js and src/App.js
- also notice that these files are imported in the src/index.js file

File structure: https://facebook.github.io/create-react-app/docs/folder-structure

1. React

- Allows usage of JSX elements

`import React from 'react';`

2. ReactDom

- Allows us to render through its render()

`import ReactDOM from 'react-dom';`

- ReactDom.render() takes 2 args: itemToBeRendered and locationToRender. Ex:

```js
ReactDOM.render(
  <ComponentName {...props} />,
  document.getElementById('root') // <div id="root"></div>
);
```

## JSX

- Introducing [JSX](https://reactjs.org/docs/introducing-jsx.html)

1. JSK looks like HTML (although its not). Its available by importing from 'react'

2. Optional, not required

 ```js
 // Ex of react without JSK
 React.createElement('h1', /* ... h1 children ... */)
 ```

3. You cannot render more than 1 JSK element next to each other (in the same render return)

4. You CAN however, wrap elements within other elements. Ex: a <div> within another <div>

```js
// Allowed:
render() {
  return (
    <div>
      <h2>Hello world! I am wrapped</h2>
      <h3> I am still wrapper </h3>
    </div>
  )
}

// Not allowed
render() {
  return (
    <h2>Hello world! I am wrapped</h2>
    <h2>I am not wrapped</h2>
  )
}
```

5. You can only render built-in DOM components such as `<div>, <p>, <li>, etc` but you can create your own components with any name you want.

6. [JSX In-Depth](https://reactjs.org/docs/jsx-in-depth.html#why-jsx)

Some important points from the link above:

- User-Defined Components Must Be Capitalized

- Props Default to “True”

- Spread Attributes

## Components and Props

[Documentation - Click me!](https://reactjs.org/docs/components-and-props.html)

1. Components use XML-like syntax (JSX)

2. Can maintain its own internal state

3. Simple functional component:

```js
function HelloEveryone() {
  return (
    <div>
      <p>How you doin... </p>
    </div>
  );
}
```

``` js
// Component declaration with arrow function
const HelloEveryone = () => <div><p>How you doin... </p></div>
```

4. Render it:

```js
ReactDOM.render(
  <HelloEveryone />,
  document.getElementById("root")
);
```

5. You can also put this component in a separate file, export it, and import it in your main file

```js
// HelloEveryone.js
export default HelloEveryone;

// index.js
import HelloEveryone from './components/HelloEveryone.js'
```

6. Components can take JSX attributes, called props (short for properties)
```js
const HelloEveryone = (props) => <div><p>How you doin... {props.name} </p></div>

ReactDOM.render(
  <HelloEveryone name="Thanos" />,
  document.getElementById('root')
);
```

- note that the component must take a `props` argument.

7. Components can refer to other components:
```js
// index.js
ReactDOM.render(
  <MainComponent />,
  document.getElementById('root')
);

// MainComponent.js
const MainComponent = () => (
  <div>
    <HelloEveryone name="Thanos" />
    <HelloEveryone name="Iron Man" />
    <HelloEveryone name="Dr Strange" />
  </div>
)
```

8. Props are Read-Only

[Read here](https://reactjs.org/docs/components-and-props.html#props-are-read-only)

9. Passing multiple props, and deconstructing

``` js
// index.js
function Main() {
  return (
    <MainComponent
      superPeople={superPeople}
      restaurants={restaurants}
      onClick={handleClick}
    />
  )
}

const handleClick = () => {
  ReactDOM.render(
    <Main />,
    document.getElementById('root')
  );
}

handleClick(); // rendering when browser first starts

// MainComponent.js
<Randomizer
  superPeople={props.superPeople}
  restaurants={props.restaurants}
  onClick={props.onClick}
/>

// Randomizer.js
let randomPerson;
let randomRestaurant;

const randomize = (props) => {
  const { superPeople, restaurants } = props;
  randomPerson = superPeople[Math.floor(Math.random() * superPeople.length)];
  randomRestaurant = restaurants[Math.floor(Math.random() * restaurants.length)];
  props.onClick();
}

const Randomizer = (props) => {
  return (
    <div>
      <h3>Randomizer</h3>
      <button onClick={() => randomize(props)}>
        Click me
      </button>
      {(randomPerson && randomRestaurant) &&
        <h4>{randomPerson.name} likes to eat at {randomRestaurant}</h4>}
    </div>
  );
}
```

## Class Component

Class components give you access to state.

Also, you can access props with `this.props.fieldName`

Here's how to convert the app from a functional component to a class component:

```js
// index.js
const superPeople = [
  {
    name: 'Thanos',
    power: 'The Snap'
  },
  {
    name: 'Iron Man',
    power: 'Intelligence x 3000'
  },
  {
    name: 'Dr Strange',
    power: 'the Time Stone'
  }
];

class Main extends React.Component {
  render() {
    return (
      <MainComponent
        superPeople={superPeople}
        restaurants={restaurants}
        onClick={handleClick}
      />
    );
  }  
}

// MainComponent.js
const MainComponent = (props) => (
  <div>
    <HelloEveryone superPeople={props.superPeople}/>
  </div>
)

// HelloEveryone.js
const HelloEveryone = (props) => {
  const listItems = props.superPeople.map((person) => (
    <p key={person.name}>{person.name} has {person.power}</p>)
  );
  return (
    <div>
      {listItems}
    </div>
  );
}
```

- You can also create your own methods within the class, and call it in your component with ` this.methodName()`. Note that class method declarations must either start with `this.methodName` or use an arrow function:

```js
class Main extends React.Component {
  myCoolFunction() {
    // will not work
  }

  this.myCoolFunction() {
    // will work
  }

  myCoolFunction = () => {
    // will also work
  }
}
```

## State

[State & Lifecycle](https://reactjs.org/docs/state-and-lifecycle.html)

- State is similar to props, but it is private and fully controlled by the component. Props are immutable (cannot be changed)

- To use state, your class must have a constructor which calls super

- Constructors initialize values

- Super goes to the parent class (React.component), and imports its methods (example: this.setState())

``` js
// index.js
class Main extends React.Component {
  constructor(props) {
    super(props);
    this.state = {};
  }
  render() {
    return (
      <MainComponent
        superPeople={superPeople}
        restaurants={restaurants}
        onClick={handleClick}
      />
    );
  }
}
```

- Changing the state will change how things look in the screen (any child components using a state variable will be rerendered)

```js
// index.js
class Main extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      superPeople,
      restaurants,
      randomPerson: '',
      randomRestaurant: ''
    };
  }
  handleClick = () => {
    const { superPeople, restaurants } = this.state;
    let randomPerson = superPeople[Math.floor(Math.random() * superPeople.length)];
    let randomRestaurant = restaurants[Math.floor(Math.random() * restaurants.length)];
    this.setState({randomPerson, randomRestaurant});
  }
  render() {
    return (
      <MainComponent
        superPeople={this.state.superPeople}
        restaurants={this.state.restaurants}
        onClick={this.handleClick}
        randomPerson={this.state.randomPerson}
        randomRestaurant={this.state.randomRestaurant}
      />
    );
  }
}

// Randomizer.js
const Randomizer = (props) => {
  return (
    <div>
      <h3>Randomizer</h3>
      <button onClick={props.onClick}>
        Click me
      </button>
      {(props.randomPerson && props.randomRestaurant) &&
        <h4>{props.randomPerson.name} likes to eat at {props.randomRestaurant}</h4>}
    </div>
  );
}
```


## Practice

- Create 1 - 3 small apps using everything you just learned (class, components, state)

Example: coin flip, rock-paper-sizors