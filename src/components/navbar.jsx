import { useContext } from 'react';
import { AppContext } from './stateprovider';
import { Link, useHistory } from 'react-router-dom';

function Navbar() {
    const { state, setState } = useContext(AppContext);
	const history = useHistory();


    const logout = () => {
		setState(prev => {
			return {
				...prev,
				isLoggedIn: false,
			};
		});
		history.push('/login');
	};


	return (

        //working with specific menu for each page on the nav bar
        <nav className='navbar'> 
			{state.isLoggedIn ? (
				<>
					<Link className='link' to='/my-note'>My List</Link>
					<br />
					<span onClick={logout} className='link'>
						Logout
					</span>
				</>
			) : (
				<>
					<Link className='link' to='/login'>Login</Link>
					<br />
					<Link className='link' to='/register'>Register</Link>
					<br />
				</>
			)}
		</nav>
	);
}

export default Navbar;
