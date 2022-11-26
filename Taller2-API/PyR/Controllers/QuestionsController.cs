using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PyR.Controllers
{
    [Route("api")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        public QuestionsController()
        {
            questions = new List<Question>(); //0-2 son tres preguntas
            questions.Add(new Question(question: "¿Si te dictan el siguiente número como lo interpretarias? -dos cuatro dos cero-.", answers: new List<Dictionary<string, dynamic>>()
            {
                new Dictionary<string, dynamic>()
                {
                    { "answer", "2420" },
                    { "correct", true }
                },
                new Dictionary<string, dynamic>()
                {
                    { "answer", "2400" },
                    { "correct", false }
                },
                new Dictionary<string, dynamic>()
                {
                    { "answer", "4400" },
                    { "correct", false }
                },
                new Dictionary<string, dynamic>()
                {
                    { "answer", "4420" },
                    { "correct", false }
                }
            }, hint: "Solo se repite el dos"));

            questions.Add(new Question(question: "¿Que es una cebra?", answers: new List<Dictionary<string, dynamic>>()
            {
                new Dictionary<string, dynamic>()
                {
                    { "answer", "Un caballo blanco con lineas negras" },
                    { "correct", false }
                },
                new Dictionary<string, dynamic>()
                {
                    { "answer", "Un caballo negro con lineas blancas" },
                    { "correct", false }
                },
                new Dictionary<string, dynamic>()
                {
                    { "answer", "Un camino de lineas que indica el cruce de peatones" },
                    { "correct", false }
                },
                new Dictionary<string, dynamic>()
                {
                    { "answer", "Todas las anteriores" },
                    { "correct", true }
                }
            }, hint: "Puede ser lo que quiera ser"));

            questions.Add(new Question(question: "¿Que significa la palabra PERICO en COLOMBIA??", answers: new List<Dictionary<string, dynamic>>()
            {
                new Dictionary<string, dynamic>()
                {
                    { "answer", "Una arepa con huevo con cebolla y tomate" },
                    { "correct", false }
                },
                new Dictionary<string, dynamic>()
                {
                    { "answer", "Una droga, que mata el alma y la envenena" },
                    { "correct", false }
                },
                new Dictionary<string, dynamic>()
                {
                    { "answer", "Un pajaro de colores" },
                    { "correct", true }
                },
                new Dictionary<string, dynamic>()
                {
                    { "answer", "Un café con leche" },
                    { "correct", false }
                }
            }, hint: "Es algo muy llamativo"));
        }
        List<Question> questions;

        [HttpGet("questions")]
        public ActionResult<List<Question>> GetQuestions()
        {
            return questions;
        }

        [HttpGet("questions/{id}")]
        public ActionResult<Question> GetQuestion(int id)
        {
            return questions[id];
        }
    }
}
