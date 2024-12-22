import React, {useEffect, useState} from 'react';
import { getQuestions } from '../services/api';

const QuestionsList = () => {
    const [questions, setQuestions] = useState([]);

    useEffect(() => {
        const fetchQuestions = async () => {
            try {
                console.log("1");
                const data = await getQuestions();
                console.log("2");
                setQuestions(data);
            } catch (error) {
                console.error('Fel vid hämtning av frågor', error);
            }
        };

        fetchQuestions();
    }, []);

    return (
        <div>
            <h2>Frågor</h2>
            <ul>
                {questions.map((question) => (
                    <li key={question.id}>{question.title} - Status: {question.status}</li>
                ))}
            </ul>
        </div>
    );
};

export default QuestionsList;
