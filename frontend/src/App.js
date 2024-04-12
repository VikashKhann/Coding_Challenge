import React, { useState } from "react";
import "./App.css";
import ProductForm from "./components/ProductForm";
import ProductList from "./components/ProductList";

const App = () => {
  const [key, setKey] = useState(0); // State to force rerender of ProductList component

  const handleProductAdded = () => {
    setKey(key + 1);
  };

  return (
    <div className="App">
      <ProductForm onProductAdded={handleProductAdded} />
      <ProductList key={key} />
    </div>
  );
};

export default App;
