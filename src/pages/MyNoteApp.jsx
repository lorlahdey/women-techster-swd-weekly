import { useState, useEffect } from 'react';
import { nanoid } from 'nanoid'
import NotesList from '../components/notesList';
import '../styles/main.css'
import Search from '../components/search';
import Header from '../components/headline';

const MyNoteApp = () => {
	//creating an array of notes list
	let notesListarray = [];

	//using a state to make our array of note dynamic
	const [notes, setNotes] = useState(notesListarray);
	// searching through all notes
	const [searchText, setSearchText] = useState('');
	const [darkMode, setDarkMode] = useState(false);

	useEffect(() => {
		const saveNote = JSON.parse(localStorage.getItem('Journal'))
		if(saveNote) {
			setNotes(saveNote)
		}
	}, [])

	useEffect(() => {
		localStorage.setItem('Journal', JSON.stringify(notes))
	}, [notes])

	const addNoteText = ( title, text) => {
		const date = new Date();
		const newNote = {
			id: nanoid(),
			noteTitle: title,
			noteBody: text,
			date: date.toDateString()
		}
		const newNotes = [...notes, newNote];
		setNotes(newNotes); 
	}

	const deleteNote = (id) => {
		const newNotes = notes.filter((note)=> note.id !== id);
		setNotes(newNotes);
	}

	return (
		<div className={`${darkMode && 'dark-mode'}`}>
			<div className='container'>
				<Header  
					darkMode={darkMode} 
					toggleDarkmode={() => setDarkMode(!darkMode)}
				/>
				<Search handleSearchNote={(e) => setSearchText(e.target.value)}/>
				<NotesList 
					notes={notes.filter((note) => 
						note.noteTitle.toLowerCase().includes(searchText) ||
						note.noteBody.toLowerCase().includes(searchText)
					)} 
					handleAddNote={addNoteText}
					handleDeleteNote={deleteNote}
				/>
			</div>
		</div>
	)
}

export default MyNoteApp