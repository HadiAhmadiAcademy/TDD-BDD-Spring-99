using System.Collections.Generic;
using Suzianna.Core.Screenplay.Actors;
using Suzianna.Core.Screenplay.Questions;

namespace UOM.Technical.WebUI.Questions
{
    public class DataInKendoGrid<T> : IQuestion<List<T>>
    {
        public List<T> AnsweredBy(Actor actor)
        {
            return new List<T>();
        }
    }
}