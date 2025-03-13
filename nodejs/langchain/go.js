const express = require('express');
const { OpenAI } = require("@langchain/openai");
const app = express();
const port = 3000;

const model = new OpenAI({ temperature: 0.9 });

app.use(express.json());

app.get('/hello', (req, res) => {
    res.json({"greeting": "Hello!"});
});

app.post('/ask', async (req, res) => {
    const question = req.body.question;
    const answer = await model.call(question);
    return res.json({"answer": answer});
});


app.listen(port, () => {
    console.log(`Server listening on port ${port}`);
});