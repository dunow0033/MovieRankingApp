import './App.css';
import RankItems  from './components/RankItems';
//import { BrowserRouter as Router, Routes } from 'react-router-dom';
//import { Layout } from './components/Layout';
import './custom.css';

function App() {
  return (
    <div className="App">
      {/*<Layout>
        <Router>
        <Routes>*/}
          <RankItems />
        {/*</Routes>
        </Router>
      </Layout>*/}
    </div>
  );
}

export default App;
