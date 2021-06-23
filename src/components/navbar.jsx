import { Link } from 'react-router-dom';

function Navbar() {
    

	return (
		<nav className='navbar'> 
            <Link className='link' to='/login'>Login </Link>
            <Link className='link' to='/register'>Register</Link>
            <Link className='link' to='/my-note'>My Note</Link>
			
		</nav>
        
	);
}

export default Navbar;
