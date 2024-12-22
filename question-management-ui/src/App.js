import React from "react";
import QuestionList from "./components/QuestionsList";
import CreateQuestion from "./components/CreateQuestion";


const App = () => {
  return (
    <div>
      <h1>Frågehantering</h1>
      <CreateQuestion/>
      <QuestionList/>
    </div>
  );
};

export default App;
