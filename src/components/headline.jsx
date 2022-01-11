import { BsFillBrightnessHighFill } from "react-icons/bs"
import { FaMoon } from "react-icons/fa";

const Header = ({ darkMode, toggleDarkmode }) => {
    return (
        <div className='header'>
            <h1>My Journal</h1>
            <button className='save' onClick={toggleDarkmode}>
                {
                    darkMode
                ?
                    <BsFillBrightnessHighFill size='1.5em' />
                :
                    <FaMoon size='1.5em' />
                }
            </button>
        </div>
    )
}

export default Header