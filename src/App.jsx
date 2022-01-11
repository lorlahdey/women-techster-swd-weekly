import { BrowserRouter, Switch, Route } from 'react-router-dom';
import Navbar from './components/navbar';
import Login from './pages/Login';
import Register from './pages/Register';
import MyNoteApp from './pages/MyNoteApp';
import StateProvider from './components/stateprovider';

const App = () =>  {
  
  return (
		<BrowserRouter>
			<StateProvider>
				<Navbar />
      
				<Switch>
					<Route path='/login'>
						<Login />
					</Route>
					<Route path='/register'>
						<Register />
					</Route>
					<Route path='/my-note'>
						<MyNoteApp />
					</Route>
					<Route path='/my-note'>
						<MyNoteApp />
					</Route>
					<Route>
						<Login />
					</Route>
				</Switch>
			</StateProvider>
		</BrowserRouter>
	);
}

export default App;