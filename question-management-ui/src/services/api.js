import axios from 'axios';

const API_URL = 'http://localhost:5031/api/questions';

export const getQuestions = async () => {
    const response = await axios.get(API_URL);
    console.log("From api.js", response.data)
    return response.data;
}


export const createQuestion = async (question) => {
    console.log("1 . From api.js")
    const response = await axios.post(API_URL, question);
    return response.data;
}