import React, {useState} from "react";
import { createQuestion } from "../services/api";
import { statusOptions } from "../constants";

const CreateQuestion = () => {
    const [title, setTitle] = useState('');
    const [status, setStatus] = useState('Ny');
    const [description, setDescription] = useState('');
    const [linkedObject, setLinkedObject] = useState('');

    const handleSubmit = async (e) => {
        e.preventDefault();
        try {
            console.log("handleSubmit", statusOptions[status]);
            const newQuestion = await createQuestion({
                title, 
                status: statusOptions[status],
                description,
                linkedObject
            });
            console.log("Fråga skapad: ", newQuestion);
            setTitle('');
            setStatus('Ny');
            setDescription('');
            setLinkedObject('');
        } catch (error) {
            console.error('Fel vid skapande av fråga: ', error.response ? error.response.data : error.message);
        }
    };
   
    return (
        <form onSubmit={handleSubmit}>
            <input 
                type="text" 
                placeholder="Titel" 
                value={title} 
                onChange={(e) => setTitle(e.target.value)} 
                required 
            />
            <select value={status} onChange={(e) => setStatus(e.target.value)}>
                <option value="Ny">Ny</option>
                <option value="Stängd">Stängd</option>
                <option value="SenareSkede">Senare skede</option>
                <option value="Pågående">Pågående</option>
            </select>
            <input 
                type="text" 
                placeholder="Beskrivning" 
                value={description} 
                onChange={(e) => setDescription(e.target.value)} 
                required 
            />
            <input 
                type="text" 
                placeholder="Länkat IFC objekt" 
                value={linkedObject} 
                onChange={(e) => setLinkedObject(e.target.value)} 
                required 
            />
            <button type="submit">Skapa Fråga</button>
        </form>
    );
};

export default CreateQuestion;